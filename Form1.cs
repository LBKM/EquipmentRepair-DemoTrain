using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipmentRepair
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "equipmentRepairDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.equipmentRepairDataSet.Users);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ConnectionStg = "Data Source=WIN-2J5GGL22MAA\\SQLEXPRESS;Initial Catalog=EquipmentRepair;Integrated Security=True;";
            string login = textBox1.Text;
            string password = textBox2.Text;
            using (SqlConnection connection = new SqlConnection(ConnectionStg))
            {
                connection.Open();
                // проверка пользователя на наличие в базе данных  помощью запроса
                string authquery = "SELECT COUNT(*) FROM Users WHERE Login = @Login AND Password = @Password";
                SqlCommand sqlCommand = new SqlCommand(authquery, connection);
                sqlCommand.Parameters.AddWithValue("Login", login);
                sqlCommand.Parameters.AddWithValue("Password", password);
                int count = (int)sqlCommand.ExecuteScalar();
                {
                    //Если пользователь есть, открываем доступ к приложению
                    if (count > 0)
                    {
                        MainMenuForm mainMenuForm = new MainMenuForm();
                        this.Hide();
                        mainMenuForm.ShowDialog();
                        this.Close();
                    }
                    //В ином случае, вывод с ошибкой
                    else
                    {
                        MessageBox.Show("Неправильный ввод данных при авторизации!", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }

        }
    }
}
