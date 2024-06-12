namespace Lab5_22520075
{
    partial class Bai03
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            listView1 = new ListView();
            email = new ColumnHeader();
            from = new ColumnHeader();
            time = new ColumnHeader();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 14.1F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(1474, 74);
            button1.Name = "button1";
            button1.Size = new Size(188, 58);
            button1.TabIndex = 0;
            button1.Text = "login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(424, 74);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(884, 47);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(424, 201);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(884, 47);
            textBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.1F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(162, 74);
            label1.Name = "label1";
            label1.Size = new Size(126, 53);
            label1.TabIndex = 3;
            label1.Text = "email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.1F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(162, 201);
            label2.Name = "label2";
            label2.Size = new Size(202, 53);
            label2.TabIndex = 4;
            label2.Text = "password";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { email, from, time });
            listView1.Location = new Point(33, 311);
            listView1.Name = "listView1";
            listView1.Size = new Size(1740, 822);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // email
            // 
            email.Text = "email";
            email.Width = 1000;
            // 
            // from
            // 
            from.Text = "from";
            from.Width = 400;
            // 
            // time
            // 
            time.Text = "time";
            time.Width = 300;
            // 
            // Bai03
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1809, 1177);
            Controls.Add(listView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Bai03";
            Text = "Bai03";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private ListView listView1;
        private ColumnHeader email;
        private ColumnHeader from;
        private ColumnHeader time;
    }
}