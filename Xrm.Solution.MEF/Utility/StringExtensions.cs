// ***********************************************************************
// Assembly         : Activity.Framework
// Created          : 05-10-2015
//
// Last Modified By : asifulm
// Last Modified On : 05-16-2015
// ***********************************************************************


using System;
using Xrm.Solution.Log;

namespace Xrm.Solution.Common
{
    /// <summary>
    ///     Class FrameworkExtensions.
    /// </summary>
    public static class FrameworkExtensions
    {
        /// <summary>
        ///     Writes trace information
        /// </summary>
        /// <param name="message">The string message to be printed.</param>
        /// <param name="level">The type of of information such as error, information, verbose, warning etc.</param>
        /// <param name="args">The arguments.</param>
        /// <returns>True if successfully printed.</returns>
        public static bool Trace(this string message, TraceLevel level, params object[] args)
        {
            message = string.Format(message, args);
            return Logger.Instance.Trace(level, message);
        }

        /// <summary>
        ///     Writes trace information
        /// </summary>
        /// <param name="message">The string message to be printed.</param>
        /// <param name="args">The arguments.</param>
        /// <returns>True if successfully printed.</returns>
        public static bool Trace(this string message, params object[] args)
        {
            message = string.Format(message, args);
            return Logger.Instance.Trace(TraceLevel.Information, message);
        }

        /// <summary>
        ///     Writes trace information
        /// </summary>
        /// <param name="message">The string message to be printed.</param>
        /// <param name="args">The arguments.</param>
        /// <returns>True if successfully printed.</returns>
        public static bool TraceVerbose(this string message, params object[] args)
        {
            message = string.Format(message, args);
            return Logger.Instance.Trace(TraceLevel.Verbose, message);
        }

        /// <summary>
        ///     Writes trace information
        /// </summary>
        /// <param name="message">The string message to be printed.</param>
        /// <returns>True if successfully printed.</returns>
        public static bool TraceError(this string message)
        {
            return Logger.Instance.Trace(TraceLevel.Error, message);
        }

        /// <summary>
        ///     Writes trace information
        /// </summary>
        /// <param name="message">The string message to be printed.</param>
        /// <param name="exception">The exception.</param>
        /// <returns>True if successfully printed.</returns>
        public static bool TraceError(this string message, Exception exception)
        {
            return Logger.Instance.Trace(TraceLevel.Error, message, exception);
        }

        /// <summary>
        ///     Writes trace information
        /// </summary>
        /// <param name="message">The string message to be printed.</param>
        /// <param name="args">The arguments.</param>
        /// <returns>True if successfully printed.</returns>
        public static bool TraceSuccess(this string message, params object[] args)
        {
            message = string.Format(message, args);
            return Logger.Instance.Trace(TraceLevel.Success, message);
        }

        /// <summary>
        ///     Converts the string to variable name
        /// </summary>
        /// <param name="text">The string to convert</param>
        /// <returns>The variable name</returns>
        public static string ToVariableName(this string text)
        {
            var characters = new char[text.Length + 1];

            characters[0] = '_';
            for (var index = 0; index < text.Length; index++)
            {
                if (!char.IsDigit(text[index]) && !char.IsLetter(text[index]))
                {
                    characters[index + 1] = '_';
                }
                else
                {
                    characters[index + 1] = text[index];
                }
            }

            return new string(characters);
        }

        /// <summary>
        /// To the name of the unique.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="replaceOddWith">The character that will replace other unwanted chars.</param>
        /// <returns>System.String.</returns>
        public static string ToUniqueName(this string text, char replaceOddWith = '_')
        {
            var characters = new char[text.Length];

            for (var index = 0; index < text.Length; index++)
            {
                if (!char.IsDigit(text[index]) && !char.IsLetter(text[index]))
                {
                   characters[index] = replaceOddWith;
                }
                else
                {
                    characters[index] = text[index];
                }
            }

            return new string(characters);
        }

        /// <summary>
        ///     Converts the string to unique path
        /// </summary>
        /// <param name="text">The text to convert</param>
        /// <returns>The unique path</returns>
        public static string ToUniquePath(this string text)
        {
            var characters = new char[text.Length];

            for (var index = 0; index < text.Length; index++)
            {
                if (!char.IsDigit(text[index]) 
                    && !char.IsLetter(text[index]) 
                    && text[index] != '.')
                {
                    if (text[index] == '\\')
                        characters[index] = '/';
                    else
                        characters[index] = '_';
                }
                else
                {
                    characters[index] = char.ToLower(text[index]);
                }
            }

            return new string(characters);
        }

        /// <summary>
        /// Converts the url to a valid Uri
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <param name="appendSuffix">The append suffix.</param>
        /// <returns>Uri.</returns>
        /// <exception cref="System.ArgumentException">The url provided [ + url + ] is not valid.</exception>
        public static Uri ToUri(this string url, Func<string, string> appendSuffix)
        {
            Uri uri;
            var isValid = true;

            url = url.EndsWith("/") ? url.Remove(url.Length - 1, 1) : url;

            if (appendSuffix != null)
                url = appendSuffix(url);

            isValid &= Uri.TryCreate(url, UriKind.Absolute, out uri)
                          && (string.Compare(uri.Scheme, "http", StringComparison.OrdinalIgnoreCase) == 0
                              || string.Compare(uri.Scheme, "https", StringComparison.OrdinalIgnoreCase) == 0);

            if (!isValid)
                throw new ArgumentException("The url provided [" + url + "] is not valid.");

            return uri;
        }
    }
}