using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Npgsql;
using System.Data;

namespace sistema_cbs
{
   class CiudadDal:Ciudad
   {
      
      // GRAVAR CIUDAD
      public void gravar_Ciudad(Ciudad pCiudad)
      {
         try
         {
            NpgsqlConnection conexion = Servidor.conectar();
            
           // comando insert sql para o banco                       
            NpgsqlCommand sql = new NpgsqlCommand(string.Format("insert into per_ciudad (per_ciudad) values ('{0}')", pCiudad.Nombre), conexion);

            sql.ExecuteNonQuery();
            conexion.Close();
         }
         catch (Exception erro)
         {
            throw erro;
         }
      }


      public void alterar_Ciudad(Ciudad pCiudad)
      {
         try
         {
            NpgsqlConnection conexion = Servidor.conectar();
            
            NpgsqlCommand sql = new NpgsqlCommand("update per_ciudad set per_ciudad = @ciudad where id_ciudad = @codigo", conexion);
            sql.Parameters.AddWithValue("@codigo", pCiudad.Id);
            sql.Parameters.AddWithValue("@ciudad", pCiudad.Nombre);
       
            sql.ExecuteNonQuery();
            conexion.Close();
         }
         catch (Exception erro)
         {
            throw erro;
         }
      }

      // EXCLUIR DATOS...
      public void excluir_ciudad(Ciudad pCiudad)
      {
         try
         {
            NpgsqlConnection conexion = Servidor.conectar();
            
            NpgsqlCommand sql = new NpgsqlCommand("delete from per_ciudad where id_ciudad = @codigo", conexion);
            sql.Parameters.AddWithValue("@codigo", pCiudad.Id);

            sql.ExecuteNonQuery();
            conexion.Close();
         }
         catch (Exception error)
         {
            throw error;
         }
      }

      // LISTA CIUDADES.
      public DataTable lista_ciudad()
      {
         try
         {
            NpgsqlConnection conexion = Servidor.conectar();
            
            // NpgsqlCommand sql = new NpgsqlCommand("select * from per_ciudad", conexao);
            NpgsqlCommand sql = new NpgsqlCommand("select id_ciudad, per_ciudad from per_ciudad order by id_ciudad", conexion);
            
            NpgsqlDataAdapter dt_adapter = new NpgsqlDataAdapter();
            dt_adapter.SelectCommand = sql;

            DataTable dt_lista = new DataTable();
            dt_adapter.Fill(dt_lista);

            conexion.Close();
            return dt_lista;
         }
         catch (Exception error)
         {
            throw error;
         }
      }


      //
      public DataTable buscar(string pCiudad)
      {
         try
         {
            NpgsqlConnection conexion = Servidor.conectar();

            // NpgsqlCommand sql = new NpgsqlCommand("select * from per_ciudad", conexao);
            NpgsqlCommand sql = new NpgsqlCommand(string.Format("select id_ciudad, per_ciudad from per_ciudad WHERE per_ciudad = '{%0%}' order by per_ciudad", pCiudad), conexion);

            NpgsqlDataAdapter dt_adapter = new NpgsqlDataAdapter();
            dt_adapter.SelectCommand = sql;

            DataTable dt_buscar = new DataTable();
            dt_adapter.Fill(dt_buscar);

            conexion.Close();
            return dt_buscar;
         }
         catch (Exception error)
         {
            throw error;
         }
      }

      /*
      // metodo buscar cliente. FUNCIONANDO...
      public List<Ciudad> Buscar(string pCiudad)
      {
         List<Ciudad> _lista = new List<Ciudad>();

         try
         {
            NpgsqlConnection conexion = Servidor.conectar();
            
            NpgsqlCommand _comando = new NpgsqlCommand(string.Format("select id_ciudad, per_ciudad from per_ciudad WHERE per_ciudad = '{%0%}' order by per_ciudad", pCiudad), conexion);

            NpgsqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())
            {
               Ciudad objeto = new Ciudad();
               objeto.Id = _reader.GetInt32(0);
               objeto.Nombre = _reader.GetString(1);
               
               _lista.Add(objeto);
            }

            conexion.Close();
            return _lista;

         }
         catch (Exception error)
         {
            throw error;
         }
      }
      */

      public List<Ciudad> ObtenerCiudad()
      {
         List<Ciudad> _lista = new List<Ciudad>();

         NpgsqlConnection conexion = Servidor.conectar();
         
         NpgsqlCommand _comando = new NpgsqlCommand(("select id_ciudad, per_ciudad from per_ciudad"), conexion);

         NpgsqlDataReader _reader = _comando.ExecuteReader();

         while (_reader.Read())
         {
            Ciudad objeto = new Ciudad();
            objeto.Id = _reader.GetInt32(0);
            objeto.Nombre = _reader.GetString(1);

            _lista.Add(objeto);
         }

         conexion.Close();
         return _lista;
      }
  }
}
