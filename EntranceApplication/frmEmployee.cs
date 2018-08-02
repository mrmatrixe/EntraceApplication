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
    public partial class frmEmployee : frmTemplate
    {
        public frmEmployee(string FullName)
        {
            InitializeComponent();
            this.Text = FullName + " خوش آمدید.";
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'EntraceDBDataSet.EntranceGrid' table. You can move, or remove it, as needed.
            this.EntranceGridTableAdapter.Fill(this.EntraceDBDataSet.EntranceGrid);
            EntranceGridBindingSource.Filter = "UserID=" + Variable.UserID;
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EntranceGridBindingSource.Filter = "Date>='" + textBox1.Text + "' AND Date<='" + textBox2.Text + "' AND UserID=" + Variable.UserID;
            this.reportViewer1.RefreshReport();
        }
    }
}
