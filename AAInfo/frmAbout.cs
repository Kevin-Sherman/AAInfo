using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*AAInfo  -frmAbout- Version 1.0
* Created: 10/22/2020
* Updated: 10/22/2020
* Designed by: Kevin Sherman at Acrelec America
* Contact at: Kevin@Metadevdigital.com
* 
* Copyright Copyright MIT Liscenece  - Enjoy boys, keep updating without me. Fork to your hearts content
*/

namespace AAInfo
{

    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Retrieves all of the default text inside of the relevant fields
        /// Not limited to just three fields as long as it is properly accounted for.
        /// </summary>
        /// <returns>String[] of all default text</returns>
        public string[] getText()
        {
            string[] text = new string[3];

            text[0] = rtbText1.Text;
            text[1] = rtbText2.Text;
            text[2] = rtbText3.Text;

            return text;
        }

        /// <summary>
        /// Gets a list of all keys inside of the form.
        /// NOTE: THESE ARE POPULATED MANUALLY
        /// ORDER IS IMPORTANT AND MUST BE RESPECTED
        /// </summary>
        /// <returns>string[] of all relevant keys</returns>
        public string[] getTextKeys()
        {
            string[] keys = new string[4];
            keys[0] = "<<TOOL>>";
            keys[1] = "<<COMPANY>>";
            keys[2] = "<<DESC>>";
            keys[3] = "<<LICENCE>>";

            return keys;
        }

        /// <summary>
        /// Takes processed strings from InfoDisplayer, sending it off to be formatted and set by buildTextBox
        /// </summary>
        /// <param name="replacementText">String[] of text that has been processed and is ready to be imported b ack</param>
        public void setText(string[] replacementText)
        {
            buildTextBox(replacementText[0], rtbText1);
            buildTextBox(replacementText[1], rtbText2);
            buildTextBox(replacementText[2], rtbText3);
        }

        /// <summary>
        /// Takes the formatted text, splitting it off of the selected operator '|' to differentiate between bolded and unbolded sections
        /// </summary>
        /// <param name="input">String that needs to be formatted</param>
        /// <param name="RTF">RichTextBox that the text will be displayed into</param>
        private void buildTextBox(string input, RichTextBox RTF)
        {
            string[] seperated = input.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
            bool isBold = true;
            RTF.Clear();
            foreach (string chunks in seperated)
            {
                if (isBold)
                {
                    RTF.SelectionFont = new Font(rtbText1.Font, FontStyle.Bold);
                    RTF.AppendText(chunks);
                    isBold = false;
                }
                else
                {
                    RTF.SelectionFont = new Font(rtbText1.Font, FontStyle.Regular);
                    RTF.AppendText(chunks);
                    isBold = true;
                }
            }
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            //TODO
        }
    }
}
