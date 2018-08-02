using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntranceApplication
{
    public partial class frmLogin : frmTemplate
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'entraceDBDataSet.tblUsers' table. You can move, or remove it, as needed.
            this.tblUsersTableAdapter.Fill(this.entraceDBDataSet.tblUsers);

        }

        private void tblUsersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblUsersBindingSource.EndEdit();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="" && textBox2.Text!="")
            {
                tblUsersBindingSource.Filter = "Username='" + textBox1.Text + "' AND Password='" + textBox2.Text + "'";
                if (tblUsersBindingSource.Count > 0)
                {
                    Variable.UserID = idTextBox.Text;
                    if (userTypeTextBox.Text == "کارمند")
                    {
                        this.Hide();
                        new frmEmployee(firstNameTextBox.Text + " " + lastNameTextBox.Text).Show();
                    }
                    else
                    {
                        this.Hide();
                        new frmMain(firstNameTextBox.Text + " " + lastNameTextBox.Text).Show();
                    }
                }
                else
                {
                    MessageBox.Show("نام کاربری یا کلمه عبور اشتباه است.","خطا",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }
    }
}
