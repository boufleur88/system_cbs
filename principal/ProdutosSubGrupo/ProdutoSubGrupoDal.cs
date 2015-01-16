using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Npgsql;

namespace cbs_sistema
{
   class ProdutoSubGrupoDal : ProdutoSubGrupo
   {
      // METODOS GRAVA SUB GRUPO PRODUTO
      public void gravar(ProdutoSubGrupo pSubGrupo)
      {
         try
         {
            NpgsqlConnection conexion = Servidor.conectar();
            //conexion;

            NpgsqlCommand sql = new NpgsqlCommand("insert into st_subgrupo (st_subgrupo) values (@st_subgrupo)", conexion);
            sql.Parameters.AddWithValue("@st_subgrupo", pSubGrupo.Subgrupo);

            sql.ExecuteNonQuery();
            
            conexion.Close();
            
         }
         catch (Exception error)
         {
            throw error;
         }
      }

      public DataTable listar()
      {
         try
         {
            NpgsqlConnection conexion = Servidor.conectar();

            NpgsqlCommand sql = new NpgsqlCommand("select id_subgrupo, st_subgrupo from st_subgrupo order by id_subgrupo", conexion);
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

      public void alterar(ProdutoSubGrupo pSubGrupo)
      {
         try
         {
            NpgsqlConnection conexion = Servidor.conectar();

            NpgsqlCommand sql = new NpgsqlCommand("update st_subgrupo set st_subgrupo = @subgrupo where id_subgrupo = @codigo", conexion);
            sql.Parameters.AddWithValue("@codigo", pSubGrupo.Id);
            sql.Parameters.AddWithValue("@subgrupo", pSubGrupo.Subgrupo);

            sql.ExecuteNonQuery();

            conexion.Close();
         }
         catch (Exception erro)
         {
            throw erro;
         }
      }

      // EXCLUIR DATOS...
      public void excluir(ProdutoSubGrupo pSubGrupo)
      {
         try
         {
            NpgsqlConnection conexion = Servidor.conectar();

            NpgsqlCommand sql = new NpgsqlCommand("delete from st_subgrupo where id_subgrupo = @codigo", conexion);
            sql.Parameters.AddWithValue("@codigo", pSubGrupo.Id);

            sql.ExecuteNonQuery();

            conexion.Close();
         }
         catch (Exception error)
         {
            throw error;
         }
      }

      public DataTable Buscar(string pSubGrupo)
      {
         try
         {
            NpgsqlConnection conexion = Servidor.conectar();

            NpgsqlCommand sql = new NpgsqlCommand(string.Format("select id_subgrupo, st_subgrupo from st_subgrupo WHERE st_subgrupo LIKE '%{0}%' order by st_subgrupo", pSubGrupo), conexion);
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

      // obtener lista sub grupo.
      public List<ProdutoSubGrupo> ObtenerLista()
      {
         List<ProdutoSubGrupo> _lista = new List<ProdutoSubGrupo>();

         NpgsqlConnection conexion = Servidor.conectar();

         NpgsqlCommand sql = new NpgsqlCommand("select id_subgrupo , st_subgrupo from st_subgrupo order by id_subgrupo", conexion);
         NpgsqlDataReader _reader = sql.ExecuteReader();

         while (_reader.Read())
         {
            ProdutoSubGrupo pSubGrupo = new ProdutoSubGrupo();

            pSubGrupo.Id = _reader.GetInt32(0);
            pSubGrupo.Subgrupo = _reader.GetString(1);

            _lista.Add(pSubGrupo);
         }
         conexion.Close();
         return _lista;
      }


      public void Buscar_datos(string query, ref DataSet dstprincipal, string tabla)
      {
         try
         {
            NpgsqlConnection conexion = Servidor.conectar();

            //NpgsqlCommand sql = new NpgsqlCommand(string.Format("select id_marca, st_marca from st_marca WHERE st_marca LIKE '%{0}%' order by st_marca", query), conexion);
            NpgsqlCommand sql = new NpgsqlCommand(query, conexion);

            NpgsqlDataAdapter dt = new NpgsqlDataAdapter(sql);
            dt.Fill(dstprincipal, tabla);
            dt.Dispose();  // detiene cualquier carga adicional en la tabla. 

            conexion.Close();

         }
         catch (Exception error)
         {
            throw error;
         }
      }


   }
}
