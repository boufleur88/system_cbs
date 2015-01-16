using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Npgsql;
using System.Data;

namespace sistema_cbs
{
   class Servidor
   {
      /*
       public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=Tutorial; Uid=root; pwd=;");
           
                conectar.Open();
                return conectar;        
        }
       */

      public static NpgsqlConnection conectar()
      {
         NpgsqlConnection conectar = new NpgsqlConnection("Server=localhost; Port=5432; User id=postgres; Password=kikiu159; Database=cbs_master");

         conectar.Open();
         return conectar;
      }



      /*
      public NpgsqlConnection conectar()
      {
         NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; User id=postgres; Password=kikiu159; Database=cbs_master");
         conn.Open();
         //conn.Close();

         return conn;

      }
      */

      /*
      // funcao para conectar con o banco de datos.
       * 
      //private NpgsqlConnection myConnection;
      //String sql;
      
       * public NpgsqlConnection conectar()
      {
         sql = "Server=localhost; Port=5432; User id=postgres; Password=kikiu159; Database=cbs_master";
         myConnection = new NpgsqlConnection(sql); // pego a conexao que creamos na variavel acima conexao banco.
         myConnection.Open();

         // myConnection.Close();
         return myConnection;
      }
      */

      /*
      public static void Main(String[] args)
      {
         NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; User id=postgres; Password=kikiu159; Database=cbs_master");
         conn.Open();
         conn.Close();
      }
      */
   }
}
