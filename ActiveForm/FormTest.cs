﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace ActiveForm
{
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
            frmActive active = new frmActive("Urbox");
            active.ShowDialog();
        }
    }
}
