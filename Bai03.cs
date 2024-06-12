using System;
using System.Linq;
using System.Windows.Forms;
using MailKit.Net.Pop3;
using MailKit;
using System.Security.Authentication;

namespace Lab5_22520075
{
    public partial class Bai03 : Form
    {
        public Bai03()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            int limit = 20; // Số lượng email gần đây nhất cần lấy

            try
            {
                using (var client = new Pop3Client())
                {
                    client.Connect("pop.gmail.com", 995, true);
                    client.Authenticate(username, password);

                    var totalMessages = client.Count;
                    if (totalMessages == 0)
                    {
                        MessageBox.Show("Không tìm thấy email nào.");
                        return;
                    }

                    listView1.Items.Clear();

                    // Tính toán phạm vi để lấy các email mới nhất
                    var startIndex = Math.Max(0, totalMessages - limit);

                    for (int i = startIndex; i < totalMessages; i++)
                    {
                        var message = client.GetMessage(i);

                        ListViewItem item = new ListViewItem(message.Subject);
                        item.SubItems.Add(message.From.ToString());
                        item.SubItems.Add(message.Date.LocalDateTime.ToString());

                        listView1.Items.Add(item);
                    }

                    client.Disconnect(true);
                }
            }
            catch (AuthenticationException ex)
            {
                MessageBox.Show("Xác thực thất bại: " + ex.Message);
            }
            catch (Pop3ProtocolException ex)
            {
                MessageBox.Show("Lỗi giao thức POP3: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Xử lý sự kiện khi người dùng chọn một mục trong ListView
        }
    }
}
