namespace EquipmentRepair
{
    partial class ChabgeReyest
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label date_AddedLabel;
            System.Windows.Forms.Label malfunction_TypeLabel;
            System.Windows.Forms.Label problem_DescriptionLabel;
            System.Windows.Forms.Label client_IDLabel;
            System.Windows.Forms.Label statusLabel;
            this.equipmentRepairDataSet = new EquipmentRepair.EquipmentRepairDataSet();
            this.requestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.requestsTableAdapter = new EquipmentRepair.EquipmentRepairDataSetTableAdapters.RequestsTableAdapter();
            this.tableAdapterManager = new EquipmentRepair.EquipmentRepairDataSetTableAdapters.TableAdapterManager();
            this.requestsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.date_AddedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.malfunction_TypeTextBox = new System.Windows.Forms.TextBox();
            this.problem_DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.client_IDTextBox = new System.Windows.Forms.TextBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            iDLabel = new System.Windows.Forms.Label();
            date_AddedLabel = new System.Windows.Forms.Label();
            malfunction_TypeLabel = new System.Windows.Forms.Label();
            problem_DescriptionLabel = new System.Windows.Forms.Label();
            client_IDLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentRepairDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(76, 97);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 3;
            iDLabel.Text = "ID:";
            // 
            // date_AddedLabel
            // 
            date_AddedLabel.AutoSize = true;
            date_AddedLabel.Location = new System.Drawing.Point(30, 141);
            date_AddedLabel.Name = "date_AddedLabel";
            date_AddedLabel.Size = new System.Drawing.Size(67, 13);
            date_AddedLabel.TabIndex = 5;
            date_AddedLabel.Text = "Date Added:";
            // 
            // malfunction_TypeLabel
            // 
            malfunction_TypeLabel.AutoSize = true;
            malfunction_TypeLabel.Location = new System.Drawing.Point(12, 200);
            malfunction_TypeLabel.Name = "malfunction_TypeLabel";
            malfunction_TypeLabel.Size = new System.Drawing.Size(92, 13);
            malfunction_TypeLabel.TabIndex = 7;
            malfunction_TypeLabel.Text = "Malfunction Type:";
            // 
            // problem_DescriptionLabel
            // 
            problem_DescriptionLabel.AutoSize = true;
            problem_DescriptionLabel.Location = new System.Drawing.Point(12, 257);
            problem_DescriptionLabel.Name = "problem_DescriptionLabel";
            problem_DescriptionLabel.Size = new System.Drawing.Size(104, 13);
            problem_DescriptionLabel.TabIndex = 9;
            problem_DescriptionLabel.Text = "Problem Description:";
            // 
            // client_IDLabel
            // 
            client_IDLabel.AutoSize = true;
            client_IDLabel.Location = new System.Drawing.Point(408, 129);
            client_IDLabel.Name = "client_IDLabel";
            client_IDLabel.Size = new System.Drawing.Size(50, 13);
            client_IDLabel.TabIndex = 11;
            client_IDLabel.Text = "Client ID:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(418, 196);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(40, 13);
            statusLabel.TabIndex = 13;
            statusLabel.Text = "Status:";
            // 
            // equipmentRepairDataSet
            // 
            this.equipmentRepairDataSet.DataSetName = "EquipmentRepairDataSet";
            this.equipmentRepairDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // requestsBindingSource
            // 
            this.requestsBindingSource.DataMember = "Requests";
            this.requestsBindingSource.DataSource = this.equipmentRepairDataSet;
            // 
            // requestsTableAdapter
            // 
            this.requestsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AssignmentsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.EquipmentTableAdapter = null;
            this.tableAdapterManager.ExecutorsTableAdapter = null;
            this.tableAdapterManager.RequestsTableAdapter = this.requestsTableAdapter;
            this.tableAdapterManager.UpdateOrder = EquipmentRepair.EquipmentRepairDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // requestsDataGridView
            // 
            this.requestsDataGridView.AllowUserToAddRows = false;
            this.requestsDataGridView.AllowUserToDeleteRows = false;
            this.requestsDataGridView.AutoGenerateColumns = false;
            this.requestsDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.requestsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.requestsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.requestsDataGridView.DataSource = this.requestsBindingSource;
            this.requestsDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.requestsDataGridView.Location = new System.Drawing.Point(0, 325);
            this.requestsDataGridView.Name = "requestsDataGridView";
            this.requestsDataGridView.ReadOnly = true;
            this.requestsDataGridView.RowHeadersVisible = false;
            this.requestsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.requestsDataGridView.Size = new System.Drawing.Size(752, 270);
            this.requestsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Date_Added";
            this.dataGridViewTextBoxColumn2.HeaderText = "Date_Added";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Equipment_ID";
            this.dataGridViewTextBoxColumn3.HeaderText = "Equipment_ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Malfunction_Type";
            this.dataGridViewTextBoxColumn4.HeaderText = "Malfunction_Type";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Problem_Description";
            this.dataGridViewTextBoxColumn5.HeaderText = "Problem_Description";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Client_ID";
            this.dataGridViewTextBoxColumn6.HeaderText = "Client_ID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn7.HeaderText = "Status";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(353, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(282, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.requestsBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(103, 94);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(200, 20);
            this.iDTextBox.TabIndex = 4;
            // 
            // date_AddedDateTimePicker
            // 
            this.date_AddedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.requestsBindingSource, "Date_Added", true));
            this.date_AddedDateTimePicker.Location = new System.Drawing.Point(103, 137);
            this.date_AddedDateTimePicker.Name = "date_AddedDateTimePicker";
            this.date_AddedDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.date_AddedDateTimePicker.TabIndex = 6;
            // 
            // malfunction_TypeTextBox
            // 
            this.malfunction_TypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.requestsBindingSource, "Malfunction_Type", true));
            this.malfunction_TypeTextBox.Location = new System.Drawing.Point(103, 197);
            this.malfunction_TypeTextBox.Name = "malfunction_TypeTextBox";
            this.malfunction_TypeTextBox.Size = new System.Drawing.Size(200, 20);
            this.malfunction_TypeTextBox.TabIndex = 8;
            // 
            // problem_DescriptionTextBox
            // 
            this.problem_DescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.requestsBindingSource, "Problem_Description", true));
            this.problem_DescriptionTextBox.Location = new System.Drawing.Point(166, 254);
            this.problem_DescriptionTextBox.Name = "problem_DescriptionTextBox";
            this.problem_DescriptionTextBox.Size = new System.Drawing.Size(137, 20);
            this.problem_DescriptionTextBox.TabIndex = 10;
            // 
            // client_IDTextBox
            // 
            this.client_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.requestsBindingSource, "Client_ID", true));
            this.client_IDTextBox.Location = new System.Drawing.Point(464, 126);
            this.client_IDTextBox.Name = "client_IDTextBox";
            this.client_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.client_IDTextBox.TabIndex = 12;
            // 
            // statusTextBox
            // 
            this.statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.requestsBindingSource, "Status", true));
            this.statusTextBox.Location = new System.Drawing.Point(464, 193);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(100, 20);
            this.statusTextBox.TabIndex = 14;
            // 
            // ChabgeReyest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 595);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(client_IDLabel);
            this.Controls.Add(this.client_IDTextBox);
            this.Controls.Add(problem_DescriptionLabel);
            this.Controls.Add(this.problem_DescriptionTextBox);
            this.Controls.Add(malfunction_TypeLabel);
            this.Controls.Add(this.malfunction_TypeTextBox);
            this.Controls.Add(date_AddedLabel);
            this.Controls.Add(this.date_AddedDateTimePicker);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.requestsDataGridView);
            this.Name = "ChabgeReyest";
            this.Text = "ChabgeReyest";
            this.Load += new System.EventHandler(this.ChabgeReyest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.equipmentRepairDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EquipmentRepairDataSet equipmentRepairDataSet;
        private System.Windows.Forms.BindingSource requestsBindingSource;
        private EquipmentRepairDataSetTableAdapters.RequestsTableAdapter requestsTableAdapter;
        private EquipmentRepairDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView requestsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.DateTimePicker date_AddedDateTimePicker;
        private System.Windows.Forms.TextBox malfunction_TypeTextBox;
        private System.Windows.Forms.TextBox problem_DescriptionTextBox;
        private System.Windows.Forms.TextBox client_IDTextBox;
        private System.Windows.Forms.TextBox statusTextBox;
    }
}