using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace WhatsupApp
{
    public partial class myWinform : Form
    {
        public myWinform()
        {
            InitializeComponent();
        }

        private void user1TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            statusLbl.Text = $"{user1NameLbl.Text} is typing...";
        }

        private void user2TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            statusLbl.Text = $"{user2NameLbl.Text} is typing...";
        }

     

        private void sendBtn2_Click(object sender, EventArgs e)
        {
            chatListBx.Items.Add($"{user2NameLbl.Text}: " + user2TextBox.Text);
        }
        
        private void sendBtn_Click(object sender, EventArgs e)
        {
            chatListBx.Items.Add($"{user1NameLbl.Text} : " + user1TextBox.Text);
                
        }

        private void user1TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                chatListBx.Items.Add($"{user1NameLbl.Text} :  {user1TextBox.Text} ({DateTime.Now })");
                user1TextBox.Text = "";
            }
        }

        private void user2TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                chatListBx.Items.Add($"{user2NameLbl.Text} :  {user2TextBox.Text} ({DateTime.Now })");
                user2TextBox.Text = "";
               // user2TextBox.Text = String.Empty;
            }
        }
    }
}
