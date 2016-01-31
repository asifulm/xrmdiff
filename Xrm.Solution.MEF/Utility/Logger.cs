// ***********************************************************************
// Assembly         : Activity.Framework
// Author           : asifulm
// Created          : 05-10-2015
//
// Last Modified By : asifulm
// Last Modified On : 05-15-2015
// ***********************************************************************

using System;
using System.Diagnostics;

namespace Xrm.Solution.Log
{
    /// <summary>
    /// The trace level
    /// </summary>
    public enum TraceLevel
    {
        /// <summary>
        /// The verbose
        /// </summary>
        Verbose = 0,
        /// <summary>
        /// The error
        /// </summary>
        Error = 1,
        /// <summary>
        /// The warning
        /// </summary>
        Warning = 2,
        /// <summary>
        /// The success
        /// </summary>
        Success = 3,
        /// <summary>
        /// The information
        /// </summary>
        Information = 4
    }

    /// <summary>
    /// Class Logger.
    /// </summary>
    public class Logger
    {
        /// <summary>
        /// Writes informational message
        /// </summary>
        /// <value>The information.</value>
        public Func<string, bool> Information { get; set; }

        /// <summary>
        /// Writes error message
        /// </summary>
        /// <value>The error.</value>
        public Func<string, Exception, bool> Error { get; set; }

        /// <summary>
        /// Writes warning message
        /// </summary>
        /// <value>The warning.</value>
        public Func<string, bool> Warning { get; set; }

        /// <summary>
        /// Writes success message
        /// </summary>
        /// <value>The success.</value>
        public Func<string, bool> Success { get; set; }

        /// <summary>
        /// Writes verbose message
        /// </summary>
        /// <value>The verbose.</value>
        public Func<string, bool> Verbose { get; set; }


        /// <summary>
        /// Gets or sets if tracing is enabled.
        /// </summary>
        /// <value><c>true</c> if [tracing enabled]; otherwise, <c>false</c>.</value>
        public bool TracingEnabled { get; set; }

        /// <summary>
        /// Gets the static instance of the logger.
        /// </summary>
        private static readonly Logger LoggerInstance = new Logger();
        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <value>The instance.</value>
        public static Logger Instance
        {
            get
            {
                return LoggerInstance;
            }
        }

        /// <summary>
        /// Writes date time and the error level
        /// </summary>
        /// <param name="level">The level.</param>
        /// <param name="message">The string message to be flushed.</param>
        /// <returns>True if successfully flushed.</returns>
        public bool Trace(TraceLevel level, string message)
        {
            if (!TracingEnabled) return true;

            if (level == TraceLevel.Information && Information != null)
                return Information(message);
            else if (level == TraceLevel.Success && Success != null)
                Success(message);
            else if (level == TraceLevel.Warning && Warning != null)
                return Warning(message);
            else if (level == TraceLevel.Verbose && Verbose != null)
                Verbose(message);

            return false;
        }

        /// <summary>
        /// Traces the specified level.
        /// </summary>
        /// <param name="level">The level.</param>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        /// <returns><c>true</c> if trace is succefully flushed, <c>false</c> otherwise.</returns>
        public bool Trace(TraceLevel level, string message, Exception exception)
        {
            if (level == TraceLevel.Error && Error != null)
                return Error(message, exception);

            return false;
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Logger()
        {
            Verbose = message =>
            {
#if DEBUG
                Debug.WriteLine(message);
#endif
                return true;
            };
            Success = Verbose;
            Error = (message, exception) =>
            {
#if DEBUG
                Debug.WriteLine(message + ".{0}", exception.StackTrace);
                return true;
#endif
            };
            Warning = Verbose;
            Information = Verbose;
#if DEBUG
            TracingEnabled = true;
#endif
        }
    }
}
