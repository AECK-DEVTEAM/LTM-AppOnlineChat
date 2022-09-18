using System;
using System.Linq;
using System.Windows.Forms;

namespace TCP_Private_Client
{
    public partial class Form_NewGroup : Form
    {
        private Form_Main formMain;
        
        private string[] users;
        
        public Form_NewGroup(string[] users, Form_Main formMain)
        {
            this.formMain = formMain;
            InitializeComponent();
            // init list box user online
            this.users = users;
            InitListBoxUserOnline(this.users);
        }

        private void InitListBoxUserOnline(string[] users)
        {
            foreach (var user in users)
            {
                listBoxUserOnline.Items.Add(user);
            }
        }

        private void listBoxUserOnline_SelectedIndexChanged(object sender, EventArgs e)
        {
            // throw new System.NotImplementedException();
        }

        private void Form_NewGroup_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var selectedItems = listBoxUserOnline.SelectedItems;
            if (selectedItems == null || selectedItems.Count == 0)
                return;

            foreach (var item in selectedItems)
            {
                this.listBoxGroupMember.Items.Add(item.ToString());
            }

            for (int i = selectedItems.Count - 1; i >= 0; i--)
            {
                this.listBoxUserOnline.Items.Remove(selectedItems[i]);
            }
        }
        
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            var selectedItems = listBoxGroupMember.SelectedItems;
            if (selectedItems == null || selectedItems.Count == 0)
                return;
            
            foreach (var item in selectedItems)
            {
                this.listBoxUserOnline.Items.Add(item);
            }
            
            for (int i = selectedItems.Count - 1; i >= 0; i--)
            {
                this.listBoxGroupMember.Items.Remove(selectedItems[i]);
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            //todo: request to server create new group
            string groupName = textBoxGroupName.Text;
            string members = string.Join(",", this.listBoxGroupMember.Items.OfType<string>().ToArray());

            string data = String.Format("NEWGROUP|Name={0},Members=[{1}]", groupName, members);
            formMain.SendData(data); // NewGroup|Name=name,MembersId=['1','2','3']
            // textBoxGroupName.Text = data; // test code
            
            //close window
            this.Close();
        }
    }
}