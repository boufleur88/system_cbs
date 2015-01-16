using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Npgsql;

namespace cbs_sistema
{
   class Servidor
   {
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
