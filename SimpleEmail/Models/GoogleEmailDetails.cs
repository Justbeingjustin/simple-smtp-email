﻿namespace SimpleEmail.Models
{
    public class GoogleEmailDetails
    {
        /// <summary>
        /// The username of the google account. Example: test@gmail.com
        /// </summary>
        public string GoogleUserName { get; set; }

        /// <summary>
        /// The password of the google account
        /// </summary>
        public string GooglePassword { get; set; }

        /// <summary>
        /// The email that will be used to send the message
        /// </summary>
        public string From { get; set; }

        /// <summary>
        /// The receipient of the email
        /// </summary>
        public string To { get; set; }

        /// <summary>
        /// The subject of the email
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// The body of the email
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// allow the body of the message to be html
        /// </summary>
        public bool IsBodyHtml { get; set; }
    }
}