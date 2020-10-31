namespace OpenFusion_Server_Configurator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.loginServerGroupBox = new System.Windows.Forms.GroupBox();
            this.lsIpAddressTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lsPortTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gsIpAddressTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gsPortTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mobsEnabledCheckBox = new System.Windows.Forms.CheckBox();
            this.motdTxtBox = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.eventCrateDropChanceTxtBox = new System.Windows.Forms.TextBox();
            this.customNameCheckBox = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.accountLevelComboBox = new System.Windows.Forms.ComboBox();
            this.eventModeComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.loadBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.loginServerGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginServerGroupBox
            // 
            this.loginServerGroupBox.Controls.Add(this.lsIpAddressTxtBox);
            this.loginServerGroupBox.Controls.Add(this.label2);
            this.loginServerGroupBox.Controls.Add(this.lsPortTxtBox);
            this.loginServerGroupBox.Controls.Add(this.label1);
            this.loginServerGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginServerGroupBox.Location = new System.Drawing.Point(12, 12);
            this.loginServerGroupBox.Name = "loginServerGroupBox";
            this.loginServerGroupBox.Size = new System.Drawing.Size(200, 110);
            this.loginServerGroupBox.TabIndex = 0;
            this.loginServerGroupBox.TabStop = false;
            this.loginServerGroupBox.Text = "Login Server";
            // 
            // lsIpAddressTxtBox
            // 
            this.lsIpAddressTxtBox.Enabled = false;
            this.lsIpAddressTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsIpAddressTxtBox.Location = new System.Drawing.Point(6, 34);
            this.lsIpAddressTxtBox.Name = "lsIpAddressTxtBox";
            this.lsIpAddressTxtBox.Size = new System.Drawing.Size(188, 20);
            this.lsIpAddressTxtBox.TabIndex = 2;
            this.lsIpAddressTxtBox.Text = "127.0.0.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ip Address";
            // 
            // lsPortTxtBox
            // 
            this.lsPortTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsPortTxtBox.Location = new System.Drawing.Point(6, 75);
            this.lsPortTxtBox.Name = "lsPortTxtBox";
            this.lsPortTxtBox.Size = new System.Drawing.Size(188, 20);
            this.lsPortTxtBox.TabIndex = 4;
            this.lsPortTxtBox.Text = "8001";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Port";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gsIpAddressTxtBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.gsPortTxtBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(218, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 110);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game Server";
            // 
            // gsIpAddressTxtBox
            // 
            this.gsIpAddressTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gsIpAddressTxtBox.Location = new System.Drawing.Point(6, 34);
            this.gsIpAddressTxtBox.Name = "gsIpAddressTxtBox";
            this.gsIpAddressTxtBox.Size = new System.Drawing.Size(188, 20);
            this.gsIpAddressTxtBox.TabIndex = 7;
            this.gsIpAddressTxtBox.Text = "127.0.0.1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ip Address";
            // 
            // gsPortTxtBox
            // 
            this.gsPortTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gsPortTxtBox.Location = new System.Drawing.Point(6, 75);
            this.gsPortTxtBox.Name = "gsPortTxtBox";
            this.gsPortTxtBox.Size = new System.Drawing.Size(188, 20);
            this.gsPortTxtBox.TabIndex = 9;
            this.gsPortTxtBox.Text = "8002";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Port";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(406, 255);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Game Features";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.mobsEnabledCheckBox);
            this.panel1.Controls.Add(this.motdTxtBox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.eventCrateDropChanceTxtBox);
            this.panel1.Controls.Add(this.customNameCheckBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.accountLevelComboBox);
            this.panel1.Controls.Add(this.eventModeComboBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 234);
            this.panel1.TabIndex = 11;
            // 
            // mobsEnabledCheckBox
            // 
            this.mobsEnabledCheckBox.AutoSize = true;
            this.mobsEnabledCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobsEnabledCheckBox.Location = new System.Drawing.Point(260, 52);
            this.mobsEnabledCheckBox.Name = "mobsEnabledCheckBox";
            this.mobsEnabledCheckBox.Size = new System.Drawing.Size(114, 17);
            this.mobsEnabledCheckBox.TabIndex = 15;
            this.mobsEnabledCheckBox.Text = "Allow Mob Combat";
            this.mobsEnabledCheckBox.UseVisualStyleBackColor = true;
            // 
            // motdTxtBox
            // 
            this.motdTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motdTxtBox.Location = new System.Drawing.Point(3, 76);
            this.motdTxtBox.Name = "motdTxtBox";
            this.motdTxtBox.Size = new System.Drawing.Size(394, 106);
            this.motdTxtBox.TabIndex = 17;
            this.motdTxtBox.Text = "Welcome to OpenFusion!";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "MOTD";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Account Level";
            // 
            // eventCrateDropChanceTxtBox
            // 
            this.eventCrateDropChanceTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventCrateDropChanceTxtBox.Location = new System.Drawing.Point(203, 202);
            this.eventCrateDropChanceTxtBox.Name = "eventCrateDropChanceTxtBox";
            this.eventCrateDropChanceTxtBox.Size = new System.Drawing.Size(194, 20);
            this.eventCrateDropChanceTxtBox.TabIndex = 21;
            this.eventCrateDropChanceTxtBox.Text = "10";
            // 
            // customNameCheckBox
            // 
            this.customNameCheckBox.AutoSize = true;
            this.customNameCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customNameCheckBox.Location = new System.Drawing.Point(260, 29);
            this.customNameCheckBox.Name = "customNameCheckBox";
            this.customNameCheckBox.Size = new System.Drawing.Size(120, 17);
            this.customNameCheckBox.TabIndex = 14;
            this.customNameCheckBox.Text = "Allow Custom Name";
            this.customNameCheckBox.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(206, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Event Crate Drop Chance";
            // 
            // accountLevelComboBox
            // 
            this.accountLevelComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountLevelComboBox.FormattingEnabled = true;
            this.accountLevelComboBox.Location = new System.Drawing.Point(3, 27);
            this.accountLevelComboBox.Name = "accountLevelComboBox";
            this.accountLevelComboBox.Size = new System.Drawing.Size(242, 21);
            this.accountLevelComboBox.TabIndex = 13;
            // 
            // eventModeComboBox
            // 
            this.eventModeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventModeComboBox.FormattingEnabled = true;
            this.eventModeComboBox.ItemHeight = 13;
            this.eventModeComboBox.Location = new System.Drawing.Point(3, 201);
            this.eventModeComboBox.Name = "eventModeComboBox";
            this.eventModeComboBox.Size = new System.Drawing.Size(188, 21);
            this.eventModeComboBox.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Event Mode";
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(262, 389);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(75, 23);
            this.loadBtn.TabIndex = 23;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(343, 389);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 24;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(12, 401);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(79, 13);
            this.linkLabel1.TabIndex = 22;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "View on Github";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 423);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.loginServerGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenFusion Server Configurator";
            this.loginServerGroupBox.ResumeLayout(false);
            this.loginServerGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox loginServerGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lsPortTxtBox;
        private System.Windows.Forms.TextBox lsIpAddressTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox gsIpAddressTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox gsPortTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox customNameCheckBox;
        private System.Windows.Forms.ComboBox accountLevelComboBox;
        private System.Windows.Forms.ComboBox eventModeComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox eventCrateDropChanceTxtBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox motdTxtBox;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.CheckBox mobsEnabledCheckBox;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

