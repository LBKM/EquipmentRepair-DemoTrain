using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EquipmentRepair
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void assignmentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.assignmentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.equipmentRepairDataSet);

        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            

            FillListView();

            comboBox1.Items.Add("Все типы");
            foreach (DataRow Row_WP in equipmentRepairDataSet.Requests) comboBox1.Items.Add(Row_WP["Malfunction_Type"]);
        }
        private void FillListView()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "equipmentRepairDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.equipmentRepairDataSet.Users);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "equipmentRepairDataSet.Requests". При необходимости она может быть перемещена или удалена.
            this.requestsTableAdapter.Fill(this.equipmentRepairDataSet.Requests);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "equipmentRepairDataSet.Executors". При необходимости она может быть перемещена или удалена.
            this.requestsTableAdapter.Update(this.equipmentRepairDataSet.Requests);
            this.executorsTableAdapter.Fill(this.equipmentRepairDataSet.Executors);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "equipmentRepairDataSet.Equipment". При необходимости она может быть перемещена или удалена.
            this.equipmentTableAdapter.Fill(this.equipmentRepairDataSet.Equipment);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "equipmentRepairDataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.equipmentRepairDataSet.Clients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "equipmentRepairDataSet.Assignments". При необходимости она может быть перемещена или удалена.
            this.assignmentsTableAdapter.Fill(this.equipmentRepairDataSet.Assignments);
            listView1.Items.Clear();
            foreach(DataRow row in equipmentRepairDataSet.Requests.Rows)
            {
                string[] items = new string[7];
            DataRow tempRow;
                items[1] = row[1].ToString();

                tempRow = row.GetParentRow("FK__Requests__Equipm__3A81B327");
                items[2] = tempRow[1].ToString();

                items[3] = row[3].ToString();

                items[4] = row[4].ToString();

                tempRow = row.GetParentRow("FK__Requests__Client__3B75D760");
                items[5] = tempRow[1].ToString();

                items[6] = row[6].ToString();


                ListViewItem item = new ListViewItem();
                item.Text = row[0].ToString();
                item.SubItems.AddRange(items);
                listView1.Items.Add(item);  
                listView1.Items[listView1.Items.Count - 1].BackColor = items[6] == "ого!!!" ? Color.LightGreen : Color.White;
            }
        }
        private void FillListViewCBFilt()
        {

            listView1.Items.Clear();
            foreach (DataRow row in equipmentRepairDataSet.Requests.Rows)
            {
                DataRow DataRowStatus = equipmentRepairDataSet.Requests.Select("Malfunction_Type = '" + comboBox1.SelectedItem + "'")[0];
                if (row["Malfunction_Type"].ToString() == DataRowStatus["Malfunction_Type"].ToString())
                {
                    string[] items = new string[7];
                    DataRow tempRow;
                    items[1] = row[1].ToString();

                    tempRow = row.GetParentRow("FK__Requests__Equipm__3A81B327");
                    items[2] = tempRow[1].ToString();

                    items[3] = row[3].ToString();

                    items[4] = row[4].ToString();

                    tempRow = row.GetParentRow("FK__Requests__Client__3B75D760");
                    items[5] = tempRow[1].ToString();

                    items[6] = row[6].ToString();


                    ListViewItem item = new ListViewItem();
                    item.Text = row[0].ToString();
                    item.SubItems.AddRange(items);
                    listView1.Items.Add(item);
                    listView1.Items[listView1.Items.Count - 1].BackColor = items[6] == "ого!!!" ? Color.LightGreen : Color.White;
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            foreach (DataRow row in equipmentRepairDataSet.Requests.OrderByDescending(p => p.Problem_Description))
            {
                DataRow TempRow;

                string[] items = new string[7];
                DataRow tempRow;
                items[1] = row[1].ToString();

                tempRow = row.GetParentRow("FK__Requests__Equipm__3A81B327");
                items[2] = tempRow[1].ToString();

                items[3] = row[3].ToString();

                items[4] = row[4].ToString();

                tempRow = row.GetParentRow("FK__Requests__Client__3B75D760");
                items[5] = tempRow[1].ToString();

                items[6] = row[6].ToString();


                ListViewItem item = new ListViewItem();
                item.Text = row[0].ToString();
                item.SubItems.AddRange(items);
                listView1.Items.Add(item);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
                listView1.Items.Clear();
                foreach (DataRow row in equipmentRepairDataSet.Requests.OrderBy(p => p.Problem_Description))
                {
                    DataRow TempRow;

                    string[] items = new string[7];
                    DataRow tempRow;
                    items[1] = row[1].ToString();

                    tempRow = row.GetParentRow("FK__Requests__Equipm__3A81B327");
                    items[2] = tempRow[1].ToString();

                    items[3] = row[3].ToString();

                    items[4] = row[4].ToString();

                    tempRow = row.GetParentRow("FK__Requests__Client__3B75D760");
                    items[5] = tempRow[1].ToString();

                    items[6] = row[6].ToString();


                    ListViewItem item = new ListViewItem();
                    item.Text = row[0].ToString();
                    item.SubItems.AddRange(items);
                    listView1.Items.Add(item);
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FillListView();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string strFindMDK = textBox1.Text;
            listView1.Items.Clear();
            foreach (DataRow row in equipmentRepairDataSet.Requests.Select("Problem_Description LIKE '%" + strFindMDK + "*'"))
            {
                DataRow TempRow;

                string[] items = new string[7];
                DataRow tempRow;
                items[1] = row[1].ToString();

                tempRow = row.GetParentRow("FK__Requests__Equipm__3A81B327");
                items[2] = tempRow[1].ToString();

                items[3] = row[3].ToString();

                items[4] = row[4].ToString();

                tempRow = row.GetParentRow("FK__Requests__Client__3B75D760");
                items[5] = tempRow[1].ToString();

                items[6] = row[6].ToString();


                ListViewItem item = new ListViewItem();
                item.Text = row[0].ToString();
                item.SubItems.AddRange(items);
                listView1.Items.Add(item);
            }

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedItem)
            {
                case "Все типы":
                    FillListView();
                    break;
                default:
                    FillListViewCBFilt();
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            requestsTableAdapter.Fill(equipmentRepairDataSet.Requests);

            AddReqForm addReqForm = new AddReqForm();
            addReqForm.ShowDialog();

            if (addReqForm.DialogResult == DialogResult.OK)
            {
                requestsTableAdapter.Update(equipmentRepairDataSet.Requests);
                FillListView();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                DataRow Row = equipmentRepairDataSet.Requests.Select("ID = '" + item.Text + "'")[0];
                DataRow[] TempRows = Row.GetChildRows("FK__Requests__Equipm__3A81B327");
                if (TempRows.Length != 0)
                {
                    MessageBox.Show("Этот есть в чьем-то заказе.\nHевозможно удалить!", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                item.Remove();
                try
                {
                    Row.Delete();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Вызов исключений");
                }
            }

            requestsTableAdapter.Update(equipmentRepairDataSet.Requests);
            equipmentTableAdapter.Update(equipmentRepairDataSet.Equipment);
            FillListView();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            ChabgeReyest chabgeReyest= new ChabgeReyest();
            chabgeReyest.ShowDialog();
            if (chabgeReyest.DialogResult == DialogResult.OK)
            {
                this.requestsTableAdapter.Update(this.equipmentRepairDataSet.Requests);
                this.executorsTableAdapter.Fill(this.equipmentRepairDataSet.Executors);
                FillListView();
            }
        }
    }
}
