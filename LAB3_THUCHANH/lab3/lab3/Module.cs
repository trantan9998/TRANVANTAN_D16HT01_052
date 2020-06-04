using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Module
    {
        public static string cnnStr = @"Data Source=VANTAN\TRANTAN;Initial Catalog=QLDATBAO;Integrated Security=True";
        public static SqlConnection cnn = new SqlConnection(cnnStr);
       
    }
}
