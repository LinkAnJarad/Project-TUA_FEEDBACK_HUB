namespace Project_TUA_FEEDBACK_HUB
{
    partial class p3_Forgot_password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(p3_Forgot_password));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            panel2 = new Panel();
            button1 = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
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
            panel1.Location = new Point(-32, -9);
            panel1.Name = "panel1";
            panel1.Size = new Size(1435, 128);
            panel1.TabIndex = 2;
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
            panel3.Location = new Point(-32, 506);
            panel3.Name = "panel3";
            panel3.Size = new Size(1435, 128);
            panel3.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightYellow;
            panel2.BackgroundImageLayout = ImageLayout.Center;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(-19, 89);
            panel2.Name = "panel2";
            panel2.Size = new Size(1408, 427);
            panel2.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlText;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(1021, 238);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 5;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(327, 171);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(806, 31);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(231, 171);
            label3.Name = "label3";
            label3.Size = new Size(63, 25);
            label3.TabIndex = 1;
            label3.Text = "Email: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.InactiveCaptionText;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(573, 5);
            label2.Name = "label2";
            label2.Size = new Size(294, 38);
            label2.TabIndex = 0;
            label2.Text = "Forgot your password!";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Heading", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(415, 43);
            label4.Name = "label4";
            label4.Size = new Size(578, 32);
            label4.TabIndex = 6;
            label4.Text = "if you forgot your password , please enter your TUA Email";
            // 
            // p3_Forgot_password
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 604);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "p3_Forgot_password";
            Text = "p3_Forgot_password";
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
        private Label label4;
        private Button button1;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
    }
}