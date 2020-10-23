using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AAInfo
{

    /*AAInfo  -ErrorReporter
     * - Version 1.0
    * Created: 10/22/2020
    * Updated: 10/23/2020
    * Designed by: Kevin Sherman at Acrelec America
    * Contact at: Kevin@Metadevdigital.com
    * 
    * Copyright Copyright MIT Liscenece  - Enjoy boys, keep updating without me. Fork to your hearts content
    */

    public class ErrorReporter
    {
        private string software;
        private Email emailSettings;
        private frmMail mailForm;

        /// <summary>
        /// Default ErrorReporter constructor to build a frmMail object. This assumes a default email configuration and sets a vague software name.
        /// </summary>
        /// <see cref="Email"/>
        /// <see cref="mailForm"/>
        public ErrorReporter()
        {
            software = "Acrelec America Software";
            emailSettings = new Email();
            mailForm = new frmMail(software, emailSettings);
        }

        /// <summary>
        ///  ErrorReporter constructor to build a frmMail object with default email configuration and a provided software name.
        /// </summary>
        /// <param name="softwareName">String of software name</param>
        /// <see cref="Email"/>
        /// <see cref="mailForm"/>
        public ErrorReporter(string softwareName)
        {
            software = softwareName;
            emailSettings = new Email();
            mailForm = new frmMail(software, emailSettings);
        }

        /// <summary>
        /// Default ErrorReporter constructor to build a frmMail object with custom email configuration and a provided software name
        /// </summary>
        /// <param name="softwareName">String of software name</param>
        /// <param name="customEmail">Email class object preconstructed with non-standard paramaters</param>
        /// <see cref="Email"/>
        /// <see cref="mailForm"/>
        public ErrorReporter(string softwareName, Email customEmail)
        {
            software = softwareName;
            emailSettings = customEmail;
            mailForm = new frmMail(software, emailSettings);
        }

        /// <summary>
        /// Displays the frmMail window
        /// </summary>
        public void showForm()
        {
            mailForm.ShowDialog();
        }
    }
}
