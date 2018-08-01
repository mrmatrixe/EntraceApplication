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
    public partial class frmMain : frmTemplate
    {
        public frmMain(string FullName)
        {
            InitializeComponent();
            this.Text = FullName + " خوش آمدید.";
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'entraceDBDataSet.EntranceGrid' table. You can move, or remove it, as needed.
            this.entranceGridTableAdapter.Fill(this.entraceDBDataSet.EntranceGrid);
            // TODO: This line of code loads data into the 'entraceDBDataSet.tblEntrance' table. You can move, or remove it, as needed.
            this.tblEntranceTableAdapter.Fill(this.entraceDBDataSet.tblEntrance);
            // TODO: This line of code loads data into the 'entraceDBDataSet.SecurityList' table. You can move, or remove it, as needed.
            this.securityListTableAdapter.Fill(this.entraceDBDataSet.SecurityList);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            securityListBindingSource.Filter = "FullName LIKE '%" + textBox1.Text + "%'";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToShortDateString();
            txtTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listUserID.SelectedItem!=null & comboType.Text!="" & txtReason.Text != "")
            {
                tblEntranceTableAdapter.InsertQuery(int.Parse(listUserID.SelectedValue.ToString()), comboType.Text, txtDate.Text, txtTime.Text, txtReason.Text);
                entranceGridTableAdapter.Fill(entraceDBDataSet.EntranceGrid);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new frmManageEmployees().ShowDialog();
            securityListTableAdapter.Fill(entraceDBDataSet.SecurityList);
        }
    }
}
