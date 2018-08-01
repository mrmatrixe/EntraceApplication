namespace EntranceApplication
{
    partial class frmManageEmployees
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label nationalCodeLabel;
            System.Windows.Forms.Label userTypeLabel;
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label unitIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageEmployees));
            this.entraceDBDataSet = new EntranceApplication.EntraceDBDataSet();
            this.tblUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblUsersTableAdapter = new EntranceApplication.EntraceDBDataSetTableAdapters.tblUsersTableAdapter();
            this.tableAdapterManager = new EntranceApplication.EntraceDBDataSetTableAdapters.TableAdapterManager();
            this.tblUnitsTableAdapter = new EntranceApplication.EntraceDBDataSetTableAdapters.tblUnitsTableAdapter();
            this.tblUsersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tblUsersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tblUsersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.nationalCodeTextBox = new System.Windows.Forms.TextBox();
            this.userTypeComboBox = new System.Windows.Forms.ComboBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.tblUnitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unitIDComboBox = new System.Windows.Forms.ComboBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            nationalCodeLabel = new System.Windows.Forms.Label();
            userTypeLabel = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            unitIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.entraceDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingNavigator)).BeginInit();
            this.tblUsersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUnitsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(99, 103);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(29, 16);
            firstNameLabel.TabIndex = 4;
            firstNameLabel.Text = "نام:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(99, 129);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(84, 16);
            lastNameLabel.TabIndex = 6;
            lastNameLabel.Text = "نام خانوادگی:";
            // 
            // nationalCodeLabel
            // 
            nationalCodeLabel.AutoSize = true;
            nationalCodeLabel.Location = new System.Drawing.Point(99, 161);
            nationalCodeLabel.Name = "nationalCodeLabel";
            nationalCodeLabel.Size = new System.Drawing.Size(55, 16);
            nationalCodeLabel.TabIndex = 8;
            nationalCodeLabel.Text = "کد ملی:";
            // 
            // userTypeLabel
            // 
            userTypeLabel.AutoSize = true;
            userTypeLabel.Location = new System.Drawing.Point(99, 187);
            userTypeLabel.Name = "userTypeLabel";
            userTypeLabel.Size = new System.Drawing.Size(70, 16);
            userTypeLabel.TabIndex = 10;
            userTypeLabel.Text = "نوع کاربری:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new System.Drawing.Point(323, 103);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(68, 16);
            usernameLabel.TabIndex = 12;
            usernameLabel.Text = "نام کاربری:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(326, 132);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(67, 16);
            passwordLabel.TabIndex = 14;
            passwordLabel.Text = "کلمه عبور:";
            // 
            // unitIDLabel
            // 
            unitIDLabel.AutoSize = true;
            unitIDLabel.Location = new System.Drawing.Point(326, 161);
            unitIDLabel.Name = "unitIDLabel";
            unitIDLabel.Size = new System.Drawing.Size(37, 16);
            unitIDLabel.TabIndex = 16;
            unitIDLabel.Text = "واحد:";
            // 
            // entraceDBDataSet
            // 
            this.entraceDBDataSet.DataSetName = "EntraceDBDataSet";
            this.entraceDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblUsersBindingSource
            // 
            this.tblUsersBindingSource.DataMember = "tblUsers";
            this.tblUsersBindingSource.DataSource = this.entraceDBDataSet;
            // 
            // tblUsersTableAdapter
            // 
            this.tblUsersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.SecurityListTableAdapter = null;
            this.tableAdapterManager.tblEntranceTableAdapter = null;
            this.tableAdapterManager.tblUnitsTableAdapter = null;
            this.tableAdapterManager.tblUsersTableAdapter = this.tblUsersTableAdapter;
            this.tableAdapterManager.UpdateOrder = EntranceApplication.EntraceDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblUnitsTableAdapter
            // 
            this.tblUnitsTableAdapter.ClearBeforeFill = true;
            // 
            // tblUsersBindingNavigator
            // 
            this.tblUsersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblUsersBindingNavigator.BindingSource = this.tblUsersBindingSource;
            this.tblUsersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblUsersBindingNavigator.DeleteItem = null;
            this.tblUsersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.toolStripButton1,
            this.tblUsersBindingNavigatorSaveItem});
            this.tblUsersBindingNavigator.Location = new System.Drawing.Point(0, 63);
            this.tblUsersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblUsersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblUsersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblUsersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblUsersBindingNavigator.Name = "tblUsersBindingNavigator";
            this.tblUsersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblUsersBindingNavigator.Size = new System.Drawing.Size(673, 25);
            this.tblUsersBindingNavigator.TabIndex = 3;
            this.tblUsersBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tblUsersBindingNavigatorSaveItem
            // 
            this.tblUsersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblUsersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblUsersBindingNavigatorSaveItem.Image")));
            this.tblUsersBindingNavigatorSaveItem.Name = "tblUsersBindingNavigatorSaveItem";
            this.tblUsersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tblUsersBindingNavigatorSaveItem.Text = "Save Data";
            this.tblUsersBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblUsersBindingNavigatorSaveItem_Click);
            // 
            // tblUsersDataGridView
            // 
            this.tblUsersDataGridView.AutoGenerateColumns = false;
            this.tblUsersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblUsersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.tblUsersDataGridView.DataSource = this.tblUsersBindingSource;
            this.tblUsersDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tblUsersDataGridView.Location = new System.Drawing.Point(0, 229);
            this.tblUsersDataGridView.Name = "tblUsersDataGridView";
            this.tblUsersDataGridView.Size = new System.Drawing.Size(673, 220);
            this.tblUsersDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn2.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn3.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NationalCode";
            this.dataGridViewTextBoxColumn4.HeaderText = "NationalCode";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "UserType";
            this.dataGridViewTextBoxColumn5.HeaderText = "UserType";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Username";
            this.dataGridViewTextBoxColumn6.HeaderText = "Username";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn7.HeaderText = "Password";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "UnitID";
            this.dataGridViewTextBoxColumn8.HeaderText = "UnitID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUsersBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(189, 97);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(121, 23);
            this.firstNameTextBox.TabIndex = 5;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUsersBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(189, 126);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(121, 23);
            this.lastNameTextBox.TabIndex = 7;
            // 
            // nationalCodeTextBox
            // 
            this.nationalCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUsersBindingSource, "NationalCode", true));
            this.nationalCodeTextBox.Location = new System.Drawing.Point(189, 155);
            this.nationalCodeTextBox.Name = "nationalCodeTextBox";
            this.nationalCodeTextBox.Size = new System.Drawing.Size(121, 23);
            this.nationalCodeTextBox.TabIndex = 9;
            // 
            // userTypeComboBox
            // 
            this.userTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUsersBindingSource, "UserType", true));
            this.userTypeComboBox.FormattingEnabled = true;
            this.userTypeComboBox.Items.AddRange(new object[] {
            "کارمند",
            "متصدی حراست"});
            this.userTypeComboBox.Location = new System.Drawing.Point(189, 184);
            this.userTypeComboBox.Name = "userTypeComboBox";
            this.userTypeComboBox.Size = new System.Drawing.Size(121, 24);
            this.userTypeComboBox.TabIndex = 11;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUsersBindingSource, "Username", true));
            this.usernameTextBox.Location = new System.Drawing.Point(400, 100);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(121, 23);
            this.usernameTextBox.TabIndex = 13;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUsersBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(400, 129);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(121, 23);
            this.passwordTextBox.TabIndex = 15;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // tblUnitsBindingSource
            // 
            this.tblUnitsBindingSource.DataMember = "tblUnits";
            this.tblUnitsBindingSource.DataSource = this.entraceDBDataSet;
            // 
            // unitIDComboBox
            // 
            this.unitIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblUsersBindingSource, "UnitID", true));
            this.unitIDComboBox.DataSource = this.tblUnitsBindingSource;
            this.unitIDComboBox.DisplayMember = "UnitName";
            this.unitIDComboBox.FormattingEnabled = true;
            this.unitIDComboBox.Location = new System.Drawing.Point(400, 158);
            this.unitIDComboBox.Name = "unitIDComboBox";
            this.unitIDComboBox.Size = new System.Drawing.Size(121, 24);
            this.unitIDComboBox.TabIndex = 18;
            this.unitIDComboBox.ValueMember = "Id";
            this.unitIDComboBox.SelectedIndexChanged += new System.EventHandler(this.unitIDComboBox_SelectedIndexChanged);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // frmManageEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 512);
            this.Controls.Add(this.unitIDComboBox);
            this.Controls.Add(unitIDLabel);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(userTypeLabel);
            this.Controls.Add(this.userTypeComboBox);
            this.Controls.Add(nationalCodeLabel);
            this.Controls.Add(this.nationalCodeTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.tblUsersDataGridView);
            this.Controls.Add(this.tblUsersBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmManageEmployees";
            this.Text = "مدیریت پرسنل";
            this.Load += new System.EventHandler(this.frmManageEmployees_Load);
            this.Controls.SetChildIndex(this.tblUsersBindingNavigator, 0);
            this.Controls.SetChildIndex(this.tblUsersDataGridView, 0);
            this.Controls.SetChildIndex(this.firstNameTextBox, 0);
            this.Controls.SetChildIndex(firstNameLabel, 0);
            this.Controls.SetChildIndex(this.lastNameTextBox, 0);
            this.Controls.SetChildIndex(lastNameLabel, 0);
            this.Controls.SetChildIndex(this.nationalCodeTextBox, 0);
            this.Controls.SetChildIndex(nationalCodeLabel, 0);
            this.Controls.SetChildIndex(this.userTypeComboBox, 0);
            this.Controls.SetChildIndex(userTypeLabel, 0);
            this.Controls.SetChildIndex(this.usernameTextBox, 0);
            this.Controls.SetChildIndex(usernameLabel, 0);
            this.Controls.SetChildIndex(this.passwordTextBox, 0);
            this.Controls.SetChildIndex(passwordLabel, 0);
            this.Controls.SetChildIndex(unitIDLabel, 0);
            this.Controls.SetChildIndex(this.unitIDComboBox, 0);
            ((System.ComponentModel.ISupportInitialize)(this.entraceDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingNavigator)).EndInit();
            this.tblUsersBindingNavigator.ResumeLayout(false);
            this.tblUsersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUnitsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EntraceDBDataSet entraceDBDataSet;
        private System.Windows.Forms.BindingSource tblUsersBindingSource;
        private EntraceDBDataSetTableAdapters.tblUsersTableAdapter tblUsersTableAdapter;
        private EntraceDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblUsersBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tblUsersBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tblUsersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox nationalCodeTextBox;
        private System.Windows.Forms.ComboBox userTypeComboBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private EntraceDBDataSetTableAdapters.tblUnitsTableAdapter tblUnitsTableAdapter;
        private System.Windows.Forms.BindingSource tblUnitsBindingSource;
        private System.Windows.Forms.ComboBox unitIDComboBox;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}