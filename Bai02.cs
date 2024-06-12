using System;
using System.Linq;
using System.Windows.Forms;
using MailKit.Net.Imap;
using MailKit;
using MailKit.Search;
using System.Security.Authentication;

namespace Lab5_22520075
{
    public partial class Bai02 : Form
    {
        public Bai02()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            int limit = 20;

            try
            {
                using (var client = new ImapClient())
                {
                    client.Connect("imap.gmail.com", 993, true);
                    client.Authenticate(username, password);

                    var inbox = client.Inbox;
                    inbox.Open(FolderAccess.ReadOnly);

                    var totalMessages = inbox.Count;
                    if (totalMessages == 0)
                    {
                        MessageBox.Show("No emails found.");
                        return;
                    }

                    listView1.Items.Clear();

                    var startIndex = Math.Max(0, totalMessages - limit);

                    for (int i = totalMessages - 1; i >= startIndex; i--)
                    {
                        var message = inbox.GetMessage(i);

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
                MessageBox.Show("Xác thực thất bại:  " + ex.Message);
            }
            catch (ImapProtocolException ex)
            {
                
                MessageBox.Show("LỖI giao thức IMAP: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
