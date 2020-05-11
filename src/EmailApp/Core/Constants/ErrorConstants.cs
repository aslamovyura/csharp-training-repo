﻿namespace Core.Constants
{
    /// <summary>
    /// Define class containing constants for error messages.
    /// </summary>
    public class ErrorConstants
    {
        /// <summary>
        /// Email address form is not correct.
        /// </summary>
        public const string EmailFormatIssues = "Email address format is not valid!";

        /// <summary>
        /// SMTP server address is not correct.
        /// </summary>
        public const string ServerFormatIssues = "SMTP server address is not valid!";

        /// <summary>
        /// SMTP port is out of range.
        /// </summary>
        public const string ServerPortIssues = "Server port value is out of range!";

        /// <summary>
        /// Email settings are not found.
        /// </summary>
        public const string EmailSettingsNotFound = "Settings for email service are not found!";

        /// <summary>
        /// Email settings are invalid.
        /// </summary>
        public const string EmailSettingsInvalid = "Settings for email service are not valid!";
    }
}