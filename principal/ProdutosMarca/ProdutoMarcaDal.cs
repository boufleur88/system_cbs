using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Npgsql;

namespace sistema_cbs
{
   class ProdutoMarcaDal : ProdutoMarca
   {

      
      // METODOS GRAVA SUB GRUPO PRODUTO
      public void gravar(ProdutoMarca pMarca)
      {
         try
         {
            NpgsqlConnection conexion = Servidor.conectar();

            NpgsqlCommand sql = new NpgsqlCommand("insert into st_marca (st_marca) values (@marca);", conexion);
            sql.Parameters.AddWithValue("@marca", pMarca.marca);

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

            NpgsqlCommand sql = new NpgsqlCommand("select id_marca, st_marca from st_marca order by id_marca", conexion);
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

      public void alterar(ProdutoMarca pMarca)
      {
         try
         {
            NpgsqlConnection conexion = Servidor.conectar();

            NpgsqlCommand sql = new NpgsqlCommand("update st_marca set st_marca = @marca where id_marca = @codigo", conexion);
            sql.Parameters.AddWithValue("@codigo", pMarca.codigo);
            sql.Parameters.AddWithValue("@marca", pMarca.marca);

            sql.ExecuteNonQuery();
            conexion.Close();
         }
         catch (Exception erro)
         {
            throw erro;
         }
      }

      // EXCLUIR DATOS...
      public void excluir(ProdutoMarca pMarca)
      {
         try
         {
            NpgsqlConnection conexion = Servidor.conectar();

            NpgsqlCommand sql = new NpgsqlCommand("delete from st_marca where id_marca = @codigo", conexion);
            sql.Parameters.AddWithValue("@codigo", pMarca.codigo);

            sql.ExecuteNonQuery();
            conexion.Close();
         }
         catch (Exception error)
         {
            throw error;
         }
      }

      public DataTable Buscar(string pMarca)
      {
         try
         {
            NpgsqlConnection conexion = Servidor.conectar();

            NpgsqlCommand sql = new NpgsqlCommand(string.Format("select id_marca, st_marca from st_marca WHERE st_marca LIKE '%{0}%' order by st_marca", pMarca), conexion);
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

      // Metodo carcar combo box marca
      public List<ProdutoMarca> ObtenerLista()
      {
         List<ProdutoMarca> _lista = new List<ProdutoMarca>();

         NpgsqlConnection conexion = Servidor.conectar();

         NpgsqlCommand sql = new NpgsqlCommand("select id_marca, st_marca from st_marca order by id_marca", conexion);
         NpgsqlDataReader _reader = sql.ExecuteReader();

         while (_reader.Read())
         {
            ProdutoMarca pMarca = new ProdutoMarca();

            pMarca.codigo = _reader.GetInt32(0);
            pMarca.marca = _reader.GetString(1);

            _lista.Add(pMarca);
         }

         return _lista;
      }

   }
}
