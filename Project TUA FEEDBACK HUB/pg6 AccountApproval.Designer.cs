﻿namespace Project_TUA_FEEDBACK_HUB
{
    partial class pg6_AccountApproval
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pg6_AccountApproval));
            panel1 = new Panel();
            panel4 = new Panel();
            linkLabel5 = new LinkLabel();
            linkLabel4 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            linkLabel1 = new LinkLabel();
            button2 = new Button();
            label2 = new Label();
            pictureBox5 = new PictureBox();
            panel2 = new Panel();
            approval_table = new DataGridView();
            FirstName = new DataGridViewTextBoxColumn();
            MiddleName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            AccountNumber = new DataGridViewTextBoxColumn();
            AccountType = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Data = new DataGridViewButtonColumn();
            label1 = new Label();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)approval_table).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.ForestGreen;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox5);
            panel1.Location = new Point(-32, -33);
            panel1.Name = "panel1";
            panel1.Size = new Size(1490, 145);
            panel1.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaptionText;
            panel4.Controls.Add(linkLabel5);
            panel4.Controls.Add(linkLabel4);
            panel4.Controls.Add(linkLabel3);
            panel4.Controls.Add(linkLabel2);
            panel4.Controls.Add(linkLabel1);
            panel4.Location = new Point(235, 102);
            panel4.Name = "panel4";
            panel4.Size = new Size(1255, 43);
            panel4.TabIndex = 7;
            // 
            // linkLabel5
            // 
            linkLabel5.AutoSize = true;
            linkLabel5.LinkColor = Color.White;
            linkLabel5.Location = new Point(1029, 16);
            linkLabel5.Name = "linkLabel5";
            linkLabel5.Size = new Size(205, 25);
            linkLabel5.TabIndex = 4;
            linkLabel5.TabStop = true;
            linkLabel5.Text = "College Complain Graph";
            // 
            // linkLabel4
            // 
            linkLabel4.AutoSize = true;
            linkLabel4.LinkColor = Color.White;
            linkLabel4.Location = new Point(786, 14);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(164, 25);
            linkLabel4.TabIndex = 3;
            linkLabel4.TabStop = true;
            linkLabel4.Text = "Complain Archives ";
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.LinkColor = Color.White;
            linkLabel3.Location = new Point(594, 16);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(132, 25);
            linkLabel3.TabIndex = 2;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Complain Lists ";
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.LinkColor = Color.White;
            linkLabel2.Location = new Point(292, 14);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(226, 25);
            linkLabel2.TabIndex = 1;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Student Account Approval ";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(74, 14);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(111, 25);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Homescreen";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlText;
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(1339, 51);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 6;
            button2.Text = "Log Out ";
            button2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(601, 51);
            label2.Name = "label2";
            label2.Size = new Size(262, 22);
            label2.TabIndex = 1;
            label2.Text = "TUA FEEDBACK SERVICE ";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(27, 26);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(210, 128);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightYellow;
            panel2.BackgroundImageLayout = ImageLayout.Center;
            panel2.Controls.Add(approval_table);
            panel2.Controls.Add(label1);
            panel2.ForeColor = SystemColors.ButtonHighlight;
            panel2.Location = new Point(-32, 111);
            panel2.Name = "panel2";
            panel2.Size = new Size(1513, 445);
            panel2.TabIndex = 5;
            // 
            // approval_table
            // 
            approval_table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            approval_table.Columns.AddRange(new DataGridViewColumn[] { FirstName, MiddleName, LastName, AccountNumber, AccountType, Column3, Data });
            approval_table.Location = new Point(69, 89);
            approval_table.Name = "approval_table";
            approval_table.RowHeadersWidth = 62;
            approval_table.Size = new Size(1116, 259);
            approval_table.TabIndex = 13;
            approval_table.CellContentClick += dataGridView1_CellContentClick;
            // 
            // FirstName
            // 
            FirstName.HeaderText = "First Name";
            FirstName.MinimumWidth = 8;
            FirstName.Name = "FirstName";
            FirstName.Width = 150;
            // 
            // MiddleName
            // 
            MiddleName.HeaderText = "Middle Name";
            MiddleName.MinimumWidth = 8;
            MiddleName.Name = "MiddleName";
            MiddleName.Width = 150;
            // 
            // LastName
            // 
            LastName.HeaderText = "LastName";
            LastName.MinimumWidth = 8;
            LastName.Name = "LastName";
            LastName.Width = 150;
            // 
            // AccountNumber
            // 
            AccountNumber.HeaderText = "Account Number";
            AccountNumber.MinimumWidth = 8;
            AccountNumber.Name = "AccountNumber";
            AccountNumber.Width = 150;
            // 
            // AccountType
            // 
            AccountType.HeaderText = "Account Type";
            AccountType.MinimumWidth = 8;
            AccountType.Name = "AccountType";
            AccountType.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "College";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // Data
            // 
            Data.HeaderText = "Data";
            Data.MinimumWidth = 8;
            Data.Name = "Data";
            Data.Resizable = DataGridViewTriState.True;
            Data.SortMode = DataGridViewColumnSortMode.Automatic;
            Data.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(610, 24);
            label1.Name = "label1";
            label1.Size = new Size(253, 32);
            label1.TabIndex = 0;
            label1.Text = "Account Approval Lists ";
            // 
            // panel3
            // 
            panel3.BackColor = Color.ForestGreen;
            panel3.Location = new Point(7, 551);
            panel3.Name = "panel3";
            panel3.Size = new Size(1493, 168);
            panel3.TabIndex = 6;
            // 
            // pg6_AccountApproval
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1449, 666);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "pg6_AccountApproval";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "pg6_AccountApproval";
            Load += pg6_AccountApproval_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)approval_table).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Label label2;
        private PictureBox pictureBox5;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private LinkLabel linkLabel5;
        private LinkLabel linkLabel4;
        private LinkLabel linkLabel3;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel1;
        private Label label1;
        private DataGridView approval_table;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn MiddleName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn AccountNumber;
        private DataGridViewTextBoxColumn AccountType;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewButtonColumn Data;
    }
}