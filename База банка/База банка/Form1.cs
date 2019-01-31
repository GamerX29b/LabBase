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

namespace База_банка
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e) // Добавление нового клиента
        {
            using (SqlConnection connection = new SqlConnection(AddToBase.dataInfo))
            {
                connection.Open();
                String sql = "EXEC new_client '"+ textAdress.Text + 
                    "', '"+ ContactData.Text + "', '"+ TelephoneBox.Text + "'";

                SqlCommand command = new SqlCommand(sql, connection);
                using (command)
                {      
                    int i = command.ExecuteNonQuery();

                    if (i > 0)
                    {
                        MessageBox.Show
                            ("Клиент успешно добавлен");
                    }
                    connection.Close();
                }
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e) //При загрузке формы
        {
            using (SqlConnection connection = new SqlConnection(AddToBase.dataInfo)) //Добавление лицевых счетов в форму нового кредита
            {
                String sql = "SELECT id FROM client";
                SqlCommand command = new SqlCommand(sql, connection);
                using (command)
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        LSComboBox.Items.Add(Convert.ToString(reader.GetSqlInt32(0))); 
                    }
                    reader.Close();
                }
            }
            using (SqlConnection connection = new SqlConnection(AddToBase.dataInfo)) //Добавление лицевых счетов в форму погашения кредита
            {
                String sql = "SELECT id FROM client";
                SqlCommand command = new SqlCommand(sql, connection);
                using (command)
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        LScomboBox2.Items.Add(Convert.ToString(reader.GetSqlInt32(0)));
                    }
                    reader.Close();
                }
            }
            using (SqlConnection connection = new SqlConnection(AddToBase.dataInfo))//Добавление типов кредитов
            {
                String sql = "SELECT type_credit FROM credit_type";
                SqlCommand command = new SqlCommand(sql, connection);
                using (command)
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        CreditComboBox.Items.Add(reader.GetString(0));
                    }
                    reader.Close();
                }
            }
        }
        //Добавление нового кредита ------------------------------
        private void button2_Click(object sender, EventArgs e) 
        {
            using (SqlConnection connection = new SqlConnection(AddToBase.dataInfo))
            {
                connection.Open();
                String sql = "EXEC new_credit '" + CreditTipBox.Text + "'";

                SqlCommand command = new SqlCommand(sql, connection);
                using (command)
                {

                    int i = command.ExecuteNonQuery();

                    if (i > 0)
                    {
                        MessageBox.Show
                            ("Новый кредит успешно добавлен");
                    }

                    connection.Close();
                }


            }
        }

        private void LSComboBox_SelectedIndexChanged(object sender, EventArgs e) //Показать ФИО введённого ID
        {
            using (SqlConnection connection = new SqlConnection(AddToBase.dataInfo))
            {
                connection.Open();
                String sql = "USE Bank SELECT contact FROM client WHERE id = " + LSComboBox.Text;

                SqlCommand command = new SqlCommand(sql, connection);
                using (command)
                {
                                                //ExecuteScalar выбирает единственное значение
                    ContactDataLabel.Text = Convert.ToString(command.ExecuteScalar()); //Выбираем единственное 
                    connection.Close();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e) //Новый кредит
        {
            if(LSComboBox.Text != null | 
                CreditComboBox.Text != null | 
                numericUpDown1.Value == 0)              //Проверять не пустые ли значения
            {
                MessageBox.Show
                           ("Заполнены не все поля");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(AddToBase.dataInfo))
            {
                connection.Open();
                String sql = "USE Bank SELECT contact FROM client WHERE id = " + LScomboBox2.Text;

                SqlCommand command = new SqlCommand(sql, connection);
                using (command)
                {
                    //ExecuteScalar выбирает единственное значение
                    ClientName.Text = Convert.ToString(command.ExecuteScalar()); //Выбираем единственное 
                    connection.Close();
                }
                connection.Open();
                sql = "USE Bank SELECT telephone FROM client WHERE id = " + LScomboBox2.Text;

                command = new SqlCommand(sql, connection);
                using (command)
                {
                    //ExecuteScalar выбирает единственное значение
                    ClientTel.Text = Convert.ToString(command.ExecuteScalar()); //Выбираем единственное 
                    connection.Close();
                }

            }
        }
    }
}
