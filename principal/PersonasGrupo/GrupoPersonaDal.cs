using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Npgsql;
using System.Data;

namespace sistema_cbs
{
   class GrupoPersonaDal:GrupoPersona
   {

      // METODO GRAVAR GRUPO DE PERSONAS
      public void gravar(GrupoPersona gPersona)
      {
         try
         {
            NpgsqlConnection conexion = Servidor.conectar();
            
            // comando insert sql para o banco                 
            NpgsqlCommand sql = new NpgsqlCommand("insert into per_grupo (per_grupo) values (@per_grupo)", conexion);
            sql.Parameters.AddWithValue("@per_grupo", gPersona.nombre);
            
            sql.ExecuteNonQuery();
            conexion.Close();
         }
         catch (Exception error)
         {
            throw error;
         }
      }

      public void alterar(GrupoPersona gPersona)
      {
         try
         {
            NpgsqlConnection conexion = Servidor.conectar();
            
            NpgsqlCommand sql = new NpgsqlCommand("update per_grupo set per_grupo = @grupo where id_grupo = @codigo", conexion);
            sql.Parameters.AddWithValue("@codigo",gPersona.id_grupo_per);
            sql.Parameters.AddWithValue("@grupo", gPersona.nombre);

            sql.ExecuteNonQuery();
            conexion.Close();
         }
         catch (Exception erro)
         {
            throw erro;
         }
      }

      // EXCLUIR DATOS...
      public void excluir(GrupoPersona gPersona)
      {
         try
         {
            NpgsqlConnection conexion = Servidor.conectar();
            
            NpgsqlCommand sql = new NpgsqlCommand("delete from per_grupo where id_grupo = @codigo", conexion);
            sql.Parameters.AddWithValue("@codigo", gPersona.id_grupo_per);

            sql.ExecuteNonQuery();
            conexion.Close();
         }
         catch (Exception error)
         {
            throw error;
         }
      }


      // DATATABLE LISTA DE GRUPO PERSONAS...
      public DataTable lista_grupo_per()
      {
         try
         {
            NpgsqlConnection conexion = Servidor.conectar();
            
            // executa a instrucao 
            NpgsqlCommand sql = new NpgsqlCommand("SELECT id_grupo, per_grupo FROM per_grupo ORDER BY id_grupo", conexion);
            NpgsqlDataAdapter dt_adapter_grupo_per = new NpgsqlDataAdapter();
            dt_adapter_grupo_per.SelectCommand = sql;

            DataTable dt_lista_grupo_per = new DataTable();
            dt_adapter_grupo_per.Fill(dt_lista_grupo_per);

            conexion.Close();
            return dt_lista_grupo_per;
         }
         catch (Exception error)
         {
            throw error;
         }
      }


      // metodo buscar cliente. FUNCIONANDO...
      public List<GrupoPersona> Buscar(string pGrupo)
      {
         List<GrupoPersona> _lista = new List<GrupoPersona>();

         try
         {
            NpgsqlConnection conexion = Servidor.conectar();
            
            NpgsqlCommand _comando = new NpgsqlCommand(string.Format("select id_grupo, per_grupo from per_grupo WHERE per_grupo LIKE '%{0}%' order by per_grupo", pGrupo), conexion);

            NpgsqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())
            {
               GrupoPersona obj = new GrupoPersona();
               obj.id_grupo_per = _reader.GetInt32(0);
               obj.nombre = _reader.GetString(1);

               _lista.Add(obj);
            }

            conexion.Close();
            return _lista;

         }
         catch (Exception error)
         {
            throw error;
         }
      }
   }
}
