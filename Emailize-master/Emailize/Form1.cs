using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Emailize
{
    public partial class EmalizeForm : Form
    {
        public EmalizeForm()
        {
            InitializeComponent();
        }

        #region Is mail valid
        private bool invalid = false;
        private string DomainMapper(Match match)
        {
            // IdnMapping class with default property values.
            IdnMapping idn = new IdnMapping();

            string domainName = match.Groups[2].Value;
            try
            {
                domainName = idn.GetAscii(domainName);
            }
            catch (ArgumentException)
            {
                invalid = true;
            }
            return match.Groups[1].Value + domainName;
        }
        private bool IsValidEmail(string strIn)
        {

            if (String.IsNullOrEmpty(strIn))
            {
                return false;
            }
            // Use IdnMapping class to convert Unicode domain names.
            try
            {
                strIn = Regex.Replace(strIn, @"(@)(.+)$", this.DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }

            if (invalid)
                return false;

            // Return true if strIn is in valid e-mail format.
            try
            {
                return Regex.IsMatch(strIn,
                      @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                      @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                      RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
        #endregion

        private void ButtonDone_Click(object sender, EventArgs e)
        {
            textBoxSendTo.Text = textBoxSendTo.Text.Replace(" ", string.Empty);
            foreach (string email in textBoxSendTo.Text.Split(';'))
            {
                if (!(IsValidEmail(email)))
                {
                    MessageBox.Show("Please confirm all email addresses are valid and divided by ';'", "Error");
                    return;
                }
            }
            textBoxComputer.Text = "mailto:" + textBoxSendTo.Text + "?Subject=" + textBoxSubject.Text + "&body=" +
                richTextBoxBody.Text;

            textBoxGmail.Text = "https://mail.google.com/mail/" +
                "?view=cm&fs=1&to=" + textBoxSendTo.Text +
                "&su=" + textBoxSubject.Text +
                "&body=" + richTextBoxBody.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxComputer.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxGmail.Text);
        }
    }
}
