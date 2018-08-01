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
    public partial class frmManageEmployees : frmTemplate
    {
        public frmManageEmployees()
        {
            InitializeComponent();
        }

        private void frmManageEmployees_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'entraceDBDataSet.tblUnits' table. You can move, or remove it, as needed.
            this.tblUnitsTableAdapter.Fill(this.entraceDBDataSet.tblUnits);
            // TODO: This line of code loads data into the 'entraceDBDataSet.tblUsers' table. You can move, or remove it, as needed.
            this.tblUsersTableAdapter.Fill(this.entraceDBDataSet.tblUsers);

        }

        private void tblUsersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //this.Validate();
            this.tblUsersBindingSource.EndEdit();
            tblUsersTableAdapter.Update(entraceDBDataSet.tblUsers);
            this.tblUsersTableAdapter.Fill(this.entraceDBDataSet.tblUsers);
            //this.tableAdapterManager.UpdateAll(this.entraceDBDataSet);

        }

        private void unitIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            tblUsersBindingSource.RemoveCurrent();
            tblUsersTableAdapter.Update(entraceDBDataSet.tblUsers);
            this.tblUsersTableAdapter.Fill(this.entraceDBDataSet.tblUsers);
        }
    }
}
