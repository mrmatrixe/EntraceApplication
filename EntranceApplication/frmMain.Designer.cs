namespace EntranceApplication
{
    partial class frmMain
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
            this.listUserID = new System.Windows.Forms.ListBox();
            this.securityListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.entraceDBDataSet = new EntranceApplication.EntraceDBDataSet();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.securityListTableAdapter = new EntranceApplication.EntraceDBDataSetTableAdapters.SecurityListTableAdapter();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entranceGridBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tblEntranceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblEntranceTableAdapter = new EntranceApplication.EntraceDBDataSetTableAdapters.tblEntranceTableAdapter();
            this.entranceGridTableAdapter = new EntranceApplication.EntraceDBDataSetTableAdapters.EntranceGridTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.securityListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entraceDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entranceGridBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEntranceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listUserID
            // 
            this.listUserID.DataSource = this.securityListBindingSource;
            this.listUserID.DisplayMember = "FullName";
            this.listUserID.FormattingEnabled = true;
            this.listUserID.ItemHeight = 16;
            this.listUserID.Location = new System.Drawing.Point(197, 91);
            this.listUserID.Name = "listUserID";
            this.listUserID.Size = new System.Drawing.Size(148, 180);
            this.listUserID.TabIndex = 3;
            this.listUserID.ValueMember = "Id";
            // 
            // securityListBindingSource
            // 
            this.securityListBindingSource.DataMember = "SecurityList";
            this.securityListBindingSource.DataSource = this.entraceDBDataSet;
            // 
            // entraceDBDataSet
            // 
            this.entraceDBDataSet.DataSetName = "EntraceDBDataSet";
            this.entraceDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(197, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 23);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // securityListTableAdapter
            // 
            this.securityListTableAdapter.ClearBeforeFill = true;
            // 
            // comboType
            // 
            this.comboType.FormattingEnabled = true;
            this.comboType.Items.AddRange(new object[] {
            "ورود",
            "خروج"});
            this.comboType.Location = new System.Drawing.Point(421, 66);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(121, 24);
            this.comboType.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "نوع:";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(421, 96);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(121, 23);
            this.txtDate.TabIndex = 8;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(421, 125);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(121, 23);
            this.txtTime.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "توضیحات:";
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(421, 157);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(121, 114);
            this.txtReason.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(592, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 12;
            this.button1.Text = "ذخیره";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.logTypeDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.reasonDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.entranceGridBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 277);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(798, 179);
            this.dataGridView1.TabIndex = 13;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // logTypeDataGridViewTextBoxColumn
            // 
            this.logTypeDataGridViewTextBoxColumn.DataPropertyName = "LogType";
            this.logTypeDataGridViewTextBoxColumn.HeaderText = "LogType";
            this.logTypeDataGridViewTextBoxColumn.Name = "logTypeDataGridViewTextBoxColumn";
            this.logTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reasonDataGridViewTextBoxColumn
            // 
            this.reasonDataGridViewTextBoxColumn.DataPropertyName = "Reason";
            this.reasonDataGridViewTextBoxColumn.HeaderText = "Reason";
            this.reasonDataGridViewTextBoxColumn.Name = "reasonDataGridViewTextBoxColumn";
            this.reasonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // entranceGridBindingSource
            // 
            this.entranceGridBindingSource.DataMember = "EntranceGrid";
            this.entranceGridBindingSource.DataSource = this.entraceDBDataSet;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tblEntranceBindingSource
            // 
            this.tblEntranceBindingSource.DataMember = "tblEntrance";
            this.tblEntranceBindingSource.DataSource = this.entraceDBDataSet;
            // 
            // tblEntranceTableAdapter
            // 
            this.tblEntranceTableAdapter.ClearBeforeFill = true;
            // 
            // entranceGridTableAdapter
            // 
            this.entranceGridTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(673, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 35);
            this.button2.TabIndex = 14;
            this.button2.Text = "مدیریت کارمندان";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 519);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboType);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listUserID);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Controls.SetChildIndex(this.listUserID, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.comboType, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtDate, 0);
            this.Controls.SetChildIndex(this.txtTime, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtReason, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.securityListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entraceDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entranceGridBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEntranceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listUserID;
        private System.Windows.Forms.TextBox textBox1;
        private EntraceDBDataSet entraceDBDataSet;
        private System.Windows.Forms.BindingSource securityListBindingSource;
        private EntraceDBDataSetTableAdapters.SecurityListTableAdapter securityListTableAdapter;
        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.BindingSource tblEntranceBindingSource;
        private EntraceDBDataSetTableAdapters.tblEntranceTableAdapter tblEntranceTableAdapter;
        private System.Windows.Forms.BindingSource entranceGridBindingSource;
        private EntraceDBDataSetTableAdapters.EntranceGridTableAdapter entranceGridTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reasonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
    }
}