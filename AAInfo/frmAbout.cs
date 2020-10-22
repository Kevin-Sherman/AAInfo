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

        public string[] getText()
        {
            string[] text = new string[3];

            text[0] = rtbText1.Text;
            text[1] = rtbText2.Text;
            text[2] = rtbText3.Text;

            return text;
        }

        public void setText(string[] replacementText)
        {
            rtbText1.Text = replacementText[0];
            rtbText2.Text = replacementText[1];
            rtbText3.Text = replacementText[2];
        }

        public string[] getTextKeys()
        {
            string[] keys = new string[4];
            keys[0] = "<<TOOL>>";
            keys[1] = "<<COMPANY>>";
            keys[2] = "<<DESC>>";
            keys[3] = "<<LICENCE>>";

            return keys;
        }
    }
}
