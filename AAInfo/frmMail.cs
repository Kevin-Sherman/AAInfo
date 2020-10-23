using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*AAInfo  -frmMail- Version 1.0
* Created: 10/22/2020
* Updated: 10/23/2020
* Designed by: Kevin Sherman at Acrelec America
* Contact at: Kevin@Metadevdigital.com
* 
* Copyright Copyright MIT Liscenece  - Enjoy boys, keep updating without me. Fork to your hearts content
*/

namespace AAInfo
{
    public partial class frmMail : Form
    {
        private Email fromEmail;
        private string software;

        public frmMail()
        {
            fromEmail = new Email();
            software = "Acrelec America Software";
            InitializeComponent();
        }

        public frmMail(string softwareName, Email email)
        {
            fromEmail = email;
            software = softwareName;
            InitializeComponent();
        }

        private void frmMail_Load(object sender, EventArgs e)
        {
            txtMessage.Focus();
        }

        /// <summary>
        /// Handles the sending of messages to the proper channels through an email. Tests and makes sure that there is 
        /// actually a message to be sent, then calls a function to handle the actual sending of the emails
        /// </summary>
        /// <param name="sender">frmMail</param>
        /// <param name="e">btnSubmit</param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtMessage.Text.Equals(""))
            {
                var selection = MessageBox.Show("Empty reports will not be sent.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (selection == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                sendEmail(txtMessage.Text);
                this.Close();
            }
        }

        /// <summary>
        /// Creates default mail client based  off of proper information. Attaches the message typed in the text
        /// box as the message of the email and sends it to an account monitored for trouble-shooting.
        /// 
        /// Allows retry of sending messaages based off user input in case error occurs during sending. Loops
        /// through this process until a message is successfully sent or the user says so.
        /// </summary>
        /// <param name="message">txtMessage's text sent. Already checked and verified to not be empty.</param>
        private void sendEmail(string message)
        {
            bool retryOpt = true;
            string subject = software + " Error Report";

            while (retryOpt == true)
            {
                try
                {
                    fromEmail.send(message, subject);
                    retryOpt = false;
                    MessageBox.Show("Message sent successfully!", "Message Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SmtpException)
                {
                    var selection = MessageBox.Show("An unexpected error occured while trying to send the message. Do you have an " +
                        "active internet connection, or has a firewall setting been changed for your network?", "Error",
                        MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                    if (selection == DialogResult.Retry)
                    {
                        retryOpt = true;
                    }
                    else
                    {
                        retryOpt = false;
                    }
                }
            }
        }
    }
}
