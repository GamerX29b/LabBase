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

                    connection.Open();
                    sql = "USE Bank SELECT MAX(id) FROM client ";

                    command = new SqlCommand(sql, connection);
                    using (command)
                    {
                        //Показываем айдишник нового клиента
                        LsNewClient.Text = Convert.ToString(command.ExecuteScalar()); //Выбираем единственное 
                        connection.Close();
                    }
                }
            }
            upload();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e) //При загрузке формы
        {
            upload();
        }
        //Добавление нового вида кредита ------------------------------
        private void button2_Click(object sender, EventArgs e) 
        {
            using (SqlConnection connection = new SqlConnection(AddToBase.dataInfo))
            {
                connection.Open();
                String sql = "EXEC new_client_type '" + CreditTipBox.Text + "'";

                SqlCommand command = new SqlCommand(sql, connection);
                using (command)
                {
                    int i = command.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show
                            ("Новый вид кредита успешно добавлен");
                    }
                    connection.Close();
                }
            }
            upload();
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
            int i = 0;
            String S = " ";
            if (LSComboBox.Text == null | 
                CreditComboBox.Text == null | 
                SummCreditUpDown1.Value == 0)              //Проверять не пустые ли значения
            {
                MessageBox.Show
                           ("Заполнены не все поля");
            } else { 
            using (SqlConnection connection = new SqlConnection(AddToBase.dataInfo))
            {
                connection.Open();
                int x = CreditComboBox.SelectionStart + 1;
                String sql = "EXEC new_credit '" + SummCreditUpDown1.Text + "','"
                    + ProcentUpDown2.Text + "','" + dateTimeBack.Value + "','"
                    + dateTimeIssuance.Value + "','" + x + "','"
                    + LSComboBox.Text + "'";
                SqlCommand command = new SqlCommand(sql, connection);
                using (command)
                {
                        i = command.ExecuteNonQuery();   
                    connection.Close();
                }
                    connection.Open();
                    sql = "USE Bank SELECT MAX(id) FROM issuance_of_credit ";
                    command = new SqlCommand(sql, connection);
                    using (command)
                    {
                        //Показываем айдишник нового клиента
                       S = Convert.ToString(command.ExecuteScalar()); //Выбираем единственное 
                        connection.Close();
                    }
                    if (i > 0)
                    {
                        MessageBox.Show
                            ("Новый кредит успешно выдан, айди нового кредита: "+ S);
                    }
                }
            }
            upload();
        }//-------Это был блок добавления кредита-------^^^^^^^

        //-------Это блок показывающий данные о пользователе при выборе лицевого счёта в блоке выплаты-------VVVV
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {  //Надо показать остаток по кредиту, фио и телефон
            int id_client = 0;
            using (SqlConnection connection = new SqlConnection(AddToBase.dataInfo))
            {
                connection.Open(); //Получаем остаток по кредиту
                String sql = "USE Bank SELECT remainder_of_credit FROM issuance_of_credit WHERE id = " + LScomboBox2.Text;

                SqlCommand command = new SqlCommand(sql, connection);
                using (command)
                {

                    remainder.Text = Convert.ToString(command.ExecuteScalar()); //Выбираем единственное 
                    connection.Close();
                }

                connection.Open(); //Получаем айди пользователя для идентификации
                sql = "USE Bank SELECT id_client FROM issuance_of_credit WHERE id = " + LScomboBox2.Text;

                command = new SqlCommand(sql, connection);
                using (command)
                {
                 
                    id_client = Convert.ToInt16(command.ExecuteScalar()); //Выбираем единственное 
                    connection.Close();
                }
                connection.Open();
                sql = "USE Bank SELECT contact FROM client WHERE id = " + id_client;

                command = new SqlCommand(sql, connection);
                using (command)
                {
                    ClientName.Text = Convert.ToString(command.ExecuteScalar()); //Выбираем единственное 
                    connection.Close();
                }

                connection.Open();
                sql = "USE Bank SELECT telephone FROM client WHERE id = " + id_client;

                command = new SqlCommand(sql, connection);
                using (command)
                {
                    //ExecuteScalar выбирает единственное значение
                    ClientTel.Text = Convert.ToString(command.ExecuteScalar()); //Выбираем единственное 
                    connection.Close();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e) //--Блок выплаты кредита
        {
            using (SqlConnection connection = new SqlConnection(AddToBase.dataInfo))
            {
                connection.Open();
                int x = CreditComboBox.SelectionStart + 1;
                String sql = "EXEC new_repayment '" + SumUpDown3.Text  + "','"
                    + dateTimeRepa.Value + "','" + LScomboBox2.Text + "'";

                SqlCommand command = new SqlCommand(sql, connection);
                using (command)
                {

                    int i = command.ExecuteNonQuery();

                    if (i > 0)
                    {
                        MessageBox.Show
                            ("Новая выплата");
                    }

                    connection.Close();  //Мы выплатили

                    connection.Open(); //Получаем остаток по кредиту
                    sql = "USE Bank SELECT remainder_of_credit FROM issuance_of_credit WHERE id = " + LScomboBox2.Text;

                    command = new SqlCommand(sql, connection);
                    using (command)
                    {

                        remainder.Text = Convert.ToString(command.ExecuteScalar()); //Выбираем единственное 
                        connection.Close();
                    }

                }
            }
            upload();
        }

        void upload() //Обновление всех пунктов формы -----------------------------------------
        {
            using (SqlConnection connection = new SqlConnection(AddToBase.dataInfo)) //Добавление лицевых счетов в форму нового кредита
            {
                LSComboBox.Items.Clear();
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
                LScomboBox2.Items.Clear();
                String sql = "SELECT id FROM issuance_of_credit";
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
                CreditComboBox.Items.Clear();
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
    }
}
