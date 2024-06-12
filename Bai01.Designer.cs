namespace Lab5_22520075
{
    partial class Bai01
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox3 = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 14.1F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(447, 871);
            button1.Name = "button1";
            button1.Size = new Size(188, 58);
            button1.TabIndex = 0;
            button1.Text = "Send";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 14.1F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(1213, 871);
            button2.Name = "button2";
            button2.Size = new Size(188, 58);
            button2.TabIndex = 1;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.1F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(201, 52);
            label1.Name = "label1";
            label1.Size = new Size(189, 53);
            label1.TabIndex = 2;
            label1.Text = "Receiver";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.1F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(201, 147);
            label2.Name = "label2";
            label2.Size = new Size(154, 53);
            label2.TabIndex = 3;
            label2.Text = "Sender";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.1F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(201, 300);
            label4.Name = "label4";
            label4.Size = new Size(171, 53);
            label4.TabIndex = 5;
            label4.Text = "Content";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(447, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(764, 47);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(447, 153);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(764, 47);
            textBox2.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(447, 300);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(764, 53);
            textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(66, 387);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(1529, 456);
            textBox5.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(447, 235);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(764, 47);
            textBox3.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.1F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(201, 235);
            label3.Name = "label3";
            label3.Size = new Size(204, 53);
            label3.TabIndex = 12;
            label3.Text = "Password";
            // 
            // Bai01
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1629, 1016);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Bai01";
            Text = "Bai01";
            Load += Bai01_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox3;
        private Label label3;
    }
}