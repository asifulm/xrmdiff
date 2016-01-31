// ***********************************************************************
// Assembly         : Xrm.Solution.Utility
// Author           : asifulm
// Created          : 06-04-2015
//
// Last Modified By : asifulm
// Last Modified On : 06-05-2015
// ***********************************************************************

using System;
using System.Linq;
using System.Net;
using System.ServiceModel.Description;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Discovery;
using Xrm.Solution.Configuration;
using Xrm.Solution.Common;

namespace Xrm.Solution.Utility
{
    /// <summary>
    ///     Class XrmConnectionManager.
    /// </summary>
    public class XrmConnectionManager
    {
        /// <summary>
        ///     Discovers the organizations that the calling user belongs to.
        /// </summary>
        /// <param name="service">A Discovery service proxy instance.</param>
        /// <returns>
        ///     Array containing detailed information on each organization that
        ///     the user belongs to.
        /// </returns>
        /// <exception cref="System.ArgumentNullException">service</exception>
        private OrganizationDetailCollection DiscoverOrganizations(
            IDiscoveryService service)
        {
            if (service == null) throw new ArgumentNullException(nameof(service));
            var orgRequest = new RetrieveOrganizationsRequest();
            var orgResponse =
                (RetrieveOrganizationsResponse) service.Execute(orgRequest);

            return orgResponse.Details;
        }

        /// <summary>
        ///     Finds a specific organization detail in the array of organization details
        ///     returned from the Discovery service.
        /// </summary>
        /// <param name="orgUniqueName">The unique name of the organization to find.</param>
        /// <param name="orgDetails">Array of organization detail object returned from the discovery service.</param>
        /// <returns>Organization details or null if the organization was not found.</returns>
        /// <exception cref="System.ArgumentNullException">
        ///     orgUniqueName
        ///     or
        ///     orgDetails
        /// </exception>
        /// <seealso />
        public OrganizationDetail FindOrganization(string orgUniqueName,
            OrganizationDetail[] orgDetails)
        {
            if (string.IsNullOrWhiteSpace(orgUniqueName))
                throw new ArgumentNullException(nameof(orgUniqueName));
            if (orgDetails == null)
                throw new ArgumentNullException(nameof(orgDetails));

            return
                orgDetails.FirstOrDefault(
                    detail =>
                        string.Compare(detail.UniqueName, orgUniqueName, StringComparison.InvariantCultureIgnoreCase) ==
                        0);
        }

        /// <summary>
        ///     Gets the connection.
        /// </summary>
        /// <param name="datasource">The datasource.</param>
        /// <returns>IOrganizationService.</returns>
        public IOrganizationService GetConnection(DataSourceElement datasource)
        {
            return GetConnection(datasource.Url, datasource.UniqueName, datasource.UserName,
                datasource.Password,
                datasource.Domain);
        }

        /// <summary>
        ///     Gets the connection.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <param name="organizationUniqueName">Name of the organization unique.</param>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <param name="domain">The domain.</param>
        /// <returns>IOrganizationService.</returns>
        public IOrganizationService GetConnection(string url, string organizationUniqueName, string username,
            string password, string domain)
        {
            var discoveryServiceUrl = url.ToUri(delegate
            {
                if (url.EndsWith("Discovery.svc")) return url;

                throw new ArgumentException("The discovery service url must be provided.");
            });

            var discoveryProxy = GetDiscoveryServiceProxy(discoveryServiceUrl.AbsoluteUri, username, password, domain);
            // Obtain organization information from the Discovery service. 

            if (discoveryProxy == null) return null;
            // Obtain information about the organizations that the system user belongs to.
            var orgs = DiscoverOrganizations(discoveryProxy);
            // Obtains the Web address (Uri) of the target organization.
            var organizationUri = FindOrganization(organizationUniqueName,
                orgs.ToArray()).Endpoints[EndpointType.OrganizationService];

            return !string.IsNullOrWhiteSpace(organizationUri)
                ? GetOrganizationServiceProxy(organizationUri, username, password, domain)
                : null;
        }

        /// <summary>
        ///     Obtain the AuthenticationCredentials based on AuthenticationProviderType.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <param name="domain">The domain.</param>
        /// <param name="endpointType">An AuthenticationProviderType of the CRM environment.</param>
        /// <returns>Get filled credentials.</returns>
        private static AuthenticationCredentials GetCredentials(string username,
            string password,
            string domain,
            AuthenticationProviderType endpointType)
        {
            var authCredentials = new AuthenticationCredentials();

            switch (endpointType)
            {
                case AuthenticationProviderType.ActiveDirectory:
                    if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                        authCredentials.ClientCredentials.Windows.ClientCredential =
                            CredentialCache.DefaultNetworkCredentials;
                    else
                        authCredentials.ClientCredentials.Windows.ClientCredential =
                            new NetworkCredential(username,
                                password,
                                domain);
                    break;
                case AuthenticationProviderType.LiveId:
                    authCredentials.ClientCredentials.UserName.UserName = username;
                    authCredentials.ClientCredentials.UserName.Password = password;
                    break;
                default: // For Federated and OnlineFederated environments.                    
                    authCredentials.ClientCredentials.UserName.UserName = username;
                    authCredentials.ClientCredentials.UserName.Password = password;
                    // For OnlineFederated single-sign on, you could just use current UserPrincipalName instead of passing user name and password.
                    // authCredentials.UserPrincipalName = UserPrincipal.Current.UserPrincipalName;  // Windows Kerberos

                    break;
            }

            return authCredentials;
        }

        /// <summary>
        ///     Get the proxy client for the Discovery.svc.
        /// </summary>
        /// <param name="discoveryServiceUrl">The CRM organization's discovery service url.</param>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <param name="domain">The domain.</param>
        /// <returns>IOrganizationService.</returns>
        public IDiscoveryService GetDiscoveryServiceProxy(string discoveryServiceUrl, string username, string password,
            string domain)
        {
            var serviceManagement =
                ServiceConfigurationFactory.CreateManagement<IDiscoveryService>(
                    new Uri(discoveryServiceUrl));
            var endpointType = serviceManagement.AuthenticationType;

            // Set the credentials.
            var authCredentials = GetCredentials(username, password, domain, endpointType);

            // Get the discovery service proxy.
            return GetProxy<IDiscoveryService, DiscoveryServiceProxy>(serviceManagement, authCredentials);
        }

        /// <summary>
        ///     Get the proxy client for the Organization.svc.
        /// </summary>
        /// <param name="organizationUri">The CRM organization url.</param>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <param name="domain">The domain.</param>
        /// <returns>IOrganizationService.</returns>
        public IOrganizationService GetOrganizationServiceProxy(string organizationUri, string username, string password,
            string domain)
        {
            var orgServiceManagement =
                ServiceConfigurationFactory.CreateManagement<IOrganizationService>(
                    new Uri(organizationUri));

            var endpointType = orgServiceManagement.AuthenticationType;
            // Set the credentials.
            var credentials = GetCredentials(username, password, domain, endpointType);

            var organizationProxy =
                GetProxy<IOrganizationService, OrganizationServiceProxy>(orgServiceManagement, credentials);

            //organizationProxy.EnableProxyTypes();
            organizationProxy.Timeout = TimeSpan.MaxValue;
            return organizationProxy;
        }

        /// <summary>
        ///     Generic method to obtain discovery/organization service proxy instance.
        /// </summary>
        /// <typeparam name="TService">
        ///     Set IDiscoveryService or IOrganizationService type to request respective service proxy
        ///     instance.
        /// </typeparam>
        /// <typeparam name="TProxy">
        ///     Set the return type to either DiscoveryServiceProxy or OrganizationServiceProxy type based on
        ///     TService type.
        /// </typeparam>
        /// <param name="serviceManagement">An instance of IServiceManagement</param>
        /// <param name="authCredentials">The user's Microsoft Dynamics CRM logon credentials.</param>
        /// <returns>TProxy.</returns>
        private static TProxy GetProxy<TService, TProxy>(
            IServiceManagement<TService> serviceManagement,
            AuthenticationCredentials authCredentials)
            where TService : class
            where TProxy : ServiceProxy<TService>
        {
            var classType = typeof (TProxy);

            if (serviceManagement.AuthenticationType !=
                AuthenticationProviderType.ActiveDirectory)
            {
                var tokenCredentials =
                    serviceManagement.Authenticate(authCredentials);
                // Obtain discovery/organization service proxy for Federated, LiveId and OnlineFederated environments. 
                // Instantiate a new class of type using the 2 parameter constructor of type IServiceManagement and SecurityTokenResponse.
                var constructorInfo = classType
                    .GetConstructor(new[] {typeof (IServiceManagement<TService>), typeof (SecurityTokenResponse)});
                if (constructorInfo !=
                    null)
                    return (TProxy) constructorInfo
                        .Invoke(new object[] {serviceManagement, tokenCredentials.SecurityTokenResponse});
            }

            // Obtain discovery/organization service proxy for ActiveDirectory environment.
            // Instantiate a new class of type using the 2 parameter constructor of type IServiceManagement and ClientCredentials.
            var constructor = classType
                .GetConstructor(new[] {typeof (IServiceManagement<TService>), typeof (ClientCredentials)});
            if (constructor != null)
                return (TProxy) constructor
                    .Invoke(new object[] {serviceManagement, authCredentials.ClientCredentials});

            return null;
        }
    }
}