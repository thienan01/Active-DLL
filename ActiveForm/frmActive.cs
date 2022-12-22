using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace ActiveForm
{
    public partial class frmActive : Form
    {
        private string paymentName;
        Dictionary<string, string> configs;
        public frmActive(string paymentName)
        {
            InitializeComponent();
            this.paymentName = paymentName;
            configs = new ConfigLoader().ReadConfigFile(Path.GetDirectoryName(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile) + "\\" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + @".exe.config");
            lbMsg.Text = configs["Message"].Replace("...",paymentName);
        }

        public void outletIDReadable(bool readable)
        {
            tbxoutletID.ReadOnly = readable;
        }
        public void outletNameReadable(bool readable)
        {
            tbxOutletName.ReadOnly = readable;
        }

        private bool validateInput()
        {
            try
            {
                if (tbxContactName.Text == "")
                    throw new Exception("Missing contact name!");
                if (tbxContactNum.Text == "")
                    throw new Exception("Missing contact number!");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Missing field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool sendEmail()
        {
            if (!validateInput())
                return false;

            MailMessage email = new MailMessage();
            email.To.Add(configs["RecieverEmail"]);
            email.From = new MailAddress(configs["SenderEmail"]);
            email.Subject = configs["EmailSubject"];
            configs["EmailContent"].Replace("CONTACT_NAME", tbxContactName.Text).Replace("CONTACT_NUM", tbxContactNum.Text);
            email.Body = configs["EmailContent"].Replace("CONTACT_NAME", tbxContactName.Text).Replace("CONTACT_NUM", tbxContactNum.Text);
            email.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(configs["SenderEmail"], configs["SenderPassword"]);
            try
            {
                smtp.Send(email);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void btnActive_Click(object sender, EventArgs e)
        {   
           frmActiveConfig frmActiveConfig = new frmActiveConfig(paymentName);
            frmActiveConfig.ShowDialog();
        }
        private void btnSendReq_Click(object sender, EventArgs e)
        {
            frmMessage loading = new frmMessage();
            loading.Show();
            this.Hide();
            Application.DoEvents();
            if (sendEmail())
            {
                loading.Close();
                MessageBox.Show("Sent request successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                loading.Close();
            this.Show();
        }

        private void tbxContactNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
