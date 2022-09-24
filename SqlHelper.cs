using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormApplication
{
    public class SqlHelper
    {
        public SqlConnection Connection() {
         SqlConnection Connection  = new SqlConnection(@"Data Source=DESKTOP-LDMU7VJ\SQLEXPRESS;Initial Catalog=DormOtomation;Integrated Security=True");
            Connection.Open();
            return Connection;  
        }
    }
}
