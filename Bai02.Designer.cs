namespace Lab5_22520075
{
    partial class Bai02
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
            listView1 = new ListView();
            email = new ColumnHeader();
            from = new ColumnHeader();
            time = new ColumnHeader();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { email, from, time });
            listView1.Location = new Point(27, 312);
            listView1.Name = "listView1";
            listView1.Size = new Size(1754, 620);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // email
            // 
            email.Text = "Email";
            email.Width = 1000;
            // 
            // from
            // 
            from.Text = "From";
            from.Width = 400;
            // 
            // time
            // 
            time.Text = "time";
            time.Width = 300;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(237, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(843, 47);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(237, 166);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(843, 47);
            textBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(96, 65);
            label1.Name = "label1";
            label1.Size = new Size(108, 46);
            label1.TabIndex = 3;
            label1.Text = "email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(47, 166);
            label2.Name = "label2";
            label2.Size = new Size(171, 46);
            label2.TabIndex = 4;
            label2.Text = "password";
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(1295, 49);
            button1.Name = "button1";
            button1.Size = new Size(188, 58);
            button1.TabIndex = 5;
            button1.Text = "login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Bai02
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1793, 996);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(listView1);
            Name = "Bai02";
            Text = "Bai02";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Button button1;
        private ColumnHeader email;
        private ColumnHeader from;
        private ColumnHeader time;
    }
}