namespace ActiveForm
{
    partial class frmActive
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtOutletID = new System.Windows.Forms.Label();
            this.txtOutletName = new System.Windows.Forms.Label();
            this.tbxoutletID = new System.Windows.Forms.TextBox();
            this.tbxOutletName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbMsg = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbxContactName = new System.Windows.Forms.TextBox();
            this.lbContactName = new System.Windows.Forms.Label();
            this.lbPhoneNum = new System.Windows.Forms.Label();
            this.tbxContactNum = new System.Windows.Forms.TextBox();
            this.btnActive = new System.Windows.Forms.Button();
            this.btnSendReq = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOutletID
            // 
            this.txtOutletID.AutoSize = true;
            this.txtOutletID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutletID.Location = new System.Drawing.Point(3, 14);
            this.txtOutletID.Name = "txtOutletID";
            this.txtOutletID.Size = new System.Drawing.Size(77, 20);
            this.txtOutletID.TabIndex = 0;
            this.txtOutletID.Text = "Outlet ID:";
            // 
            // txtOutletName
            // 
            this.txtOutletName.AutoSize = true;
            this.txtOutletName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutletName.Location = new System.Drawing.Point(3, 51);
            this.txtOutletName.Name = "txtOutletName";
            this.txtOutletName.Size = new System.Drawing.Size(102, 20);
            this.txtOutletName.TabIndex = 1;
            this.txtOutletName.Text = "Outlet Name:";
            // 
            // tbxoutletID
            // 
            this.tbxoutletID.Location = new System.Drawing.Point(184, 16);
            this.tbxoutletID.Name = "tbxoutletID";
            this.tbxoutletID.ReadOnly = true;
            this.tbxoutletID.Size = new System.Drawing.Size(403, 20);
            this.tbxoutletID.TabIndex = 2;
            // 
            // tbxOutletName
            // 
            this.tbxOutletName.Location = new System.Drawing.Point(184, 53);
            this.tbxOutletName.Name = "tbxOutletName";
            this.tbxOutletName.ReadOnly = true;
            this.tbxOutletName.Size = new System.Drawing.Size(403, 20);
            this.tbxOutletName.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbxoutletID);
            this.panel1.Controls.Add(this.txtOutletID);
            this.panel1.Controls.Add(this.txtOutletName);
            this.panel1.Controls.Add(this.tbxOutletName);
            this.panel1.Location = new System.Drawing.Point(12, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 98);
            this.panel1.TabIndex = 4;
            // 
            // lbMsg
            // 
            this.lbMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMsg.Location = new System.Drawing.Point(15, 182);
            this.lbMsg.Name = "lbMsg";
            this.lbMsg.Size = new System.Drawing.Size(582, 76);
            this.lbMsg.TabIndex = 5;
            this.lbMsg.Text = "Bạn muốn khởi tạo thanh toán MoMo vui lòng nhập thông tin sau để chúng tôi liên l" +
    "ạc";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbxContactName);
            this.panel3.Controls.Add(this.lbContactName);
            this.panel3.Controls.Add(this.lbPhoneNum);
            this.panel3.Controls.Add(this.tbxContactNum);
            this.panel3.Location = new System.Drawing.Point(12, 246);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(603, 110);
            this.panel3.TabIndex = 7;
            // 
            // tbxContactName
            // 
            this.tbxContactName.Location = new System.Drawing.Point(184, 16);
            this.tbxContactName.Name = "tbxContactName";
            this.tbxContactName.Size = new System.Drawing.Size(403, 20);
            this.tbxContactName.TabIndex = 2;
            // 
            // lbContactName
            // 
            this.lbContactName.AutoSize = true;
            this.lbContactName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContactName.Location = new System.Drawing.Point(3, 16);
            this.lbContactName.Name = "lbContactName";
            this.lbContactName.Size = new System.Drawing.Size(135, 20);
            this.lbContactName.TabIndex = 0;
            this.lbContactName.Text = "Tên người liên lạc:";
            // 
            // lbPhoneNum
            // 
            this.lbPhoneNum.AutoSize = true;
            this.lbPhoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhoneNum.Location = new System.Drawing.Point(3, 53);
            this.lbPhoneNum.Name = "lbPhoneNum";
            this.lbPhoneNum.Size = new System.Drawing.Size(158, 20);
            this.lbPhoneNum.TabIndex = 1;
            this.lbPhoneNum.Text = "Số điện thoại liên lạc:";
            // 
            // tbxContactNum
            // 
            this.tbxContactNum.Location = new System.Drawing.Point(184, 53);
            this.tbxContactNum.Name = "tbxContactNum";
            this.tbxContactNum.Size = new System.Drawing.Size(403, 20);
            this.tbxContactNum.TabIndex = 3;
            this.tbxContactNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxContactNum_KeyPress);
            // 
            // btnActive
            // 
            this.btnActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActive.Location = new System.Drawing.Point(313, 3);
            this.btnActive.Name = "btnActive";
            this.btnActive.Size = new System.Drawing.Size(140, 45);
            this.btnActive.TabIndex = 8;
            this.btnActive.Text = "Active by Speed";
            this.btnActive.UseVisualStyleBackColor = true;
            this.btnActive.Click += new System.EventHandler(this.btnActive_Click);
            // 
            // btnSendReq
            // 
            this.btnSendReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendReq.Location = new System.Drawing.Point(459, 3);
            this.btnSendReq.Name = "btnSendReq";
            this.btnSendReq.Size = new System.Drawing.Size(141, 45);
            this.btnSendReq.TabIndex = 9;
            this.btnSendReq.Text = "Send request";
            this.btnSendReq.UseVisualStyleBackColor = true;
            this.btnSendReq.Click += new System.EventHandler(this.btnSendReq_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnSendReq);
            this.panel2.Controls.Add(this.btnActive);
            this.panel2.Location = new System.Drawing.Point(12, 377);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(603, 51);
            this.panel2.TabIndex = 10;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(7, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 45);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ActiveForm.Properties.Resources.speed;
            this.pictureBox1.Location = new System.Drawing.Point(234, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // frmActive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(627, 439);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lbMsg);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmActive";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Active payment";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txtOutletID;
        private System.Windows.Forms.Label txtOutletName;
        private System.Windows.Forms.TextBox tbxoutletID;
        private System.Windows.Forms.TextBox tbxOutletName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbMsg;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbxContactName;
        private System.Windows.Forms.Label lbContactName;
        private System.Windows.Forms.Label lbPhoneNum;
        private System.Windows.Forms.TextBox tbxContactNum;
        private System.Windows.Forms.Button btnActive;
        private System.Windows.Forms.Button btnSendReq;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

