namespace Tic_Tac_Toe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            CPUTimer = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 192, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(156, 32);
            label1.TabIndex = 0;
            label1.Text = "Player Wins:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(371, 9);
            label2.Name = "label2";
            label2.Size = new Size(132, 32);
            label2.TabIndex = 1;
            label2.Text = "CPU Wins:";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(95, 284);
            button1.Name = "button1";
            button1.Size = new Size(122, 98);
            button1.TabIndex = 2;
            button1.Text = "?";
            button1.UseVisualStyleBackColor = false;
            button1.Click += PlayerClickButton;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(223, 284);
            button2.Name = "button2";
            button2.Size = new Size(122, 98);
            button2.TabIndex = 3;
            button2.Text = "?";
            button2.UseVisualStyleBackColor = false;
            button2.Click += PlayerClickButton;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(351, 284);
            button3.Name = "button3";
            button3.Size = new Size(122, 98);
            button3.TabIndex = 4;
            button3.Text = "?";
            button3.UseVisualStyleBackColor = false;
            button3.Click += PlayerClickButton;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(95, 388);
            button4.Name = "button4";
            button4.Size = new Size(122, 98);
            button4.TabIndex = 2;
            button4.Text = "?";
            button4.UseVisualStyleBackColor = false;
            button4.Click += PlayerClickButton;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(223, 388);
            button5.Name = "button5";
            button5.Size = new Size(122, 98);
            button5.TabIndex = 3;
            button5.Text = "?";
            button5.UseVisualStyleBackColor = false;
            button5.Click += PlayerClickButton;
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(351, 388);
            button6.Name = "button6";
            button6.Size = new Size(122, 98);
            button6.TabIndex = 4;
            button6.Text = "?";
            button6.UseVisualStyleBackColor = false;
            button6.Click += PlayerClickButton;
            // 
            // button7
            // 
            button7.BackColor = Color.White;
            button7.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(95, 492);
            button7.Name = "button7";
            button7.Size = new Size(122, 98);
            button7.TabIndex = 2;
            button7.Text = "?";
            button7.UseVisualStyleBackColor = false;
            button7.Click += PlayerClickButton;
            // 
            // button8
            // 
            button8.BackColor = Color.White;
            button8.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(223, 492);
            button8.Name = "button8";
            button8.Size = new Size(122, 98);
            button8.TabIndex = 3;
            button8.Text = "?";
            button8.UseVisualStyleBackColor = false;
            button8.Click += PlayerClickButton;
            // 
            // button9
            // 
            button9.BackColor = Color.White;
            button9.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button9.Location = new Point(351, 492);
            button9.Name = "button9";
            button9.Size = new Size(122, 98);
            button9.TabIndex = 4;
            button9.Text = "?";
            button9.UseVisualStyleBackColor = false;
            button9.Click += PlayerClickButton;
            // 
            // button10
            // 
            button10.BackColor = Color.Aqua;
            button10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button10.Location = new Point(203, 604);
            button10.Name = "button10";
            button10.Size = new Size(154, 34);
            button10.TabIndex = 5;
            button10.Text = "Restart Game";
            button10.UseVisualStyleBackColor = false;
            button10.Click += RestartGame;
            // 
            // CPUTimer
            // 
            CPUTimer.Interval = 1000;
            CPUTimer.Tick += CPUmove;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(165, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(246, 234);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(565, 652);
            Controls.Add(pictureBox1);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button7);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Tic tac Toe Game Win Forms";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private System.Windows.Forms.Timer CPUTimer;
        private PictureBox pictureBox1;
    }
}