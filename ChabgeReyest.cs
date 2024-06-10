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
    public partial class ChabgeReyest : Form
    {
        public ChabgeReyest()
        {
            InitializeComponent();
        }

        private void ChabgeReyest_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "equipmentRepairDataSet.Requests". При необходимости она может быть перемещена или удалена.
            this.requestsTableAdapter.Fill(this.equipmentRepairDataSet.Requests);

         }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Validate();
            this.requestsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.equipmentRepairDataSet);
            this.requestsTableAdapter.Fill(this.equipmentRepairDataSet.Requests);
        }
    }
}
