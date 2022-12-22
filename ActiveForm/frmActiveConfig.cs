using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActiveForm
{
    public partial class frmActiveConfig : Form
    {
        Dictionary<string, string> configs;
        private string paymentname;
        public frmActiveConfig(string name)
        {
            InitializeComponent();
            this.paymentname = name;
            configs = new ConfigLoader().ReadConfigFile(paymentname + @".dll.config");
            int x = 200;
            int width = 250;
            foreach (var config in configs)
            {
                var label = new Label();
                label.Text = config.Key+ ": ";
                label.AutoSize = true;
                label.Location = new Point(0, 0);

                var textbox = new TextBox();
                textbox.Text = config.Value;
                textbox.Width = width;
                textbox.Location = new Point(x,0);
                textbox.Name = config.Key;

                Panel panel = new Panel();
                panel.Name = config.Key;
                panel.Controls.Add(label);
                panel.Controls.Add(textbox);
                panel.AutoSize = true;

                flpnConfig.Controls.Add(panel);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var panel = flpnConfig.Controls.OfType<Panel>();
            var panellst = panel.ToList();
            foreach (var item in panellst)
            {
                TextBox tbx = item.Controls.OfType<TextBox>().ToList()[0];
                configs[tbx.Name] = tbx.Text;
            }
            bool result;
            string err = new ConfigLoader().WriteConfigFile(configs, paymentname + @".dll.config", out result);
            if(result)
            {
                this.Close();
                MessageBox.Show("Save successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
