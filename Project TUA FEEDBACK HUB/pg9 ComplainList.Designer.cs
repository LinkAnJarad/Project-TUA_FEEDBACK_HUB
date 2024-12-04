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
            label1 = new Label();
            panel3 = new Panel();
            hdrName = new DataGridViewTextBoxColumn();
            hdrComplainID = new DataGridViewTextBoxColumn();
            hdrComplainType = new DataGridViewTextBoxColumn();
            hdrPriorityLevel = new DataGridViewComboBoxColumn();
            hdrOpen = new DataGridViewButtonColumn();
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
            panel1.Location = new Point(-11, -16);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1043, 88);
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
            panel4.Location = new Point(164, 61);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(878, 26);
            panel4.TabIndex = 7;
            // 
            // linkLabel5
            // 
            linkLabel5.AutoSize = true;
            linkLabel5.LinkColor = Color.White;
            linkLabel5.Location = new Point(708, 8);
            linkLabel5.Margin = new Padding(2, 0, 2, 0);
            linkLabel5.Name = "linkLabel5";
            linkLabel5.Size = new Size(137, 15);
            linkLabel5.TabIndex = 5;
            linkLabel5.TabStop = true;
            linkLabel5.Text = "College Complain Graph";
            // 
            // linkLabel4
            // 
            linkLabel4.AutoSize = true;
            linkLabel4.LinkColor = Color.White;
            linkLabel4.Location = new Point(548, 8);
            linkLabel4.Margin = new Padding(2, 0, 2, 0);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(110, 15);
            linkLabel4.TabIndex = 3;
            linkLabel4.TabStop = true;
            linkLabel4.Text = "Complain Archives ";
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.LinkColor = Color.White;
            linkLabel3.Location = new Point(377, 8);
            linkLabel3.Margin = new Padding(2, 0, 2, 0);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(88, 15);
            linkLabel3.TabIndex = 2;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Complain Lists ";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.LinkColor = Color.White;
            linkLabel2.Location = new Point(174, 8);
            linkLabel2.Margin = new Padding(2, 0, 2, 0);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(150, 15);
            linkLabel2.TabIndex = 1;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Student Account Approval ";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(29, 8);
            linkLabel1.Margin = new Padding(2, 0, 2, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(74, 15);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Homescreen";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlText;
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(937, 31);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(78, 20);
            button2.TabIndex = 6;
            button2.Text = "Log Out ";
            button2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(421, 31);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(196, 15);
            label2.TabIndex = 1;
            label2.Text = "TUA FEEDBACK SERVICE ";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(2, 16);
            pictureBox5.Margin = new Padding(2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(164, 77);
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
            panel2.Location = new Point(-19, 71);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1049, 263);
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
            dgComplaintList.Location = new Point(256, 74);
            dgComplaintList.Margin = new Padding(2);
            dgComplaintList.Name = "dgComplaintList";
            dgComplaintList.RowHeadersWidth = 62;
            dgComplaintList.Size = new Size(574, 166);
            dgComplaintList.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightYellow;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(428, 11);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(159, 19);
            label1.TabIndex = 12;
            label1.Text = "Feedback/Concern Lists ";
            // 
            // panel3
            // 
            panel3.BackColor = Color.ForestGreen;
            panel3.Location = new Point(-12, 332);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1045, 80);
            panel3.TabIndex = 7;
            // 
            // hdrName
            // 
            hdrName.HeaderText = "Name";
            hdrName.Name = "hdrName";
            // 
            // hdrComplainID
            // 
            hdrComplainID.HeaderText = "Complain ID";
            hdrComplainID.Name = "hdrComplainID";
            // 
            // hdrComplainType
            // 
            hdrComplainType.HeaderText = "Complain Type";
            hdrComplainType.Name = "hdrComplainType";
            // 
            // hdrPriorityLevel
            // 
            hdrPriorityLevel.HeaderText = "Priority Level";
            hdrPriorityLevel.Items.AddRange(new object[] { "Important - Urgent", "Important - Not Urgent", "Not important - Urgent", "Not important - Not Urgent" });
            hdrPriorityLevel.Name = "hdrPriorityLevel";
            hdrPriorityLevel.Resizable = DataGridViewTriState.True;
            hdrPriorityLevel.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // hdrOpen
            // 
            hdrOpen.HeaderText = "Open";
            hdrOpen.Name = "hdrOpen";
            hdrOpen.Text = "Open";
            // 
            // pg9_ComplainList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1021, 401);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(2);
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