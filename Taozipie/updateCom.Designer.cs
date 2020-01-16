namespace Taozipie
{
    partial class updateCom
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
            this.components = new System.ComponentModel.Container();
            this.btnDelete = new System.Windows.Forms.Button();
            this.MainTab = new System.Windows.Forms.TabControl();
            this.tabCreateCommission = new System.Windows.Forms.TabPage();
            this.btnCancel = new System.Windows.Forms.Button();
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
            this.tbProductType = new System.Windows.Forms.ComboBox();
            this.tbDate = new System.Windows.Forms.DateTimePicker();
            this.tabOngoingCommissions = new System.Windows.Forms.TabPage();
            this.lvOriginal = new System.Windows.Forms.ListView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lvFinished = new System.Windows.Forms.ListView();
            this.cbCommissionFinished = new System.Windows.Forms.CheckBox();
            this.dateFinished = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbInstagram = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPaypal = new System.Windows.Forms.TextBox();
            this.tbPayedAmmount = new System.Windows.Forms.TextBox();
            this.tbDetails = new System.Windows.Forms.RichTextBox();
            this.cmsControlImages = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainTab.SuspendLayout();
            this.tabCreateCommission.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabOngoingCommissions.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.cmsControlImages.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(178, 449);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(158, 45);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.MainTab.Size = new System.Drawing.Size(905, 579);
            this.MainTab.TabIndex = 1;
            // 
            // tabCreateCommission
            // 
            this.tabCreateCommission.Controls.Add(this.tbDetails);
            this.tabCreateCommission.Controls.Add(this.tbPayedAmmount);
            this.tabCreateCommission.Controls.Add(this.tbPaypal);
            this.tabCreateCommission.Controls.Add(this.tbEmail);
            this.tabCreateCommission.Controls.Add(this.tbInstagram);
            this.tabCreateCommission.Controls.Add(this.tbName);
            this.tabCreateCommission.Controls.Add(this.label9);
            this.tabCreateCommission.Controls.Add(this.dateFinished);
            this.tabCreateCommission.Controls.Add(this.cbCommissionFinished);
            this.tabCreateCommission.Controls.Add(this.btnCancel);
            this.tabCreateCommission.Controls.Add(this.btnDelete);
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
            this.tabCreateCommission.Controls.Add(this.tbProductType);
            this.tabCreateCommission.Controls.Add(this.tbDate);
            this.tabCreateCommission.Location = new System.Drawing.Point(4, 22);
            this.tabCreateCommission.Name = "tabCreateCommission";
            this.tabCreateCommission.Padding = new System.Windows.Forms.Padding(3);
            this.tabCreateCommission.Size = new System.Drawing.Size(897, 553);
            this.tabCreateCommission.TabIndex = 0;
            this.tabCreateCommission.Text = "Details";
            this.tabCreateCommission.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(5, 500);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(331, 45);
            this.btnCancel.TabIndex = 35;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            // tabOngoingCommissions
            // 
            this.tabOngoingCommissions.Controls.Add(this.lvOriginal);
            this.tabOngoingCommissions.Location = new System.Drawing.Point(4, 22);
            this.tabOngoingCommissions.Name = "tabOngoingCommissions";
            this.tabOngoingCommissions.Padding = new System.Windows.Forms.Padding(3);
            this.tabOngoingCommissions.Size = new System.Drawing.Size(897, 553);
            this.tabOngoingCommissions.TabIndex = 1;
            this.tabOngoingCommissions.Text = "Original";
            this.tabOngoingCommissions.UseVisualStyleBackColor = true;
            // 
            // lvOriginal
            // 
            this.lvOriginal.ContextMenuStrip = this.cmsControlImages;
            this.lvOriginal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvOriginal.Location = new System.Drawing.Point(3, 3);
            this.lvOriginal.Name = "lvOriginal";
            this.lvOriginal.Size = new System.Drawing.Size(891, 547);
            this.lvOriginal.TabIndex = 0;
            this.lvOriginal.UseCompatibleStateImageBehavior = false;
            this.lvOriginal.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvOriginal_MouseClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lvFinished);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(897, 553);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Finished";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lvFinished
            // 
            this.lvFinished.ContextMenuStrip = this.cmsControlImages;
            this.lvFinished.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvFinished.Location = new System.Drawing.Point(3, 3);
            this.lvFinished.Name = "lvFinished";
            this.lvFinished.Size = new System.Drawing.Size(891, 547);
            this.lvFinished.TabIndex = 0;
            this.lvFinished.UseCompatibleStateImageBehavior = false;
            // 
            // cbCommissionFinished
            // 
            this.cbCommissionFinished.AutoSize = true;
            this.cbCommissionFinished.Location = new System.Drawing.Point(342, 525);
            this.cbCommissionFinished.Name = "cbCommissionFinished";
            this.cbCommissionFinished.Size = new System.Drawing.Size(120, 17);
            this.cbCommissionFinished.TabIndex = 37;
            this.cbCommissionFinished.Text = "Commission finished";
            this.cbCommissionFinished.UseVisualStyleBackColor = true;
            // 
            // dateFinished
            // 
            this.dateFinished.Location = new System.Drawing.Point(465, 525);
            this.dateFinished.Name = "dateFinished";
            this.dateFinished.Size = new System.Drawing.Size(424, 20);
            this.dateFinished.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(465, 506);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Finished date";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(6, 25);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(324, 20);
            this.tbName.TabIndex = 40;
            // 
            // tbInstagram
            // 
            this.tbInstagram.Location = new System.Drawing.Point(6, 64);
            this.tbInstagram.Name = "tbInstagram";
            this.tbInstagram.Size = new System.Drawing.Size(324, 20);
            this.tbInstagram.TabIndex = 41;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(6, 103);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(324, 20);
            this.tbEmail.TabIndex = 42;
            // 
            // tbPaypal
            // 
            this.tbPaypal.Location = new System.Drawing.Point(6, 142);
            this.tbPaypal.Name = "tbPaypal";
            this.tbPaypal.Size = new System.Drawing.Size(324, 20);
            this.tbPaypal.TabIndex = 43;
            // 
            // tbPayedAmmount
            // 
            this.tbPayedAmmount.Location = new System.Drawing.Point(5, 181);
            this.tbPayedAmmount.Name = "tbPayedAmmount";
            this.tbPayedAmmount.Size = new System.Drawing.Size(324, 20);
            this.tbPayedAmmount.TabIndex = 44;
            // 
            // tbDetails
            // 
            this.tbDetails.Location = new System.Drawing.Point(4, 300);
            this.tbDetails.Name = "tbDetails";
            this.tbDetails.Size = new System.Drawing.Size(326, 143);
            this.tbDetails.TabIndex = 45;
            this.tbDetails.Text = "";
            // 
            // cmsControlImages
            // 
            this.cmsControlImages.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.cmsControlImages.Name = "cmsControlImages";
            this.cmsControlImages.Size = new System.Drawing.Size(118, 48);
            this.cmsControlImages.Text = "Image controller";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // updateCom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 579);
            this.Controls.Add(this.MainTab);
            this.Name = "updateCom";
            this.Text = "updateCom";
            this.MainTab.ResumeLayout(false);
            this.tabCreateCommission.ResumeLayout(false);
            this.tabCreateCommission.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabOngoingCommissions.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.cmsControlImages.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TabControl MainTab;
        private System.Windows.Forms.TabPage tabCreateCommission;
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
        private System.Windows.Forms.ComboBox tbProductType;
        private System.Windows.Forms.DateTimePicker tbDate;
        private System.Windows.Forms.TabPage tabOngoingCommissions;
        private System.Windows.Forms.ListView lvOriginal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView lvFinished;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox cbCommissionFinished;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateFinished;
        private System.Windows.Forms.RichTextBox tbDetails;
        private System.Windows.Forms.TextBox tbPayedAmmount;
        private System.Windows.Forms.TextBox tbPaypal;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbInstagram;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ContextMenuStrip cmsControlImages;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
    }
}