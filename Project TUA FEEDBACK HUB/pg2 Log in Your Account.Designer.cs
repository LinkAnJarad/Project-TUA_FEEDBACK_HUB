namespace Project_TUA_FEEDBACK_HUB
{
    partial class pg2_Log_in_Your_Account
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pg2_Log_in_Your_Account));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            panel2 = new Panel();
            emailTXTbox = new TextBox();
            linkLabel2 = new LinkLabel();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            passTXTbox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.ForestGreen;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-33, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1435, 108);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(603, 38);
            label1.Name = "label1";
            label1.Size = new Size(262, 22);
            label1.TabIndex = 1;
            label1.Text = "TUA FEEDBACK SERVICE ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(17, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(181, 109);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.ForestGreen;
            panel3.Location = new Point(-33, 515);
            panel3.Name = "panel3";
            panel3.Size = new Size(1435, 108);
            panel3.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightYellow;
            panel2.BackgroundImageLayout = ImageLayout.Center;
            panel2.Controls.Add(emailTXTbox);
            panel2.Controls.Add(linkLabel2);
            panel2.Controls.Add(linkLabel1);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(passTXTbox);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(-16, 104);
            panel2.Name = "panel2";
            panel2.Size = new Size(1408, 427);
            panel2.TabIndex = 4;
            // 
            // emailTXTbox
            // 
            emailTXTbox.Location = new Point(421, 110);
            emailTXTbox.Name = "emailTXTbox";
            emailTXTbox.Size = new Size(591, 31);
            emailTXTbox.TabIndex = 9;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            linkLabel2.ForeColor = SystemColors.ControlText;
            linkLabel2.LinkColor = Color.Black;
            linkLabel2.Location = new Point(1215, 383);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(150, 27);
            linkLabel2.TabIndex = 7;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Create Account ";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(76, 383);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(159, 27);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot Password";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlText;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(900, 295);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 5;
            button1.Text = "Log In ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // passTXTbox
            // 
            passTXTbox.Location = new Point(421, 242);
            passTXTbox.Name = "passTXTbox";
            passTXTbox.Size = new Size(591, 31);
            passTXTbox.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(321, 242);
            label4.Name = "label4";
            label4.Size = new Size(96, 25);
            label4.TabIndex = 2;
            label4.Text = "Password: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(321, 113);
            label3.Name = "label3";
            label3.Size = new Size(63, 25);
            label3.TabIndex = 1;
            label3.Text = "Email: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.InactiveCaptionText;
            label2.Font = new Font("Sitka Banner", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(610, 7);
            label2.Name = "label2";
            label2.Size = new Size(238, 40);
            label2.TabIndex = 0;
            label2.Text = "Log in Your Account ";
            label2.Click += label2_Click;
            // 
            // pg2_Log_in_Your_Account
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1369, 617);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "pg2_Log_in_Your_Account";
            Text = "pg2_Log_in_Your_Account";
            Load += pg2_Log_in_Your_Account_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Panel panel2;
        private Label label2;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel1;
        private Button button1;
        private TextBox passTXTbox;
        private Label label4;
        private Label label3;
        private TextBox emailTXTbox;
    }
}