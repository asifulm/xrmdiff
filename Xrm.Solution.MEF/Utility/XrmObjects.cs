using System;

namespace Xrm.Solution.MEF
{

    #region "Entity Names"

    public class EntityName
    {
        public const string account = "account";
        public const string accountleads = "accountleads";
        public const string activitymimeattachment = "activitymimeattachment";
        public const string activityparty = "activityparty";
        public const string activitypointer = "activitypointer";
        public const string annotation = "annotation";
        public const string annualfiscalcalendar = "annualfiscalcalendar";
        public const string applicationfile = "applicationfile";
        public const string appointment = "appointment";
        public const string asyncoperation = "asyncoperation";
        public const string attachment = "attachment";
        public const string attributemap = "attributemap";
        public const string audit = "audit";
        public const string authorizationserver = "authorizationserver";
        public const string bulkdeletefailure = "bulkdeletefailure";
        public const string bulkdeleteoperation = "bulkdeleteoperation";
        public const string bulkoperation = "bulkoperation";
        public const string bulkoperationlog = "bulkoperationlog";
        public const string businessdatalocalizedlabel = "businessdatalocalizedlabel";
        public const string businessprocessflowinstance = "businessprocessflowinstance";
        public const string businessunit = "businessunit";
        public const string businessunitmap = "businessunitmap";
        public const string businessunitnewsarticle = "businessunitnewsarticle";
        public const string calendar = "calendar";
        public const string calendarrule = "calendarrule";
        public const string campaign = "campaign";
        public const string campaignactivity = "campaignactivity";
        public const string campaignactivityitem = "campaignactivityitem";
        public const string campaignitem = "campaignitem";
        public const string campaignresponse = "campaignresponse";
        public const string channelproperty = "channelproperty";
        public const string channelpropertygroup = "channelpropertygroup";
        public const string childincidentcount = "childincidentcount";
        public const string clientupdate = "clientupdate";
        public const string columnmapping = "columnmapping";
        public const string commitment = "commitment";
        public const string competitor = "competitor";
        public const string competitoraddress = "competitoraddress";
        public const string competitorproduct = "competitorproduct";
        public const string competitorsalesliterature = "competitorsalesliterature";
        public const string complexcontrol = "complexcontrol";
        public const string connection = "connection";
        public const string connectionrole = "connectionrole";
        public const string connectionroleassociation = "connectionroleassociation";
        public const string connectionroleobjecttypecode = "connectionroleobjecttypecode";
        public const string constraintbasedgroup = "constraintbasedgroup";
        public const string contact = "contact";
        public const string contactinvoices = "contactinvoices";
        public const string contactleads = "contactleads";
        public const string contactorders = "contactorders";
        public const string contactquotes = "contactquotes";
        public const string contract = "contract";
        public const string contractdetail = "contractdetail";
        public const string contracttemplate = "contracttemplate";
        public const string convertrule = "convertrule";
        public const string convertruleitem = "convertruleitem";
        public const string customeraddress = "customeraddress";
        public const string customeropportunityrole = "customeropportunityrole";
        public const string customerrelationship = "customerrelationship";
        public const string dependency = "dependency";
        public const string dependencyfeature = "dependencyfeature";
        public const string dependencynode = "dependencynode";
        public const string discount = "discount";
        public const string discounttype = "discounttype";
        public const string displaystring = "displaystring";
        public const string displaystringmap = "displaystringmap";
        public const string documentindex = "documentindex";
        public const string duplicaterecord = "duplicaterecord";
        public const string duplicaterule = "duplicaterule";
        public const string duplicaterulecondition = "duplicaterulecondition";
        public const string dynamicproperty = "dynamicproperty";
        public const string dynamicpropertyassociation = "dynamicpropertyassociation";
        public const string dynamicpropertyinstance = "dynamicpropertyinstance";
        public const string dynamicpropertyoptionsetitem = "dynamicpropertyoptionsetitem";
        public const string email = "email";
        public const string emailhash = "emailhash";
        public const string emailsearch = "emailsearch";
        public const string emailserverprofile = "emailserverprofile";
        public const string entitlement = "entitlement";
        public const string entitlementchannel = "entitlementchannel";
        public const string entitlementcontacts = "entitlementcontacts";
        public const string entitlementproducts = "entitlementproducts";
        public const string entitlementtemplate = "entitlementtemplate";
        public const string entitlementtemplatechannel = "entitlementtemplatechannel";
        public const string entitlementtemplateproducts = "entitlementtemplateproducts";
        public const string entitymap = "entitymap";
        public const string equipment = "equipment";
        public const string exchangesyncidmapping = "exchangesyncidmapping";
        public const string fax = "fax";
        public const string fieldpermission = "fieldpermission";
        public const string fieldsecurityprofile = "fieldsecurityprofile";
        public const string filtertemplate = "filtertemplate";
        public const string fixedmonthlyfiscalcalendar = "fixedmonthlyfiscalcalendar";
        public const string goal = "goal";
        public const string goalrollupquery = "goalrollupquery";
        public const string hierarchyrule = "hierarchyrule";
        public const string hierarchysecurityconfiguration = "hierarchysecurityconfiguration";
        public const string imagedescriptor = "imagedescriptor";
        public const string import = "import";
        public const string importdata = "importdata";
        public const string importentitymapping = "importentitymapping";
        public const string importfile = "importfile";
        public const string importjob = "importjob";
        public const string importlog = "importlog";
        public const string importmap = "importmap";
        public const string incident = "incident";
        public const string incidentknowledgebaserecord = "incidentknowledgebaserecord";
        public const string incidentresolution = "incidentresolution";
        public const string integrationstatus = "integrationstatus";
        public const string internaladdress = "internaladdress";
        public const string interprocesslock = "interprocesslock";
        public const string invaliddependency = "invaliddependency";
        public const string invoice = "invoice";
        public const string invoicedetail = "invoicedetail";
        public const string isvconfig = "isvconfig";
        public const string kbarticle = "kbarticle";
        public const string kbarticlecomment = "kbarticlecomment";
        public const string kbarticletemplate = "kbarticletemplate";
        public const string knowledgebaserecord = "knowledgebaserecord";
        public const string lead = "lead";
        public const string leadaddress = "leadaddress";
        public const string leadcompetitors = "leadcompetitors";
        public const string leadproduct = "leadproduct";
        public const string letter = "letter";
        public const string license = "license";
        public const string list = "list";
        public const string listmember = "listmember";
        public const string lookupmapping = "lookupmapping";
        public const string mailbox = "mailbox";
        public const string mailboxstatistics = "mailboxstatistics";
        public const string mailboxtrackingfolder = "mailboxtrackingfolder";
        public const string mailmergetemplate = "mailmergetemplate";
        public const string metadatadifference = "metadatadifference";
        public const string metric = "metric";
        public const string monthlyfiscalcalendar = "monthlyfiscalcalendar";
        public const string ms_solution = "ms_solution";
        public const string ms_solutionsynchsetting = "ms_solutionsynchsetting";
        public const string msdyn_postalbum = "msdyn_postalbum";
        public const string msdyn_postconfig = "msdyn_postconfig";
        public const string msdyn_postruleconfig = "msdyn_postruleconfig";
        public const string msdyn_wallsavedquery = "msdyn_wallsavedquery";
        public const string msdyn_wallsavedqueryusersettings = "msdyn_wallsavedqueryusersettings";
        public const string multientitysearch = "multientitysearch";
        public const string multientitysearchentities = "multientitysearchentities";
        public const string new_competitor_account = "new_competitor_account";
        public const string notification = "notification";
        public const string officedocument = "officedocument";
        public const string opportunity = "opportunity";
        public const string opportunityclose = "opportunityclose";
        public const string opportunitycompetitors = "opportunitycompetitors";
        public const string opportunityproduct = "opportunityproduct";
        public const string orderclose = "orderclose";
        public const string organization = "organization";
        public const string organizationstatistic = "organizationstatistic";
        public const string organizationui = "organizationui";
        public const string owner = "owner";
        public const string ownermapping = "ownermapping";
        public const string partnerapplication = "partnerapplication";
        public const string phonecall = "phonecall";
        public const string picklistmapping = "picklistmapping";
        public const string pluginassembly = "pluginassembly";
        public const string plugintracelog = "plugintracelog";
        public const string plugintype = "plugintype";
        public const string plugintypestatistic = "plugintypestatistic";
        public const string position = "position";
        public const string post = "post";
        public const string postcomment = "postcomment";
        public const string postfollow = "postfollow";
        public const string postlike = "postlike";
        public const string postregarding = "postregarding";
        public const string postrole = "postrole";
        public const string pricelevel = "pricelevel";
        public const string principalattributeaccessmap = "principalattributeaccessmap";
        public const string principalentitymap = "principalentitymap";
        public const string principalobjectaccess = "principalobjectaccess";
        public const string principalobjectaccessreadsnapshot = "principalobjectaccessreadsnapshot";
        public const string principalobjectattributeaccess = "principalobjectattributeaccess";
        public const string principalsyncattributemap = "principalsyncattributemap";
        public const string privilege = "privilege";
        public const string privilegeobjecttypecodes = "privilegeobjecttypecodes";
        public const string processsession = "processsession";
        public const string processstage = "processstage";
        public const string processtrigger = "processtrigger";
        public const string product = "product";
        public const string productassociation = "productassociation";
        public const string productpricelevel = "productpricelevel";
        public const string productsalesliterature = "productsalesliterature";
        public const string productsubstitute = "productsubstitute";
        public const string publisher = "publisher";
        public const string publisheraddress = "publisheraddress";
        public const string quarterlyfiscalcalendar = "quarterlyfiscalcalendar";
        public const string queue = "queue";
        public const string queueitem = "queueitem";
        public const string queueitemcount = "queueitemcount";
        public const string queuemembercount = "queuemembercount";
        public const string queuemembership = "queuemembership";
        public const string quote = "quote";
        public const string quoteclose = "quoteclose";
        public const string quotedetail = "quotedetail";
        public const string recordcountsnapshot = "recordcountsnapshot";
        public const string recurrencerule = "recurrencerule";
        public const string recurringappointmentmaster = "recurringappointmentmaster";
        public const string relationshiprole = "relationshiprole";
        public const string relationshiprolemap = "relationshiprolemap";
        public const string replicationbacklog = "replicationbacklog";
        public const string report = "report";
        public const string reportcategory = "reportcategory";
        public const string reportentity = "reportentity";
        public const string reportlink = "reportlink";
        public const string reportvisibility = "reportvisibility";
        public const string resource = "resource";
        public const string resourcegroup = "resourcegroup";
        public const string resourcegroupexpansion = "resourcegroupexpansion";
        public const string resourcespec = "resourcespec";
        public const string ribboncommand = "ribboncommand";
        public const string ribboncontextgroup = "ribboncontextgroup";
        public const string ribboncustomization = "ribboncustomization";
        public const string ribbondiff = "ribbondiff";
        public const string ribbonrule = "ribbonrule";
        public const string ribbontabtocommandmap = "ribbontabtocommandmap";
        public const string role = "role";
        public const string roleprivileges = "roleprivileges";
        public const string roletemplate = "roletemplate";
        public const string roletemplateprivileges = "roletemplateprivileges";
        public const string rollupfield = "rollupfield";
        public const string rollupjob = "rollupjob";
        public const string rollupproperties = "rollupproperties";
        public const string routingrule = "routingrule";
        public const string routingruleitem = "routingruleitem";
        public const string salesliterature = "salesliterature";
        public const string salesliteratureitem = "salesliteratureitem";
        public const string salesorder = "salesorder";
        public const string salesorderdetail = "salesorderdetail";
        public const string salesprocessinstance = "salesprocessinstance";
        public const string savedquery = "savedquery";
        public const string savedqueryvisualization = "savedqueryvisualization";
        public const string sdkmessage = "sdkmessage";
        public const string sdkmessagefilter = "sdkmessagefilter";
        public const string sdkmessagepair = "sdkmessagepair";
        public const string sdkmessageprocessingstep = "sdkmessageprocessingstep";
        public const string sdkmessageprocessingstepimage = "sdkmessageprocessingstepimage";
        public const string sdkmessageprocessingstepsecureconfig = "sdkmessageprocessingstepsecureconfig";
        public const string sdkmessagerequest = "sdkmessagerequest";
        public const string sdkmessagerequestfield = "sdkmessagerequestfield";
        public const string sdkmessageresponse = "sdkmessageresponse";
        public const string sdkmessageresponsefield = "sdkmessageresponsefield";
        public const string semiannualfiscalcalendar = "semiannualfiscalcalendar";
        public const string service = "service";
        public const string serviceappointment = "serviceappointment";
        public const string servicecontractcontacts = "servicecontractcontacts";
        public const string serviceendpoint = "serviceendpoint";
        public const string sharepointdata = "sharepointdata";
        public const string sharepointdocument = "sharepointdocument";
        public const string sharepointdocumentlocation = "sharepointdocumentlocation";
        public const string sharepointsite = "sharepointsite";
        public const string site = "site";
        public const string sitemap = "sitemap";
        public const string sla = "sla";
        public const string slaitem = "slaitem";
        public const string slakpiinstance = "slakpiinstance";
        public const string socialactivity = "socialactivity";
        public const string socialinsightsconfiguration = "socialinsightsconfiguration";
        public const string socialprofile = "socialprofile";
        public const string solution = "solution";
        public const string solutioncomponent = "solutioncomponent";
        public const string sqlencryptionaudit = "sqlencryptionaudit";
        public const string statusmap = "statusmap";
        public const string stringmap = "stringmap";
        public const string subject = "subject";
        public const string subscription = "subscription";
        public const string subscriptionclients = "subscriptionclients";
        public const string subscriptionmanuallytrackedobject = "subscriptionmanuallytrackedobject";
        public const string subscriptionsyncinfo = "subscriptionsyncinfo";
        public const string subscriptiontrackingdeletedobject = "subscriptiontrackingdeletedobject";
        public const string syncattributemapping = "syncattributemapping";
        public const string syncattributemappingprofile = "syncattributemappingprofile";
        public const string systemapplicationmetadata = "systemapplicationmetadata";
        public const string systemform = "systemform";
        public const string systemuser = "systemuser";
        public const string systemuserbusinessunitentitymap = "systemuserbusinessunitentitymap";
        public const string systemuserlicenses = "systemuserlicenses";
        public const string systemusermanagermap = "systemusermanagermap";
        public const string systemuserprincipals = "systemuserprincipals";
        public const string systemuserprofiles = "systemuserprofiles";
        public const string systemuserroles = "systemuserroles";
        public const string systemusersyncmappingprofiles = "systemusersyncmappingprofiles";
        public const string task = "task";
        public const string team = "team";
        public const string teammembership = "teammembership";
        public const string teamprofiles = "teamprofiles";
        public const string teamroles = "teamroles";
        public const string teamsyncattributemappingprofiles = "teamsyncattributemappingprofiles";
        public const string teamtemplate = "teamtemplate";
        public const string template = "template";
        public const string territory = "territory";
        public const string theme = "theme";
        public const string timestampdatemapping = "timestampdatemapping";
        public const string timezonedefinition = "timezonedefinition";
        public const string timezonelocalizedname = "timezonelocalizedname";
        public const string timezonerule = "timezonerule";
        public const string traceassociation = "traceassociation";
        public const string tracelog = "tracelog";
        public const string traceregarding = "traceregarding";
        public const string transactioncurrency = "transactioncurrency";
        public const string transformationmapping = "transformationmapping";
        public const string transformationparametermapping = "transformationparametermapping";
        public const string unresolvedaddress = "unresolvedaddress";
        public const string uom = "uom";
        public const string uomschedule = "uomschedule";
        public const string userapplicationmetadata = "userapplicationmetadata";
        public const string userentityinstancedata = "userentityinstancedata";
        public const string userentityuisettings = "userentityuisettings";
        public const string userfiscalcalendar = "userfiscalcalendar";
        public const string userform = "userform";
        public const string usermapping = "usermapping";
        public const string userquery = "userquery";
        public const string userqueryvisualization = "userqueryvisualization";
        public const string usersettings = "usersettings";
        public const string webresource = "webresource";
        public const string webwizard = "webwizard";
        public const string wizardaccessprivilege = "wizardaccessprivilege";
        public const string wizardpage = "wizardpage";
        public const string workflow = "workflow";
        public const string workflowdependency = "workflowdependency";
        public const string workflowlog = "workflowlog";
        public const string workflowwaitsubscription = "workflowwaitsubscription";
    }

    #endregion

    #region "Business Unit"

    public class businessunit
    {
        //Fields
        public const string address1_addressid = "address1_addressid";
        public const string address1_addresstypecode = "address1_addresstypecode";
        public const string address1_addresstypecodename = "address1_addresstypecodename";
        public const string address1_city = "address1_city";
        public const string address1_country = "address1_country";
        public const string address1_county = "address1_county";
        public const string address1_fax = "address1_fax";
        public const string address1_latitude = "address1_latitude";
        public const string address1_line1 = "address1_line1";
        public const string address1_line2 = "address1_line2";
        public const string address1_line3 = "address1_line3";
        public const string address1_longitude = "address1_longitude";
        public const string address1_name = "address1_name";
        public const string address1_postalcode = "address1_postalcode";
        public const string address1_postofficebox = "address1_postofficebox";
        public const string address1_shippingmethodcode = "address1_shippingmethodcode";
        public const string address1_shippingmethodcodename = "address1_shippingmethodcodename";
        public const string address1_stateorprovince = "address1_stateorprovince";
        public const string address1_telephone1 = "address1_telephone1";
        public const string address1_telephone2 = "address1_telephone2";
        public const string address1_telephone3 = "address1_telephone3";
        public const string address1_upszone = "address1_upszone";
        public const string address1_utcoffset = "address1_utcoffset";
        public const string address2_addressid = "address2_addressid";
        public const string address2_addresstypecode = "address2_addresstypecode";
        public const string address2_addresstypecodename = "address2_addresstypecodename";
        public const string address2_city = "address2_city";
        public const string address2_country = "address2_country";
        public const string address2_county = "address2_county";
        public const string address2_fax = "address2_fax";
        public const string address2_latitude = "address2_latitude";
        public const string address2_line1 = "address2_line1";
        public const string address2_line2 = "address2_line2";
        public const string address2_line3 = "address2_line3";
        public const string address2_longitude = "address2_longitude";
        public const string address2_name = "address2_name";
        public const string address2_postalcode = "address2_postalcode";
        public const string address2_postofficebox = "address2_postofficebox";
        public const string address2_shippingmethodcode = "address2_shippingmethodcode";
        public const string address2_shippingmethodcodename = "address2_shippingmethodcodename";
        public const string address2_stateorprovince = "address2_stateorprovince";
        public const string address2_telephone1 = "address2_telephone1";
        public const string address2_telephone2 = "address2_telephone2";
        public const string address2_telephone3 = "address2_telephone3";
        public const string address2_upszone = "address2_upszone";
        public const string address2_utcoffset = "address2_utcoffset";
        public const string bizmap_businessid_businessunit_1M = "bizmap_businessid_businessunit";
        public const string bizmap_subbusinessid_businessunit_1M = "bizmap_subbusinessid_businessunit";
        public const string BulkDeleteOperation_BusinessUnit_1M = "BulkDeleteOperation_BusinessUnit";
        public const string business_customer_opportunity_roles_1M = "business_customer_opportunity_roles";
        public const string business_unit_accounts_1M = "business_unit_accounts";
        public const string business_unit_activitypointer_1M = "business_unit_activitypointer";
        public const string business_unit_annotations_1M = "business_unit_annotations";
        public const string business_unit_appointment_activities_1M = "business_unit_appointment_activities";
        public const string business_unit_asyncoperation_1M = "business_unit_asyncoperation";
        public const string business_unit_BulkOperation_activities_1M = "business_unit_BulkOperation_activities";
        public const string business_unit_calendars_1M = "business_unit_calendars";
        public const string business_unit_campaignactivity_activities_1M = "business_unit_campaignactivity_activities";
        public const string business_unit_campaignresponse_activities_1M = "business_unit_campaignresponse_activities";
        public const string business_unit_connections_1M = "business_unit_connections";
        public const string business_unit_constraint_based_groups_1M = "business_unit_constraint_based_groups";
        public const string business_unit_contacts_1M = "business_unit_contacts";
        public const string business_unit_convertrule_1M = "business_unit_convertrule";
        public const string business_unit_customer_relationship_1M = "business_unit_customer_relationship";
        public const string business_unit_dynamicproperyinstance_1M = "business_unit_dynamicproperyinstance";
        public const string business_unit_email_activities_1M = "business_unit_email_activities";
        public const string business_unit_emailserverprofile_1M = "business_unit_emailserverprofile";
        public const string business_unit_entitlement_1M = "business_unit_entitlement";
        public const string business_unit_equipment_1M = "business_unit_equipment";
        // One To Many Relationships
        public const string business_unit_exchangesyncidmapping_1M = "business_unit_exchangesyncidmapping";
        public const string business_unit_fax_activities_1M = "business_unit_fax_activities";
        public const string business_unit_goal_1M = "business_unit_goal";
        public const string business_unit_goalrollupquery_1M = "business_unit_goalrollupquery";

        public const string business_unit_incident_resolution_activities_1M =
            "business_unit_incident_resolution_activities";

        public const string business_unit_incidents_1M = "business_unit_incidents";
        public const string business_unit_invoices_1M = "business_unit_invoices";
        public const string business_unit_leads_1M = "business_unit_leads";
        public const string business_unit_letter_activities_1M = "business_unit_letter_activities";
        public const string business_unit_list_1M = "business_unit_list";
        public const string business_unit_mailbox_1M = "business_unit_mailbox";
        public const string business_unit_mailmergetemplates_1M = "business_unit_mailmergetemplates";
        public const string business_unit_msdyn_postalbum_1M = "business_unit_msdyn_postalbum";

        public const string business_unit_msdyn_wallsavedqueryusersettings_1M =
            "business_unit_msdyn_wallsavedqueryusersettings";

        public const string business_unit_opportunities_1M = "business_unit_opportunities";
        public const string business_unit_opportunity_close_activities_1M = "business_unit_opportunity_close_activities";
        public const string business_unit_order_close_activities_1M = "business_unit_order_close_activities";
        public const string business_unit_orders_1M = "business_unit_orders";
        public const string business_unit_parent_business_unit_1M = "business_unit_parent_business_unit";
        public const string business_unit_parent_business_unit_M1 = "business_unit_parent_business_unit";
        public const string business_unit_phone_call_activities_1M = "business_unit_phone_call_activities";
        public const string business_unit_postfollows_1M = "business_unit_postfollows";
        public const string business_unit_PostRegarding_1M = "business_unit_PostRegarding";
        public const string business_unit_queues_1M = "business_unit_queues";
        public const string business_unit_queues2_1M = "business_unit_queues2";
        public const string business_unit_quote_close_activities_1M = "business_unit_quote_close_activities";
        public const string business_unit_quotes_1M = "business_unit_quotes";
        public const string business_unit_recurrencerule_1M = "business_unit_recurrencerule";

        public const string business_unit_recurringappointmentmaster_activities_1M =
            "business_unit_recurringappointmentmaster_activities";

        public const string business_unit_reports_1M = "business_unit_reports";
        public const string business_unit_resource_groups_1M = "business_unit_resource_groups";
        public const string business_unit_resource_specs_1M = "business_unit_resource_specs";
        public const string business_unit_resources_1M = "business_unit_resources";
        public const string business_unit_roles_1M = "business_unit_roles";
        public const string business_unit_routingrule_1M = "business_unit_routingrule";
        public const string business_unit_service_appointments_1M = "business_unit_service_appointments";
        public const string business_unit_service_contracts_1M = "business_unit_service_contracts";
        public const string business_unit_sharepointdocument_1M = "business_unit_sharepointdocument";
        public const string business_unit_sharepointdocument2_1M = "business_unit_sharepointdocument2";
        public const string business_unit_sharepointdocumentlocation_1M = "business_unit_sharepointdocumentlocation";
        public const string business_unit_sharepointsites_1M = "business_unit_sharepointsites";
        public const string business_unit_slabase_1M = "business_unit_slabase";
        public const string business_unit_slakpiinstance_1M = "business_unit_slakpiinstance";
        public const string business_unit_socialactivity_1M = "business_unit_socialactivity";
        public const string business_unit_socialprofiles_1M = "business_unit_socialprofiles";
        public const string business_unit_system_users_1M = "business_unit_system_users";
        public const string business_unit_task_activities_1M = "business_unit_task_activities";
        public const string business_unit_teams_1M = "business_unit_teams";
        public const string business_unit_templates_1M = "business_unit_templates";
        public const string business_unit_TraceRegarding_1M = "business_unit_TraceRegarding";
        public const string business_unit_user_settings_1M = "business_unit_user_settings";
        public const string business_unit_userapplicationmetadata_1M = "business_unit_userapplicationmetadata";
        public const string business_unit_userform_1M = "business_unit_userform";
        public const string business_unit_userquery_1M = "business_unit_userquery";
        public const string business_unit_userqueryvisualizations_1M = "business_unit_userqueryvisualizations";
        public const string business_unit_workflow_1M = "business_unit_workflow";
        public const string business_unit_workflowlogs_1M = "business_unit_workflowlogs";
        public const string BusinessUnit_AsyncOperations_1M = "BusinessUnit_AsyncOperations";
        public const string BusinessUnit_BulkDeleteFailures_1M = "BusinessUnit_BulkDeleteFailures";
        public const string BusinessUnit_Calendar_M1 = "BusinessUnit_Calendar";
        public const string BusinessUnit_Campaigns_1M = "BusinessUnit_Campaigns";
        public const string businessunit_DuplicateBaseRecord_1M = "businessunit_DuplicateBaseRecord";
        public const string businessunit_DuplicateMatchingRecord_1M = "businessunit_DuplicateMatchingRecord";
        public const string BusinessUnit_DuplicateRules_1M = "BusinessUnit_DuplicateRules";
        public const string BusinessUnit_ImportData_1M = "BusinessUnit_ImportData";
        public const string BusinessUnit_ImportFiles_1M = "BusinessUnit_ImportFiles";
        public const string BusinessUnit_ImportLogs_1M = "BusinessUnit_ImportLogs";
        public const string BusinessUnit_ImportMaps_1M = "BusinessUnit_ImportMaps";
        public const string BusinessUnit_Imports_1M = "BusinessUnit_Imports";
        public const string businessunit_internal_addresses_1M = "businessunit_internal_addresses";
        public const string businessunit_mailboxtrackingfolder_1M = "businessunit_mailboxtrackingfolder";

        public const string businessunit_principalobjectattributeaccess_1M =
            "businessunit_principalobjectattributeaccess";

        public const string BusinessUnit_ProcessSessions_1M = "BusinessUnit_ProcessSessions";
        public const string businessunitid = "businessunitid";
        public const string calendarid = "calendarid";
        public const string costcenter = "costcenter";
        public const string createdby = "createdby";
        public const string createdbyname = "createdbyname";
        public const string createdbyyominame = "createdbyyominame";
        public const string createdon = "createdon";
        public const string createdonbehalfby = "createdonbehalfby";
        public const string createdonbehalfbyname = "createdonbehalfbyname";
        public const string createdonbehalfbyyominame = "createdonbehalfbyyominame";
        public const string creditlimit = "creditlimit";
        public const string description = "description";
        public const string disabledreason = "disabledreason";
        public const string divisionname = "divisionname";
        public const string emailaddress = "emailaddress";
        public const string exchangerate = "exchangerate";
        public const string fileasname = "fileasname";
        public const string ftpsiteurl = "ftpsiteurl";
        public const string importsequencenumber = "importsequencenumber";
        public const string inheritancemask = "inheritancemask";
        public const string isdisabled = "isdisabled";
        public const string isdisabledname = "isdisabledname";
        public const string lk_businessunit_createdonbehalfby_M1 = "lk_businessunit_createdonbehalfby";
        public const string lk_businessunit_modifiedonbehalfby_M1 = "lk_businessunit_modifiedonbehalfby";
        public const string lk_businessunitbase_createdby_M1 = "lk_businessunitbase_createdby";
        public const string lk_businessunitbase_modifiedby_M1 = "lk_businessunitbase_modifiedby";
        public const string lk_userfiscalcalendar_businessunit_1M = "lk_userfiscalcalendar_businessunit";
        public const string modifiedby = "modifiedby";
        public const string modifiedbyname = "modifiedbyname";
        public const string modifiedbyyominame = "modifiedbyyominame";
        public const string modifiedon = "modifiedon";
        public const string modifiedonbehalfby = "modifiedonbehalfby";
        public const string modifiedonbehalfbyname = "modifiedonbehalfbyname";
        public const string modifiedonbehalfbyyominame = "modifiedonbehalfbyyominame";
        public const string name = "name";
        public const string organization_business_units_M1 = "organization_business_units";
        public const string organizationid = "organizationid";
        public const string organizationidname = "organizationidname";
        public const string overriddencreatedon = "overriddencreatedon";
        public const string Owning_businessunit_processsessions_1M = "Owning_businessunit_processsessions";
        public const string parentbusinessunitid = "parentbusinessunitid";
        public const string parentbusinessunitidname = "parentbusinessunitidname";
        public const string picture = "picture";
        public const string stockexchange = "stockexchange";

        public const string systemuserbusinessunitentitymap_businessunitid_businessunit_1M =
            "systemuserbusinessunitentitymap_businessunitid_businessunit";

        public const string tickersymbol = "tickersymbol";
        // Many To One
        public const string TransactionCurrency_BusinessUnit_M1 = "TransactionCurrency_BusinessUnit";
        public const string transactioncurrencyid = "transactioncurrencyid";
        public const string transactioncurrencyidname = "transactioncurrencyidname";
        public const string userentityinstancedata_businessunit_1M = "userentityinstancedata_businessunit";
        public const string userentityuisettings_businessunit_1M = "userentityuisettings_businessunit";
        public const string usergroupid = "usergroupid";
        public const string utcoffset = "utcoffset";
        public const string versionnumber = "versionnumber";
        public const string websiteurl = "websiteurl";
        public const string workflowsuspended = "workflowsuspended";
        public const string workflowsuspendedname = "workflowsuspendedname";
    }

    #endregion

    #region "Opportunity"

    public class opportunity
    {
        //Fields
        public const string accountid = "accountid";
        public const string accountidname = "accountidname";
        public const string accountidyominame = "accountidyominame";
        public const string actualclosedate = "actualclosedate";
        public const string actualvalue = "actualvalue";
        public const string actualvalue_base = "actualvalue_base";
        public const string budgetamount = "budgetamount";
        public const string budgetamount_base = "budgetamount_base";
        public const string budgetstatus = "budgetstatus";
        public const string budgettypename = "budgettypename";
        public const string business_unit_opportunities_M1 = "business_unit_opportunities";
        public const string campaign_opportunities_M1 = "campaign_opportunities";
        public const string campaignid = "campaignid";
        public const string campaignidname = "campaignidname";
        public const string captureproposalfeedback = "captureproposalfeedback";
        public const string captureproposalfeedbackname = "captureproposalfeedbackname";
        public const string closeprobability = "closeprobability";
        public const string completefinalproposal = "completefinalproposal";
        public const string completefinalproposalname = "completefinalproposalname";
        public const string completeinternalreview = "completeinternalreview";
        public const string completeinternalreviewname = "completeinternalreviewname";
        public const string confirminterest = "confirminterest";
        public const string confirminterestname = "confirminterestname";
        public const string contactid = "contactid";
        public const string contactidname = "contactidname";
        public const string contactidyominame = "contactidyominame";
        public const string createdby = "createdby";
        public const string createdbyname = "createdbyname";
        public const string createdbyyominame = "createdbyyominame";
        public const string createdon = "createdon";
        public const string createdonbehalfby = "createdonbehalfby";
        public const string createdonbehalfbyname = "createdonbehalfbyname";
        public const string createdonbehalfbyyominame = "createdonbehalfbyyominame";
        public const string CreatedOpportunity_BulkOperationLogs_1M = "CreatedOpportunity_BulkOperationLogs";
        public const string currentsituation = "currentsituation";
        public const string customerid = "customerid";
        public const string customeridname = "customeridname";
        public const string customeridtype = "customeridtype";
        public const string customeridyominame = "customeridyominame";
        public const string customerneed = "customerneed";
        public const string customerpainpoints = "customerpainpoints";
        public const string decisionmaker = "decisionmaker";
        public const string decisionmakername = "decisionmakername";
        public const string description = "description";
        public const string developproposal = "developproposal";
        public const string developproposalname = "developproposalname";
        public const string discountamount = "discountamount";
        public const string discountamount_base = "discountamount_base";
        public const string discountpercentage = "discountpercentage";
        public const string estimatedclosedate = "estimatedclosedate";
        public const string estimatedvalue = "estimatedvalue";
        public const string estimatedvalue_base = "estimatedvalue_base";
        public const string evaluatefit = "evaluatefit";
        public const string evaluatefitname = "evaluatefitname";
        public const string exchangerate = "exchangerate";
        public const string filedebrief = "filedebrief";
        public const string filedebriefname = "filedebriefname";
        public const string finaldecisiondate = "finaldecisiondate";
        public const string freightamount = "freightamount";
        public const string freightamount_base = "freightamount_base";
        public const string identifycompetitors = "identifycompetitors";
        public const string identifycompetitorsname = "identifycompetitorsname";
        public const string identifycustomercontacts = "identifycustomercontacts";
        public const string identifycustomercontactsname = "identifycustomercontactsname";
        public const string identifypursuitteam = "identifypursuitteam";
        public const string identifypursuitteamname = "identifypursuitteamname";
        public const string importsequencenumber = "importsequencenumber";
        public const string initialcommunication = "initialcommunication";
        public const string initialcommunicationname = "initialcommunicationname";
        public const string isprivate = "isprivate";
        public const string isprivatename = "isprivatename";
        public const string isrevenuesystemcalculated = "isrevenuesystemcalculated";
        public const string isrevenuesystemcalculatedname = "isrevenuesystemcalculatedname";
        public const string lead_qualifying_opportunity_1M = "lead_qualifying_opportunity";
        public const string lk_opportunity_createdonbehalfby_M1 = "lk_opportunity_createdonbehalfby";
        public const string lk_opportunity_modifiedonbehalfby_M1 = "lk_opportunity_modifiedonbehalfby";
        // Many To One
        public const string lk_opportunitybase_createdby_M1 = "lk_opportunitybase_createdby";
        public const string lk_opportunitybase_modifiedby_M1 = "lk_opportunitybase_modifiedby";
        public const string modifiedby = "modifiedby";
        public const string modifiedbyname = "modifiedbyname";
        public const string modifiedbyyominame = "modifiedbyyominame";
        public const string modifiedon = "modifiedon";
        public const string modifiedonbehalfby = "modifiedonbehalfby";
        public const string modifiedonbehalfbyname = "modifiedonbehalfbyname";
        public const string modifiedonbehalfbyyominame = "modifiedonbehalfbyyominame";
        public const string name = "name";
        public const string need = "need";
        public const string needname = "needname";
        public const string opportunity_activity_parties_1M = "opportunity_activity_parties";
        public const string Opportunity_ActivityPointers_1M = "Opportunity_ActivityPointers";
        public const string Opportunity_Annotation_1M = "Opportunity_Annotation";
        public const string Opportunity_Appointments_1M = "Opportunity_Appointments";
        public const string Opportunity_AsyncOperations_1M = "Opportunity_AsyncOperations";
        public const string Opportunity_BulkDeleteFailures_1M = "Opportunity_BulkDeleteFailures";
        public const string opportunity_connections1_1M = "opportunity_connections1";
        public const string opportunity_connections2_1M = "opportunity_connections2";
        public const string opportunity_customer_accounts_M1 = "opportunity_customer_accounts";
        public const string opportunity_customer_contacts_M1 = "opportunity_customer_contacts";
        public const string opportunity_customer_opportunity_roles_1M = "opportunity_customer_opportunity_roles";
        public const string Opportunity_DuplicateBaseRecord_1M = "Opportunity_DuplicateBaseRecord";
        public const string Opportunity_DuplicateMatchingRecord_1M = "Opportunity_DuplicateMatchingRecord";
        public const string Opportunity_Emails_1M = "Opportunity_Emails";
        public const string Opportunity_Faxes_1M = "Opportunity_Faxes";
        public const string opportunity_invoices_1M = "opportunity_invoices";
        public const string Opportunity_Letters_1M = "Opportunity_Letters";
        public const string Opportunity_MailboxTrackingFolder_1M = "Opportunity_MailboxTrackingFolder";
        public const string Opportunity_OpportunityClose_1M = "Opportunity_OpportunityClose";
        public const string opportunity_originating_lead_M1 = "opportunity_originating_lead";
        public const string opportunity_owning_user_M1 = "opportunity_owning_user";
        public const string opportunity_parent_account_M1 = "opportunity_parent_account";
        public const string opportunity_parent_contact_M1 = "opportunity_parent_contact";
        public const string Opportunity_Phonecalls_1M = "Opportunity_Phonecalls";
        public const string opportunity_PostFollows_1M = "opportunity_PostFollows";
        public const string opportunity_PostRegardings_1M = "opportunity_PostRegardings";
        public const string opportunity_PostRoles_1M = "opportunity_PostRoles";
        public const string opportunity_principalobjectattributeaccess_1M = "opportunity_principalobjectattributeaccess";
        public const string Opportunity_ProcessSessions_1M = "Opportunity_ProcessSessions";
        public const string opportunity_quotes_1M = "opportunity_quotes";
        public const string Opportunity_RecurringAppointmentMasters_1M = "Opportunity_RecurringAppointmentMasters";
        public const string opportunity_sales_orders_1M = "opportunity_sales_orders";
        public const string Opportunity_ServiceAppointments_1M = "Opportunity_ServiceAppointments";
        public const string Opportunity_SharepointDocument_1M = "Opportunity_SharepointDocument";
        public const string Opportunity_SharepointDocumentLocation_1M = "Opportunity_SharepointDocumentLocation";
        // One To Many Relationships
        public const string Opportunity_SocialActivities_1M = "Opportunity_SocialActivities";
        public const string Opportunity_Tasks_1M = "Opportunity_Tasks";
        public const string opportunity_Teams_1M = "opportunity_Teams";
        // Many To Many
        public const string opportunitycompetitors_MM = "opportunitycompetitors";
        public const string opportunityid = "opportunityid";
        public const string opportunityratingcode = "opportunityratingcode";
        public const string opportunityratingcodename = "opportunityratingcodename";
        public const string originatingleadid = "originatingleadid";
        public const string originatingleadidname = "originatingleadidname";
        public const string originatingleadidyominame = "originatingleadidyominame";
        public const string overriddencreatedon = "overriddencreatedon";
        public const string owner_opportunitys_M1 = "owner_opportunitys";
        public const string ownerid = "ownerid";
        public const string owneridname = "owneridname";
        public const string owneridtype = "owneridtype";
        public const string owneridyominame = "owneridyominame";
        public const string owningbusinessunit = "owningbusinessunit";
        public const string owningteam = "owningteam";
        public const string owninguser = "owninguser";
        public const string parentaccountid = "parentaccountid";
        public const string parentaccountidname = "parentaccountidname";
        public const string parentaccountidyominame = "parentaccountidyominame";
        public const string parentcontactid = "parentcontactid";
        public const string parentcontactidname = "parentcontactidname";
        public const string parentcontactidyominame = "parentcontactidyominame";
        public const string participatesinworkflow = "participatesinworkflow";
        public const string participatesinworkflowname = "participatesinworkflowname";
        public const string presentfinalproposal = "presentfinalproposal";
        public const string presentfinalproposalname = "presentfinalproposalname";
        public const string presentproposal = "presentproposal";
        public const string presentproposalname = "presentproposalname";
        public const string price_level_opportunties_M1 = "price_level_opportunties";
        public const string pricelevelid = "pricelevelid";
        public const string pricelevelidname = "pricelevelidname";
        public const string pricingerrorcode = "pricingerrorcode";
        public const string pricingerrorcodename = "pricingerrorcodename";
        public const string prioritycode = "prioritycode";
        public const string prioritycodename = "prioritycodename";
        public const string processid = "processid";
        public const string processstage_opportunity_M1 = "processstage_opportunity";
        public const string product_opportunities_1M = "product_opportunities";
        public const string proposedsolution = "proposedsolution";
        public const string purchaseprocess = "purchaseprocess";
        public const string purchaseprocessname = "purchaseprocessname";
        public const string purchasetimeframe = "purchasetimeframe";
        public const string purchasetimeframename = "purchasetimeframename";
        public const string pursuitdecision = "pursuitdecision";
        public const string pursuitdecisionname = "pursuitdecisionname";
        public const string qualificationcomments = "qualificationcomments";
        public const string quotecomments = "quotecomments";
        public const string resolvefeedback = "resolvefeedback";
        public const string resolvefeedbackname = "resolvefeedbackname";
        public const string salesstage = "salesstage";
        public const string salesstagecode = "salesstagecode";
        public const string salesstagecodename = "salesstagecodename";
        public const string salesstagename = "salesstagename";
        public const string schedulefollowup_prospect = "schedulefollowup_prospect";
        public const string schedulefollowup_qualify = "schedulefollowup_qualify";
        public const string scheduleproposalmeeting = "scheduleproposalmeeting";
        public const string sendthankyounote = "sendthankyounote";
        public const string sendthankyounotename = "sendthankyounotename";
        public const string stageid = "stageid";
        public const string statecode = "statecode";
        public const string statecodename = "statecodename";
        public const string statuscode = "statuscode";
        public const string statuscodename = "statuscodename";
        public const string stepid = "stepid";
        public const string stepname = "stepname";
        public const string team_opportunities_M1 = "team_opportunities";
        public const string timeline = "timeline";
        public const string timelinename = "timelinename";
        public const string timezoneruleversionnumber = "timezoneruleversionnumber";
        public const string totalamount = "totalamount";
        public const string totalamount_base = "totalamount_base";
        public const string totalamountlessfreight = "totalamountlessfreight";
        public const string totalamountlessfreight_base = "totalamountlessfreight_base";
        public const string totaldiscountamount = "totaldiscountamount";
        public const string totaldiscountamount_base = "totaldiscountamount_base";
        public const string totallineitemamount = "totallineitemamount";
        public const string totallineitemamount_base = "totallineitemamount_base";
        public const string totallineitemdiscountamount = "totallineitemdiscountamount";
        public const string totallineitemdiscountamount_base = "totallineitemdiscountamount_base";
        public const string totaltax = "totaltax";
        public const string totaltax_base = "totaltax_base";
        public const string transactioncurrency_opportunity_M1 = "transactioncurrency_opportunity";
        public const string transactioncurrencyid = "transactioncurrencyid";
        public const string transactioncurrencyidname = "transactioncurrencyidname";
        public const string traversedpath = "traversedpath";
        public const string userentityinstancedata_opportunity_1M = "userentityinstancedata_opportunity";
        public const string utcconversiontimezonecode = "utcconversiontimezonecode";
        public const string versionnumber = "versionnumber";
    }

    public class opportunity_enums
    {
        public enum budgetstatus
        {
            Can_Buy = 2,
            May_Buy = 1,
            No_Committed_Budget = 0,
            Will_Buy = 3
        }

        public enum initialcommunication
        {
            Contacted = 0,
            Not_Contacted = 1
        }

        public enum need
        {
            Good_to_have = 2,
            Must_have = 0,
            No_need = 3,
            Should_have = 1
        }

        public enum pricingerrorcode
        {
            Base_Currency_Attribute_Overflow = 36,
            Base_Currency_Attribute_Underflow = 37,
            Detail_Error = 1,
            Discount_Type_Invalid_State = 27,
            Inactive_Discount_Type = 33,
            Inactive_Price_Level = 3,
            Invalid_Current_Cost = 20,
            Invalid_Discount = 28,
            Invalid_Discount_Type = 26,
            Invalid_Price = 19,
            Invalid_Price_Level_Amount = 17,
            Invalid_Price_Level_Currency = 34,
            Invalid_Price_Level_Percentage = 18,
            Invalid_Pricing_Code = 9,
            Invalid_Pricing_Precision = 30,
            Invalid_Product = 7,
            Invalid_Quantity = 29,
            Invalid_Rounding_Amount = 24,
            Invalid_Rounding_Option = 23,
            Invalid_Rounding_Policy = 22,
            Invalid_Standard_Cost = 21,
            Missing_Current_Cost = 15,
            Missing_Price = 14,
            Missing_Price_Level = 2,
            Missing_Price_Level_Amount = 12,
            Missing_Price_Level_Percentage = 13,
            Missing_Pricing_Code = 8,
            Missing_Product = 6,
            Missing_Product_Default_UOM = 31,
            Missing_Product_UOM_Schedule_ = 32,
            Missing_Quantity = 4,
            Missing_Standard_Cost = 16,
            Missing_Unit_Price = 5,
            Missing_UOM = 10,
            None = 0,
            Price_Attribute_Out_Of_Range = 35,
            Price_Calculation_Error = 25,
            Product_Not_In_Price_Level = 11
        }

        public enum prioritycode
        {
            Default_Value = 1
        }

        public enum purchaseprocess
        {
            Committee = 1,
            Individual = 0,
            Unknown = 2
        }

        public enum purchasetimeframe
        {
            Immediate = 0,
            Next_Quarter = 2,
            This_Quarter = 1,
            This_Year = 3,
            Unknown = 4
        }

        public enum salesstage
        {
            Close = 3,
            Develop = 1,
            Propose = 2,
            Qualify = 0
        }

        public enum salesstagecode
        {
            Default_Value = 1
        }

        public enum statecode
        {
            Lost = 2,
            Open = 0,
            Won = 1
        }

        /// <summary>
        /// Enum timeline
        /// </summary>
        public enum timeline
        {
            Immediate = 0,
            Next_Quarter = 2,
            Not_known = 4,
            This_Quarter = 1,
            This_Year = 3
        }
    }

    #endregion

    #region "opportunityclose"

    public class opportunityclose
    {
        public const string activity_pointer_opportunity_close_M1 = "activity_pointer_opportunity_close";
        //Fields
        public const string activityid = "activityid";
        public const string activitytypecode = "activitytypecode";
        public const string activitytypecodename = "activitytypecodename";
        public const string actualdurationminutes = "actualdurationminutes";
        public const string actualend = "actualend";
        public const string actualrevenue = "actualrevenue";
        public const string actualrevenue_base = "actualrevenue_base";
        public const string actualstart = "actualstart";
        public const string business_unit_opportunity_close_activities_M1 = "business_unit_opportunity_close_activities";
        public const string category = "category";
        public const string competitor_opportunity_activities_M1 = "competitor_opportunity_activities";
        public const string competitorid = "competitorid";
        public const string competitoridname = "competitoridname";
        public const string competitoridyominame = "competitoridyominame";
        public const string createdby = "createdby";
        public const string createdbyname = "createdbyname";
        public const string createdbyyominame = "createdbyyominame";
        public const string createdon = "createdon";
        public const string createdonbehalfby = "createdonbehalfby";
        public const string createdonbehalfbyname = "createdonbehalfbyname";
        public const string createdonbehalfbyyominame = "createdonbehalfbyyominame";
        public const string description = "description";
        public const string exchangerate = "exchangerate";
        public const string importsequencenumber = "importsequencenumber";
        public const string isbilled = "isbilled";
        public const string isbilledname = "isbilledname";
        public const string isregularactivity = "isregularactivity";
        public const string isregularactivityname = "isregularactivityname";
        public const string isworkflowcreated = "isworkflowcreated";
        public const string isworkflowcreatedname = "isworkflowcreatedname";
        public const string lk_opportunityclose_createdby_M1 = "lk_opportunityclose_createdby";
        public const string lk_opportunityclose_createdonbehalfby_M1 = "lk_opportunityclose_createdonbehalfby";
        public const string lk_opportunityclose_modifiedby_M1 = "lk_opportunityclose_modifiedby";
        public const string lk_opportunityclose_modifiedonbehalfby_M1 = "lk_opportunityclose_modifiedonbehalfby";
        public const string modifiedby = "modifiedby";
        public const string modifiedbyname = "modifiedbyname";
        public const string modifiedbyyominame = "modifiedbyyominame";
        public const string modifiedon = "modifiedon";
        public const string modifiedonbehalfby = "modifiedonbehalfby";
        public const string modifiedonbehalfbyname = "modifiedonbehalfbyname";
        public const string modifiedonbehalfbyyominame = "modifiedonbehalfbyyominame";
        public const string Opportunity_OpportunityClose_M1 = "Opportunity_OpportunityClose";
        public const string opportunityclose_activity_parties_1M = "opportunityclose_activity_parties";
        public const string OpportunityClose_Annotation_1M = "OpportunityClose_Annotation";
        public const string OpportunityClose_AsyncOperations_1M = "OpportunityClose_AsyncOperations";
        // One To Many Relationships
        public const string OpportunityClose_BulkDeleteFailures_1M = "OpportunityClose_BulkDeleteFailures";
        public const string opportunityid = "opportunityid";
        public const string opportunityidname = "opportunityidname";
        public const string opportunityidtype = "opportunityidtype";
        public const string overriddencreatedon = "overriddencreatedon";
        public const string ownerid = "ownerid";
        public const string owneridname = "owneridname";
        public const string owneridtype = "owneridtype";
        public const string owneridyominame = "owneridyominame";
        public const string owningbusinessunit = "owningbusinessunit";
        public const string owningteam = "owningteam";
        public const string owninguser = "owninguser";
        public const string scheduleddurationminutes = "scheduleddurationminutes";
        public const string scheduledend = "scheduledend";
        public const string scheduledstart = "scheduledstart";
        public const string service_opportunityclose_M1 = "service_opportunityclose";
        public const string serviceid = "serviceid";
        public const string statecode = "statecode";
        public const string statecodename = "statecodename";
        public const string statuscode = "statuscode";
        public const string statuscodename = "statuscodename";
        public const string subcategory = "subcategory";
        public const string subject = "subject";
        public const string team_opportunityclose_M1 = "team_opportunityclose";
        public const string timezoneruleversionnumber = "timezoneruleversionnumber";
        // Many To One
        public const string transactioncurrency_opportunityclose_M1 = "transactioncurrency_opportunityclose";
        public const string transactioncurrencyid = "transactioncurrencyid";
        public const string transactioncurrencyidname = "transactioncurrencyidname";
        public const string user_opportunityclose_M1 = "user_opportunityclose";
        public const string userentityinstancedata_opportunityclose_1M = "userentityinstancedata_opportunityclose";
        public const string utcconversiontimezonecode = "utcconversiontimezonecode";
        public const string versionnumber = "versionnumber";
    }

    #endregion

    #region "organization"

    public class organization
    {
        //Fields
        public const string acknowledgementtemplateid = "acknowledgementtemplateid";
        public const string acknowledgementtemplateidname = "acknowledgementtemplateidname";
        public const string allowaddressbooksyncs = "allowaddressbooksyncs";
        public const string allowautoresponsecreation = "allowautoresponsecreation";
        public const string allowautounsubscribe = "allowautounsubscribe";
        public const string allowautounsubscribeacknowledgement = "allowautounsubscribeacknowledgement";
        public const string allowclientmessagebarad = "allowclientmessagebarad";
        public const string allowentityonlyaudit = "allowentityonlyaudit";
        public const string allowmarketingemailexecution = "allowmarketingemailexecution";
        public const string allowofflinescheduledsyncs = "allowofflinescheduledsyncs";
        public const string allowoutlookscheduledsyncs = "allowoutlookscheduledsyncs";
        public const string allowunresolvedpartiesonemailsend = "allowunresolvedpartiesonemailsend";
        public const string allowuserformmodepreference = "allowuserformmodepreference";
        public const string allowusersseeappdownloadmessage = "allowusersseeappdownloadmessage";
        public const string allowwebexcelexport = "allowwebexcelexport";
        public const string amdesignator = "amdesignator";
        public const string autoapplydefaultoncasecreate = "autoapplydefaultoncasecreate";
        public const string autoapplydefaultoncasecreatename = "autoapplydefaultoncasecreatename";
        public const string autoapplydefaultoncaseupdate = "autoapplydefaultoncaseupdate";
        public const string autoapplydefaultoncaseupdatename = "autoapplydefaultoncaseupdatename";
        public const string basecurrency_organization_M1 = "basecurrency_organization";
        public const string basecurrencyid = "basecurrencyid";
        public const string basecurrencyidname = "basecurrencyidname";
        public const string basecurrencyprecision = "basecurrencyprecision";
        public const string basecurrencysymbol = "basecurrencysymbol";
        public const string baseisocurrencycode = "baseisocurrencycode";
        public const string bingmapsapikey = "bingmapsapikey";
        public const string blockedattachments = "blockedattachments";
        public const string bulkoperationprefix = "bulkoperationprefix";
        public const string businessclosurecalendarid = "businessclosurecalendarid";
        public const string calendar_organization_M1 = "calendar_organization";
        public const string calendartype = "calendartype";
        public const string campaignprefix = "campaignprefix";
        public const string cascadestatusupdate = "cascadestatusupdate";
        public const string caseprefix = "caseprefix";
        public const string channelproperty_organization_1M = "channelproperty_organization";
        public const string channelpropertygroup_organization_1M = "channelpropertygroup_organization";
        public const string contractprefix = "contractprefix";
        public const string createdby = "createdby";
        public const string createdbyname = "createdbyname";
        public const string createdbyyominame = "createdbyyominame";
        public const string createdon = "createdon";
        public const string createdonbehalfby = "createdonbehalfby";
        public const string createdonbehalfbyname = "createdonbehalfbyname";
        public const string createdonbehalfbyyominame = "createdonbehalfbyyominame";
        public const string createproductswithoutparentinactivestate = "createproductswithoutparentinactivestate";
        public const string currencydecimalprecision = "currencydecimalprecision";
        public const string currencydisplayoption = "currencydisplayoption";
        public const string currencyformatcode = "currencyformatcode";
        public const string currencyformatcodename = "currencyformatcodename";
        public const string currencysymbol = "currencysymbol";
        public const string currentbulkoperationnumber = "currentbulkoperationnumber";
        public const string currentcampaignnumber = "currentcampaignnumber";
        public const string currentcasenumber = "currentcasenumber";
        public const string currentcontractnumber = "currentcontractnumber";
        public const string currentimportsequencenumber = "currentimportsequencenumber";
        public const string currentinvoicenumber = "currentinvoicenumber";
        public const string currentkbnumber = "currentkbnumber";
        public const string currentordernumber = "currentordernumber";
        public const string currentparsedtablenumber = "currentparsedtablenumber";
        public const string currentquotenumber = "currentquotenumber";
        public const string dateformatcode = "dateformatcode";
        public const string dateformatcodename = "dateformatcodename";
        public const string dateformatstring = "dateformatstring";
        public const string dateseparator = "dateseparator";
        public const string decimalsymbol = "decimalsymbol";
        public const string defaultcountrycode = "defaultcountrycode";
        public const string defaultemailserverprofileid = "defaultemailserverprofileid";
        public const string defaultemailserverprofileidname = "defaultemailserverprofileidname";
        public const string defaultemailsettings = "defaultemailsettings";
        public const string defaultrecurrenceendrangetype = "defaultrecurrenceendrangetype";
        public const string defaultrecurrenceendrangetypename = "defaultrecurrenceendrangetypename";
        public const string defaultthemedata = "defaultthemedata";
        public const string disabledreason = "disabledreason";
        public const string disablesocialcare = "disablesocialcare";
        public const string discountcalculationmethod = "discountcalculationmethod";
        public const string displaynavigationtour = "displaynavigationtour";
        public const string dynamicproperty_organization_1M = "dynamicproperty_organization";
        public const string DynamicPropertyAssociation_organization_1M = "DynamicPropertyAssociation_organization";
        public const string DynamicPropertyOptionSetItem_organization_1M = "DynamicPropertyOptionSetItem_organization";
        public const string emailconnectionchannel = "emailconnectionchannel";
        public const string emailcorrelationenabled = "emailcorrelationenabled";
        public const string emailsendpollingperiod = "emailsendpollingperiod";
        public const string EmailServerProfile_Organization_M1 = "EmailServerProfile_Organization";
        public const string enablebingmapsintegration = "enablebingmapsintegration";
        public const string enablepricingoncreate = "enablepricingoncreate";
        public const string enablesmartmatching = "enablesmartmatching";
        public const string enforcereadonlyplugins = "enforcereadonlyplugins";
        public const string entitlementchannel_organization_1M = "entitlementchannel_organization";
        public const string entitlementtemplate_organization_1M = "entitlementtemplate_organization";
        public const string entitlementtemplatechannel_organization_1M = "entitlementtemplatechannel_organization";
        public const string entityimage = "entityimage";
        public const string entityimage_timestamp = "entityimage_timestamp";
        public const string entityimage_url = "entityimage_url";
        public const string entityimageid = "entityimageid";
        public const string expirechangetrackingindays = "expirechangetrackingindays";
        public const string expiresubscriptionsindays = "expiresubscriptionsindays";
        public const string featureset = "featureset";
        public const string fiscalcalendarstart = "fiscalcalendarstart";
        public const string fiscalperiodformat = "fiscalperiodformat";
        public const string fiscalperiodformatperiod = "fiscalperiodformatperiod";
        public const string fiscalperiodformatperiodname = "fiscalperiodformatperiodname";
        public const string fiscalperiodtype = "fiscalperiodtype";
        public const string fiscalsettingsupdated = "fiscalsettingsupdated";
        public const string fiscalsettingsupdatedname = "fiscalsettingsupdatedname";
        public const string fiscalyeardisplaycode = "fiscalyeardisplaycode";
        public const string fiscalyearformat = "fiscalyearformat";
        public const string fiscalyearformatprefix = "fiscalyearformatprefix";
        public const string fiscalyearformatprefixname = "fiscalyearformatprefixname";
        public const string fiscalyearformatsuffix = "fiscalyearformatsuffix";
        public const string fiscalyearformatsuffixname = "fiscalyearformatsuffixname";
        public const string fiscalyearformatyear = "fiscalyearformatyear";
        public const string fiscalyearformatyearname = "fiscalyearformatyearname";
        public const string fiscalyearperiodconnect = "fiscalyearperiodconnect";
        public const string fullnameconventioncode = "fullnameconventioncode";
        public const string fullnameconventioncodename = "fullnameconventioncodename";
        public const string futureexpansionwindow = "futureexpansionwindow";
        public const string generatealertsforerrors = "generatealertsforerrors";
        public const string generatealertsforinformation = "generatealertsforinformation";
        public const string generatealertsforwarnings = "generatealertsforwarnings";
        public const string getstartedpanecontentenabled = "getstartedpanecontentenabled";
        public const string globalappendurlparametersenabled = "globalappendurlparametersenabled";
        public const string globalhelpurl = "globalhelpurl";
        public const string globalhelpurlenabled = "globalhelpurlenabled";
        public const string goalrollupexpirytime = "goalrollupexpirytime";
        public const string goalrollupfrequency = "goalrollupfrequency";
        public const string grantaccesstonetworkservice = "grantaccesstonetworkservice";
        public const string hashdeltasubjectcount = "hashdeltasubjectcount";
        public const string hashfilterkeywords = "hashfilterkeywords";
        public const string hashmaxcount = "hashmaxcount";
        public const string hashminaddresscount = "hashminaddresscount";
        public const string highcontrastthemedata = "highcontrastthemedata";
        public const string ignoreinternalemail = "ignoreinternalemail";

        public const string incomingemailexchangeemailretrievalbatchsize =
            "incomingemailexchangeemailretrievalbatchsize";

        public const string initialversion = "initialversion";
        public const string integrationuserid = "integrationuserid";
        public const string invoiceprefix = "invoiceprefix";
        public const string isappmode = "isappmode";
        public const string isappointmentattachmentsyncenabled = "isappointmentattachmentsyncenabled";
        public const string isassignedtaskssyncenabled = "isassignedtaskssyncenabled";
        public const string isauditenabled = "isauditenabled";
        public const string isautosaveenabled = "isautosaveenabled";
        public const string iscontactmailingaddresssyncenabled = "iscontactmailingaddresssyncenabled";
        public const string isdefaultcountrycodecheckenabled = "isdefaultcountrycodecheckenabled";
        public const string isdelegateaccessenabled = "isdelegateaccessenabled";
        public const string isdisabled = "isdisabled";
        public const string isdisabledname = "isdisabledname";
        public const string isduplicatedetectionenabled = "isduplicatedetectionenabled";
        public const string isduplicatedetectionenabledforimport = "isduplicatedetectionenabledforimport";
        public const string isduplicatedetectionenabledforofflinesync = "isduplicatedetectionenabledforofflinesync";

        public const string isduplicatedetectionenabledforonlinecreateupdate =
            "isduplicatedetectionenabledforonlinecreateupdate";

        public const string isemailserverprofilecontentfilteringenabled = "isemailserverprofilecontentfilteringenabled";
        public const string isfiscalperiodmonthbased = "isfiscalperiodmonthbased";
        public const string isfolderbasedtrackingenabled = "isfolderbasedtrackingenabled";
        public const string isfulltextsearchenabled = "isfulltextsearchenabled";
        public const string ishierarchicalsecuritymodelenabled = "ishierarchicalsecuritymodelenabled";
        public const string ismailboxforcedunlockingenabled = "ismailboxforcedunlockingenabled";
        public const string ismailboxinactivebackoffenabled = "ismailboxinactivebackoffenabled";
        public const string ispresenceenabled = "ispresenceenabled";
        public const string ispresenceenabledname = "ispresenceenabledname";
        public const string issopintegrationenabled = "issopintegrationenabled";
        public const string isuseraccessauditenabled = "isuseraccessauditenabled";
        public const string isvintegrationcode = "isvintegrationcode";
        public const string kbprefix = "kbprefix";
        public const string kmsettings = "kmsettings";
        public const string languagecode = "languagecode";
        public const string languagecodename = "languagecodename";
        public const string lk_authorizationserver_organizationid_1M = "lk_authorizationserver_organizationid";
        public const string lk_fieldsecurityprofile_organizationid_1M = "lk_fieldsecurityprofile_organizationid";
        public const string lk_organization_createdonbehalfby_M1 = "lk_organization_createdonbehalfby";
        public const string lk_organization_entityimage_M1 = "lk_organization_entityimage";
        public const string lk_organization_modifiedonbehalfby_M1 = "lk_organization_modifiedonbehalfby";
        public const string lk_organizationbase_createdby_M1 = "lk_organizationbase_createdby";
        // Many To One
        public const string lk_organizationbase_modifiedby_M1 = "lk_organizationbase_modifiedby";
        public const string lk_organizationui_organizationid_1M = "lk_organizationui_organizationid";
        public const string lk_partnerapplication_organizationid_1M = "lk_partnerapplication_organizationid";
        // One To Many Relationships
        public const string lk_principalobjectattributeaccess_organizationid_1M =
            "lk_principalobjectattributeaccess_organizationid";

        public const string lk_principalsyncattributemap_organizationid_1M =
            "lk_principalsyncattributemap_organizationid";

        public const string lk_syncattributemappingprofile_organizationid_1M =
            "lk_syncattributemappingprofile_organizationid";

        public const string localeid = "localeid";
        public const string longdateformatcode = "longdateformatcode";
        public const string mailboxintermittentissueminrange = "mailboxintermittentissueminrange";
        public const string mailboxpermanentissueminrange = "mailboxpermanentissueminrange";
        public const string maxappointmentdurationdays = "maxappointmentdurationdays";
        public const string maxdepthforhierarchicalsecuritymodel = "maxdepthforhierarchicalsecuritymodel";
        public const string maxfolderbasedtrackingmappings = "maxfolderbasedtrackingmappings";

        public const string maximumactivebusinessprocessflowsallowedperentity =
            "maximumactivebusinessprocessflowsallowedperentity";

        public const string maximumdynamicpropertiesallowed = "maximumdynamicpropertiesallowed";
        public const string maximumtrackingnumber = "maximumtrackingnumber";
        public const string maxproductsinbundle = "maxproductsinbundle";
        public const string maxrecordsforexporttoexcel = "maxrecordsforexporttoexcel";
        public const string maxrecordsforlookupfilters = "maxrecordsforlookupfilters";
        public const string maxsupportedinternetexplorerversion = "maxsupportedinternetexplorerversion";
        public const string maxuploadfilesize = "maxuploadfilesize";

        public const string metadatasynclasttimeofneverexpireddeletedobjects =
            "metadatasynclasttimeofneverexpireddeletedobjects";

        public const string metadatasynctimestamp = "metadatasynctimestamp";
        public const string minaddressbooksyncinterval = "minaddressbooksyncinterval";
        public const string minofflinesyncinterval = "minofflinesyncinterval";
        public const string minoutlooksyncinterval = "minoutlooksyncinterval";
        public const string mobileclientmashupenabled = "mobileclientmashupenabled";
        public const string modifiedby = "modifiedby";
        public const string modifiedbyname = "modifiedbyname";
        public const string modifiedbyyominame = "modifiedbyyominame";
        public const string modifiedon = "modifiedon";
        public const string modifiedonbehalfby = "modifiedonbehalfby";
        public const string modifiedonbehalfbyname = "modifiedonbehalfbyname";
        public const string modifiedonbehalfbyyominame = "modifiedonbehalfbyyominame";
        public const string name = "name";
        public const string negativecurrencyformatcode = "negativecurrencyformatcode";
        public const string negativeformatcode = "negativeformatcode";
        public const string negativeformatcodename = "negativeformatcodename";
        public const string nextcustomobjecttypecode = "nextcustomobjecttypecode";
        public const string nexttrackingnumber = "nexttrackingnumber";
        public const string notifymailboxownerofemailserverlevelalerts = "notifymailboxownerofemailserverlevelalerts";
        public const string numberformat = "numberformat";
        public const string numbergroupformat = "numbergroupformat";
        public const string numberseparator = "numberseparator";
        public const string oobpricecalculationenabled = "oobpricecalculationenabled";
        public const string orderprefix = "orderprefix";
        public const string organization_applicationfile_1M = "organization_applicationfile";
        public const string Organization_AsyncOperations_1M = "Organization_AsyncOperations";
        public const string organization_attributemap_1M = "organization_attributemap";
        public const string Organization_BulkDeleteFailures_1M = "Organization_BulkDeleteFailures";
        public const string organization_business_unit_news_articles_1M = "organization_business_unit_news_articles";
        public const string organization_business_units_1M = "organization_business_units";
        public const string organization_calendars_1M = "organization_calendars";
        public const string organization_competitors_1M = "organization_competitors";
        public const string organization_complexcontrols_1M = "organization_complexcontrols";
        public const string organization_connection_roles_1M = "organization_connection_roles";
        public const string organization_constraint_based_groups_1M = "organization_constraint_based_groups";
        public const string organization_contract_templates_1M = "organization_contract_templates";
        public const string organization_custom_displaystrings_1M = "organization_custom_displaystrings";
        public const string organization_discount_types_1M = "organization_discount_types";
        public const string organization_emailserverprofile_1M = "organization_emailserverprofile";
        public const string organization_entitymap_1M = "organization_entitymap";
        public const string organization_equipment_1M = "organization_equipment";
        public const string organization_hierarchyrules_1M = "organization_hierarchyrules";
        public const string organization_importjob_1M = "organization_importjob";
        public const string organization_indexed_documents_1M = "organization_indexed_documents";
        public const string organization_integration_statuses_1M = "organization_integration_statuses";
        public const string organization_isvconfigs_1M = "organization_isvconfigs";
        public const string organization_kb_article_templates_1M = "organization_kb_article_templates";
        public const string organization_kb_articles_1M = "organization_kb_articles";
        public const string organization_KnowledgeBaseRecord_1M = "organization_KnowledgeBaseRecord";
        public const string organization_licenses_1M = "organization_licenses";
        public const string organization_mailbox_1M = "organization_mailbox";
        public const string organization_mailboxstatistics_1M = "organization_mailboxstatistics";
        public const string Organization_MailboxTrackingFolder_1M = "Organization_MailboxTrackingFolder";
        public const string organization_metric_1M = "organization_metric";
        public const string organization_msdyn_postconfig_1M = "organization_msdyn_postconfig";
        public const string organization_msdyn_postruleconfig_1M = "organization_msdyn_postruleconfig";
        public const string organization_msdyn_wallsavedquery_1M = "organization_msdyn_wallsavedquery";
        public const string organization_pluginassembly_1M = "organization_pluginassembly";
        public const string organization_plugintype_1M = "organization_plugintype";
        public const string organization_plugintypestatistic_1M = "organization_plugintypestatistic";
        public const string organization_position_1M = "organization_position";
        public const string organization_post_1M = "organization_post";
        public const string organization_PostComment_1M = "organization_PostComment";
        public const string organization_postlike_1M = "organization_postlike";
        public const string organization_postrole_1M = "organization_postrole";
        public const string organization_price_levels_1M = "organization_price_levels";
        public const string organization_ProductAssociation_1M = "organization_ProductAssociation";
        public const string organization_products_1M = "organization_products";
        public const string organization_ProductSubstitute_1M = "organization_ProductSubstitute";
        public const string organization_publisher_1M = "organization_publisher";
        public const string organization_queueitems_1M = "organization_queueitems";
        public const string organization_queues_1M = "organization_queues";
        public const string organization_relationship_roles_1M = "organization_relationship_roles";
        public const string organization_resource_groups_1M = "organization_resource_groups";
        public const string organization_resource_specs_1M = "organization_resource_specs";
        public const string organization_resources_1M = "organization_resources";
        public const string organization_ribbon_command_1M = "organization_ribbon_command";
        public const string organization_ribbon_context_group_1M = "organization_ribbon_context_group";
        public const string organization_ribbon_customization_1M = "organization_ribbon_customization";
        public const string organization_ribbon_diff_1M = "organization_ribbon_diff";
        public const string organization_ribbon_rule_1M = "organization_ribbon_rule";
        public const string organization_ribbon_tab_to_command_map_1M = "organization_ribbon_tab_to_command_map";
        public const string organization_roles_1M = "organization_roles";
        public const string organization_routingruleitems_1M = "organization_routingruleitems";
        public const string organization_RoutingRules_1M = "organization_RoutingRules";
        public const string organization_sales_literature_1M = "organization_sales_literature";
        public const string organization_saved_queries_1M = "organization_saved_queries";
        public const string organization_saved_query_visualizations_1M = "organization_saved_query_visualizations";
        public const string organization_sdkmessage_1M = "organization_sdkmessage";
        public const string organization_sdkmessagefilter_1M = "organization_sdkmessagefilter";
        public const string organization_sdkmessagepair_1M = "organization_sdkmessagepair";
        public const string organization_sdkmessageprocessingstep_1M = "organization_sdkmessageprocessingstep";
        public const string organization_sdkmessageprocessingstepimage_1M = "organization_sdkmessageprocessingstepimage";

        public const string organization_sdkmessageprocessingstepsecureconfig_1M =
            "organization_sdkmessageprocessingstepsecureconfig";

        public const string organization_sdkmessagerequest_1M = "organization_sdkmessagerequest";
        public const string organization_sdkmessagerequestfield_1M = "organization_sdkmessagerequestfield";
        public const string organization_sdkmessageresponse_1M = "organization_sdkmessageresponse";
        public const string organization_sdkmessageresponsefield_1M = "organization_sdkmessageresponsefield";
        public const string organization_serviceendpoint_1M = "organization_serviceendpoint";
        public const string organization_services_1M = "organization_services";
        public const string organization_sharepointdata_1M = "organization_sharepointdata";
        public const string organization_sharepointdocument_1M = "organization_sharepointdocument";
        public const string organization_sitemap_1M = "organization_sitemap";
        public const string organization_sites_1M = "organization_sites";
        public const string organization_socialinsightsconfiguration_1M = "organization_socialinsightsconfiguration";
        public const string organization_solution_1M = "organization_solution";
        public const string organization_status_maps_1M = "organization_status_maps";
        public const string organization_string_maps_1M = "organization_string_maps";
        public const string organization_subjects_1M = "organization_subjects";
        public const string organization_system_users_1M = "organization_system_users";
        public const string organization_systemapplicationmetadata_1M = "organization_systemapplicationmetadata";
        public const string organization_systemforms_1M = "organization_systemforms";
        public const string organization_teams_1M = "organization_teams";
        public const string organization_territories_1M = "organization_territories";
        public const string organization_theme_1M = "organization_theme";
        public const string organization_traceassociation_1M = "organization_traceassociation";
        public const string organization_tracelog_1M = "organization_tracelog";
        public const string organization_transactioncurrencies_1M = "organization_transactioncurrencies";
        public const string organization_uof_schedules_1M = "organization_uof_schedules";
        public const string organization_UserMapping_1M = "organization_UserMapping";
        public const string organization_webwizard_1M = "organization_webwizard";
        public const string organization_wizardaccessprivilege_1M = "organization_wizardaccessprivilege";
        public const string organization_wizardpage_1M = "organization_wizardpage";
        public const string organizationid = "organizationid";
        public const string orgdborgsettings = "orgdborgsettings";
        public const string parsedtablecolumnprefix = "parsedtablecolumnprefix";
        public const string parsedtableprefix = "parsedtableprefix";
        public const string pastexpansionwindow = "pastexpansionwindow";
        public const string picture = "picture";
        public const string pinpointlanguagecode = "pinpointlanguagecode";
        public const string plugintracelogsetting = "plugintracelogsetting";
        public const string plugintracelogsettingname = "plugintracelogsettingname";
        public const string pmdesignator = "pmdesignator";
        public const string pricingdecimalprecision = "pricingdecimalprecision";
        public const string privacystatementurl = "privacystatementurl";
        public const string privilegeusergroupid = "privilegeusergroupid";
        public const string privreportinggroupid = "privreportinggroupid";
        public const string privreportinggroupname = "privreportinggroupname";
        public const string quickfindrecordlimitenabled = "quickfindrecordlimitenabled";
        public const string quoteprefix = "quoteprefix";
        public const string recurrencedefaultnumberofoccurrences = "recurrencedefaultnumberofoccurrences";
        public const string recurrenceexpansionjobbatchinterval = "recurrenceexpansionjobbatchinterval";
        public const string recurrenceexpansionjobbatchsize = "recurrenceexpansionjobbatchsize";
        public const string recurrenceexpansionsynchcreatemax = "recurrenceexpansionsynchcreatemax";
        public const string referencesitemapxml = "referencesitemapxml";
        public const string rendersecureiframeforemail = "rendersecureiframeforemail";
        public const string reportinggroupid = "reportinggroupid";
        public const string reportinggroupname = "reportinggroupname";
        public const string reportscripterrors = "reportscripterrors";
        public const string reportscripterrorsname = "reportscripterrorsname";
        public const string requireapprovalforqueueemail = "requireapprovalforqueueemail";
        public const string requireapprovalforuseremail = "requireapprovalforuseremail";
        public const string restrictstatusupdate = "restrictstatusupdate";
        public const string sampledataimportid = "sampledataimportid";
        public const string schemanameprefix = "schemanameprefix";
        public const string sharepointdeploymenttype = "sharepointdeploymenttype";
        public const string sharetopreviousowneronassign = "sharetopreviousowneronassign";
        public const string showweeknumber = "showweeknumber";
        public const string showweeknumbername = "showweeknumbername";
        public const string signupoutlookdownloadfwlink = "signupoutlookdownloadfwlink";
        public const string sitemapxml = "sitemapxml";
        public const string slapausestates = "slapausestates";
        public const string socialinsightsenabled = "socialinsightsenabled";
        public const string socialinsightsinstance = "socialinsightsinstance";
        public const string socialinsightstermsaccepted = "socialinsightstermsaccepted";
        public const string sortid = "sortid";
        public const string sqlaccessgroupid = "sqlaccessgroupid";
        public const string sqlaccessgroupname = "sqlaccessgroupname";
        public const string sqmenabled = "sqmenabled";
        public const string supportuserid = "supportuserid";
        public const string suppresssla = "suppresssla";
        public const string systemuserid = "systemuserid";
        public const string tagmaxaggressivecycles = "tagmaxaggressivecycles";
        public const string tagpollingperiod = "tagpollingperiod";
        public const string Template_Organization_M1 = "Template_Organization";
        public const string timeformatcode = "timeformatcode";
        public const string timeformatcodename = "timeformatcodename";
        public const string timeformatstring = "timeformatstring";
        public const string timeseparator = "timeseparator";
        public const string timezoneruleversionnumber = "timezoneruleversionnumber";
        public const string tokenexpiry = "tokenexpiry";
        public const string tokenkey = "tokenkey";
        public const string trackingprefix = "trackingprefix";
        public const string trackingtokenidbase = "trackingtokenidbase";
        public const string trackingtokeniddigits = "trackingtokeniddigits";
        public const string uniquespecifierlength = "uniquespecifierlength";
        public const string useinbuiltrulefordefaultpricelistselection = "useinbuiltrulefordefaultpricelistselection";
        public const string uselegacyrendering = "uselegacyrendering";
        public const string usepositionhierarchy = "usepositionhierarchy";
        public const string useraccessauditinginterval = "useraccessauditinginterval";
        public const string usereadform = "usereadform";
        public const string userentityinstancedata_organization_1M = "userentityinstancedata_organization";
        public const string usergroupid = "usergroupid";
        public const string useskypeprotocol = "useskypeprotocol";
        public const string utcconversiontimezonecode = "utcconversiontimezonecode";
        public const string v3calloutconfighash = "v3calloutconfighash";
        public const string versionnumber = "versionnumber";
        public const string webresource_organization_1M = "webresource_organization";
        public const string webresourcehash = "webresourcehash";
        public const string weekstartdaycode = "weekstartdaycode";
        public const string weekstartdaycodename = "weekstartdaycodename";
        public const string yammergroupid = "yammergroupid";
        public const string yammernetworkpermalink = "yammernetworkpermalink";
        public const string yammeroauthaccesstokenexpired = "yammeroauthaccesstokenexpired";
        public const string yammerpostmethod = "yammerpostmethod";
        public const string yearstartweekcode = "yearstartweekcode";
    }

    public class organization_enums
    {
        public enum currencydisplayoption
        {
            Currency_code = 1,
            Currency_symbol = 0
        }

        public enum currencyformatcode
        {
            Space_123 = 2,
            Dollar123 = 0,
            _123_Space_Dollar = 3,
            _123Dollar = 1
        }

        public enum dateformatcode
        {
        }

        public enum defaultrecurrenceendrangetype
        {
            End_By_Date = 3,
            No_End_Date = 1,
            Number_of_Occurrences = 2
        }

        public enum discountcalculationmethod
        {
            Line_item = 0,
            Per_unit = 1
        }

        public enum emailconnectionchannel
        {
            Microsoft_Dynamics_CRM_2015_Email_Router = 1,
            Server_Side_Synchronization = 0
        }

        public enum fiscalperiodformatperiod
        {
            M_0 = 5,
            Month_0 = 4,
            Month_Name = 7,
            P_0 = 3,
            Q_0 = 2,
            Quarter_0 = 1,
            Semester_0 = 6
        }

        public enum fiscalyearformatprefix
        {
            None = 2,
            FY = 1
        }

        public enum fiscalyearformatsuffix
        {
            None = 3,
            Fiscal_Year = 2,
            FY = 1
        }

        public enum fiscalyearformatyear
        {
            GGYY = 3,
            YY = 2,
            YYYY = 1
        }

        public enum fullnameconventioncode
        {
            First_Name = 1,
            First_Name_Middle_Initial_Last_Name = 3,
            First_Name_Middle_Name_Last_Name = 5,
            Last_Name_First_Name = 0,
            Last_Name_First_Name_Middle_Initial = 2,
            Last_Name_First_Name_Middle_Name = 4,
            Last_Name_no_space_First_Name = 7,
            Last_Name_space_First_Name = 6
        }

        public enum isvintegrationcode
        {
            All = 7,
            None = 0,
            Outlook = 6,
            Outlook_Laptop_Client = 4,
            Outlook_Workstation_Client = 2,
            Web = 1,
            Web_Outlook_Laptop_Client = 5,
            Web_Outlook_Workstation_Client = 3
        }

        public enum negativeformatcode
        {
            Brackets = 0,
            Dash = 1,
            Dash_plus_Space = 2,
            Space_plus_Trailing_Dash = 4,
            Trailing_Dash = 3
        }

        public enum plugintracelogsetting
        {
            All = 2,
            Exception = 1,
            Off = 0
        }

        public enum reportscripterrors
        {
            Ask_me_for_permission_to_send_an_error_report_to_Microsoft = 1,
            Automatically_send_an_error_report_to_Microsoft_without_asking_me_for_permission = 2,
            Never_send_an_error_report_to_Microsoft_about_Microsoft_Dynamics_CRM = 3,
            No_preference_for_sending_an_error_report_to_Microsoft_about_Microsoft_Dynamics_CRM = 0
        }

        public enum sharepointdeploymenttype
        {
            Online = 0,
            On_Premises = 1
        }

        public enum timeformatcode
        {
        }

        public enum weekstartdaycode
        {
        }

        public enum yammerpostmethod
        {
            Private = 1,
            Public = 0
        }
    }

    #endregion

    #region "Role"

    public class role
    {
        public const string business_unit_roles_M1 = "business_unit_roles";
        //Fields
        public const string businessunitid = "businessunitid";
        public const string businessunitidname = "businessunitidname";
        public const string componentstate = "componentstate";
        public const string createdby = "createdby";
        public const string createdbyname = "createdbyname";
        public const string createdbyyominame = "createdbyyominame";
        public const string createdon = "createdon";
        public const string createdonbehalfby = "createdonbehalfby";
        public const string createdonbehalfbyname = "createdonbehalfbyname";
        public const string createdonbehalfbyyominame = "createdonbehalfbyyominame";
        public const string importsequencenumber = "importsequencenumber";
        public const string iscustomizable = "iscustomizable";
        public const string ismanaged = "ismanaged";
        public const string ismanagedname = "ismanagedname";
        public const string lk_role_createdonbehalfby_M1 = "lk_role_createdonbehalfby";
        public const string lk_role_modifiedonbehalfby_M1 = "lk_role_modifiedonbehalfby";
        public const string lk_rolebase_createdby_M1 = "lk_rolebase_createdby";
        // Many To One
        public const string lk_rolebase_modifiedby_M1 = "lk_rolebase_modifiedby";
        public const string modifiedby = "modifiedby";
        public const string modifiedbyname = "modifiedbyname";
        public const string modifiedbyyominame = "modifiedbyyominame";
        public const string modifiedon = "modifiedon";
        public const string modifiedonbehalfby = "modifiedonbehalfby";
        public const string modifiedonbehalfbyname = "modifiedonbehalfbyname";
        public const string modifiedonbehalfbyyominame = "modifiedonbehalfbyyominame";
        public const string name = "name";
        public const string organization_roles_M1 = "organization_roles";
        public const string organizationid = "organizationid";
        public const string organizationidname = "organizationidname";
        public const string overriddencreatedon = "overriddencreatedon";
        public const string overwritetime = "overwritetime";
        public const string parentroleid = "parentroleid";
        public const string parentroleidname = "parentroleidname";
        public const string parentrootroleid = "parentrootroleid";
        public const string parentrootroleidname = "parentrootroleidname";
        public const string Role_AsyncOperations_1M = "Role_AsyncOperations";
        public const string Role_BulkDeleteFailures_1M = "Role_BulkDeleteFailures";
        // One To Many Relationships
        public const string role_parent_role_1M = "role_parent_role";
        public const string role_parent_role_M1 = "role_parent_role";
        public const string role_parent_root_role_1M = "role_parent_root_role";
        public const string role_parent_root_role_M1 = "role_parent_root_role";
        public const string role_template_roles_M1 = "role_template_roles";
        public const string roleid = "roleid";
        public const string roleidunique = "roleidunique";
        public const string roleprivileges_MM = "roleprivileges";
        public const string roletemplateid = "roletemplateid";
        public const string solutionid = "solutionid";
        public const string supportingsolutionid = "supportingsolutionid";
        // Many To Many
        public const string systemuserroles_MM = "systemuserroles";
        public const string teamroles_MM = "teamroles";
        public const string userentityinstancedata_role_1M = "userentityinstancedata_role";
        public const string versionnumber = "versionnumber";
    }


    public class role_enums
    {
        public enum componentstate
        {
            Deleted = 2,
            Deleted_Unpublished = 3,
            Published = 0,
            Unpublished = 1
        }
    }

    #endregion

    #region "sdkmessageprocessingstep"

    public class sdkmessageprocessingstep
    {
        //Fields
        public const string asyncautodelete = "asyncautodelete";
        public const string asyncautodeletename = "asyncautodeletename";
        public const string canusereadonlyconnection = "canusereadonlyconnection";
        public const string canusereadonlyconnectionname = "canusereadonlyconnectionname";
        public const string componentstate = "componentstate";
        public const string configuration = "configuration";
        public const string createdby = "createdby";
        public const string createdby_sdkmessageprocessingstep_M1 = "createdby_sdkmessageprocessingstep";
        public const string createdbyname = "createdbyname";
        public const string createdon = "createdon";
        public const string createdonbehalfby = "createdonbehalfby";
        public const string createdonbehalfbyname = "createdonbehalfbyname";
        public const string createdonbehalfbyyominame = "createdonbehalfbyyominame";
        public const string customizationlevel = "customizationlevel";
        public const string description = "description";
        public const string eventhandler = "eventhandler";
        public const string eventhandlername = "eventhandlername";
        public const string eventhandlertypecode = "eventhandlertypecode";
        public const string filteringattributes = "filteringattributes";
        public const string impersonatinguserid = "impersonatinguserid";

        public const string impersonatinguserid_sdkmessageprocessingstep_M1 =
            "impersonatinguserid_sdkmessageprocessingstep";

        public const string impersonatinguseridname = "impersonatinguseridname";
        public const string introducedversion = "introducedversion";
        public const string invocationsource = "invocationsource";
        public const string invocationsourcename = "invocationsourcename";
        public const string iscustomizable = "iscustomizable";
        public const string ishidden = "ishidden";
        public const string ismanaged = "ismanaged";
        public const string ismanagedname = "ismanagedname";

        public const string lk_sdkmessageprocessingstep_createdonbehalfby_M1 =
            "lk_sdkmessageprocessingstep_createdonbehalfby";

        public const string lk_sdkmessageprocessingstep_modifiedonbehalfby_M1 =
            "lk_sdkmessageprocessingstep_modifiedonbehalfby";

        public const string mode = "mode";
        public const string modename = "modename";
        public const string modifiedby = "modifiedby";
        public const string modifiedby_sdkmessageprocessingstep_M1 = "modifiedby_sdkmessageprocessingstep";
        public const string modifiedbyname = "modifiedbyname";
        public const string modifiedon = "modifiedon";
        public const string modifiedonbehalfby = "modifiedonbehalfby";
        public const string modifiedonbehalfbyname = "modifiedonbehalfbyname";
        public const string modifiedonbehalfbyyominame = "modifiedonbehalfbyyominame";
        public const string name = "name";
        public const string organization_sdkmessageprocessingstep_M1 = "organization_sdkmessageprocessingstep";
        public const string organizationid = "organizationid";
        public const string overwritetime = "overwritetime";
        // Many To One
        public const string plugintype_sdkmessageprocessingstep_M1 = "plugintype_sdkmessageprocessingstep";
        public const string plugintypeid = "plugintypeid";
        public const string plugintypeid_sdkmessageprocessingstep_M1 = "plugintypeid_sdkmessageprocessingstep";
        public const string plugintypeidname = "plugintypeidname";
        public const string rank = "rank";
        public const string sdkmessagefilterid = "sdkmessagefilterid";

        public const string sdkmessagefilterid_sdkmessageprocessingstep_M1 =
            "sdkmessagefilterid_sdkmessageprocessingstep";

        public const string sdkmessageid = "sdkmessageid";
        public const string sdkmessageid_sdkmessageprocessingstep_M1 = "sdkmessageid_sdkmessageprocessingstep";
        public const string sdkmessageidname = "sdkmessageidname";
        // One To Many Relationships
        public const string SdkMessageProcessingStep_AsyncOperations_1M = "SdkMessageProcessingStep_AsyncOperations";
        public const string sdkmessageprocessingstepid = "sdkmessageprocessingstepid";

        public const string sdkmessageprocessingstepid_sdkmessageprocessingstepimage_1M =
            "sdkmessageprocessingstepid_sdkmessageprocessingstepimage";

        public const string sdkmessageprocessingstepidunique = "sdkmessageprocessingstepidunique";
        public const string sdkmessageprocessingstepsecureconfigid = "sdkmessageprocessingstepsecureconfigid";

        public const string sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep_M1 =
            "sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep";

        public const string serviceendpoint_sdkmessageprocessingstep_M1 = "serviceendpoint_sdkmessageprocessingstep";
        public const string solutionid = "solutionid";
        public const string stage = "stage";
        public const string stagename = "stagename";
        public const string statecode = "statecode";
        public const string statecodename = "statecodename";
        public const string statuscode = "statuscode";
        public const string statuscodename = "statuscodename";
        public const string supporteddeployment = "supporteddeployment";
        public const string supporteddeploymentname = "supporteddeploymentname";
        public const string supportingsolutionid = "supportingsolutionid";

        public const string userentityinstancedata_sdkmessageprocessingstep_1M =
            "userentityinstancedata_sdkmessageprocessingstep";

        public const string versionnumber = "versionnumber";
    }


    public class sdkmessageprocessingstep_enums
    {
        public enum componentstate
        {
            Deleted = 2,
            Deleted_Unpublished = 3,
            Published = 0,
            Unpublished = 1
        }

        public enum invocationsource
        {
            Child = 1,
            Internal = -1,
            Parent = 0
        }

        public enum mode
        {
            Asynchronous = 1,
            Synchronous = 0
        }

        public enum stage
        {
            Final_Post_operation_For_internal_use_only = 55,
            Initial_Pre_operation_For_internal_use_only = 5,
            Internal_Post_operation_After_External_Plugins_For_internal_use_only = 45,
            Internal_Post_operation_Before_External_Plugins_For_internal_use_only = 35,
            Internal_Pre_operation_After_External_Plugins_For_internal_use_only = 25,
            Internal_Pre_operation_Before_External_Plugins_For_internal_use_only = 15,
            Main_Operation_For_internal_use_only = 30,
            Post_operation = 40,
            Post_operation_Deprecated = 50,
            Pre_operation = 20,
            Pre_validation = 10
        }

        public enum statecode
        {
            Disabled = 1,
            Enabled = 0
        }

        public enum statuscode
        {
            Disabled = 2,
            Enabled = 1
        }

        public enum supporteddeployment
        {
            Both = 2,
            Microsoft_Dynamics_CRM_Client_for_Outlook_Only = 1,
            Server_Only = 0
        }
    }

    #endregion

    #region "System Entity"

    public class systementity
    {
        public const string activityid = "activityid";
        public const string activitypartyid = "activitypartyid";
        public const string createdby = "createdby";
        public const string createdbyname = "createdbyname";
        public const string createdbyyominame = "createdbyyominame";
        public const string createdon = "createdon";
        public const string createdonbehalfby = "createdonbehalfby";
        public const string createdonbehalfbyname = "createdonbehalfbyname";
        public const string createdonbehalfbyyominame = "createdonbehalfbyyominame";
        public const string ismanaged = "ismanaged";
        public const string ismaster = "ismaster";
        public const string modifiedby = "modifiedby";
        public const string modifiedbyname = "modifiedbyname";
        public const string modifiedbyyominame = "modifiedbyyominame";
        public const string modifiedon = "modifiedon";
        public const string modifiedonbehalfby = "modifiedonbehalfby";
        public const string modifiedonbehalfbyname = "modifiedonbehalfbyname";
        public const string modifiedonbehalfbyyominame = "modifiedonbehalfbyyominame";
        public const string name = "name";
        public const string objecttypecode = "objecttypecode";
        public const string overriddencreatedon = "overriddencreatedon";
        public const string ownerid = "ownerid";
        public const string owneridname = "owneridname";
        public const string owneridtype = "owneridtype";
        public const string owneridyominame = "owneridyominame";
        public const string owningbusinessunit = "owningbusinessunit";
        public const string owningteam = "owningteam";
        public const string owninguser = "owninguser";
        public const string partyid = "partyid";
        public const string regardingobjectid = "regardingobjectid";
        public const string statecode = "statecode";
        public const string statecodename = "statecodename";
        public const string statuscode = "statuscode";
        public const string statuscodename = "statuscodename";
        public const string text = "text";
        public const string transactioncurrencyid = "transactioncurrencyid";
        public const string transactioncurrencyidname = "transactioncurrencyidname";
        public const string type = "type";
        public const string utcoffset = "utcoffset";
        public const string versionnumber = "versionnumber";
    }

    #endregion

    #region "System User"

    public class systemuser
    {
        public const string accessmode = "accessmode";
        public const string accessmodename = "accessmodename";
        public const string activedirectoryguid = "activedirectoryguid";
        public const string address1_addressid = "address1_addressid";
        public const string address1_addresstypecode = "address1_addresstypecode";
        public const string address1_addresstypecodename = "address1_addresstypecodename";
        public const string address1_city = "address1_city";
        public const string address1_composite = "address1_composite";
        public const string address1_country = "address1_country";
        public const string address1_county = "address1_county";
        public const string address1_fax = "address1_fax";
        public const string address1_latitude = "address1_latitude";
        public const string address1_line1 = "address1_line1";
        public const string address1_line2 = "address1_line2";
        public const string address1_line3 = "address1_line3";
        public const string address1_longitude = "address1_longitude";
        public const string address1_name = "address1_name";
        public const string address1_postalcode = "address1_postalcode";
        public const string address1_postofficebox = "address1_postofficebox";
        public const string address1_shippingmethodcode = "address1_shippingmethodcode";
        public const string address1_shippingmethodcodename = "address1_shippingmethodcodename";
        public const string address1_stateorprovince = "address1_stateorprovince";
        public const string address1_telephone1 = "address1_telephone1";
        public const string address1_telephone2 = "address1_telephone2";
        public const string address1_telephone3 = "address1_telephone3";
        public const string address1_upszone = "address1_upszone";
        public const string address1_utcoffset = "address1_utcoffset";
        public const string address2_addressid = "address2_addressid";
        public const string address2_addresstypecode = "address2_addresstypecode";
        public const string address2_addresstypecodename = "address2_addresstypecodename";
        public const string address2_city = "address2_city";
        public const string address2_composite = "address2_composite";
        public const string address2_country = "address2_country";
        public const string address2_county = "address2_county";
        public const string address2_fax = "address2_fax";
        public const string address2_latitude = "address2_latitude";
        public const string address2_line1 = "address2_line1";
        public const string address2_line2 = "address2_line2";
        public const string address2_line3 = "address2_line3";
        public const string address2_longitude = "address2_longitude";
        public const string address2_name = "address2_name";
        public const string address2_postalcode = "address2_postalcode";
        public const string address2_postofficebox = "address2_postofficebox";
        public const string address2_shippingmethodcode = "address2_shippingmethodcode";
        public const string address2_shippingmethodcodename = "address2_shippingmethodcodename";
        public const string address2_stateorprovince = "address2_stateorprovince";
        public const string address2_telephone1 = "address2_telephone1";
        public const string address2_telephone2 = "address2_telephone2";
        public const string address2_telephone3 = "address2_telephone3";
        public const string address2_upszone = "address2_upszone";
        public const string address2_utcoffset = "address2_utcoffset";
        public const string annotation_owning_user_1M = "annotation_owning_user";
        public const string bizmap_systemuser_businessid_1M = "bizmap_systemuser_businessid";
        public const string business_unit_system_users_M1 = "business_unit_system_users";
        public const string businessunitid = "businessunitid";
        public const string businessunitidname = "businessunitidname";
        public const string calendar_system_users_M1 = "calendar_system_users";
        public const string calendarid = "calendarid";
        public const string caltype = "caltype";
        public const string caltypename = "caltypename";
        public const string constraintbasedgroup_systemuser_1M = "constraintbasedgroup_systemuser";
        public const string contact_owning_user_1M = "contact_owning_user";
        public const string createdby = "createdby";
        public const string createdby_attributemap_1M = "createdby_attributemap";
        public const string createdby_connection_1M = "createdby_connection";
        public const string createdby_connection_role_1M = "createdby_connection_role";
        public const string createdby_customer_relationship_1M = "createdby_customer_relationship";
        public const string createdby_entitymap_1M = "createdby_entitymap";
        public const string createdby_pluginassembly_1M = "createdby_pluginassembly";
        public const string createdby_plugintracelog_1M = "createdby_plugintracelog";
        public const string createdby_plugintype_1M = "createdby_plugintype";
        public const string createdby_plugintypestatistic_1M = "createdby_plugintypestatistic";
        public const string createdby_relationship_role_1M = "createdby_relationship_role";
        public const string createdby_relationship_role_map_1M = "createdby_relationship_role_map";
        public const string createdby_sdkmessage_1M = "createdby_sdkmessage";
        public const string createdby_sdkmessagefilter_1M = "createdby_sdkmessagefilter";
        public const string createdby_sdkmessagepair_1M = "createdby_sdkmessagepair";
        public const string createdby_sdkmessageprocessingstep_1M = "createdby_sdkmessageprocessingstep";
        public const string createdby_sdkmessageprocessingstepimage_1M = "createdby_sdkmessageprocessingstepimage";

        public const string createdby_sdkmessageprocessingstepsecureconfig_1M =
            "createdby_sdkmessageprocessingstepsecureconfig";

        public const string createdby_sdkmessagerequest_1M = "createdby_sdkmessagerequest";
        public const string createdby_sdkmessagerequestfield_1M = "createdby_sdkmessagerequestfield";
        public const string createdby_sdkmessageresponse_1M = "createdby_sdkmessageresponse";
        public const string createdby_sdkmessageresponsefield_1M = "createdby_sdkmessageresponsefield";
        public const string createdby_serviceendpoint_1M = "createdby_serviceendpoint";
        public const string createdbyname = "createdbyname";
        public const string createdbyyominame = "createdbyyominame";
        public const string createdon = "createdon";
        public const string createdonbehalfby = "createdonbehalfby";
        public const string createdonbehalfby_attributemap_1M = "createdonbehalfby_attributemap";
        public const string createdonbehalfby_customer_relationship_1M = "createdonbehalfby_customer_relationship";
        public const string createdonbehalfbyname = "createdonbehalfbyname";
        public const string createdonbehalfbyyominame = "createdonbehalfbyyominame";
        public const string defaultfilterspopulated = "defaultfilterspopulated";
        public const string defaultmailbox = "defaultmailbox";
        public const string defaultmailboxname = "defaultmailboxname";
        public const string disabledreason = "disabledreason";
        public const string displayinserviceviews = "displayinserviceviews";
        public const string displayinserviceviewsname = "displayinserviceviewsname";
        public const string domainname = "domainname";
        public const string Dynamicpropertyinsatance_createdby_1M = "Dynamicpropertyinsatance_createdby";
        public const string emailrouteraccessapproval = "emailrouteraccessapproval";
        public const string emailrouteraccessapprovalname = "emailrouteraccessapprovalname";
        public const string employeeid = "employeeid";
        public const string entityimage = "entityimage";
        public const string entityimage_timestamp = "entityimage_timestamp";
        public const string entityimage_url = "entityimage_url";
        public const string entityimageid = "entityimageid";
        public const string equipment_systemuser_1M = "equipment_systemuser";
        public const string exchangerate = "exchangerate";
        public const string firstname = "firstname";
        public const string fullname = "fullname";
        public const string governmentid = "governmentid";
        public const string homephone = "homephone";

        public const string impersonatinguserid_sdkmessageprocessingstep_1M =
            "impersonatinguserid_sdkmessageprocessingstep";

        public const string ImportFile_SystemUser_1M = "ImportFile_SystemUser";
        public const string importsequencenumber = "importsequencenumber";
        public const string incomingemaildeliverymethod = "incomingemaildeliverymethod";
        public const string incomingemaildeliverymethodname = "incomingemaildeliverymethodname";
        public const string internalemailaddress = "internalemailaddress";
        public const string invitestatuscode = "invitestatuscode";
        public const string invitestatuscodename = "invitestatuscodename";
        public const string isactivedirectoryuser = "isactivedirectoryuser";
        public const string isdisabled = "isdisabled";
        public const string isdisabledname = "isdisabledname";
        public const string isemailaddressapprovedbyo365admin = "isemailaddressapprovedbyo365admin";
        public const string isintegrationuser = "isintegrationuser";
        public const string isintegrationusername = "isintegrationusername";
        public const string islicensed = "islicensed";
        public const string issyncwithdirectory = "issyncwithdirectory";
        public const string jobtitle = "jobtitle";
        public const string lastname = "lastname";
        public const string lead_owning_user_1M = "lead_owning_user";
        public const string lk_accountbase_createdby_1M = "lk_accountbase_createdby";
        public const string lk_accountbase_createdonbehalfby_1M = "lk_accountbase_createdonbehalfby";
        public const string lk_accountbase_modifiedby_1M = "lk_accountbase_modifiedby";
        public const string lk_accountbase_modifiedonbehalfby_1M = "lk_accountbase_modifiedonbehalfby";
        public const string lk_activitypointer_createdby_1M = "lk_activitypointer_createdby";
        public const string lk_activitypointer_createdonbehalfby_1M = "lk_activitypointer_createdonbehalfby";
        public const string lk_activitypointer_modifiedby_1M = "lk_activitypointer_modifiedby";
        public const string lk_activitypointer_modifiedonbehalfby_1M = "lk_activitypointer_modifiedonbehalfby";
        public const string lk_annotationbase_createdby_1M = "lk_annotationbase_createdby";
        public const string lk_annotationbase_createdonbehalfby_1M = "lk_annotationbase_createdonbehalfby";
        public const string lk_annotationbase_modifiedby_1M = "lk_annotationbase_modifiedby";
        public const string lk_annotationbase_modifiedonbehalfby_1M = "lk_annotationbase_modifiedonbehalfby";
        public const string lk_annualfiscalcalendar_createdby_1M = "lk_annualfiscalcalendar_createdby";
        public const string lk_annualfiscalcalendar_createdonbehalfby_1M = "lk_annualfiscalcalendar_createdonbehalfby";
        public const string lk_annualfiscalcalendar_modifiedby_1M = "lk_annualfiscalcalendar_modifiedby";
        public const string lk_annualfiscalcalendar_modifiedonbehalfby_1M = "lk_annualfiscalcalendar_modifiedonbehalfby";
        public const string lk_annualfiscalcalendar_salespersonid_1M = "lk_annualfiscalcalendar_salespersonid";
        public const string lk_applicationfile_createdby_1M = "lk_applicationfile_createdby";
        public const string lk_applicationfile_createdonbehalfby_1M = "lk_applicationfile_createdonbehalfby";
        public const string lk_applicationfile_modifiedby_1M = "lk_applicationfile_modifiedby";
        public const string lk_applicationfile_modifiedonbehalfby_1M = "lk_applicationfile_modifiedonbehalfby";
        public const string lk_appointment_createdby_1M = "lk_appointment_createdby";
        public const string lk_appointment_createdonbehalfby_1M = "lk_appointment_createdonbehalfby";
        public const string lk_appointment_modifiedby_1M = "lk_appointment_modifiedby";
        public const string lk_appointment_modifiedonbehalfby_1M = "lk_appointment_modifiedonbehalfby";
        public const string lk_asyncoperation_createdby_1M = "lk_asyncoperation_createdby";
        public const string lk_asyncoperation_createdonbehalfby_1M = "lk_asyncoperation_createdonbehalfby";
        public const string lk_asyncoperation_modifiedby_1M = "lk_asyncoperation_modifiedby";
        public const string lk_asyncoperation_modifiedonbehalfby_1M = "lk_asyncoperation_modifiedonbehalfby";
        public const string lk_audit_callinguserid_1M = "lk_audit_callinguserid";
        public const string lk_audit_userid_1M = "lk_audit_userid";
        public const string lk_authorizationserver_createdby_1M = "lk_authorizationserver_createdby";
        public const string lk_authorizationserver_createdonbehalfby_1M = "lk_authorizationserver_createdonbehalfby";
        public const string lk_authorizationserver_modifiedby_1M = "lk_authorizationserver_modifiedby";
        public const string lk_authorizationserver_modifiedonbehalfby_1M = "lk_authorizationserver_modifiedonbehalfby";
        public const string lk_bulkdeleteoperation_createdonbehalfby_1M = "lk_bulkdeleteoperation_createdonbehalfby";
        public const string lk_bulkdeleteoperation_modifiedonbehalfby_1M = "lk_bulkdeleteoperation_modifiedonbehalfby";
        public const string lk_bulkdeleteoperationbase_createdby_1M = "lk_bulkdeleteoperationbase_createdby";
        public const string lk_bulkdeleteoperationbase_modifiedby_1M = "lk_bulkdeleteoperationbase_modifiedby";
        public const string lk_BulkOperation_createdby_1M = "lk_BulkOperation_createdby";
        public const string lk_BulkOperation_createdonbehalfby_1M = "lk_BulkOperation_createdonbehalfby";
        public const string lk_BulkOperation_modifiedby_1M = "lk_BulkOperation_modifiedby";
        public const string lk_BulkOperation_modifiedonbehalfby_1M = "lk_BulkOperation_modifiedonbehalfby";
        public const string lk_businessunit_createdonbehalfby_1M = "lk_businessunit_createdonbehalfby";
        public const string lk_businessunit_modifiedonbehalfby_1M = "lk_businessunit_modifiedonbehalfby";
        public const string lk_businessunitbase_createdby_1M = "lk_businessunitbase_createdby";
        public const string lk_businessunitbase_modifiedby_1M = "lk_businessunitbase_modifiedby";

        public const string lk_businessunitnewsarticle_createdonbehalfby_1M =
            "lk_businessunitnewsarticle_createdonbehalfby";

        public const string lk_businessunitnewsarticle_modifiedonbehalfby_1M =
            "lk_businessunitnewsarticle_modifiedonbehalfby";

        public const string lk_businessunitnewsarticlebase_createdby_1M = "lk_businessunitnewsarticlebase_createdby";
        public const string lk_businessunitnewsarticlebase_modifiedby_1M = "lk_businessunitnewsarticlebase_modifiedby";
        public const string lk_calendar_createdby_1M = "lk_calendar_createdby";
        public const string lk_calendar_createdonbehalfby_1M = "lk_calendar_createdonbehalfby";
        public const string lk_calendar_modifiedby_1M = "lk_calendar_modifiedby";
        public const string lk_calendar_modifiedonbehalfby_1M = "lk_calendar_modifiedonbehalfby";
        public const string lk_calendarrule_createdby_1M = "lk_calendarrule_createdby";
        public const string lk_calendarrule_createdonbehalfby_1M = "lk_calendarrule_createdonbehalfby";
        public const string lk_calendarrule_modifiedby_1M = "lk_calendarrule_modifiedby";
        public const string lk_calendarrule_modifiedonbehalfby_1M = "lk_calendarrule_modifiedonbehalfby";
        public const string lk_campaign_createdby_1M = "lk_campaign_createdby";
        public const string lk_campaign_createdonbehalfby_1M = "lk_campaign_createdonbehalfby";
        public const string lk_campaign_modifiedby_1M = "lk_campaign_modifiedby";
        public const string lk_campaign_modifiedonbehalfby_1M = "lk_campaign_modifiedonbehalfby";
        public const string lk_campaignactivity_createdby_1M = "lk_campaignactivity_createdby";
        public const string lk_campaignactivity_createdonbehalfby_1M = "lk_campaignactivity_createdonbehalfby";
        public const string lk_campaignactivity_modifiedby_1M = "lk_campaignactivity_modifiedby";
        public const string lk_campaignactivity_modifiedonbehalfby_1M = "lk_campaignactivity_modifiedonbehalfby";
        public const string lk_campaignresponse_createdby_1M = "lk_campaignresponse_createdby";
        public const string lk_campaignresponse_createdonbehalfby_1M = "lk_campaignresponse_createdonbehalfby";
        public const string lk_campaignresponse_modifiedby_1M = "lk_campaignresponse_modifiedby";
        public const string lk_campaignresponse_modifiedonbehalfby_1M = "lk_campaignresponse_modifiedonbehalfby";
        public const string lk_ChannelProperty_createdby_1M = "lk_ChannelProperty_createdby";
        public const string lk_ChannelProperty_createdonbehalfby_1M = "lk_ChannelProperty_createdonbehalfby";
        public const string lk_ChannelProperty_modifiedby_1M = "lk_ChannelProperty_modifiedby";
        public const string lk_ChannelProperty_modifiedonbehalfby_1M = "lk_ChannelProperty_modifiedonbehalfby";
        public const string lk_ChannelPropertyGroup_createdby_1M = "lk_ChannelPropertyGroup_createdby";
        public const string lk_ChannelPropertyGroup_createdonbehalfby_1M = "lk_ChannelPropertyGroup_createdonbehalfby";
        public const string lk_ChannelPropertyGroup_modifiedby_1M = "lk_ChannelPropertyGroup_modifiedby";
        public const string lk_ChannelPropertyGroup_modifiedonbehalfby_1M = "lk_ChannelPropertyGroup_modifiedonbehalfby";
        public const string lk_columnmapping_createdby_1M = "lk_columnmapping_createdby";
        public const string lk_columnmapping_createdonbehalfby_1M = "lk_columnmapping_createdonbehalfby";
        public const string lk_columnmapping_modifiedby_1M = "lk_columnmapping_modifiedby";
        public const string lk_columnmapping_modifiedonbehalfby_1M = "lk_columnmapping_modifiedonbehalfby";
        public const string lk_competitor_createdonbehalfby_1M = "lk_competitor_createdonbehalfby";
        public const string lk_competitor_modifiedonbehalfby_1M = "lk_competitor_modifiedonbehalfby";
        public const string lk_competitoraddress_createdonbehalfby_1M = "lk_competitoraddress_createdonbehalfby";
        public const string lk_competitoraddress_modifiedonbehalfby_1M = "lk_competitoraddress_modifiedonbehalfby";
        public const string lk_competitoraddressbase_createdby_1M = "lk_competitoraddressbase_createdby";
        public const string lk_competitoraddressbase_modifiedby_1M = "lk_competitoraddressbase_modifiedby";
        public const string lk_competitorbase_createdby_1M = "lk_competitorbase_createdby";
        public const string lk_competitorbase_modifiedby_1M = "lk_competitorbase_modifiedby";
        public const string lk_connectionbase_createdonbehalfby_1M = "lk_connectionbase_createdonbehalfby";
        public const string lk_connectionbase_modifiedonbehalfby_1M = "lk_connectionbase_modifiedonbehalfby";
        public const string lk_connectionrolebase_createdonbehalfby_1M = "lk_connectionrolebase_createdonbehalfby";
        public const string lk_connectionrolebase_modifiedonbehalfby_1M = "lk_connectionrolebase_modifiedonbehalfby";
        public const string lk_constraintbasedgroup_createdby_1M = "lk_constraintbasedgroup_createdby";
        public const string lk_constraintbasedgroup_createdonbehalfby_1M = "lk_constraintbasedgroup_createdonbehalfby";
        public const string lk_constraintbasedgroup_modifiedby_1M = "lk_constraintbasedgroup_modifiedby";
        public const string lk_constraintbasedgroup_modifiedonbehalfby_1M = "lk_constraintbasedgroup_modifiedonbehalfby";
        public const string lk_contact_createdonbehalfby_1M = "lk_contact_createdonbehalfby";
        public const string lk_contact_modifiedonbehalfby_1M = "lk_contact_modifiedonbehalfby";
        public const string lk_contactbase_createdby_1M = "lk_contactbase_createdby";
        public const string lk_contactbase_modifiedby_1M = "lk_contactbase_modifiedby";
        public const string lk_contract_createdonbehalfby_1M = "lk_contract_createdonbehalfby";
        public const string lk_contract_modifiedonbehalfby_1M = "lk_contract_modifiedonbehalfby";
        public const string lk_contractbase_createdby_1M = "lk_contractbase_createdby";
        public const string lk_contractbase_modifiedby_1M = "lk_contractbase_modifiedby";
        public const string lk_contractdetail_createdonbehalfby_1M = "lk_contractdetail_createdonbehalfby";
        public const string lk_contractdetail_modifiedonbehalfby_1M = "lk_contractdetail_modifiedonbehalfby";
        public const string lk_contractdetailbase_createdby_1M = "lk_contractdetailbase_createdby";
        public const string lk_contractdetailbase_modifiedby_1M = "lk_contractdetailbase_modifiedby";
        public const string lk_contracttemplate_createdonbehalfby_1M = "lk_contracttemplate_createdonbehalfby";
        public const string lk_contracttemplate_modifiedonbehalfby_1M = "lk_contracttemplate_modifiedonbehalfby";
        public const string lk_contracttemplatebase_createdby_1M = "lk_contracttemplatebase_createdby";
        public const string lk_contracttemplatebase_modifiedby_1M = "lk_contracttemplatebase_modifiedby";
        public const string lk_convertrule_createdby_1M = "lk_convertrule_createdby";
        public const string lk_ConvertRule_createdonbehalfby_1M = "lk_ConvertRule_createdonbehalfby";
        public const string lk_ConvertRule_modifiedby_1M = "lk_ConvertRule_modifiedby";
        public const string lk_ConvertRule_modifiedonbehalfby_1M = "lk_ConvertRule_modifiedonbehalfby";
        public const string lk_convertruleitembase_createdby_1M = "lk_convertruleitembase_createdby";
        public const string lk_convertruleitembase_createdonbehalfby_1M = "lk_convertruleitembase_createdonbehalfby";
        public const string lk_convertruleitembase_modifiedby_1M = "lk_convertruleitembase_modifiedby";
        public const string lk_convertruleitembase_modifiedonbehalfby_1M = "lk_convertruleitembase_modifiedonbehalfby";
        public const string lk_customeraddress_createdonbehalfby_1M = "lk_customeraddress_createdonbehalfby";
        public const string lk_customeraddress_modifiedonbehalfby_1M = "lk_customeraddress_modifiedonbehalfby";
        public const string lk_customeraddressbase_createdby_1M = "lk_customeraddressbase_createdby";
        public const string lk_customeraddressbase_modifiedby_1M = "lk_customeraddressbase_modifiedby";
        public const string lk_customeropportunityrole_createdby_1M = "lk_customeropportunityrole_createdby";

        public const string lk_customeropportunityrole_createdonbehalfby_1M =
            "lk_customeropportunityrole_createdonbehalfby";

        public const string lk_customeropportunityrole_modifiedby_1M = "lk_customeropportunityrole_modifiedby";

        public const string lk_customeropportunityrole_modifiedonbehalfby_1M =
            "lk_customeropportunityrole_modifiedonbehalfby";

        public const string lk_discount_createdonbehalfby_1M = "lk_discount_createdonbehalfby";
        public const string lk_discount_modifiedonbehalfby_1M = "lk_discount_modifiedonbehalfby";
        public const string lk_discountbase_createdby_1M = "lk_discountbase_createdby";
        public const string lk_discountbase_modifiedby_1M = "lk_discountbase_modifiedby";
        public const string lk_discounttype_createdonbehalfby_1M = "lk_discounttype_createdonbehalfby";
        public const string lk_discounttype_modifiedonbehalfby_1M = "lk_discounttype_modifiedonbehalfby";
        public const string lk_discounttypebase_createdby_1M = "lk_discounttypebase_createdby";
        public const string lk_discounttypebase_modifiedby_1M = "lk_discounttypebase_modifiedby";
        public const string lk_DisplayStringbase_createdby_1M = "lk_DisplayStringbase_createdby";
        public const string lk_DisplayStringbase_createdonbehalfby_1M = "lk_DisplayStringbase_createdonbehalfby";
        public const string lk_DisplayStringbase_modifiedby_1M = "lk_DisplayStringbase_modifiedby";
        public const string lk_DisplayStringbase_modifiedonbehalfby_1M = "lk_DisplayStringbase_modifiedonbehalfby";
        public const string lk_documentindex_createdby_1M = "lk_documentindex_createdby";
        public const string lk_documentindex_createdonbehalfby_1M = "lk_documentindex_createdonbehalfby";
        public const string lk_documentindex_modifiedby_1M = "lk_documentindex_modifiedby";
        public const string lk_documentindex_modifiedonbehalfby_1M = "lk_documentindex_modifiedonbehalfby";
        public const string lk_duplicaterule_createdonbehalfby_1M = "lk_duplicaterule_createdonbehalfby";
        public const string lk_duplicaterule_modifiedonbehalfby_1M = "lk_duplicaterule_modifiedonbehalfby";
        public const string lk_duplicaterulebase_createdby_1M = "lk_duplicaterulebase_createdby";
        public const string lk_duplicaterulebase_modifiedby_1M = "lk_duplicaterulebase_modifiedby";

        public const string lk_duplicaterulecondition_createdonbehalfby_1M =
            "lk_duplicaterulecondition_createdonbehalfby";

        public const string lk_duplicaterulecondition_modifiedonbehalfby_1M =
            "lk_duplicaterulecondition_modifiedonbehalfby";

        public const string lk_duplicateruleconditionbase_createdby_1M = "lk_duplicateruleconditionbase_createdby";
        public const string lk_duplicateruleconditionbase_modifiedby_1M = "lk_duplicateruleconditionbase_modifiedby";
        public const string lk_DynamicProperty_createdby_1M = "lk_DynamicProperty_createdby";
        public const string lk_DynamicProperty_createdonbehalfby_1M = "lk_DynamicProperty_createdonbehalfby";
        public const string lk_DynamicProperty_modifiedby_1M = "lk_DynamicProperty_modifiedby";
        public const string lk_DynamicProperty_modifiedonbehalfby_1M = "lk_DynamicProperty_modifiedonbehalfby";

        public const string lk_DynamicPropertyAssociationattribute_createdby_1M =
            "lk_DynamicPropertyAssociationattribute_createdby";

        public const string lk_DynamicPropertyAssociationattribute_CreatedOnBehalfBy_1M =
            "lk_DynamicPropertyAssociationattribute_CreatedOnBehalfBy";

        public const string lk_DynamicPropertyAssociationattribute_ModifiedBy_1M =
            "lk_DynamicPropertyAssociationattribute_ModifiedBy";

        public const string lk_DynamicPropertyAssociationattribute_ModifiedOnBehalfBy_1M =
            "lk_DynamicPropertyAssociationattribute_ModifiedOnBehalfBy";

        public const string lk_Dynamicpropertyinsatanceattribute_createdonbehalfby_1M =
            "lk_Dynamicpropertyinsatanceattribute_createdonbehalfby";

        public const string lk_Dynamicpropertyinsatanceattribute_ModifiedBy_1M =
            "lk_Dynamicpropertyinsatanceattribute_ModifiedBy";

        public const string lk_Dynamicpropertyinsatanceattribute_ModifiedOnBehalfBy_1M =
            "lk_Dynamicpropertyinsatanceattribute_ModifiedOnBehalfBy";

        public const string lk_DynamicPropertyOptionSetItem_createdby_1M = "lk_DynamicPropertyOptionSetItem_createdby";

        public const string lk_DynamicPropertyOptionSetItem_createdonbehalfby_1M =
            "lk_DynamicPropertyOptionSetItem_createdonbehalfby";

        public const string lk_DynamicPropertyOptionSetItem_modifiedby_1M = "lk_DynamicPropertyOptionSetItem_modifiedby";

        public const string lk_DynamicPropertyOptionSetItem_modifiedonbehalfby_1M =
            "lk_DynamicPropertyOptionSetItem_modifiedonbehalfby";

        public const string lk_email_createdby_1M = "lk_email_createdby";
        public const string lk_email_createdonbehalfby_1M = "lk_email_createdonbehalfby";
        public const string lk_email_modifiedby_1M = "lk_email_modifiedby";
        public const string lk_email_modifiedonbehalfby_1M = "lk_email_modifiedonbehalfby";
        public const string lk_emailserverprofile_createdby_1M = "lk_emailserverprofile_createdby";
        public const string lk_emailserverprofile_createdonbehalfby_1M = "lk_emailserverprofile_createdonbehalfby";
        public const string lk_emailserverprofile_modifiedby_1M = "lk_emailserverprofile_modifiedby";
        public const string lk_emailserverprofile_modifiedonbehalfby_1M = "lk_emailserverprofile_modifiedonbehalfby";
        public const string lk_entitlement_createdby_1M = "lk_entitlement_createdby";
        public const string lk_entitlement_createdonbehalfby_1M = "lk_entitlement_createdonbehalfby";
        public const string lk_entitlement_modifiedby_1M = "lk_entitlement_modifiedby";
        public const string lk_entitlement_modifiedonbehalfby_1M = "lk_entitlement_modifiedonbehalfby";
        public const string lk_entitlementchannel_createdby_1M = "lk_entitlementchannel_createdby";
        public const string lk_entitlementchannel_createdonbehalfby_1M = "lk_entitlementchannel_createdonbehalfby";
        public const string lk_entitlementchannel_modifiedby_1M = "lk_entitlementchannel_modifiedby";
        public const string lk_entitlementchannel_modifiedonbehalfby_1M = "lk_entitlementchannel_modifiedonbehalfby";
        public const string lk_entitlementtemplate_createdby_1M = "lk_entitlementtemplate_createdby";
        public const string lk_entitlementtemplate_createdonbehalfby_1M = "lk_entitlementtemplate_createdonbehalfby";
        public const string lk_entitlementtemplate_modifiedby_1M = "lk_entitlementtemplate_modifiedby";
        public const string lk_entitlementtemplate_modifiedonbehalfby_1M = "lk_entitlementtemplate_modifiedonbehalfby";
        public const string lk_entitlementtemplatechannel_createdby_1M = "lk_entitlementtemplatechannel_createdby";

        public const string lk_entitlementtemplatechannel_createdonbehalfby_1M =
            "lk_entitlementtemplatechannel_createdonbehalfby";

        public const string lk_entitlementtemplatechannel_modifiedby_1M = "lk_entitlementtemplatechannel_modifiedby";

        public const string lk_entitlementtemplatechannel_modifiedonbehalfby_1M =
            "lk_entitlementtemplatechannel_modifiedonbehalfby";

        public const string lk_entitymap_createdonbehalfby_1M = "lk_entitymap_createdonbehalfby";
        public const string lk_entitymap_modifiedonbehalfby_1M = "lk_entitymap_modifiedonbehalfby";
        public const string lk_equipment_createdby_1M = "lk_equipment_createdby";
        public const string lk_equipment_createdonbehalfby_1M = "lk_equipment_createdonbehalfby";
        public const string lk_equipment_modifiedby_1M = "lk_equipment_modifiedby";
        public const string lk_equipment_modifiedonbehalfby_1M = "lk_equipment_modifiedonbehalfby";
        public const string lk_fax_createdby_1M = "lk_fax_createdby";
        public const string lk_fax_createdonbehalfby_1M = "lk_fax_createdonbehalfby";
        public const string lk_fax_modifiedby_1M = "lk_fax_modifiedby";
        public const string lk_fax_modifiedonbehalfby_1M = "lk_fax_modifiedonbehalfby";
        public const string lk_fieldsecurityprofile_createdby_1M = "lk_fieldsecurityprofile_createdby";
        public const string lk_fieldsecurityprofile_createdonbehalfby_1M = "lk_fieldsecurityprofile_createdonbehalfby";
        public const string lk_fieldsecurityprofile_modifiedby_1M = "lk_fieldsecurityprofile_modifiedby";
        public const string lk_fieldsecurityprofile_modifiedonbehalfby_1M = "lk_fieldsecurityprofile_modifiedonbehalfby";
        public const string lk_fixedmonthlyfiscalcalendar_createdby_1M = "lk_fixedmonthlyfiscalcalendar_createdby";

        public const string lk_fixedmonthlyfiscalcalendar_createdonbehalfby_1M =
            "lk_fixedmonthlyfiscalcalendar_createdonbehalfby";

        public const string lk_fixedmonthlyfiscalcalendar_modifiedby_1M = "lk_fixedmonthlyfiscalcalendar_modifiedby";

        public const string lk_fixedmonthlyfiscalcalendar_modifiedonbehalfby_1M =
            "lk_fixedmonthlyfiscalcalendar_modifiedonbehalfby";

        public const string lk_fixedmonthlyfiscalcalendar_salespersonid_1M =
            "lk_fixedmonthlyfiscalcalendar_salespersonid";

        public const string lk_goal_createdby_1M = "lk_goal_createdby";
        public const string lk_goal_createdonbehalfby_1M = "lk_goal_createdonbehalfby";
        public const string lk_goal_modifiedby_1M = "lk_goal_modifiedby";
        public const string lk_goal_modifiedonbehalfby_1M = "lk_goal_modifiedonbehalfby";
        public const string lk_goalrollupquery_createdby_1M = "lk_goalrollupquery_createdby";
        public const string lk_goalrollupquery_createdonbehalfby_1M = "lk_goalrollupquery_createdonbehalfby";
        public const string lk_goalrollupquery_modifiedby_1M = "lk_goalrollupquery_modifiedby";
        public const string lk_goalrollupquery_modifiedonbehalfby_1M = "lk_goalrollupquery_modifiedonbehalfby";
        public const string lk_import_createdonbehalfby_1M = "lk_import_createdonbehalfby";
        public const string lk_import_modifiedonbehalfby_1M = "lk_import_modifiedonbehalfby";
        public const string lk_importbase_createdby_1M = "lk_importbase_createdby";
        public const string lk_importbase_modifiedby_1M = "lk_importbase_modifiedby";
        public const string lk_importdata_createdonbehalfby_1M = "lk_importdata_createdonbehalfby";
        public const string lk_importdata_modifiedonbehalfby_1M = "lk_importdata_modifiedonbehalfby";
        public const string lk_importdatabase_createdby_1M = "lk_importdatabase_createdby";
        public const string lk_importdatabase_modifiedby_1M = "lk_importdatabase_modifiedby";
        public const string lk_importentitymapping_createdby_1M = "lk_importentitymapping_createdby";
        public const string lk_importentitymapping_createdonbehalfby_1M = "lk_importentitymapping_createdonbehalfby";
        public const string lk_importentitymapping_modifiedby_1M = "lk_importentitymapping_modifiedby";
        public const string lk_importentitymapping_modifiedonbehalfby_1M = "lk_importentitymapping_modifiedonbehalfby";
        public const string lk_importfilebase_createdby_1M = "lk_importfilebase_createdby";
        public const string lk_importfilebase_createdonbehalfby_1M = "lk_importfilebase_createdonbehalfby";
        public const string lk_importfilebase_modifiedby_1M = "lk_importfilebase_modifiedby";
        public const string lk_importfilebase_modifiedonbehalfby_1M = "lk_importfilebase_modifiedonbehalfby";
        public const string lk_importjobbase_createdby_1M = "lk_importjobbase_createdby";
        public const string lk_importjobbase_createdonbehalfby_1M = "lk_importjobbase_createdonbehalfby";
        public const string lk_importjobbase_modifiedby_1M = "lk_importjobbase_modifiedby";
        public const string lk_importjobbase_modifiedonbehalfby_1M = "lk_importjobbase_modifiedonbehalfby";
        public const string lk_importlog_createdonbehalfby_1M = "lk_importlog_createdonbehalfby";
        public const string lk_importlog_modifiedonbehalfby_1M = "lk_importlog_modifiedonbehalfby";
        public const string lk_importlogbase_createdby_1M = "lk_importlogbase_createdby";
        public const string lk_importlogbase_modifiedby_1M = "lk_importlogbase_modifiedby";
        public const string lk_importmap_createdonbehalfby_1M = "lk_importmap_createdonbehalfby";
        public const string lk_importmap_modifiedonbehalfby_1M = "lk_importmap_modifiedonbehalfby";
        public const string lk_importmapbase_createdby_1M = "lk_importmapbase_createdby";
        public const string lk_importmapbase_modifiedby_1M = "lk_importmapbase_modifiedby";
        public const string lk_incidentbase_createdby_1M = "lk_incidentbase_createdby";
        public const string lk_incidentbase_createdonbehalfby_1M = "lk_incidentbase_createdonbehalfby";
        public const string lk_incidentbase_modifiedby_1M = "lk_incidentbase_modifiedby";
        public const string lk_incidentbase_modifiedonbehalfby_1M = "lk_incidentbase_modifiedonbehalfby";
        public const string lk_incidentresolution_createdby_1M = "lk_incidentresolution_createdby";
        public const string lk_incidentresolution_createdonbehalfby_1M = "lk_incidentresolution_createdonbehalfby";
        public const string lk_incidentresolution_modifiedby_1M = "lk_incidentresolution_modifiedby";
        public const string lk_incidentresolution_modifiedonbehalfby_1M = "lk_incidentresolution_modifiedonbehalfby";
        public const string lk_integrationstatus_createdby_1M = "lk_integrationstatus_createdby";
        public const string lk_integrationstatus_createdonbehalfby_1M = "lk_integrationstatus_createdonbehalfby";
        public const string lk_integrationstatus_modifiedby_1M = "lk_integrationstatus_modifiedby";
        public const string lk_integrationstatus_modifiedonbehalfby_1M = "lk_integrationstatus_modifiedonbehalfby";
        public const string lk_internaladdress_createdonbehalfby_1M = "lk_internaladdress_createdonbehalfby";
        public const string lk_internaladdress_modifiedonbehalfby_1M = "lk_internaladdress_modifiedonbehalfby";
        public const string lk_internaladdressbase_createdby_1M = "lk_internaladdressbase_createdby";
        public const string lk_internaladdressbase_modifiedby_1M = "lk_internaladdressbase_modifiedby";
        public const string lk_invoice_createdonbehalfby_1M = "lk_invoice_createdonbehalfby";
        public const string lk_invoice_modifiedonbehalfby_1M = "lk_invoice_modifiedonbehalfby";
        public const string lk_invoicebase_createdby_1M = "lk_invoicebase_createdby";
        public const string lk_invoicebase_modifiedby_1M = "lk_invoicebase_modifiedby";
        public const string lk_invoicedetail_createdonbehalfby_1M = "lk_invoicedetail_createdonbehalfby";
        public const string lk_invoicedetail_modifiedonbehalfby_1M = "lk_invoicedetail_modifiedonbehalfby";
        public const string lk_invoicedetailbase_createdby_1M = "lk_invoicedetailbase_createdby";
        public const string lk_invoicedetailbase_modifiedby_1M = "lk_invoicedetailbase_modifiedby";
        public const string lk_isvconfig_createdonbehalfby_1M = "lk_isvconfig_createdonbehalfby";
        public const string lk_isvconfig_modifiedonbehalfby_1M = "lk_isvconfig_modifiedonbehalfby";
        public const string lk_isvconfigbase_createdby_1M = "lk_isvconfigbase_createdby";
        public const string lk_isvconfigbase_modifiedby_1M = "lk_isvconfigbase_modifiedby";
        public const string lk_kbarticle_createdonbehalfby_1M = "lk_kbarticle_createdonbehalfby";
        public const string lk_kbarticle_modifiedonbehalfby_1M = "lk_kbarticle_modifiedonbehalfby";
        public const string lk_kbarticlebase_createdby_1M = "lk_kbarticlebase_createdby";
        public const string lk_kbarticlebase_modifiedby_1M = "lk_kbarticlebase_modifiedby";
        public const string lk_kbarticlecomment_createdonbehalfby_1M = "lk_kbarticlecomment_createdonbehalfby";
        public const string lk_kbarticlecomment_modifiedonbehalfby_1M = "lk_kbarticlecomment_modifiedonbehalfby";
        public const string lk_kbarticlecommentbase_createdby_1M = "lk_kbarticlecommentbase_createdby";
        public const string lk_kbarticlecommentbase_modifiedby_1M = "lk_kbarticlecommentbase_modifiedby";
        public const string lk_kbarticletemplate_createdonbehalfby_1M = "lk_kbarticletemplate_createdonbehalfby";
        public const string lk_kbarticletemplate_modifiedonbehalfby_1M = "lk_kbarticletemplate_modifiedonbehalfby";
        public const string lk_kbarticletemplatebase_createdby_1M = "lk_kbarticletemplatebase_createdby";
        public const string lk_kbarticletemplatebase_modifiedby_1M = "lk_kbarticletemplatebase_modifiedby";
        public const string lk_KnowledgeBaseRecord_createdby_1M = "lk_KnowledgeBaseRecord_createdby";
        public const string lk_KnowledgeBaseRecord_createdonbehalfby_1M = "lk_KnowledgeBaseRecord_createdonbehalfby";
        public const string lk_KnowledgeBaseRecord_modifiedby_1M = "lk_KnowledgeBaseRecord_modifiedby";
        public const string lk_KnowledgeBaseRecord_modifiedonbehalfby_1M = "lk_KnowledgeBaseRecord_modifiedonbehalfby";
        public const string lk_lead_createdonbehalfby_1M = "lk_lead_createdonbehalfby";
        public const string lk_lead_modifiedonbehalfby_1M = "lk_lead_modifiedonbehalfby";
        public const string lk_leadaddress_createdonbehalfby_1M = "lk_leadaddress_createdonbehalfby";
        public const string lk_leadaddress_modifiedonbehalfby_1M = "lk_leadaddress_modifiedonbehalfby";
        public const string lk_leadaddressbase_createdby_1M = "lk_leadaddressbase_createdby";
        public const string lk_leadaddressbase_modifiedby_1M = "lk_leadaddressbase_modifiedby";
        public const string lk_leadbase_createdby_1M = "lk_leadbase_createdby";
        public const string lk_leadbase_modifiedby_1M = "lk_leadbase_modifiedby";
        public const string lk_letter_createdby_1M = "lk_letter_createdby";
        public const string lk_letter_createdonbehalfby_1M = "lk_letter_createdonbehalfby";
        public const string lk_letter_modifiedby_1M = "lk_letter_modifiedby";
        public const string lk_letter_modifiedonbehalfby_1M = "lk_letter_modifiedonbehalfby";
        public const string lk_list_createdby_1M = "lk_list_createdby";
        public const string lk_list_createdonbehalfby_1M = "lk_list_createdonbehalfby";
        public const string lk_list_modifiedby_1M = "lk_list_modifiedby";
        public const string lk_list_modifiedonbehalfby_1M = "lk_list_modifiedonbehalfby";
        public const string lk_listmember_createdby_1M = "lk_listmember_createdby";
        public const string lk_listmember_createdonbehalfby_1M = "lk_listmember_createdonbehalfby";
        public const string lk_listmember_modifiedby_1M = "lk_listmember_modifiedby";
        public const string lk_listmember_modifiedonbehalfby_1M = "lk_listmember_modifiedonbehalfby";
        public const string lk_lookupmapping_createdby_1M = "lk_lookupmapping_createdby";
        public const string lk_lookupmapping_createdonbehalfby_1M = "lk_lookupmapping_createdonbehalfby";
        public const string lk_lookupmapping_modifiedby_1M = "lk_lookupmapping_modifiedby";
        public const string lk_lookupmapping_modifiedonbehalfby_1M = "lk_lookupmapping_modifiedonbehalfby";
        public const string lk_mailbox_createdby_1M = "lk_mailbox_createdby";
        public const string lk_mailbox_createdonbehalfby_1M = "lk_mailbox_createdonbehalfby";
        public const string lk_mailbox_modifiedby_1M = "lk_mailbox_modifiedby";
        public const string lk_mailbox_modifiedonbehalfby_1M = "lk_mailbox_modifiedonbehalfby";
        public const string lk_mailboxtrackingfolder_createdby_1M = "lk_mailboxtrackingfolder_createdby";
        public const string lk_mailboxtrackingfolder_createdonbehalfby_1M = "lk_mailboxtrackingfolder_createdonbehalfby";
        public const string lk_mailboxtrackingfolder_modifiedby_1M = "lk_mailboxtrackingfolder_modifiedby";

        public const string lk_mailboxtrackingfolder_modifiedonbehalfby_1M =
            "lk_mailboxtrackingfolder_modifiedonbehalfby";

        public const string lk_mailmergetemplate_createdonbehalfby_1M = "lk_mailmergetemplate_createdonbehalfby";
        public const string lk_mailmergetemplate_modifiedonbehalfby_1M = "lk_mailmergetemplate_modifiedonbehalfby";
        public const string lk_mailmergetemplatebase_createdby_1M = "lk_mailmergetemplatebase_createdby";
        public const string lk_mailmergetemplatebase_modifiedby_1M = "lk_mailmergetemplatebase_modifiedby";
        public const string lk_metric_createdby_1M = "lk_metric_createdby";
        public const string lk_metric_createdonbehalfby_1M = "lk_metric_createdonbehalfby";
        public const string lk_metric_modifiedby_1M = "lk_metric_modifiedby";
        public const string lk_metric_modifiedonbehalfby_1M = "lk_metric_modifiedonbehalfby";
        public const string lk_monthlyfiscalcalendar_createdby_1M = "lk_monthlyfiscalcalendar_createdby";
        public const string lk_monthlyfiscalcalendar_createdonbehalfby_1M = "lk_monthlyfiscalcalendar_createdonbehalfby";
        public const string lk_monthlyfiscalcalendar_modifiedby_1M = "lk_monthlyfiscalcalendar_modifiedby";

        public const string lk_monthlyfiscalcalendar_modifiedonbehalfby_1M =
            "lk_monthlyfiscalcalendar_modifiedonbehalfby";

        public const string lk_monthlyfiscalcalendar_salespersonid_1M = "lk_monthlyfiscalcalendar_salespersonid";
        public const string lk_msdyn_postalbum_createdby_1M = "lk_msdyn_postalbum_createdby";
        public const string lk_msdyn_postalbum_createdonbehalfby_1M = "lk_msdyn_postalbum_createdonbehalfby";
        public const string lk_msdyn_postalbum_modifiedby_1M = "lk_msdyn_postalbum_modifiedby";
        public const string lk_msdyn_postalbum_modifiedonbehalfby_1M = "lk_msdyn_postalbum_modifiedonbehalfby";
        public const string lk_msdyn_postconfig_createdby_1M = "lk_msdyn_postconfig_createdby";
        public const string lk_msdyn_postconfig_createdonbehalfby_1M = "lk_msdyn_postconfig_createdonbehalfby";
        public const string lk_msdyn_postconfig_modifiedby_1M = "lk_msdyn_postconfig_modifiedby";
        public const string lk_msdyn_postconfig_modifiedonbehalfby_1M = "lk_msdyn_postconfig_modifiedonbehalfby";
        public const string lk_msdyn_postruleconfig_createdby_1M = "lk_msdyn_postruleconfig_createdby";
        public const string lk_msdyn_postruleconfig_createdonbehalfby_1M = "lk_msdyn_postruleconfig_createdonbehalfby";
        public const string lk_msdyn_postruleconfig_modifiedby_1M = "lk_msdyn_postruleconfig_modifiedby";
        public const string lk_msdyn_postruleconfig_modifiedonbehalfby_1M = "lk_msdyn_postruleconfig_modifiedonbehalfby";
        public const string lk_msdyn_wallsavedquery_createdby_1M = "lk_msdyn_wallsavedquery_createdby";
        public const string lk_msdyn_wallsavedquery_createdonbehalfby_1M = "lk_msdyn_wallsavedquery_createdonbehalfby";
        public const string lk_msdyn_wallsavedquery_modifiedby_1M = "lk_msdyn_wallsavedquery_modifiedby";
        public const string lk_msdyn_wallsavedquery_modifiedonbehalfby_1M = "lk_msdyn_wallsavedquery_modifiedonbehalfby";

        public const string lk_msdyn_wallsavedqueryusersettings_createdby_1M =
            "lk_msdyn_wallsavedqueryusersettings_createdby";

        public const string lk_msdyn_wallsavedqueryusersettings_createdonbehalfby_1M =
            "lk_msdyn_wallsavedqueryusersettings_createdonbehalfby";

        public const string lk_msdyn_wallsavedqueryusersettings_modifiedby_1M =
            "lk_msdyn_wallsavedqueryusersettings_modifiedby";

        public const string lk_msdyn_wallsavedqueryusersettings_modifiedonbehalfby_1M =
            "lk_msdyn_wallsavedqueryusersettings_modifiedonbehalfby";

        public const string lk_officedocumentbase_createdonbehalfby_1M = "lk_officedocumentbase_createdonbehalfby";
        public const string lk_officedocumentbase_modifiedonbehalfby_1M = "lk_officedocumentbase_modifiedonbehalfby";
        public const string lk_opportunity_createdonbehalfby_1M = "lk_opportunity_createdonbehalfby";
        public const string lk_opportunity_modifiedonbehalfby_1M = "lk_opportunity_modifiedonbehalfby";
        public const string lk_opportunitybase_createdby_1M = "lk_opportunitybase_createdby";
        public const string lk_opportunitybase_modifiedby_1M = "lk_opportunitybase_modifiedby";
        public const string lk_opportunityclose_createdby_1M = "lk_opportunityclose_createdby";
        public const string lk_opportunityclose_createdonbehalfby_1M = "lk_opportunityclose_createdonbehalfby";
        public const string lk_opportunityclose_modifiedby_1M = "lk_opportunityclose_modifiedby";
        public const string lk_opportunityclose_modifiedonbehalfby_1M = "lk_opportunityclose_modifiedonbehalfby";
        public const string lk_opportunityproduct_createdonbehalfby_1M = "lk_opportunityproduct_createdonbehalfby";
        public const string lk_opportunityproduct_modifiedonbehalfby_1M = "lk_opportunityproduct_modifiedonbehalfby";
        public const string lk_opportunityproductbase_createdby_1M = "lk_opportunityproductbase_createdby";
        public const string lk_opportunityproductbase_modifiedby_1M = "lk_opportunityproductbase_modifiedby";
        public const string lk_orderclose_createdby_1M = "lk_orderclose_createdby";
        public const string lk_orderclose_createdonbehalfby_1M = "lk_orderclose_createdonbehalfby";
        public const string lk_orderclose_modifiedby_1M = "lk_orderclose_modifiedby";
        public const string lk_orderclose_modifiedonbehalfby_1M = "lk_orderclose_modifiedonbehalfby";
        public const string lk_organization_createdonbehalfby_1M = "lk_organization_createdonbehalfby";
        public const string lk_organization_modifiedonbehalfby_1M = "lk_organization_modifiedonbehalfby";
        public const string lk_organizationbase_createdby_1M = "lk_organizationbase_createdby";
        public const string lk_organizationbase_modifiedby_1M = "lk_organizationbase_modifiedby";
        public const string lk_ownermapping_createdby_1M = "lk_ownermapping_createdby";
        public const string lk_ownermapping_createdonbehalfby_1M = "lk_ownermapping_createdonbehalfby";
        public const string lk_ownermapping_modifiedby_1M = "lk_ownermapping_modifiedby";
        public const string lk_ownermapping_modifiedonbehalfby_1M = "lk_ownermapping_modifiedonbehalfby";
        public const string lk_partnerapplication_createdby_1M = "lk_partnerapplication_createdby";
        public const string lk_partnerapplication_createdonbehalfby_1M = "lk_partnerapplication_createdonbehalfby";
        public const string lk_partnerapplication_modifiedby_1M = "lk_partnerapplication_modifiedby";
        public const string lk_partnerapplication_modifiedonbehalfby_1M = "lk_partnerapplication_modifiedonbehalfby";
        public const string lk_phonecall_createdby_1M = "lk_phonecall_createdby";
        public const string lk_phonecall_createdonbehalfby_1M = "lk_phonecall_createdonbehalfby";
        public const string lk_phonecall_modifiedby_1M = "lk_phonecall_modifiedby";
        public const string lk_phonecall_modifiedonbehalfby_1M = "lk_phonecall_modifiedonbehalfby";
        public const string lk_picklistmapping_createdby_1M = "lk_picklistmapping_createdby";
        public const string lk_picklistmapping_createdonbehalfby_1M = "lk_picklistmapping_createdonbehalfby";
        public const string lk_picklistmapping_modifiedby_1M = "lk_picklistmapping_modifiedby";
        public const string lk_picklistmapping_modifiedonbehalfby_1M = "lk_picklistmapping_modifiedonbehalfby";
        public const string lk_pluginassembly_createdonbehalfby_1M = "lk_pluginassembly_createdonbehalfby";
        public const string lk_pluginassembly_modifiedonbehalfby_1M = "lk_pluginassembly_modifiedonbehalfby";
        public const string lk_plugintracelogbase_createdonbehalfby_1M = "lk_plugintracelogbase_createdonbehalfby";
        public const string lk_plugintype_createdonbehalfby_1M = "lk_plugintype_createdonbehalfby";
        public const string lk_plugintype_modifiedonbehalfby_1M = "lk_plugintype_modifiedonbehalfby";

        public const string lk_plugintypestatisticbase_createdonbehalfby_1M =
            "lk_plugintypestatisticbase_createdonbehalfby";

        public const string lk_plugintypestatisticbase_modifiedonbehalfby_1M =
            "lk_plugintypestatisticbase_modifiedonbehalfby";

        public const string lk_position_createdby_1M = "lk_position_createdby";
        public const string lk_position_createdonbehalfby_1M = "lk_position_createdonbehalfby";
        public const string lk_position_modifiedby_1M = "lk_position_modifiedby";
        public const string lk_position_modifiedonbehalfby_1M = "lk_position_modifiedonbehalfby";
        public const string lk_post_createdby_1M = "lk_post_createdby";
        public const string lk_post_createdonbehalfby_1M = "lk_post_createdonbehalfby";
        public const string lk_post_modifiedby_1M = "lk_post_modifiedby";
        public const string lk_post_modifiedonbehalfby_1M = "lk_post_modifiedonbehalfby";
        public const string lk_postcomment_createdby_1M = "lk_postcomment_createdby";
        public const string lk_postcomment_createdonbehalfby_1M = "lk_postcomment_createdonbehalfby";
        public const string lk_PostFollow_createdby_1M = "lk_PostFollow_createdby";
        public const string lk_postfollow_createdonbehalfby_1M = "lk_postfollow_createdonbehalfby";
        public const string lk_postlike_createdby_1M = "lk_postlike_createdby";
        public const string lk_postlike_createdonbehalfby_1M = "lk_postlike_createdonbehalfby";
        public const string lk_pricelevel_createdonbehalfby_1M = "lk_pricelevel_createdonbehalfby";
        public const string lk_pricelevel_modifiedonbehalfby_1M = "lk_pricelevel_modifiedonbehalfby";
        public const string lk_pricelevelbase_createdby_1M = "lk_pricelevelbase_createdby";
        public const string lk_pricelevelbase_modifiedby_1M = "lk_pricelevelbase_modifiedby";
        public const string lk_processsession_canceledby_1M = "lk_processsession_canceledby";
        public const string lk_processsession_completedby_1M = "lk_processsession_completedby";
        public const string lk_processsession_createdby_1M = "lk_processsession_createdby";
        public const string lk_processsession_executedby_1M = "lk_processsession_executedby";
        public const string lk_processsession_modifiedby_1M = "lk_processsession_modifiedby";
        public const string lk_processsession_startedby_1M = "lk_processsession_startedby";
        public const string lk_processsessionbase_createdonbehalfby_1M = "lk_processsessionbase_createdonbehalfby";
        public const string lk_processsessionbase_modifiedonbehalfby_1M = "lk_processsessionbase_modifiedonbehalfby";
        public const string lk_processtriggerbase_createdby_1M = "lk_processtriggerbase_createdby";
        public const string lk_processtriggerbase_createdonbehalfby_1M = "lk_processtriggerbase_createdonbehalfby";
        public const string lk_processtriggerbase_modifiedby_1M = "lk_processtriggerbase_modifiedby";
        public const string lk_processtriggerbase_modifiedonbehalfby_1M = "lk_processtriggerbase_modifiedonbehalfby";
        public const string lk_product_createdonbehalfby_1M = "lk_product_createdonbehalfby";
        public const string lk_product_modifiedonbehalfby_1M = "lk_product_modifiedonbehalfby";
        public const string lk_ProductAssociate_createdby_1M = "lk_ProductAssociate_createdby";
        public const string lk_ProductAssociation_createdonbehalfby_1M = "lk_ProductAssociation_createdonbehalfby";
        public const string lk_ProductAssociation_modifiedby_1M = "lk_ProductAssociation_modifiedby";
        public const string lk_ProductAssociation_modifiedonbehalfby_1M = "lk_ProductAssociation_modifiedonbehalfby";
        public const string lk_productbase_createdby_1M = "lk_productbase_createdby";
        public const string lk_productbase_modifiedby_1M = "lk_productbase_modifiedby";
        public const string lk_productpricelevel_createdonbehalfby_1M = "lk_productpricelevel_createdonbehalfby";
        public const string lk_productpricelevel_modifiedonbehalfby_1M = "lk_productpricelevel_modifiedonbehalfby";
        public const string lk_productpricelevelbase_createdby_1M = "lk_productpricelevelbase_createdby";
        public const string lk_productpricelevelbase_modifiedby_1M = "lk_productpricelevelbase_modifiedby";
        public const string lk_ProductSubstitute_createdby_1M = "lk_ProductSubstitute_createdby";
        public const string lk_ProductSubstitute_createdonbehalfby_1M = "lk_ProductSubstitute_createdonbehalfby";
        public const string lk_ProductSubstitute_modifiedby_1M = "lk_ProductSubstitute_modifiedby";
        public const string lk_ProductSubstitute_modifiedonbehalfby_1M = "lk_ProductSubstitute_modifiedonbehalfby";
        public const string lk_publisher_createdby_1M = "lk_publisher_createdby";
        public const string lk_publisher_modifiedby_1M = "lk_publisher_modifiedby";
        public const string lk_publisheraddressbase_createdby_1M = "lk_publisheraddressbase_createdby";
        public const string lk_publisheraddressbase_createdonbehalfby_1M = "lk_publisheraddressbase_createdonbehalfby";
        public const string lk_publisheraddressbase_modifiedby_1M = "lk_publisheraddressbase_modifiedby";
        public const string lk_publisheraddressbase_modifiedonbehalfby_1M = "lk_publisheraddressbase_modifiedonbehalfby";
        public const string lk_publisherbase_createdonbehalfby_1M = "lk_publisherbase_createdonbehalfby";
        public const string lk_publisherbase_modifiedonbehalfby_1M = "lk_publisherbase_modifiedonbehalfby";
        public const string lk_quarterlyfiscalcalendar_createdby_1M = "lk_quarterlyfiscalcalendar_createdby";

        public const string lk_quarterlyfiscalcalendar_createdonbehalfby_1M =
            "lk_quarterlyfiscalcalendar_createdonbehalfby";

        public const string lk_quarterlyfiscalcalendar_modifiedby_1M = "lk_quarterlyfiscalcalendar_modifiedby";

        public const string lk_quarterlyfiscalcalendar_modifiedonbehalfby_1M =
            "lk_quarterlyfiscalcalendar_modifiedonbehalfby";

        public const string lk_quarterlyfiscalcalendar_salespersonid_1M = "lk_quarterlyfiscalcalendar_salespersonid";
        public const string lk_queue_createdonbehalfby_1M = "lk_queue_createdonbehalfby";
        public const string lk_queue_modifiedonbehalfby_1M = "lk_queue_modifiedonbehalfby";
        public const string lk_queuebase_createdby_1M = "lk_queuebase_createdby";
        public const string lk_queuebase_modifiedby_1M = "lk_queuebase_modifiedby";
        public const string lk_queueitem_createdonbehalfby_1M = "lk_queueitem_createdonbehalfby";
        public const string lk_queueitem_modifiedonbehalfby_1M = "lk_queueitem_modifiedonbehalfby";
        public const string lk_queueitembase_createdby_1M = "lk_queueitembase_createdby";
        public const string lk_queueitembase_modifiedby_1M = "lk_queueitembase_modifiedby";
        public const string lk_queueitembase_workerid_1M = "lk_queueitembase_workerid";
        public const string lk_quote_createdonbehalfby_1M = "lk_quote_createdonbehalfby";
        public const string lk_quote_modifiedonbehalfby_1M = "lk_quote_modifiedonbehalfby";
        public const string lk_quotebase_createdby_1M = "lk_quotebase_createdby";
        public const string lk_quotebase_modifiedby_1M = "lk_quotebase_modifiedby";
        public const string lk_quoteclose_createdby_1M = "lk_quoteclose_createdby";
        public const string lk_quoteclose_createdonbehalfby_1M = "lk_quoteclose_createdonbehalfby";
        public const string lk_quoteclose_modifiedby_1M = "lk_quoteclose_modifiedby";
        public const string lk_quoteclose_modifiedonbehalfby_1M = "lk_quoteclose_modifiedonbehalfby";
        public const string lk_quotedetail_createdonbehalfby_1M = "lk_quotedetail_createdonbehalfby";
        public const string lk_quotedetail_modifiedonbehalfby_1M = "lk_quotedetail_modifiedonbehalfby";
        public const string lk_quotedetailbase_createdby_1M = "lk_quotedetailbase_createdby";
        public const string lk_quotedetailbase_modifiedby_1M = "lk_quotedetailbase_modifiedby";
        public const string lk_recurrencerule_createdby_1M = "lk_recurrencerule_createdby";
        public const string lk_recurrencerule_modifiedby_1M = "lk_recurrencerule_modifiedby";
        public const string lk_recurrencerulebase_createdonbehalfby_1M = "lk_recurrencerulebase_createdonbehalfby";
        public const string lk_recurrencerulebase_modifiedonbehalfby_1M = "lk_recurrencerulebase_modifiedonbehalfby";
        public const string lk_recurringappointmentmaster_createdby_1M = "lk_recurringappointmentmaster_createdby";

        public const string lk_recurringappointmentmaster_createdonbehalfby_1M =
            "lk_recurringappointmentmaster_createdonbehalfby";

        public const string lk_recurringappointmentmaster_modifiedby_1M = "lk_recurringappointmentmaster_modifiedby";

        public const string lk_recurringappointmentmaster_modifiedonbehalfby_1M =
            "lk_recurringappointmentmaster_modifiedonbehalfby";

        public const string lk_relationshiprole_createdonbehalfby_1M = "lk_relationshiprole_createdonbehalfby";
        public const string lk_relationshiprole_modifiedonbehalfby_1M = "lk_relationshiprole_modifiedonbehalfby";
        public const string lk_relationshiprolemap_createdonbehalfby_1M = "lk_relationshiprolemap_createdonbehalfby";
        public const string lk_relationshiprolemap_modifiedonbehalfby_1M = "lk_relationshiprolemap_modifiedonbehalfby";
        public const string lk_report_createdonbehalfby_1M = "lk_report_createdonbehalfby";
        public const string lk_report_modifiedonbehalfby_1M = "lk_report_modifiedonbehalfby";
        public const string lk_reportbase_createdby_1M = "lk_reportbase_createdby";
        public const string lk_reportbase_modifiedby_1M = "lk_reportbase_modifiedby";
        public const string lk_reportcategory_createdonbehalfby_1M = "lk_reportcategory_createdonbehalfby";
        public const string lk_reportcategory_modifiedonbehalfby_1M = "lk_reportcategory_modifiedonbehalfby";
        public const string lk_reportcategorybase_createdby_1M = "lk_reportcategorybase_createdby";
        public const string lk_reportcategorybase_modifiedby_1M = "lk_reportcategorybase_modifiedby";
        public const string lk_reportentity_createdonbehalfby_1M = "lk_reportentity_createdonbehalfby";
        public const string lk_reportentity_modifiedonbehalfby_1M = "lk_reportentity_modifiedonbehalfby";
        public const string lk_reportentitybase_createdby_1M = "lk_reportentitybase_createdby";
        public const string lk_reportentitybase_modifiedby_1M = "lk_reportentitybase_modifiedby";
        public const string lk_reportlink_createdonbehalfby_1M = "lk_reportlink_createdonbehalfby";
        public const string lk_reportlink_modifiedonbehalfby_1M = "lk_reportlink_modifiedonbehalfby";
        public const string lk_reportlinkbase_createdby_1M = "lk_reportlinkbase_createdby";
        public const string lk_reportlinkbase_modifiedby_1M = "lk_reportlinkbase_modifiedby";
        public const string lk_reportvisibility_createdonbehalfby_1M = "lk_reportvisibility_createdonbehalfby";
        public const string lk_reportvisibility_modifiedonbehalfby_1M = "lk_reportvisibility_modifiedonbehalfby";
        public const string lk_reportvisibilitybase_createdby_1M = "lk_reportvisibilitybase_createdby";
        public const string lk_reportvisibilitybase_modifiedby_1M = "lk_reportvisibilitybase_modifiedby";
        public const string lk_resourcespec_createdby_1M = "lk_resourcespec_createdby";
        public const string lk_resourcespec_createdonbehalfby_1M = "lk_resourcespec_createdonbehalfby";
        public const string lk_resourcespec_modifiedby_1M = "lk_resourcespec_modifiedby";
        public const string lk_resourcespec_modifiedonbehalfby_1M = "lk_resourcespec_modifiedonbehalfby";
        public const string lk_role_createdonbehalfby_1M = "lk_role_createdonbehalfby";
        public const string lk_role_modifiedonbehalfby_1M = "lk_role_modifiedonbehalfby";
        public const string lk_rolebase_createdby_1M = "lk_rolebase_createdby";
        public const string lk_rolebase_modifiedby_1M = "lk_rolebase_modifiedby";
        public const string lk_rollupfield_createdby_1M = "lk_rollupfield_createdby";
        public const string lk_rollupfield_createdonbehalfby_1M = "lk_rollupfield_createdonbehalfby";
        public const string lk_rollupfield_modifiedby_1M = "lk_rollupfield_modifiedby";
        public const string lk_rollupfield_modifiedonbehalfby_1M = "lk_rollupfield_modifiedonbehalfby";
        public const string lk_routingrule_createdby_1M = "lk_routingrule_createdby";
        public const string lk_routingrule_createdonbehalfby_1M = "lk_routingrule_createdonbehalfby";
        public const string lk_routingrule_modifiedby_1M = "lk_routingrule_modifiedby";
        public const string lk_routingrule_modifiedonbehalfby_1M = "lk_routingrule_modifiedonbehalfby";
        public const string lk_RoutingRuleItem_createdby_1M = "lk_RoutingRuleItem_createdby";
        public const string lk_routingruleitem_createdonbehalfby_1M = "lk_routingruleitem_createdonbehalfby";
        public const string lk_routingruleitem_modifiedby_1M = "lk_routingruleitem_modifiedby";
        public const string lk_routingruleitem_modifiedonbehalfby_1M = "lk_routingruleitem_modifiedonbehalfby";
        public const string lk_salesliterature_createdonbehalfby_1M = "lk_salesliterature_createdonbehalfby";
        public const string lk_salesliterature_modifiedonbehalfby_1M = "lk_salesliterature_modifiedonbehalfby";
        public const string lk_salesliteraturebase_createdby_1M = "lk_salesliteraturebase_createdby";
        public const string lk_salesliteraturebase_modifiedby_1M = "lk_salesliteraturebase_modifiedby";
        public const string lk_salesliteratureitem_createdonbehalfby_1M = "lk_salesliteratureitem_createdonbehalfby";
        public const string lk_salesliteratureitem_modifiedonbehalfby_1M = "lk_salesliteratureitem_modifiedonbehalfby";
        public const string lk_salesliteratureitembase_createdby_1M = "lk_salesliteratureitembase_createdby";
        public const string lk_salesliteratureitembase_modifiedby_1M = "lk_salesliteratureitembase_modifiedby";
        public const string lk_salesorder_createdonbehalfby_1M = "lk_salesorder_createdonbehalfby";
        public const string lk_salesorder_modifiedonbehalfby_1M = "lk_salesorder_modifiedonbehalfby";
        public const string lk_salesorderbase_createdby_1M = "lk_salesorderbase_createdby";
        public const string lk_salesorderbase_modifiedby_1M = "lk_salesorderbase_modifiedby";
        public const string lk_salesorderdetail_createdonbehalfby_1M = "lk_salesorderdetail_createdonbehalfby";
        public const string lk_salesorderdetail_modifiedonbehalfby_1M = "lk_salesorderdetail_modifiedonbehalfby";
        public const string lk_salesorderdetailbase_createdby_1M = "lk_salesorderdetailbase_createdby";
        public const string lk_salesorderdetailbase_modifiedby_1M = "lk_salesorderdetailbase_modifiedby";
        public const string lk_savedquery_createdonbehalfby_1M = "lk_savedquery_createdonbehalfby";
        public const string lk_savedquery_modifiedonbehalfby_1M = "lk_savedquery_modifiedonbehalfby";
        public const string lk_savedquerybase_createdby_1M = "lk_savedquerybase_createdby";
        public const string lk_savedquerybase_modifiedby_1M = "lk_savedquerybase_modifiedby";
        public const string lk_savedqueryvisualizationbase_createdby_1M = "lk_savedqueryvisualizationbase_createdby";

        public const string lk_savedqueryvisualizationbase_createdonbehalfby_1M =
            "lk_savedqueryvisualizationbase_createdonbehalfby";

        public const string lk_savedqueryvisualizationbase_modifiedby_1M = "lk_savedqueryvisualizationbase_modifiedby";

        public const string lk_savedqueryvisualizationbase_modifiedonbehalfby_1M =
            "lk_savedqueryvisualizationbase_modifiedonbehalfby";

        public const string lk_sdkmessage_createdonbehalfby_1M = "lk_sdkmessage_createdonbehalfby";
        public const string lk_sdkmessage_modifiedonbehalfby_1M = "lk_sdkmessage_modifiedonbehalfby";
        public const string lk_sdkmessagefilter_createdonbehalfby_1M = "lk_sdkmessagefilter_createdonbehalfby";
        public const string lk_sdkmessagefilter_modifiedonbehalfby_1M = "lk_sdkmessagefilter_modifiedonbehalfby";
        public const string lk_sdkmessagepair_createdonbehalfby_1M = "lk_sdkmessagepair_createdonbehalfby";
        public const string lk_sdkmessagepair_modifiedonbehalfby_1M = "lk_sdkmessagepair_modifiedonbehalfby";

        public const string lk_sdkmessageprocessingstep_createdonbehalfby_1M =
            "lk_sdkmessageprocessingstep_createdonbehalfby";

        public const string lk_sdkmessageprocessingstep_modifiedonbehalfby_1M =
            "lk_sdkmessageprocessingstep_modifiedonbehalfby";

        public const string lk_sdkmessageprocessingstepimage_createdonbehalfby_1M =
            "lk_sdkmessageprocessingstepimage_createdonbehalfby";

        public const string lk_sdkmessageprocessingstepimage_modifiedonbehalfby_1M =
            "lk_sdkmessageprocessingstepimage_modifiedonbehalfby";

        public const string lk_sdkmessageprocessingstepsecureconfig_createdonbehalfby_1M =
            "lk_sdkmessageprocessingstepsecureconfig_createdonbehalfby";

        public const string lk_sdkmessageprocessingstepsecureconfig_modifiedonbehalfby_1M =
            "lk_sdkmessageprocessingstepsecureconfig_modifiedonbehalfby";

        public const string lk_sdkmessagerequest_createdonbehalfby_1M = "lk_sdkmessagerequest_createdonbehalfby";
        public const string lk_sdkmessagerequest_modifiedonbehalfby_1M = "lk_sdkmessagerequest_modifiedonbehalfby";

        public const string lk_sdkmessagerequestfield_createdonbehalfby_1M =
            "lk_sdkmessagerequestfield_createdonbehalfby";

        public const string lk_sdkmessagerequestfield_modifiedonbehalfby_1M =
            "lk_sdkmessagerequestfield_modifiedonbehalfby";

        public const string lk_sdkmessageresponse_createdonbehalfby_1M = "lk_sdkmessageresponse_createdonbehalfby";
        public const string lk_sdkmessageresponse_modifiedonbehalfby_1M = "lk_sdkmessageresponse_modifiedonbehalfby";

        public const string lk_sdkmessageresponsefield_createdonbehalfby_1M =
            "lk_sdkmessageresponsefield_createdonbehalfby";

        public const string lk_sdkmessageresponsefield_modifiedonbehalfby_1M =
            "lk_sdkmessageresponsefield_modifiedonbehalfby";

        public const string lk_semiannualfiscalcalendar_createdby_1M = "lk_semiannualfiscalcalendar_createdby";

        public const string lk_semiannualfiscalcalendar_createdonbehalfby_1M =
            "lk_semiannualfiscalcalendar_createdonbehalfby";

        public const string lk_semiannualfiscalcalendar_modifiedby_1M = "lk_semiannualfiscalcalendar_modifiedby";

        public const string lk_semiannualfiscalcalendar_modifiedonbehalfby_1M =
            "lk_semiannualfiscalcalendar_modifiedonbehalfby";

        public const string lk_semiannualfiscalcalendar_salespersonid_1M = "lk_semiannualfiscalcalendar_salespersonid";
        public const string lk_service_createdby_1M = "lk_service_createdby";
        public const string lk_service_createdonbehalfby_1M = "lk_service_createdonbehalfby";
        public const string lk_service_modifiedby_1M = "lk_service_modifiedby";
        public const string lk_service_modifiedonbehalfby_1M = "lk_service_modifiedonbehalfby";
        public const string lk_serviceappointment_createdby_1M = "lk_serviceappointment_createdby";
        public const string lk_serviceappointment_createdonbehalfby_1M = "lk_serviceappointment_createdonbehalfby";
        public const string lk_serviceappointment_modifiedby_1M = "lk_serviceappointment_modifiedby";
        public const string lk_serviceappointment_modifiedonbehalfby_1M = "lk_serviceappointment_modifiedonbehalfby";
        public const string lk_serviceendpointbase_createdonbehalfby_1M = "lk_serviceendpointbase_createdonbehalfby";
        public const string lk_serviceendpointbase_modifiedonbehalfby_1M = "lk_serviceendpointbase_modifiedonbehalfby";
        public const string lk_SharePointData_createdby_1M = "lk_SharePointData_createdby";
        public const string lk_SharePointData_createdonbehalfby_1M = "lk_SharePointData_createdonbehalfby";
        public const string lk_SharePointData_modifiedby_1M = "lk_SharePointData_modifiedby";
        public const string lk_SharePointData_modifiedonbehalfby_1M = "lk_SharePointData_modifiedonbehalfby";
        public const string lk_sharepointdata_user_1M = "lk_sharepointdata_user";
        public const string lk_sharepointdocumentbase_createdby_1M = "lk_sharepointdocumentbase_createdby";

        public const string lk_sharepointdocumentbase_createdonbehalfby_1M =
            "lk_sharepointdocumentbase_createdonbehalfby";

        public const string lk_sharepointdocumentbase_modifiedby_1M = "lk_sharepointdocumentbase_modifiedby";

        public const string lk_sharepointdocumentbase_modifiedonbehalfby_1M =
            "lk_sharepointdocumentbase_modifiedonbehalfby";

        public const string lk_sharepointdocumentlocationbase_createdby_1M =
            "lk_sharepointdocumentlocationbase_createdby";

        public const string lk_sharepointdocumentlocationbase_createdonbehalfby_1M =
            "lk_sharepointdocumentlocationbase_createdonbehalfby";

        public const string lk_sharepointdocumentlocationbase_modifiedby_1M =
            "lk_sharepointdocumentlocationbase_modifiedby";

        public const string lk_sharepointdocumentlocationbase_modifiedonbehalfby_1M =
            "lk_sharepointdocumentlocationbase_modifiedonbehalfby";

        public const string lk_sharepointsitebase_createdby_1M = "lk_sharepointsitebase_createdby";
        public const string lk_sharepointsitebase_createdonbehalfby_1M = "lk_sharepointsitebase_createdonbehalfby";
        public const string lk_sharepointsitebase_modifiedby_1M = "lk_sharepointsitebase_modifiedby";
        public const string lk_sharepointsitebase_modifiedonbehalfby_1M = "lk_sharepointsitebase_modifiedonbehalfby";
        public const string lk_site_createdonbehalfby_1M = "lk_site_createdonbehalfby";
        public const string lk_site_modifiedonbehalfby_1M = "lk_site_modifiedonbehalfby";
        public const string lk_sitebase_createdby_1M = "lk_sitebase_createdby";
        public const string lk_sitebase_modifiedby_1M = "lk_sitebase_modifiedby";
        public const string lk_slabase_createdby_1M = "lk_slabase_createdby";
        public const string lk_slabase_createdonbehalfby_1M = "lk_slabase_createdonbehalfby";
        public const string lk_slabase_modifiedby_1M = "lk_slabase_modifiedby";
        public const string lk_slabase_modifiedonbehalfby_1M = "lk_slabase_modifiedonbehalfby";
        public const string lk_slaitembase_createdby_1M = "lk_slaitembase_createdby";
        public const string lk_slaitembase_createdonbehalfby_1M = "lk_slaitembase_createdonbehalfby";
        public const string lk_slaitembase_modifiedby_1M = "lk_slaitembase_modifiedby";
        public const string lk_slaitembase_modifiedonbehalfby_1M = "lk_slaitembase_modifiedonbehalfby";
        public const string lk_slakpiinstancebase_createdby_1M = "lk_slakpiinstancebase_createdby";
        public const string lk_slakpiinstancebase_createdonbehalfby_1M = "lk_slakpiinstancebase_createdonbehalfby";
        public const string lk_slakpiinstancebase_modifiedby_1M = "lk_slakpiinstancebase_modifiedby";
        public const string lk_slakpiinstancebase_modifiedonbehalfby_1M = "lk_slakpiinstancebase_modifiedonbehalfby";
        public const string lk_socialactivity_createdby_1M = "lk_socialactivity_createdby";
        public const string lk_socialactivity_modifiedby_1M = "lk_socialactivity_modifiedby";
        public const string lk_socialactivitybase_createdonbehalfby_1M = "lk_socialactivitybase_createdonbehalfby";
        public const string lk_socialactivitybase_modifiedonbehalfby_1M = "lk_socialactivitybase_modifiedonbehalfby";
        public const string lk_socialinsightsconfiguration_createdby_1M = "lk_socialinsightsconfiguration_createdby";

        public const string lk_socialinsightsconfiguration_createdonbehalfby_1M =
            "lk_socialinsightsconfiguration_createdonbehalfby";

        public const string lk_socialinsightsconfiguration_modifiedby_1M = "lk_socialinsightsconfiguration_modifiedby";

        public const string lk_socialinsightsconfiguration_modifiedonbehalfby_1M =
            "lk_socialinsightsconfiguration_modifiedonbehalfby";

        public const string lk_SocialProfile_createdonbehalfby_1M = "lk_SocialProfile_createdonbehalfby";
        public const string lk_SocialProfile_modifiedonbehalfby_1M = "lk_SocialProfile_modifiedonbehalfby";
        public const string lk_solution_createdby_1M = "lk_solution_createdby";
        public const string lk_solution_modifiedby_1M = "lk_solution_modifiedby";
        public const string lk_solutionbase_createdonbehalfby_1M = "lk_solutionbase_createdonbehalfby";
        public const string lk_solutionbase_modifiedonbehalfby_1M = "lk_solutionbase_modifiedonbehalfby";
        public const string lk_solutioncomponentbase_createdonbehalfby_1M = "lk_solutioncomponentbase_createdonbehalfby";

        public const string lk_solutioncomponentbase_modifiedonbehalfby_1M =
            "lk_solutioncomponentbase_modifiedonbehalfby";

        public const string lk_subject_createdonbehalfby_1M = "lk_subject_createdonbehalfby";
        public const string lk_subject_modifiedonbehalfby_1M = "lk_subject_modifiedonbehalfby";
        public const string lk_subjectbase_createdby_1M = "lk_subjectbase_createdby";
        public const string lk_subjectbase_modifiedby_1M = "lk_subjectbase_modifiedby";
        public const string lk_syncattributemappingprofile_createdby_1M = "lk_syncattributemappingprofile_createdby";

        public const string lk_syncattributemappingprofile_createdonbehalfby_1M =
            "lk_syncattributemappingprofile_createdonbehalfby";

        public const string lk_syncattributemappingprofile_modifiedby_1M = "lk_syncattributemappingprofile_modifiedby";

        public const string lk_syncattributemappingprofile_modifiedonbehalfby_1M =
            "lk_syncattributemappingprofile_modifiedonbehalfby";

        public const string lk_systemapplicationmetadata_createdby_1M = "lk_systemapplicationmetadata_createdby";

        public const string lk_systemapplicationmetadata_createdonbehalfby_1M =
            "lk_systemapplicationmetadata_createdonbehalfby";

        public const string lk_systemapplicationmetadata_modifiedby_1M = "lk_systemapplicationmetadata_modifiedby";

        public const string lk_systemapplicationmetadata_modifiedonbehalfby_1M =
            "lk_systemapplicationmetadata_modifiedonbehalfby";

        public const string lk_systemuser_createdonbehalfby_1M = "lk_systemuser_createdonbehalfby";
        public const string lk_systemuser_createdonbehalfby_M1 = "lk_systemuser_createdonbehalfby";
        public const string lk_systemuser_entityimage_M1 = "lk_systemuser_entityimage";
        public const string lk_systemuser_modifiedonbehalfby_1M = "lk_systemuser_modifiedonbehalfby";
        public const string lk_systemuser_modifiedonbehalfby_M1 = "lk_systemuser_modifiedonbehalfby";
        public const string lk_systemuserbase_createdby_1M = "lk_systemuserbase_createdby";
        public const string lk_systemuserbase_createdby_M1 = "lk_systemuserbase_createdby";
        public const string lk_systemuserbase_modifiedby_1M = "lk_systemuserbase_modifiedby";
        public const string lk_systemuserbase_modifiedby_M1 = "lk_systemuserbase_modifiedby";
        public const string lk_task_createdby_1M = "lk_task_createdby";
        public const string lk_task_createdonbehalfby_1M = "lk_task_createdonbehalfby";
        public const string lk_task_modifiedby_1M = "lk_task_modifiedby";
        public const string lk_task_modifiedonbehalfby_1M = "lk_task_modifiedonbehalfby";
        public const string lk_team_createdonbehalfby_1M = "lk_team_createdonbehalfby";
        public const string lk_team_modifiedonbehalfby_1M = "lk_team_modifiedonbehalfby";
        public const string lk_teambase_administratorid_1M = "lk_teambase_administratorid";
        public const string lk_teambase_createdby_1M = "lk_teambase_createdby";
        public const string lk_teambase_modifiedby_1M = "lk_teambase_modifiedby";
        public const string lk_teamtemplate_createdby_1M = "lk_teamtemplate_createdby";
        public const string lk_teamtemplate_createdonbehalfby_1M = "lk_teamtemplate_createdonbehalfby";
        public const string lk_teamtemplate_modifiedby_1M = "lk_teamtemplate_modifiedby";
        public const string lk_teamtemplate_modifiedonbehalfby_1M = "lk_teamtemplate_modifiedonbehalfby";
        public const string lk_templatebase_createdby_1M = "lk_templatebase_createdby";
        public const string lk_templatebase_createdonbehalfby_1M = "lk_templatebase_createdonbehalfby";
        public const string lk_templatebase_modifiedby_1M = "lk_templatebase_modifiedby";
        public const string lk_templatebase_modifiedonbehalfby_1M = "lk_templatebase_modifiedonbehalfby";
        public const string lk_territory_createdonbehalfby_1M = "lk_territory_createdonbehalfby";
        public const string lk_territory_modifiedonbehalfby_1M = "lk_territory_modifiedonbehalfby";
        public const string lk_territorybase_createdby_1M = "lk_territorybase_createdby";
        public const string lk_territorybase_modifiedby_1M = "lk_territorybase_modifiedby";
        public const string lk_theme_createdby_1M = "lk_theme_createdby";
        public const string lk_theme_createdonbehalfby_1M = "lk_theme_createdonbehalfby";
        public const string lk_theme_modifiedby_1M = "lk_theme_modifiedby";
        public const string lk_theme_modifiedonbehalfby_1M = "lk_theme_modifiedonbehalfby";
        public const string lk_timezonedefinition_createdby_1M = "lk_timezonedefinition_createdby";
        public const string lk_timezonedefinition_createdonbehalfby_1M = "lk_timezonedefinition_createdonbehalfby";
        public const string lk_timezonedefinition_modifiedby_1M = "lk_timezonedefinition_modifiedby";
        public const string lk_timezonedefinition_modifiedonbehalfby_1M = "lk_timezonedefinition_modifiedonbehalfby";
        public const string lk_timezonelocalizedname_createdby_1M = "lk_timezonelocalizedname_createdby";
        public const string lk_timezonelocalizedname_createdonbehalfby_1M = "lk_timezonelocalizedname_createdonbehalfby";
        public const string lk_timezonelocalizedname_modifiedby_1M = "lk_timezonelocalizedname_modifiedby";

        public const string lk_timezonelocalizedname_modifiedonbehalfby_1M =
            "lk_timezonelocalizedname_modifiedonbehalfby";

        public const string lk_timezonerule_createdby_1M = "lk_timezonerule_createdby";
        public const string lk_timezonerule_createdonbehalfby_1M = "lk_timezonerule_createdonbehalfby";
        public const string lk_timezonerule_modifiedby_1M = "lk_timezonerule_modifiedby";
        public const string lk_timezonerule_modifiedonbehalfby_1M = "lk_timezonerule_modifiedonbehalfby";
        public const string lk_tracelog_createdby_1M = "lk_tracelog_createdby";
        public const string lk_tracelog_createdonbehalfby_1M = "lk_tracelog_createdonbehalfby";
        public const string lk_tracelog_modifiedby_1M = "lk_tracelog_modifiedby";
        public const string lk_tracelog_modifiedonbehalfby_1M = "lk_tracelog_modifiedonbehalfby";
        public const string lk_transactioncurrency_createdonbehalfby_1M = "lk_transactioncurrency_createdonbehalfby";
        public const string lk_transactioncurrency_modifiedonbehalfby_1M = "lk_transactioncurrency_modifiedonbehalfby";
        public const string lk_transactioncurrencybase_createdby_1M = "lk_transactioncurrencybase_createdby";
        public const string lk_transactioncurrencybase_modifiedby_1M = "lk_transactioncurrencybase_modifiedby";
        public const string lk_transformationmapping_createdby_1M = "lk_transformationmapping_createdby";
        public const string lk_transformationmapping_createdonbehalfby_1M = "lk_transformationmapping_createdonbehalfby";
        public const string lk_transformationmapping_modifiedby_1M = "lk_transformationmapping_modifiedby";

        public const string lk_transformationmapping_modifiedonbehalfby_1M =
            "lk_transformationmapping_modifiedonbehalfby";

        public const string lk_transformationparametermapping_createdby_1M =
            "lk_transformationparametermapping_createdby";

        public const string lk_transformationparametermapping_createdonbehalfby_1M =
            "lk_transformationparametermapping_createdonbehalfby";

        public const string lk_transformationparametermapping_modifiedby_1M =
            "lk_transformationparametermapping_modifiedby";

        public const string lk_transformationparametermapping_modifiedonbehalfby_1M =
            "lk_transformationparametermapping_modifiedonbehalfby";

        public const string lk_uom_createdonbehalfby_1M = "lk_uom_createdonbehalfby";
        public const string lk_uom_modifiedonbehalfby_1M = "lk_uom_modifiedonbehalfby";
        public const string lk_uombase_createdby_1M = "lk_uombase_createdby";
        public const string lk_uombase_modifiedby_1M = "lk_uombase_modifiedby";
        public const string lk_uomschedule_createdonbehalfby_1M = "lk_uomschedule_createdonbehalfby";
        public const string lk_uomschedule_modifiedonbehalfby_1M = "lk_uomschedule_modifiedonbehalfby";
        public const string lk_uomschedulebase_createdby_1M = "lk_uomschedulebase_createdby";
        public const string lk_uomschedulebase_modifiedby_1M = "lk_uomschedulebase_modifiedby";
        public const string lk_userapplicationmetadata_createdby_1M = "lk_userapplicationmetadata_createdby";

        public const string lk_userapplicationmetadata_createdonbehalfby_1M =
            "lk_userapplicationmetadata_createdonbehalfby";

        public const string lk_userapplicationmetadata_modifiedby_1M = "lk_userapplicationmetadata_modifiedby";

        public const string lk_userapplicationmetadata_modifiedonbehalfby_1M =
            "lk_userapplicationmetadata_modifiedonbehalfby";

        public const string lk_userfiscalcalendar_createdby_1M = "lk_userfiscalcalendar_createdby";
        public const string lk_userfiscalcalendar_createdonbehalfby_1M = "lk_userfiscalcalendar_createdonbehalfby";
        public const string lk_userfiscalcalendar_modifiedby_1M = "lk_userfiscalcalendar_modifiedby";
        public const string lk_userfiscalcalendar_modifiedonbehalfby_1M = "lk_userfiscalcalendar_modifiedonbehalfby";
        public const string lk_userform_createdby_1M = "lk_userform_createdby";
        public const string lk_userform_modifiedby_1M = "lk_userform_modifiedby";
        public const string lk_userformbase_createdonbehalfby_1M = "lk_userformbase_createdonbehalfby";
        public const string lk_userformbase_modifiedonbehalfby_1M = "lk_userformbase_modifiedonbehalfby";
        public const string lk_usermapping_createdby_1M = "lk_usermapping_createdby";
        public const string lk_usermapping_createdonbehalfby_1M = "lk_usermapping_createdonbehalfby";
        public const string lk_usermapping_modifiedby_1M = "lk_usermapping_modifiedby";
        public const string lk_usermapping_modifiedonbehalfby_1M = "lk_usermapping_modifiedonbehalfby";
        public const string lk_userquery_createdby_1M = "lk_userquery_createdby";
        public const string lk_userquery_createdonbehalfby_1M = "lk_userquery_createdonbehalfby";
        public const string lk_userquery_modifiedby_1M = "lk_userquery_modifiedby";
        public const string lk_userquery_modifiedonbehalfby_1M = "lk_userquery_modifiedonbehalfby";
        public const string lk_userqueryvisualization_createdby_1M = "lk_userqueryvisualization_createdby";
        public const string lk_userqueryvisualization_modifiedby_1M = "lk_userqueryvisualization_modifiedby";

        public const string lk_userqueryvisualizationbase_createdonbehalfby_1M =
            "lk_userqueryvisualizationbase_createdonbehalfby";

        public const string lk_userqueryvisualizationbase_modifiedonbehalfby_1M =
            "lk_userqueryvisualizationbase_modifiedonbehalfby";

        public const string lk_usersettings_createdonbehalfby_1M = "lk_usersettings_createdonbehalfby";
        public const string lk_usersettings_modifiedonbehalfby_1M = "lk_usersettings_modifiedonbehalfby";
        public const string lk_usersettingsbase_createdby_1M = "lk_usersettingsbase_createdby";
        public const string lk_usersettingsbase_modifiedby_1M = "lk_usersettingsbase_modifiedby";
        public const string lk_webresourcebase_createdonbehalfby_1M = "lk_webresourcebase_createdonbehalfby";
        public const string lk_webresourcebase_modifiedonbehalfby_1M = "lk_webresourcebase_modifiedonbehalfby";
        public const string lk_webwizard_createdby_1M = "lk_webwizard_createdby";
        public const string lk_webwizard_createdonbehalfby_1M = "lk_webwizard_createdonbehalfby";
        public const string lk_webwizard_modifiedby_1M = "lk_webwizard_modifiedby";
        public const string lk_webwizard_modifiedonbehalfby_1M = "lk_webwizard_modifiedonbehalfby";
        public const string lk_wizardaccessprivilege_createdby_1M = "lk_wizardaccessprivilege_createdby";
        public const string lk_wizardaccessprivilege_createdonbehalfby_1M = "lk_wizardaccessprivilege_createdonbehalfby";
        public const string lk_wizardaccessprivilege_modifiedby_1M = "lk_wizardaccessprivilege_modifiedby";

        public const string lk_wizardaccessprivilege_modifiedonbehalfby_1M =
            "lk_wizardaccessprivilege_modifiedonbehalfby";

        public const string lk_wizardpage_createdby_1M = "lk_wizardpage_createdby";
        public const string lk_wizardpage_createdonbehalfby_1M = "lk_wizardpage_createdonbehalfby";
        public const string lk_wizardpage_modifiedby_1M = "lk_wizardpage_modifiedby";
        public const string lk_wizardpage_modifiedonbehalfby_1M = "lk_wizardpage_modifiedonbehalfby";
        public const string lk_workflowlog_createdby_1M = "lk_workflowlog_createdby";
        public const string lk_workflowlog_createdonbehalfby_1M = "lk_workflowlog_createdonbehalfby";
        public const string lk_workflowlog_modifiedby_1M = "lk_workflowlog_modifiedby";
        public const string lk_workflowlog_modifiedonbehalfby_1M = "lk_workflowlog_modifiedonbehalfby";
        public const string mailbox_regarding_systemuser_1M = "mailbox_regarding_systemuser";
        public const string middlename = "middlename";
        public const string mobilealertemail = "mobilealertemail";
        public const string mobilephone = "mobilephone";
        public const string modifiedby = "modifiedby";
        public const string modifiedby_attributemap_1M = "modifiedby_attributemap";
        public const string modifiedby_connection_1M = "modifiedby_connection";
        public const string modifiedby_connection_role_1M = "modifiedby_connection_role";
        public const string modifiedby_customer_relationship_1M = "modifiedby_customer_relationship";
        public const string modifiedby_entitymap_1M = "modifiedby_entitymap";
        public const string modifiedby_pluginassembly_1M = "modifiedby_pluginassembly";
        public const string modifiedby_plugintype_1M = "modifiedby_plugintype";
        public const string modifiedby_plugintypestatistic_1M = "modifiedby_plugintypestatistic";
        public const string modifiedby_relationship_role_1M = "modifiedby_relationship_role";
        public const string modifiedby_relationship_role_map_1M = "modifiedby_relationship_role_map";
        public const string modifiedby_sdkmessage_1M = "modifiedby_sdkmessage";
        public const string modifiedby_sdkmessagefilter_1M = "modifiedby_sdkmessagefilter";
        public const string modifiedby_sdkmessagepair_1M = "modifiedby_sdkmessagepair";
        public const string modifiedby_sdkmessageprocessingstep_1M = "modifiedby_sdkmessageprocessingstep";
        public const string modifiedby_sdkmessageprocessingstepimage_1M = "modifiedby_sdkmessageprocessingstepimage";

        public const string modifiedby_sdkmessageprocessingstepsecureconfig_1M =
            "modifiedby_sdkmessageprocessingstepsecureconfig";

        public const string modifiedby_sdkmessagerequest_1M = "modifiedby_sdkmessagerequest";
        public const string modifiedby_sdkmessagerequestfield_1M = "modifiedby_sdkmessagerequestfield";
        public const string modifiedby_sdkmessageresponse_1M = "modifiedby_sdkmessageresponse";
        public const string modifiedby_sdkmessageresponsefield_1M = "modifiedby_sdkmessageresponsefield";
        public const string modifiedby_serviceendpoint_1M = "modifiedby_serviceendpoint";
        public const string modifiedbyname = "modifiedbyname";
        public const string modifiedbyyominame = "modifiedbyyominame";
        public const string modifiedon = "modifiedon";
        public const string modifiedonbehalfby = "modifiedonbehalfby";
        public const string modifiedonbehalfby_attributemap_1M = "modifiedonbehalfby_attributemap";
        public const string modifiedonbehalfby_customer_relationship_1M = "modifiedonbehalfby_customer_relationship";
        public const string modifiedonbehalfbyname = "modifiedonbehalfbyname";
        public const string modifiedonbehalfbyyominame = "modifiedonbehalfbyyominame";

        public const string msdyn_systemuser_wallsavedqueryusersettings_userid_1M =
            "msdyn_systemuser_wallsavedqueryusersettings_userid";

        public const string multientitysearch_createdby_1M = "multientitysearch_createdby";
        public const string multientitysearch_createdonbehalfby_1M = "multientitysearch_createdonbehalfby";
        public const string multientitysearch_modifiedby_1M = "multientitysearch_modifiedby";
        public const string multientitysearch_modifiedonbehalfby_1M = "multientitysearch_modifiedonbehalfby";
        public const string nickname = "nickname";
        public const string opportunity_owning_user_1M = "opportunity_owning_user";
        public const string organization_system_users_M1 = "organization_system_users";
        public const string organizationid = "organizationid";
        public const string organizationidname = "organizationidname";
        public const string outgoingemaildeliverymethod = "outgoingemaildeliverymethod";
        public const string outgoingemaildeliverymethodname = "outgoingemaildeliverymethodname";
        public const string overriddencreatedon = "overriddencreatedon";
        public const string OwnerMapping_SystemUser_1M = "OwnerMapping_SystemUser";
        public const string OwningUser_Dynamicpropertyinsatance_1M = "OwningUser_Dynamicpropertyinsatance";
        public const string parentsystemuserid = "parentsystemuserid";
        public const string parentsystemuseridname = "parentsystemuseridname";
        public const string parentsystemuseridyominame = "parentsystemuseridyominame";
        public const string passporthi = "passporthi";
        public const string passportlo = "passportlo";
        public const string personalemailaddress = "personalemailaddress";
        public const string photourl = "photourl";
        public const string position_users_M1 = "position_users";
        public const string positionid = "positionid";
        public const string positionidname = "positionidname";
        public const string preferredaddresscode = "preferredaddresscode";
        public const string preferredaddresscodename = "preferredaddresscodename";
        public const string preferredemailcode = "preferredemailcode";
        public const string preferredemailcodename = "preferredemailcodename";
        public const string preferredphonecode = "preferredphonecode";
        public const string preferredphonecodename = "preferredphonecodename";
        public const string processid = "processid";
        public const string processstage_systemusers_M1 = "processstage_systemusers";
        public const string queue_primary_user_1M = "queue_primary_user";
        public const string queue_system_user_M1 = "queue_system_user";
        public const string queueid = "queueid";
        public const string queueidname = "queueidname";
        public const string queuemembership_MM = "queuemembership";
        public const string salutation = "salutation";
        public const string setupuser = "setupuser";
        public const string setupusername = "setupusername";
        public const string sharepointemailaddress = "sharepointemailaddress";
        public const string site_system_users_M1 = "site_system_users";
        public const string siteid = "siteid";
        public const string siteidname = "siteidname";
        public const string skills = "skills";
        public const string socialProfile_owning_user_1M = "socialProfile_owning_user";
        public const string stageid = "stageid";
        public const string sup_principalid_systemuser_1M = "sup_principalid_systemuser";
        public const string system_user_accounts_1M = "system_user_accounts";
        public const string system_user_activity_parties_1M = "system_user_activity_parties";
        public const string system_user_asyncoperation_1M = "system_user_asyncoperation";
        public const string system_user_contacts_1M = "system_user_contacts";
        public const string system_user_email_templates_1M = "system_user_email_templates";
        public const string system_user_incidents_1M = "system_user_incidents";
        public const string system_user_invoicedetail_1M = "system_user_invoicedetail";
        public const string system_user_invoices_1M = "system_user_invoices";
        public const string system_user_orders_1M = "system_user_orders";
        public const string system_user_quotas_1M = "system_user_quotas";
        public const string system_user_quotedetail_1M = "system_user_quotedetail";
        public const string system_user_quotes_1M = "system_user_quotes";
        public const string system_user_sales_literature_1M = "system_user_sales_literature";
        public const string system_user_salesorderdetail_1M = "system_user_salesorderdetail";
        public const string system_user_service_appointments_1M = "system_user_service_appointments";
        public const string system_user_service_contracts_1M = "system_user_service_contracts";
        public const string system_user_territories_1M = "system_user_territories";
        public const string system_user_workflow_1M = "system_user_workflow";
        public const string SystemUser_AsyncOperations_1M = "SystemUser_AsyncOperations";
        public const string SystemUser_BulkDeleteFailures_1M = "SystemUser_BulkDeleteFailures";
        public const string SystemUser_Campaigns_1M = "SystemUser_Campaigns";
        public const string systemuser_connections1_1M = "systemuser_connections1";
        public const string systemuser_connections2_1M = "systemuser_connections2";
        // Many To One
        public const string systemuser_defaultmailbox_mailbox_M1 = "systemuser_defaultmailbox_mailbox";
        public const string SystemUser_DuplicateBaseRecord_1M = "SystemUser_DuplicateBaseRecord";
        public const string SystemUser_DuplicateMatchingRecord_1M = "SystemUser_DuplicateMatchingRecord";
        public const string SystemUser_DuplicateRules_1M = "SystemUser_DuplicateRules";
        public const string SystemUser_Email_EmailSender_1M = "SystemUser_Email_EmailSender";
        public const string SystemUser_ImportData_1M = "SystemUser_ImportData";
        public const string SystemUser_ImportFiles_1M = "SystemUser_ImportFiles";
        public const string SystemUser_ImportLogs_1M = "SystemUser_ImportLogs";
        public const string SystemUser_ImportMaps_1M = "SystemUser_ImportMaps";
        public const string SystemUser_Imports_1M = "SystemUser_Imports";
        public const string systemuser_internal_addresses_1M = "systemuser_internal_addresses";
        public const string systemuser_PostFollows_1M = "systemuser_PostFollows";
        public const string systemuser_PostRegardings_1M = "systemuser_PostRegardings";
        public const string systemuser_PostRoles_1M = "systemuser_PostRoles";
        public const string systemuser_principalobjectattributeaccess_1M = "systemuser_principalobjectattributeaccess";
        // One To Many Relationships
        public const string systemuser_principalobjectattributeaccess_principalid_1M =
            "systemuser_principalobjectattributeaccess_principalid";

        public const string SystemUser_ProcessSessions_1M = "SystemUser_ProcessSessions";
        public const string systemuser_resources_1M = "systemuser_resources";

        public const string systemuserbusinessunitentitymap_systemuserid_systemuser_1M =
            "systemuserbusinessunitentitymap_systemuserid_systemuser";

        public const string systemuserid = "systemuserid";
        // Many To Many
        public const string systemuserprofiles_MM = "systemuserprofiles";
        public const string systemuserroles_MM = "systemuserroles";
        public const string systemusersyncmappingprofiles_MM = "systemusersyncmappingprofiles";
        public const string teammembership_MM = "teammembership";
        public const string territory_system_users_M1 = "territory_system_users";
        public const string territoryid = "territoryid";
        public const string territoryidname = "territoryidname";
        public const string timezoneruleversionnumber = "timezoneruleversionnumber";
        public const string title = "title";
        public const string TransactionCurrency_SystemUser_M1 = "TransactionCurrency_SystemUser";
        public const string transactioncurrencyid = "transactioncurrencyid";
        public const string transactioncurrencyidname = "transactioncurrencyidname";
        //Fields
        public const string traversedpath = "traversedpath";
        public const string user_accounts_1M = "user_accounts";
        public const string user_activity_1M = "user_activity";
        public const string user_appointment_1M = "user_appointment";
        public const string user_BulkOperation_1M = "user_BulkOperation";
        public const string user_campaignactivity_1M = "user_campaignactivity";
        public const string user_campaignresponse_1M = "user_campaignresponse";
        public const string user_convertrule_1M = "user_convertrule";
        public const string user_customer_opportunity_roles_1M = "user_customer_opportunity_roles";
        public const string user_customer_relationship_1M = "user_customer_relationship";
        public const string user_email_1M = "user_email";
        public const string user_entitlement_1M = "user_entitlement";
        public const string user_exchangesyncidmapping_1M = "user_exchangesyncidmapping";
        public const string user_fax_1M = "user_fax";
        public const string user_goal_1M = "user_goal";
        public const string user_goal_goalowner_1M = "user_goal_goalowner";
        public const string user_incidentresolution_1M = "user_incidentresolution";
        public const string user_letter_1M = "user_letter";
        public const string user_list_1M = "user_list";
        public const string user_mailbox_1M = "user_mailbox";
        public const string user_msdyn_postalbum_1M = "user_msdyn_postalbum";
        public const string user_msdyn_wallsavedqueryusersettings_1M = "user_msdyn_wallsavedqueryusersettings";
        public const string user_opportunityclose_1M = "user_opportunityclose";
        public const string user_orderclose_1M = "user_orderclose";
        public const string user_owner_postfollows_1M = "user_owner_postfollows";
        public const string user_parent_user_1M = "user_parent_user";
        public const string user_parent_user_M1 = "user_parent_user";
        public const string user_phonecall_1M = "user_phonecall";
        public const string user_quoteclose_1M = "user_quoteclose";
        public const string user_recurringappointmentmaster_1M = "user_recurringappointmentmaster";
        public const string user_routingrule_1M = "user_routingrule";
        public const string user_routingruleitem_1M = "user_routingruleitem";
        public const string user_settings_1M = "user_settings";
        public const string user_sharepointdocumentlocation_1M = "user_sharepointdocumentlocation";
        public const string user_sharepointsite_1M = "user_sharepointsite";
        public const string user_slabase_1M = "user_slabase";
        public const string user_socialactivity_1M = "user_socialactivity";
        public const string user_task_1M = "user_task";
        public const string user_userapplicationmetadata_1M = "user_userapplicationmetadata";
        public const string user_userform_1M = "user_userform";
        public const string user_userquery_1M = "user_userquery";
        public const string user_userqueryvisualizations_1M = "user_userqueryvisualizations";
        public const string userentityinstancedata_owning_user_1M = "userentityinstancedata_owning_user";
        public const string userentityinstancedata_systemuser_1M = "userentityinstancedata_systemuser";
        public const string userentityuisettings_owning_user_1M = "userentityuisettings_owning_user";
        public const string userlicensetype = "userlicensetype";
        public const string utcconversiontimezonecode = "utcconversiontimezonecode";
        public const string versionnumber = "versionnumber";
        public const string webresource_createdby_1M = "webresource_createdby";
        public const string webresource_modifiedby_1M = "webresource_modifiedby";
        public const string windowsliveid = "windowsliveid";
        public const string workflow_createdby_1M = "workflow_createdby";
        public const string workflow_createdonbehalfby_1M = "workflow_createdonbehalfby";
        public const string workflow_dependency_createdby_1M = "workflow_dependency_createdby";
        public const string workflow_dependency_createdonbehalfby_1M = "workflow_dependency_createdonbehalfby";
        public const string workflow_dependency_modifiedby_1M = "workflow_dependency_modifiedby";
        public const string workflow_dependency_modifiedonbehalfby_1M = "workflow_dependency_modifiedonbehalfby";
        public const string workflow_modifiedby_1M = "workflow_modifiedby";
        public const string workflow_modifiedonbehalfby_1M = "workflow_modifiedonbehalfby";
        public const string yammeremailaddress = "yammeremailaddress";
        public const string yammeruserid = "yammeruserid";
        public const string yomifirstname = "yomifirstname";
        public const string yomifullname = "yomifullname";
        public const string yomilastname = "yomilastname";
        public const string yomimiddlename = "yomimiddlename";
    }

    public class systemuser_enums
    {
        public enum accessmode
        {
            Administrative = 1,
            Non_interactive = 4,
            Read = 2,
            Read_Write = 0,
            Support_User = 3
        }

        public enum address1_addresstypecode
        {
            Default_Value = 1
        }

        public enum address1_shippingmethodcode
        {
            Default_Value = 1
        }

        public enum address2_addresstypecode
        {
            Default_Value = 1
        }

        public enum address2_shippingmethodcode
        {
            Default_Value = 1
        }

        public enum caltype
        {
            Administrative = 1,
            Basic = 2,
            Device_Basic = 4,
            Device_Enterprise = 8,
            Device_Essential = 6,
            Device_Professional = 3,
            Enterprise = 7,
            Essential = 5,
            Professional = 0
        }

        public enum emailrouteraccessapproval
        {
            Approved = 1,
            Empty = 0,
            Pending_Approval = 2,
            Rejected = 3
        }

        public enum incomingemaildeliverymethod
        {
            Forward_Mailbox = 3,
            Microsoft_Dynamics_CRM_for_Outlook = 1,
            None = 0,
            Server_Side_Synchronization_or_Email_Router = 2
        }

        public enum invitestatuscode
        {
            Invitation_Accepted = 4,
            Invitation_Expired = 3,
            Invitation_Near_Expired = 2,
            Invitation_Not_Sent = 0,
            Invitation_Rejected = 5,
            Invitation_Revoked = 6,
            Invited = 1
        }

        public enum outgoingemaildeliverymethod
        {
            Microsoft_Dynamics_CRM_for_Outlook = 1,
            None = 0,
            Server_Side_Synchronization_or_Email_Router = 2
        }

        public enum preferredaddresscode
        {
            Mailing_Address = 1,
            Other_Address = 2
        }

        public enum preferredemailcode
        {
            Default_Value = 1
        }

        public enum preferredphonecode
        {
            Home_Phone = 3,
            Main_Phone = 1,
            Mobile_Phone = 4,
            Other_Phone = 2
        }
    }

    #endregion

    #region  "System User Roles"

    public class systemuserroles
    {
        public const string roleid = "roleid";
        public const string systemuserid = "systemuserid";
        public const string systemuserroleid = "systemuserroleid";
        // Many To Many
        public const string systemuserroles_MM = "systemuserroles";
        //Fields
        public const string versionnumber = "versionnumber";
    }

    #endregion

    #region "Transaction Currency"

    public class transactioncurrency
    {
        public const string basecurrency_organization_1M = "basecurrency_organization";
        //Fields
        public const string createdby = "createdby";
        public const string createdbyname = "createdbyname";
        public const string createdbyyominame = "createdbyyominame";
        public const string createdon = "createdon";
        public const string createdonbehalfby = "createdonbehalfby";
        public const string createdonbehalfbyname = "createdonbehalfbyname";
        public const string createdonbehalfbyyominame = "createdonbehalfbyyominame";
        public const string currencyname = "currencyname";
        public const string currencyprecision = "currencyprecision";
        public const string currencysymbol = "currencysymbol";

        public const string DynamicPropertyAssociation_TransactionCurrency_1M =
            "DynamicPropertyAssociation_TransactionCurrency";

        public const string DynamicPropertyOptionSetItem_TransactionCurrency_1M =
            "DynamicPropertyOptionSetItem_TransactionCurrency";

        public const string entityimage = "entityimage";
        public const string entityimage_timestamp = "entityimage_timestamp";
        public const string entityimage_url = "entityimage_url";
        public const string entityimageid = "entityimageid";
        public const string exchangerate = "exchangerate";
        public const string importsequencenumber = "importsequencenumber";
        public const string isocurrencycode = "isocurrencycode";
        public const string lk_transactioncurrency_createdonbehalfby_M1 = "lk_transactioncurrency_createdonbehalfby";
        public const string lk_transactioncurrency_entityimage_M1 = "lk_transactioncurrency_entityimage";
        public const string lk_transactioncurrency_modifiedonbehalfby_M1 = "lk_transactioncurrency_modifiedonbehalfby";
        // Many To One
        public const string lk_transactioncurrencybase_createdby_M1 = "lk_transactioncurrencybase_createdby";
        public const string lk_transactioncurrencybase_modifiedby_M1 = "lk_transactioncurrencybase_modifiedby";
        public const string modifiedby = "modifiedby";
        public const string modifiedbyname = "modifiedbyname";
        public const string modifiedbyyominame = "modifiedbyyominame";
        public const string modifiedon = "modifiedon";
        public const string modifiedonbehalfby = "modifiedonbehalfby";
        public const string modifiedonbehalfbyname = "modifiedonbehalfbyname";
        public const string modifiedonbehalfbyyominame = "modifiedonbehalfbyyominame";
        public const string organization_transactioncurrencies_M1 = "organization_transactioncurrencies";
        public const string organizationid = "organizationid";
        public const string overriddencreatedon = "overriddencreatedon";
        public const string statecode = "statecode";
        public const string statecodename = "statecodename";
        public const string statuscode = "statuscode";
        public const string statuscodename = "statuscodename";
        public const string transactioncurrency_account_1M = "transactioncurrency_account";
        public const string TransactionCurrency_ActivityPointer_1M = "TransactionCurrency_ActivityPointer";
        public const string transactioncurrency_annualfiscalcalendar_1M = "transactioncurrency_annualfiscalcalendar";
        public const string TransactionCurrency_Appointment_1M = "TransactionCurrency_Appointment";
        public const string TransactionCurrency_AsyncOperations_1M = "TransactionCurrency_AsyncOperations";
        public const string TransactionCurrency_BusinessUnit_1M = "TransactionCurrency_BusinessUnit";
        public const string transactioncurrency_campaign_1M = "transactioncurrency_campaign";
        public const string transactioncurrency_campaignactivity_1M = "transactioncurrency_campaignactivity";
        public const string TransactionCurrency_CampaignResponse_1M = "TransactionCurrency_CampaignResponse";
        public const string transactioncurrency_competitor_1M = "transactioncurrency_competitor";
        public const string TransactionCurrency_Connection_1M = "TransactionCurrency_Connection";
        public const string transactioncurrency_contact_1M = "transactioncurrency_contact";
        public const string transactioncurrency_contract_1M = "transactioncurrency_contract";
        public const string transactioncurrency_contractdetail_1M = "transactioncurrency_contractdetail";
        public const string TransactionCurrency_ConvertRule_1M = "TransactionCurrency_ConvertRule";
        public const string transactioncurrency_convertruleitem_1M = "transactioncurrency_convertruleitem";
        public const string TransactionCurrency_CustomerAddress_1M = "TransactionCurrency_CustomerAddress";
        public const string transactioncurrency_discount_1M = "transactioncurrency_discount";
        public const string transactioncurrency_discounttype_1M = "transactioncurrency_discounttype";
        public const string TransactionCurrency_DuplicateBaseRecord_1M = "TransactionCurrency_DuplicateBaseRecord";

        public const string TransactionCurrency_DuplicateMatchingRecord_1M =
            "TransactionCurrency_DuplicateMatchingRecord";

        public const string TransactionCurrency_Dynamicpropertyinsatance_1M =
            "TransactionCurrency_Dynamicpropertyinsatance";

        public const string TransactionCurrency_Email_1M = "TransactionCurrency_Email";
        public const string TransactionCurrency_Entitlement_1M = "TransactionCurrency_Entitlement";
        public const string TransactionCurrency_entitlementchannel_1M = "TransactionCurrency_entitlementchannel";
        public const string TransactionCurrency_entitlementtemplate_1M = "TransactionCurrency_entitlementtemplate";

        public const string TransactionCurrency_entitlementtemplatechannel_1M =
            "TransactionCurrency_entitlementtemplatechannel";

        public const string TransactionCurrency_Equipment_1M = "TransactionCurrency_Equipment";
        public const string TransactionCurrency_Fax_1M = "TransactionCurrency_Fax";

        public const string transactioncurrency_fixedmonthlyfiscalcalendar_1M =
            "transactioncurrency_fixedmonthlyfiscalcalendar";

        // One To Many Relationships
        public const string TransactionCurrency_Goal_1M = "TransactionCurrency_Goal";
        public const string TransactionCurrency_Incident_1M = "TransactionCurrency_Incident";
        public const string transactioncurrency_invoice_1M = "transactioncurrency_invoice";
        public const string transactioncurrency_invoicedetail_1M = "transactioncurrency_invoicedetail";
        public const string TransactionCurrency_KbArticle_1M = "TransactionCurrency_KbArticle";
        public const string TransactionCurrency_KnowledgeBaseRecord_1M = "TransactionCurrency_KnowledgeBaseRecord";
        public const string transactioncurrency_lead_1M = "transactioncurrency_lead";
        public const string TransactionCurrency_LeadAddress_1M = "TransactionCurrency_LeadAddress";
        public const string TransactionCurrency_Letter_1M = "TransactionCurrency_Letter";
        public const string transactioncurrency_list_1M = "transactioncurrency_list";
        public const string TransactionCurrency_MailMergeTemplate_1M = "TransactionCurrency_MailMergeTemplate";
        public const string transactioncurrency_monthlyfiscalcalendar_1M = "transactioncurrency_monthlyfiscalcalendar";
        public const string transactioncurrency_opportunity_1M = "transactioncurrency_opportunity";
        public const string transactioncurrency_opportunityclose_1M = "transactioncurrency_opportunityclose";
        public const string transactioncurrency_opportunityproduct_1M = "transactioncurrency_opportunityproduct";
        public const string TransactionCurrency_PhoneCall_1M = "TransactionCurrency_PhoneCall";
        public const string transactioncurrency_position_1M = "transactioncurrency_position";
        public const string transactioncurrency_pricelevel_1M = "transactioncurrency_pricelevel";
        public const string TransactionCurrency_ProcessSessions_1M = "TransactionCurrency_ProcessSessions";
        public const string transactioncurrency_product_1M = "transactioncurrency_product";
        public const string transactioncurrency_ProductAssociation_1M = "transactioncurrency_ProductAssociation";
        public const string transactioncurrency_productpricelevel_1M = "transactioncurrency_productpricelevel";
        public const string transactioncurrency_ProductSubstitute_1M = "transactioncurrency_ProductSubstitute";

        public const string transactioncurrency_quarterlyfiscalcalendar_1M =
            "transactioncurrency_quarterlyfiscalcalendar";

        public const string TransactionCurrency_Queue_1M = "TransactionCurrency_Queue";
        public const string TransactionCurrency_QueueItem_1M = "TransactionCurrency_QueueItem";
        public const string transactioncurrency_quote_1M = "transactioncurrency_quote";
        public const string transactioncurrency_quotedetail_1M = "transactioncurrency_quotedetail";

        public const string TransactionCurrency_RecurringAppointmentMaster_1M =
            "TransactionCurrency_RecurringAppointmentMaster";

        public const string TransactionCurrency_ReportCategory_1M = "TransactionCurrency_ReportCategory";
        public const string TransactionCurrency_Routingrule_1M = "TransactionCurrency_Routingrule";
        public const string TransactionCurrency_routingruleitem_1M = "TransactionCurrency_routingruleitem";
        public const string TransactionCurrency_SalesLiterature_1M = "TransactionCurrency_SalesLiterature";
        public const string transactioncurrency_salesorder_1M = "transactioncurrency_salesorder";
        public const string transactioncurrency_salesorderdetail_1M = "transactioncurrency_salesorderdetail";

        public const string transactioncurrency_semiannualfiscalcalendar_1M =
            "transactioncurrency_semiannualfiscalcalendar";

        public const string TransactionCurrency_ServiceAppointment_1M = "TransactionCurrency_ServiceAppointment";
        public const string TransactionCurrency_SharePointDocument_1M = "TransactionCurrency_SharePointDocument";

        public const string TransactionCurrency_SharePointDocumentLocation_1M =
            "TransactionCurrency_SharePointDocumentLocation";

        public const string TransactionCurrency_SharePointSite_1M = "TransactionCurrency_SharePointSite";
        public const string TransactionCurrency_SLA_1M = "TransactionCurrency_SLA";
        public const string TransactionCurrency_SLAItem_1M = "TransactionCurrency_SLAItem";
        public const string TransactionCurrency_slakpiinstance_1M = "TransactionCurrency_slakpiinstance";
        public const string transactioncurrency_socialactivity_1M = "transactioncurrency_socialactivity";
        public const string transactioncurrency_SocialProfile_1M = "transactioncurrency_SocialProfile";
        public const string TransactionCurrency_SystemUser_1M = "TransactionCurrency_SystemUser";
        public const string TransactionCurrency_Task_1M = "TransactionCurrency_Task";
        public const string TransactionCurrency_Team_1M = "TransactionCurrency_Team";
        public const string TransactionCurrency_Territory_1M = "TransactionCurrency_Territory";
        public const string TransactionCurrency_Theme_1M = "TransactionCurrency_Theme";
        public const string TransactionCurrency_tsa_application_1M = "TransactionCurrency_tsa_application";
        public const string TransactionCurrency_tsa_course_1M = "TransactionCurrency_tsa_course";
        public const string transactioncurrency_userfiscalcalendar_1M = "transactioncurrency_userfiscalcalendar";
        public const string TransactionCurrency_UserMapping_1M = "TransactionCurrency_UserMapping";
        public const string transactioncurrency_usersettings_1M = "transactioncurrency_usersettings";
        public const string transactioncurrencyid = "transactioncurrencyid";
        public const string uniquedscid = "uniquedscid";
        public const string userentityinstancedata_transactioncurrency_1M = "userentityinstancedata_transactioncurrency";
        public const string versionnumber = "versionnumber";
    }


    public class transactioncurrency_enums
    {
        public enum statecode
        {
            Active = 0,
            Inactive = 1
        }

        public enum statuscode
        {
            Active = 1,
            Inactive = 2
        }
    }

    #endregion

    #region "workflow"

    public class workflow_enums
    {
        public enum category
        {
            Action = 3,
            Business_Process_Flow = 4,
            Business_Rule = 2,
            Dialog = 1,
            Workflow = 0
        }

        public enum componentstate
        {
            Deleted = 2,
            Deleted_Unpublished = 3,
            Published = 0,
            Unpublished = 1
        }

        public enum createstage
        {
            Post_operation = 40,
            Pre_operation = 20
        }

        public enum deletestage
        {
            Post_operation = 40,
            Pre_operation = 20
        }

        public enum mode
        {
            Background = 0,
            Real_time = 1
        }

        public enum runas
        {
            Calling_User = 1,
            Owner = 0
        }

        public enum scope
        {
            Business_Unit = 2,
            Organization = 4,
            Parent_Child_Business_Units = 3,
            User = 1
        }

        public enum statecode
        {
            Activated = 1,
            Draft = 0
        }

        public enum statuscode
        {
            Activated = 2,
            Draft = 1
        }

        public enum type
        {
            Activation = 2,
            Definition = 1,
            Template = 3
        }

        public enum updatestage
        {
            Post_operation = 40,
            Pre_operation = 20
        }
    }

    public class workflow
    {
        //Fields
        public const string activeworkflowid = "activeworkflowid";
        public const string activeworkflowidname = "activeworkflowidname";
        public const string asyncautodelete = "asyncautodelete";
        public const string asyncautodeletename = "asyncautodeletename";
        public const string business_unit_workflow_M1 = "business_unit_workflow";
        public const string category = "category";
        public const string categoryname = "categoryname";
        public const string clientdata = "clientdata";
        public const string componentstate = "componentstate";
        public const string convertruleitembase_workflowid_1M = "convertruleitembase_workflowid";
        public const string createdby = "createdby";
        public const string createdbyname = "createdbyname";
        public const string createdbyyominame = "createdbyyominame";
        public const string createdon = "createdon";
        public const string createdonbehalfby = "createdonbehalfby";
        public const string createdonbehalfbyname = "createdonbehalfbyname";
        public const string createdonbehalfbyyominame = "createdonbehalfbyyominame";
        public const string createstage = "createstage";
        public const string createstagename = "createstagename";
        public const string deletestage = "deletestage";
        public const string deletestagename = "deletestagename";
        public const string description = "description";
        public const string inputparameters = "inputparameters";
        public const string introducedversion = "introducedversion";
        public const string iscrmuiworkflow = "iscrmuiworkflow";
        public const string iscustomizable = "iscustomizable";
        public const string ismanaged = "ismanaged";
        public const string ismanagedname = "ismanagedname";
        public const string istransacted = "istransacted";
        public const string istransactedname = "istransactedname";
        public const string languagecode = "languagecode";
        public const string lk_asyncoperation_workflowactivationid_1M = "lk_asyncoperation_workflowactivationid";
        public const string lk_processsession_processid_1M = "lk_processsession_processid";
        public const string mode = "mode";
        public const string modename = "modename";
        public const string modifiedby = "modifiedby";
        public const string modifiedbyname = "modifiedbyname";
        public const string modifiedbyyominame = "modifiedbyyominame";
        public const string modifiedon = "modifiedon";
        public const string modifiedonbehalfby = "modifiedonbehalfby";
        public const string modifiedonbehalfbyname = "modifiedonbehalfbyname";
        public const string modifiedonbehalfbyyominame = "modifiedonbehalfbyyominame";
        public const string name = "name";
        public const string ondemand = "ondemand";
        public const string ondemandname = "ondemandname";
        public const string overwritetime = "overwritetime";
        public const string owner_workflows_M1 = "owner_workflows";
        public const string ownerid = "ownerid";
        public const string owneridname = "owneridname";
        public const string owneridtype = "owneridtype";
        public const string owneridyominame = "owneridyominame";
        public const string owningbusinessunit = "owningbusinessunit";
        public const string owningbusinessunitname = "owningbusinessunitname";
        public const string owningteam = "owningteam";
        public const string owninguser = "owninguser";
        public const string parentworkflowid = "parentworkflowid";
        public const string parentworkflowidname = "parentworkflowidname";
        public const string plugintypeid = "plugintypeid";
        public const string primaryentity = "primaryentity";
        public const string primaryentityname = "primaryentityname";
        public const string process_processstage_1M = "process_processstage";
        public const string process_processtrigger_1M = "process_processtrigger";
        public const string processorder = "processorder";
        public const string processroleassignment = "processroleassignment";
        public const string rank = "rank";
        public const string rendererobjecttypecode = "rendererobjecttypecode";
        public const string runas = "runas";
        public const string runasname = "runasname";
        public const string scope = "scope";
        public const string scopename = "scopename";
        public const string sdkmessageid = "sdkmessageid";
        public const string slabase_workflowid_1M = "slabase_workflowid";
        public const string slaitembase_workflowid_1M = "slaitembase_workflowid";
        public const string solutionid = "solutionid";
        public const string statecode = "statecode";
        public const string statecodename = "statecodename";
        public const string statuscode = "statuscode";
        public const string statuscodename = "statuscodename";
        public const string subprocess = "subprocess";
        public const string subprocessname = "subprocessname";
        public const string supportingsolutionid = "supportingsolutionid";
        public const string syncworkflowlogonfailure = "syncworkflowlogonfailure";
        public const string syncworkflowlogonfailurename = "syncworkflowlogonfailurename";
        public const string system_user_workflow_M1 = "system_user_workflow";
        public const string team_workflow_M1 = "team_workflow";
        public const string triggeroncreate = "triggeroncreate";
        public const string triggeroncreatename = "triggeroncreatename";
        public const string triggerondelete = "triggerondelete";
        public const string triggerondeletename = "triggerondeletename";
        public const string triggeronupdateattributelist = "triggeronupdateattributelist";
        public const string type = "type";
        public const string typename = "typename";
        public const string uniquename = "uniquename";
        public const string updatestage = "updatestage";
        public const string updatestagename = "updatestagename";
        public const string userentityinstancedata_workflow_1M = "userentityinstancedata_workflow";
        public const string versionnumber = "versionnumber";
        public const string workflow_active_workflow_1M = "workflow_active_workflow";
        // Many To One
        public const string workflow_active_workflow_M1 = "workflow_active_workflow";
        // One To Many Relationships
        public const string Workflow_Annotation_1M = "Workflow_Annotation";
        public const string workflow_createdby_M1 = "workflow_createdby";
        public const string workflow_createdonbehalfby_M1 = "workflow_createdonbehalfby";
        public const string workflow_dependencies_1M = "workflow_dependencies";
        public const string workflow_modifiedby_M1 = "workflow_modifiedby";
        public const string workflow_modifiedonbehalfby_M1 = "workflow_modifiedonbehalfby";
        public const string workflow_parent_workflow_1M = "workflow_parent_workflow";
        public const string workflow_parent_workflow_M1 = "workflow_parent_workflow";
        public const string Workflow_routingrule_1M = "Workflow_routingrule";
        public const string workflowid = "workflowid";
        public const string workflowid_convertrule_1M = "workflowid_convertrule";
        public const string workflowidunique = "workflowidunique";
        public const string xaml = "xaml";
    }

    #endregion

    #region "solutions"

    [Flags]
    public enum SolutionPackageType
    {
        Entity,
        Report,
        Webresources,
        Workflows,
        Plugins,
        SecurityRoles
    }

    public enum WebResourceType
    {
        Webpage = 1,
        StyleSheetCss = 2,
        Script = 3,
        Data = 4,
        ImagePng = 5,
        ImageJpg = 6,
        ImageGif = 7,
        Silverlight = 8,
        StyleSheet = 9,
        ImageIco = 10
    }

    public enum ComponentType
    {
        Entity = 1,
        Attribute = 2,
        Relationship = 3,
        AttributePicklistValue = 4,
        AttributeLookupValue = 5,
        ViewAttribute = 6,
        LocalizedLabel = 7,
        RelationshipExtraCondition = 8,
        OptionSet = 9,
        EntityRelationship = 10,
        EntityRelationshipRole = 11,
        EntityRelationshipRelationships = 12,
        ManagedProperty = 13,
        Role = 20,
        RolePrivilege = 21,
        DisplayString = 22,
        DisplayStringMap = 23,
        Form = 24,
        Organization = 25,
        SavedQuery = 26,
        Workflow = 29,
        Report = 31,
        ReportEntity = 32,
        ReportCategory = 33,
        ReportVisibility = 34,
        Attachment = 35,
        EmailTemplate = 36,
        ContractTemplate = 37,
        KbArticleTemplate = 38,
        MailMergeTemplate = 39,
        DuplicateRule = 44,
        DuplicateRuleCondition = 45,
        EntityMap = 46,
        AttributeMap = 47,
        RibbonCommand = 48,
        RibbonContextGroup = 49,
        RibbonCustomization = 50,
        RibbonRule = 52,
        RibbonTabToCommandMap = 53,
        RibbonDiff = 55,
        SavedQueryVisualization = 59,
        SystemForm = 60,
        WebResource = 61,
        SiteMap = 62,
        ConnectionRole = 63,
        FieldSecurityProfile = 70,
        FieldPermission = 71,
        PluginType = 90,
        PluginAssembly = 91,
        SdkMessageProcessingStep = 92,
        SdkMessageProcessingStepImage = 93,
        ServiceEndpoint = 95
    }

    public enum SystemFormType
    {
        Dashboard = 0,
        AppointmentBook = 1,
        Main = 2,
        MiniCampaignBo = 3,
        Preview = 4,
        Mobile = 5,
        Other = 100,
        MainBackup = 101,
        AppointmentBookBackup = 102
    }

    public class ParameterName
    {
        public const string DefaultPublisherId = "d21aab71-79e7-11dd-8874-00188b01e34f";
        public const string ParameterXml = "parameterxml";
        public const string Target = "Target";
    }

    public class publisher
    {
        //Fields
        public const string address1_addressid = "address1_addressid";
        public const string address1_addresstypecode = "address1_addresstypecode";
        public const string address1_addresstypecodename = "address1_addresstypecodename";
        public const string address1_city = "address1_city";
        public const string address1_country = "address1_country";
        public const string address1_county = "address1_county";
        public const string address1_fax = "address1_fax";
        public const string address1_latitude = "address1_latitude";
        public const string address1_line1 = "address1_line1";
        public const string address1_line2 = "address1_line2";
        public const string address1_line3 = "address1_line3";
        public const string address1_longitude = "address1_longitude";
        public const string address1_name = "address1_name";
        public const string address1_postalcode = "address1_postalcode";
        public const string address1_postofficebox = "address1_postofficebox";
        public const string address1_shippingmethodcode = "address1_shippingmethodcode";
        public const string address1_shippingmethodcodename = "address1_shippingmethodcodename";
        public const string address1_stateorprovince = "address1_stateorprovince";
        public const string address1_telephone1 = "address1_telephone1";
        public const string address1_telephone2 = "address1_telephone2";
        public const string address1_telephone3 = "address1_telephone3";
        public const string address1_upszone = "address1_upszone";
        public const string address1_utcoffset = "address1_utcoffset";
        public const string address2_addressid = "address2_addressid";
        public const string address2_addresstypecode = "address2_addresstypecode";
        public const string address2_addresstypecodename = "address2_addresstypecodename";
        public const string address2_city = "address2_city";
        public const string address2_country = "address2_country";
        public const string address2_county = "address2_county";
        public const string address2_fax = "address2_fax";
        public const string address2_latitude = "address2_latitude";
        public const string address2_line1 = "address2_line1";
        public const string address2_line2 = "address2_line2";
        public const string address2_line3 = "address2_line3";
        public const string address2_longitude = "address2_longitude";
        public const string address2_name = "address2_name";
        public const string address2_postalcode = "address2_postalcode";
        public const string address2_postofficebox = "address2_postofficebox";
        public const string address2_shippingmethodcode = "address2_shippingmethodcode";
        public const string address2_shippingmethodcodename = "address2_shippingmethodcodename";
        public const string address2_stateorprovince = "address2_stateorprovince";
        public const string address2_telephone1 = "address2_telephone1";
        public const string address2_telephone2 = "address2_telephone2";
        public const string address2_telephone3 = "address2_telephone3";
        public const string address2_upszone = "address2_upszone";
        public const string address2_utcoffset = "address2_utcoffset";
        public const string createdby = "createdby";
        public const string createdbyname = "createdbyname";
        public const string createdon = "createdon";
        public const string createdonbehalfby = "createdonbehalfby";
        public const string createdonbehalfbyname = "createdonbehalfbyname";
        public const string createdonbehalfbyyominame = "createdonbehalfbyyominame";
        public const string customizationoptionvalueprefix = "customizationoptionvalueprefix";
        public const string customizationprefix = "customizationprefix";
        public const string description = "description";
        public const string emailaddress = "emailaddress";
        public const string friendlyname = "friendlyname";
        public const string isreadonly = "isreadonly";
        // Many To One
        public const string lk_publisher_createdby_M1 = "lk_publisher_createdby";
        public const string lk_publisher_modifiedby_M1 = "lk_publisher_modifiedby";
        public const string lk_publisherbase_createdonbehalfby_M1 = "lk_publisherbase_createdonbehalfby";
        public const string lk_publisherbase_modifiedonbehalfby_M1 = "lk_publisherbase_modifiedonbehalfby";
        public const string modifiedby = "modifiedby";
        public const string modifiedbyname = "modifiedbyname";
        public const string modifiedon = "modifiedon";
        public const string modifiedonbehalfby = "modifiedonbehalfby";
        public const string modifiedonbehalfbyname = "modifiedonbehalfbyname";
        public const string modifiedonbehalfbyyominame = "modifiedonbehalfbyyominame";
        public const string organization_publisher_M1 = "organization_publisher";
        public const string organizationid = "organizationid";
        public const string organizationidname = "organizationidname";
        public const string pinpointpublisherdefaultlocale = "pinpointpublisherdefaultlocale";
        public const string pinpointpublisherid = "pinpointpublisherid";
        // One To Many Relationships
        public const string Publisher_PublisherAddress_1M = "Publisher_PublisherAddress";
        public const string publisher_solution_1M = "publisher_solution";
        public const string publisherid = "publisherid";
        public const string supportingwebsiteurl = "supportingwebsiteurl";
        public const string uniquename = "uniquename";
        public const string userentityinstancedata_publisher_1M = "userentityinstancedata_publisher";
        public const string versionnumber = "versionnumber";
    }


    public class solution
    {
        //Fields
        public const string configurationpageid = "configurationpageid";
        public const string configurationpageidname = "configurationpageidname";
        public const string createdby = "createdby";
        public const string createdbyname = "createdbyname";
        public const string createdon = "createdon";
        public const string createdonbehalfby = "createdonbehalfby";
        public const string createdonbehalfbyname = "createdonbehalfbyname";
        public const string createdonbehalfbyyominame = "createdonbehalfbyyominame";
        public const string description = "description";
        public const string friendlyname = "friendlyname";
        public const string installedon = "installedon";
        public const string ismanaged = "ismanaged";
        public const string ismanagedname = "ismanagedname";
        public const string isvisible = "isvisible";
        // Many To One
        public const string lk_solution_createdby_M1 = "lk_solution_createdby";
        public const string lk_solution_modifiedby_M1 = "lk_solution_modifiedby";
        public const string lk_solutionbase_createdonbehalfby_M1 = "lk_solutionbase_createdonbehalfby";
        public const string lk_solutionbase_modifiedonbehalfby_M1 = "lk_solutionbase_modifiedonbehalfby";
        public const string modifiedby = "modifiedby";
        public const string modifiedbyname = "modifiedbyname";
        public const string modifiedon = "modifiedon";
        public const string modifiedonbehalfby = "modifiedonbehalfby";
        public const string modifiedonbehalfbyname = "modifiedonbehalfbyname";
        public const string modifiedonbehalfbyyominame = "modifiedonbehalfbyyominame";
        public const string organization_solution_M1 = "organization_solution";
        public const string organizationid = "organizationid";
        public const string organizationidname = "organizationidname";
        public const string pinpointassetid = "pinpointassetid";
        public const string pinpointpublisherid = "pinpointpublisherid";
        public const string pinpointsolutiondefaultlocale = "pinpointsolutiondefaultlocale";
        public const string pinpointsolutionid = "pinpointsolutionid";
        public const string publisher_solution_M1 = "publisher_solution";
        public const string publisherid = "publisherid";
        public const string publisheridname = "publisheridname";
        public const string publisheridoptionvalueprefix = "publisheridoptionvalueprefix";
        public const string publisheridprefix = "publisheridprefix";
        public const string solution_base_dependencynode_1M = "solution_base_dependencynode";
        public const string solution_configuration_webresource_M1 = "solution_configuration_webresource";
        // One To Many Relationships
        public const string solution_solutioncomponent_1M = "solution_solutioncomponent";
        public const string solution_top_dependencynode_1M = "solution_top_dependencynode";
        public const string solutionid = "solutionid";
        public const string uniquename = "uniquename";
        public const string userentityinstancedata_solution_1M = "userentityinstancedata_solution";
        public const string version = "version";
        public const string versionnumber = "versionnumber";
    }


    public class solution_enums
    {
    }

    #endregion
}