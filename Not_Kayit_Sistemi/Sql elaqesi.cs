using System.Data.SqlClient;

namespace Not_Kayit_Sistemi
{
    class Sql_elaqesi
    {
        public SqlConnection Elaqe()
        {
            SqlConnection elaqe = new SqlConnection("Data Source=DESKTOP-FKU6315\\SQL;Initial Catalog=DbNotKayit;Integrated Security=True");
            elaqe.Open();
            return elaqe;
        }
    }
}
