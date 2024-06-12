using System;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MimeKit;
namespace Lab5_22520075
{
    public partial class Bai01 : Form
    {
        public Bai01()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thông tin từ các hộp văn bản
                var recipientEmail = textBox1.Text;
                var senderEmail = textBox2.Text;
                var senderPassword = textBox3.Text;
                var subject = textBox4.Text;
                var body = textBox5.Text;

                // Tạo một thông điệp email mới
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("", senderEmail));
                message.To.Add(new MailboxAddress("", recipientEmail));
                message.Subject = subject;
                message.Body = new TextPart("plain")
                {
                    Text = body
                };

                // Kết nối đến máy chủ SMTP và gửi email
                using (var client = new SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 465, true);
                    client.Authenticate(senderEmail, senderPassword);
                    client.Send(message);
                    client.Disconnect(true);
                }

                // Hiển thị thông báo thành công
                MessageBox.Show("Email đã được gửi thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi
                MessageBox.Show($"Lỗi khi gửi email: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Bai01_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
