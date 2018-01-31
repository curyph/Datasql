using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;

namespace DataAc
{
    public class SqlCon
    {
        public SqlConnection myConnection = new SqlConnection("user id=sa;" +
                                       "password=l4p1s;server=PEDRO-PC\\SQLFGA;" +
                                       "Trusted_Connection=yes;" +
                                       "database=DBC; " +
                                       "connection timeout=15");



        public SqlCommand myCommand = new SqlCommand();
        }
}
