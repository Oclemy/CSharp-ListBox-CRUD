using System;
using MetroFramework.Forms;

namespace ListBox_CRUD
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
        * ITEM SELECTED
        */
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index != -1)
            {
                nameTxt.Text = listBox1.SelectedItem.ToString();

            }
        }

        /*
        *ADD
        */
        private void addBtn_Click(object sender, EventArgs e)
        {
            string name = nameTxt.Text;
            listBox1.Items.Add(name);
            clearTxt();
        }

        /*
        * UPDATE
        */
        private void updateBtn_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index != -1)
            {
                listBox1.Items.RemoveAt(index);
                listBox1.Items.Insert(index, nameTxt.Text);
            }
           
        }

        /*
        * DELETE
        */
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index != -1)
            {
                listBox1.Items.RemoveAt(index);
                clearTxt();
            }
        }

        /*
        * CLEAR
        */
        private void clearBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            clearTxt();
        }

        /*
         * CLEAR TEXTBOX
         */
        private void clearTxt()
        {
            nameTxt.Text = "";
        }
    }
}
