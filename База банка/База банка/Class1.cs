using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace База_банка
{
    class AddToBase
    {
        
        public void newClient(String contact, String adress, String telephone) //Добавление нового  клиента в базу
        {

            Random rnd = new Random();
            int random = 0;
            DateTime dt = TimeZoneInfo.ConvertTimeToUtc(DateTime.Now);
            DateTime dt1970 = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            TimeSpan tsInterval = dt.Subtract(dt1970);
            random = rnd.Next(2, Convert.ToInt32(tsInterval.TotalSeconds));
            string sql = " ";

            sql = "instert into client VALUES ("+random+", "+ contact+ "', '" + adress + "', '" + telephone + "')";
            DataSet1;


        }
        public void newIssuance(int summ, int procent, string data, string dataIssuance, int id_type, int id_client) //Выдача кредита
        {
            Random rnd = new Random();
            int random = 0;
            DateTime dt = TimeZoneInfo.ConvertTimeToUtc(DateTime.Now);
            DateTime dt1970 = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            TimeSpan tsInterval = dt.Subtract(dt1970);
            random = rnd.Next(2, Convert.ToInt32(tsInterval.TotalSeconds));

            string sql = " ";
            sql = "instert into client VALUES (" + random + "," + summ + ", " + procent + ", '" + data + "'" +
                ", '" + dataIssuance + "', " + id_type + ", " + id_client + ")";
        }
        public void repayment(int summ, string date, int id_credit) //Один из возвратов кредита
        {
            Random rnd = new Random();
            int random = 0;
            DateTime dt = TimeZoneInfo.ConvertTimeToUtc(DateTime.Now);
            DateTime dt1970 = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            TimeSpan tsInterval = dt.Subtract(dt1970);
            random = rnd.Next(2, Convert.ToInt32(tsInterval.TotalSeconds));

            string sql = " ";
            sql = "instert into client VALUES (" + random + ", " + summ + ", '" + date + "', " + id_credit + ")";
        }
        public void newCreditType(string typeCredit)//Добавление типа кредита
        {
            Random rnd = new Random();
            int random = 0;
            DateTime dt = TimeZoneInfo.ConvertTimeToUtc(DateTime.Now);
            DateTime dt1970 = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            TimeSpan tsInterval = dt.Subtract(dt1970);
            random = rnd.Next(2, Convert.ToInt32(tsInterval.TotalSeconds));

            string sql = " ";
            sql = "instert into client VALUES (" + random + ", '" + typeCredit + "')";
        }
    }
}
