using EquipmentRepair.EquipmentRepairDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipmentRepair
{
    public partial class AddReqForm : Form
    {
        public AddReqForm()
        {
            InitializeComponent();
        }

        private void AddReqForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "equipmentRepairDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.equipmentRepairDataSet.Users);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "equipmentRepairDataSet.Requests". При необходимости она может быть перемещена или удалена.
            this.requestsTableAdapter.Fill(this.equipmentRepairDataSet.Requests);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "equipmentRepairDataSet.Executors". При необходимости она может быть перемещена или удалена.
            this.executorsTableAdapter.Fill(this.equipmentRepairDataSet.Executors);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "equipmentRepairDataSet.Assignments". При необходимости она может быть перемещена или удалена.
            this.assignmentsTableAdapter.Fill(this.equipmentRepairDataSet.Assignments);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "equipmentRepairDataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.equipmentRepairDataSet.Clients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "equipmentRepairDataSet.Equipment". При необходимости она может быть перемещена или удалена.
            this.equipmentTableAdapter.Fill(this.equipmentRepairDataSet.Equipment);

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            int InsertedRows = requestsTableAdapter.Insert( //Добавление данных в БД через поля приложения:
           Convert.ToDateTime(dateTimePicker1.Text),
           Convert.ToInt32(iDTextBox.Text),
           comboBox1.Text.ToString(),
           textBox1.Text.ToString(),
           Convert.ToInt32(iDTextBox1.Text),
           textBox2.Text.ToString());

            try
            {
                if (InsertedRows > 0)
                    MessageBox.Show("Успешное добавление!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                if (InsertedRows == 0)
                    // Если произошла ошибка, отобразите сообщение об ошибке
                    MessageBox.Show("Не удалось добавить новые данные. Причина: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.tableAdapterManager.UpdateAll(this.equipmentRepairDataSet);
            requestsTableAdapter.Update(equipmentRepairDataSet.Requests);
            this.requestsTableAdapter.Fill(this.equipmentRepairDataSet.Requests);
            requestsTableAdapter.Update(equipmentRepairDataSet.Requests);
            this.Close();
            
        }
    }
}
