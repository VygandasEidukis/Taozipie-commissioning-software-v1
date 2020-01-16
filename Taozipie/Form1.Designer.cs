namespace Taozipie
{
    partial class formMain
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
            this.MainTab = new System.Windows.Forms.TabControl();
            this.tabCreateCommission = new System.Windows.Forms.TabPage();
            this.tbPayedAmmount = new Taozipie.customValueBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDetails = new Taozipie.customRichTextBox();
            this.tbProductType = new System.Windows.Forms.ComboBox();
            this.tbDate = new System.Windows.Forms.DateTimePicker();
            this.tbInstagram = new Taozipie.customTextBox();
            this.tbPaypal = new Taozipie.customTextBox();
            this.tbEmail = new Taozipie.customTextBox();
            this.tbName = new Taozipie.customTextBox();
            this.tabOngoingCommissions = new System.Windows.Forms.TabPage();
            this.lw_Ongoing = new System.Windows.Forms.ListView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lv_All = new System.Windows.Forms.ListView();
            this.MainTab.SuspendLayout();
            this.tabCreateCommission.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabOngoingCommissions.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTab
            // 
            this.MainTab.Controls.Add(this.tabCreateCommission);
            this.MainTab.Controls.Add(this.tabOngoingCommissions);
            this.MainTab.Controls.Add(this.tabPage1);
            this.MainTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTab.Location = new System.Drawing.Point(0, 0);
            this.MainTab.Name = "MainTab";
            this.MainTab.SelectedIndex = 0;
            this.MainTab.Size = new System.Drawing.Size(904, 528);
            this.MainTab.TabIndex = 0;
            // 
            // tabCreateCommission
            // 
            this.tabCreateCommission.Controls.Add(this.tbPayedAmmount);
            this.tabCreateCommission.Controls.Add(this.btnClear);
            this.tabCreateCommission.Controls.Add(this.btnSave);
            this.tabCreateCommission.Controls.Add(this.pictureBox1);
            this.tabCreateCommission.Controls.Add(this.label8);
            this.tabCreateCommission.Controls.Add(this.label7);
            this.tabCreateCommission.Controls.Add(this.label6);
            this.tabCreateCommission.Controls.Add(this.label5);
            this.tabCreateCommission.Controls.Add(this.label4);
            this.tabCreateCommission.Controls.Add(this.label3);
            this.tabCreateCommission.Controls.Add(this.label2);
            this.tabCreateCommission.Controls.Add(this.label1);
            this.tabCreateCommission.Controls.Add(this.tbDetails);
            this.tabCreateCommission.Controls.Add(this.tbProductType);
            this.tabCreateCommission.Controls.Add(this.tbDate);
            this.tabCreateCommission.Controls.Add(this.tbInstagram);
            this.tabCreateCommission.Controls.Add(this.tbPaypal);
            this.tabCreateCommission.Controls.Add(this.tbEmail);
            this.tabCreateCommission.Controls.Add(this.tbName);
            this.tabCreateCommission.Location = new System.Drawing.Point(4, 22);
            this.tabCreateCommission.Name = "tabCreateCommission";
            this.tabCreateCommission.Padding = new System.Windows.Forms.Padding(3);
            this.tabCreateCommission.Size = new System.Drawing.Size(896, 502);
            this.tabCreateCommission.TabIndex = 0;
            this.tabCreateCommission.Text = "Commissions";
            this.tabCreateCommission.UseVisualStyleBackColor = true;
            // 
            // tbPayedAmmount
            // 
            this.tbPayedAmmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.tbPayedAmmount.ForeColor = System.Drawing.Color.Gray;
            this.tbPayedAmmount.Location = new System.Drawing.Point(6, 182);
            this.tbPayedAmmount.Name = "tbPayedAmmount";
            this.tbPayedAmmount.PlaceHolderText = "Enter payed ammount";
            this.tbPayedAmmount.Size = new System.Drawing.Size(324, 20);
            this.tbPayedAmmount.TabIndex = 34;
            this.tbPayedAmmount.Text = "Enter payed ammount";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(178, 449);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(158, 45);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(5, 449);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(163, 45);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(342, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(548, 488);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Details provided by the customer";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Date of purchase";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Payed money ammount by a customer (EUR)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Payed money ammount by a customer (EUR)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Customer paypal email adress";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Customer email adress";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Customer Instagram name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Customer name";
            // 
            // tbDetails
            // 
            this.tbDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.tbDetails.ForeColor = System.Drawing.Color.Gray;
            this.tbDetails.Location = new System.Drawing.Point(5, 299);
            this.tbDetails.Name = "tbDetails";
            this.tbDetails.PlaceHolderText = "Enter product details provided by customer";
            this.tbDetails.Size = new System.Drawing.Size(328, 144);
            this.tbDetails.TabIndex = 7;
            this.tbDetails.Text = "Enter product details provided by customer";
            // 
            // tbProductType
            // 
            this.tbProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbProductType.FormattingEnabled = true;
            this.tbProductType.Location = new System.Drawing.Point(6, 220);
            this.tbProductType.Name = "tbProductType";
            this.tbProductType.Size = new System.Drawing.Size(327, 21);
            this.tbProductType.TabIndex = 5;
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(5, 260);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(328, 20);
            this.tbDate.TabIndex = 6;
            // 
            // tbInstagram
            // 
            this.tbInstagram.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.tbInstagram.ForeColor = System.Drawing.Color.Gray;
            this.tbInstagram.Location = new System.Drawing.Point(6, 64);
            this.tbInstagram.Name = "tbInstagram";
            this.tbInstagram.PlaceHolderText = "Enter instagram name";
            this.tbInstagram.Size = new System.Drawing.Size(326, 20);
            this.tbInstagram.TabIndex = 1;
            this.tbInstagram.Text = "Enter instagram name";
            // 
            // tbPaypal
            // 
            this.tbPaypal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.tbPaypal.ForeColor = System.Drawing.Color.Gray;
            this.tbPaypal.Location = new System.Drawing.Point(5, 142);
            this.tbPaypal.Name = "tbPaypal";
            this.tbPaypal.PlaceHolderText = "Enter paypal";
            this.tbPaypal.Size = new System.Drawing.Size(325, 20);
            this.tbPaypal.TabIndex = 3;
            this.tbPaypal.Text = "Enter paypal";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.tbEmail.ForeColor = System.Drawing.Color.Gray;
            this.tbEmail.Location = new System.Drawing.Point(5, 103);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.PlaceHolderText = "Enter customer email";
            this.tbEmail.Size = new System.Drawing.Size(327, 20);
            this.tbEmail.TabIndex = 2;
            this.tbEmail.Text = "Enter customer email";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.tbName.ForeColor = System.Drawing.Color.Gray;
            this.tbName.Location = new System.Drawing.Point(6, 25);
            this.tbName.Name = "tbName";
            this.tbName.PlaceHolderText = "Enter customer name";
            this.tbName.Size = new System.Drawing.Size(328, 20);
            this.tbName.TabIndex = 0;
            this.tbName.Text = "Enter customer name";
            // 
            // tabOngoingCommissions
            // 
            this.tabOngoingCommissions.Controls.Add(this.lw_Ongoing);
            this.tabOngoingCommissions.Location = new System.Drawing.Point(4, 22);
            this.tabOngoingCommissions.Name = "tabOngoingCommissions";
            this.tabOngoingCommissions.Padding = new System.Windows.Forms.Padding(3);
            this.tabOngoingCommissions.Size = new System.Drawing.Size(896, 502);
            this.tabOngoingCommissions.TabIndex = 1;
            this.tabOngoingCommissions.Text = "Ongoing Commissions";
            this.tabOngoingCommissions.UseVisualStyleBackColor = true;
            // 
            // lw_Ongoing
            // 
            this.lw_Ongoing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lw_Ongoing.Location = new System.Drawing.Point(3, 3);
            this.lw_Ongoing.Name = "lw_Ongoing";
            this.lw_Ongoing.Size = new System.Drawing.Size(890, 496);
            this.lw_Ongoing.TabIndex = 0;
            this.lw_Ongoing.UseCompatibleStateImageBehavior = false;
            this.lw_Ongoing.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lw_Ongoing_MouseDoubleClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lv_All);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(896, 502);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Commission List";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lv_All
            // 
            this.lv_All.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_All.Location = new System.Drawing.Point(3, 3);
            this.lv_All.Name = "lv_All";
            this.lv_All.Size = new System.Drawing.Size(890, 496);
            this.lv_All.TabIndex = 0;
            this.lv_All.UseCompatibleStateImageBehavior = false;
            this.lv_All.DoubleClick += new System.EventHandler(this.lv_All_DoubleClick);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 528);
            this.Controls.Add(this.MainTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "formMain";
            this.Text = "Taozipie";
            this.MainTab.ResumeLayout(false);
            this.tabCreateCommission.ResumeLayout(false);
            this.tabCreateCommission.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabOngoingCommissions.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTab;
        private System.Windows.Forms.TabPage tabCreateCommission;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private customRichTextBox tbDetails;
        private System.Windows.Forms.ComboBox tbProductType;
        private System.Windows.Forms.DateTimePicker tbDate;
        private customTextBox tbPaypal;
        private customTextBox tbEmail;
        private customTextBox tbName;
        private System.Windows.Forms.TabPage tabOngoingCommissions;
        private System.Windows.Forms.TabPage tabPage1;
        private customTextBox tbInstagram;
        private customValueBox tbPayedAmmount;
        private System.Windows.Forms.ListView lw_Ongoing;
        private System.Windows.Forms.ListView lv_All;
    }
}

