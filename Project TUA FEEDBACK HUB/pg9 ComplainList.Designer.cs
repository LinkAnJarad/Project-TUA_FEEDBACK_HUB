namespace Project_TUA_FEEDBACK_HUB
{
    partial class pg9_ComplainList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pg9_ComplainList));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            dgComplaintList = new DataGridView();
            hdrName = new DataGridViewTextBoxColumn();
            hdrComplainID = new DataGridViewTextBoxColumn();
            hdrComplainType = new DataGridViewTextBoxColumn();
            hdrPriorityLevel = new DataGridViewComboBoxColumn();
            hdrOpen = new DataGridViewButtonColumn();
            label1 = new Label();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgComplaintList).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.ForestGreen;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox5);
            panel1.Location = new Point(-13, -21);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1192, 117);
            panel1.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaptionText;
            panel4.Controls.Add(linkLabel5);
            panel4.Controls.Add(linkLabel4);
            panel4.Controls.Add(linkLabel3);
            panel4.Controls.Add(linkLabel2);
            panel4.Controls.Add(linkLabel1);
            panel4.Location = new Point(187, 81);
            panel4.Margin = new Padding(2, 3, 2, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(1003, 35);
            panel4.TabIndex = 7;
            // 
            // linkLabel5
            // 
            linkLabel5.AutoSize = true;
            linkLabel5.LinkColor = Color.White;
            linkLabel5.Location = new Point(809, 11);
            linkLabel5.Margin = new Padding(2, 0, 2, 0);
            linkLabel5.Name = "linkLabel5";
            linkLabel5.Size = new Size(172, 20);
            linkLabel5.TabIndex = 5;
            linkLabel5.TabStop = true;
            linkLabel5.Text = "College Complain Graph";
            // 
            // linkLabel4
            // 
            linkLabel4.AutoSize = true;
            linkLabel4.LinkColor = Color.White;
            linkLabel4.Location = new Point(626, 11);
            linkLabel4.Margin = new Padding(2, 0, 2, 0);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(136, 20);
            linkLabel4.TabIndex = 3;
            linkLabel4.TabStop = true;
            linkLabel4.Text = "Complain Archives ";
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.LinkColor = Color.White;
            linkLabel3.Location = new Point(431, 11);
            linkLabel3.Margin = new Padding(2, 0, 2, 0);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(109, 20);
            linkLabel3.TabIndex = 2;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Complain Lists ";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.LinkColor = Color.White;
            linkLabel2.Location = new Point(199, 11);
            linkLabel2.Margin = new Padding(2, 0, 2, 0);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(187, 20);
            linkLabel2.TabIndex = 1;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Student Account Approval ";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(33, 11);
            linkLabel1.Margin = new Padding(2, 0, 2, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(92, 20);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Homescreen";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlText;
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(1071, 41);
            button2.Margin = new Padding(2, 3, 2, 3);
            button2.Name = "button2";
            button2.Size = new Size(89, 27);
            button2.TabIndex = 6;
            button2.Text = "Log Out ";
            button2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(481, 41);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(240, 19);
            label2.TabIndex = 1;
            label2.Text = "TUA FEEDBACK SERVICE ";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(2, 21);
            pictureBox5.Margin = new Padding(2, 3, 2, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(187, 103);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightYellow;
            panel2.BackgroundImageLayout = ImageLayout.Center;
            panel2.Controls.Add(dgComplaintList);
            panel2.Controls.Add(label1);
            panel2.ForeColor = SystemColors.ButtonHighlight;
            panel2.Location = new Point(-22, 95);
            panel2.Margin = new Padding(2, 3, 2, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1199, 351);
            panel2.TabIndex = 6;
            // 
            // dgComplaintList
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgComplaintList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgComplaintList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgComplaintList.Columns.AddRange(new DataGridViewColumn[] { hdrName, hdrComplainID, hdrComplainType, hdrPriorityLevel, hdrOpen });
            dgComplaintList.Location = new Point(293, 99);
            dgComplaintList.Margin = new Padding(2, 3, 2, 3);
            dgComplaintList.Name = "dgComplaintList";
            dgComplaintList.RowHeadersWidth = 62;
            dgComplaintList.Size = new Size(656, 221);
            dgComplaintList.TabIndex = 13;
            dgComplaintList.CellContentClick += dgComplaintList_CellContentClick_1;
            // 
            // hdrName
            // 
            hdrName.HeaderText = "Name";
            hdrName.MinimumWidth = 6;
            hdrName.Name = "hdrName";
            hdrName.Width = 125;
            // 
            // hdrComplainID
            // 
            hdrComplainID.HeaderText = "Complain ID";
            hdrComplainID.MinimumWidth = 6;
            hdrComplainID.Name = "hdrComplainID";
            hdrComplainID.Width = 125;
            // 
            // hdrComplainType
            // 
            hdrComplainType.HeaderText = "Complain Type";
            hdrComplainType.MinimumWidth = 6;
            hdrComplainType.Name = "hdrComplainType";
            hdrComplainType.Width = 125;
            // 
            // hdrPriorityLevel
            // 
            hdrPriorityLevel.HeaderText = "Priority Level";
            hdrPriorityLevel.Items.AddRange(new object[] { "Important - Urgent", "Important - Not Urgent", "Not important - Urgent", "Not important - Not Urgent" });
            hdrPriorityLevel.MinimumWidth = 6;
            hdrPriorityLevel.Name = "hdrPriorityLevel";
            hdrPriorityLevel.Resizable = DataGridViewTriState.True;
            hdrPriorityLevel.SortMode = DataGridViewColumnSortMode.Automatic;
            hdrPriorityLevel.Width = 125;
            // 
            // hdrOpen
            // 
            hdrOpen.HeaderText = "Open";
            hdrOpen.MinimumWidth = 6;
            hdrOpen.Name = "hdrOpen";
            hdrOpen.Text = "Open";
            hdrOpen.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightYellow;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(489, 15);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(186, 23);
            label1.TabIndex = 12;
            label1.Text = "Feedback/Concern Lists ";
            // 
            // panel3
            // 
            panel3.BackColor = Color.ForestGreen;
            panel3.Location = new Point(-14, 443);
            panel3.Margin = new Padding(2, 3, 2, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1194, 107);
            panel3.TabIndex = 7;
            // 
            // pg9_ComplainList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 535);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(2, 3, 2, 3);
            Name = "pg9_ComplainList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "pg9_ComplainList";
            Load += pg9_ComplainList_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgComplaintList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private LinkLabel linkLabel4;
        private LinkLabel linkLabel3;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel1;
        private Button button2;
        private Label label2;
        private PictureBox pictureBox5;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private LinkLabel linkLabel5;
        private DataGridView dgComplaintList;
        private DataGridViewTextBoxColumn hdrName;
        private DataGridViewTextBoxColumn hdrComplainID;
        private DataGridViewTextBoxColumn hdrComplainType;
        private DataGridViewComboBoxColumn hdrPriorityLevel;
        private DataGridViewButtonColumn hdrOpen;
    }
}