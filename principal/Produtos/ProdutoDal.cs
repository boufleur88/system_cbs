using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Npgsql;

namespace sistema_cbs
{
   class ProdutoDal: Produto
   {
      // METODOS PARA GRAVAR PRODUTOS
      public void gravar(Produto pProduto)
      {
         try
         {
            NpgsqlConnection conexion = Servidor.conectar();

            
            // comando insert sql para o banco                       
            NpgsqlCommand sql = new NpgsqlCommand("insert into produto (pro_descr, pro_unidad, pro_moneda, pro_iva, pro_costocon, pro_costoadm, pro_ventamay, pro_ventamin, pro_cantmin, pro_obs, id_marca, id_grupo, id_subgrupo) values (@pro_ean, @pro_orig, @pro_fabr, @pro_descr, @pro_unidad, @pro_moneda, @pro_iva, @pro_costocon, @pro_costoadm, @pro_ventamay, @pro_ventamin, @pro_cantmin, @pro_obs, @pro_marca, @pro_grupo, @pro_subgrupo);", conexion);
            sql.Parameters.AddWithValue("@pro_descr", pProduto.descr);
            sql.Parameters.AddWithValue("@pro_unidad", pProduto.unidad);
            sql.Parameters.AddWithValue("@pro_moneda", pProduto.moneda);
            sql.Parameters.AddWithValue("@pro_iva", pProduto.iva);
            sql.Parameters.AddWithValue("@pro_costocon", pProduto.costocon);
            sql.Parameters.AddWithValue("@pro_costoadm", pProduto.costoadm);
            sql.Parameters.AddWithValue("@pro_ventamay", pProduto.ventamay);
            sql.Parameters.AddWithValue("@pro_ventamin", pProduto.ventamin);
            sql.Parameters.AddWithValue("@pro_cantmin", pProduto.st_minimo);
            sql.Parameters.AddWithValue("@pro_obs", pProduto.observacion);
            sql.Parameters.AddWithValue("@pro_marca", pProduto.marca);
            sql.Parameters.AddWithValue("@pro_grupo", pProduto.grupo);
            sql.Parameters.AddWithValue("@pro_subgrupo", pProduto.subgrupo);

            sql.ExecuteNonQuery();
            conexion.Close();
         }
         catch (Exception erro)
         {
            throw erro;
         }
      }
      
      // PRODUCTOS - EXCLUIR DATOS...
      public void excluir(Produto pProduto)
      {
         try
         {
            NpgsqlConnection conexion = Servidor.conectar();

            NpgsqlCommand sql = new NpgsqlCommand("delete from produto where id_produto = @codigo", conexion);
            sql.Parameters.AddWithValue("@codigo", pProduto.codigo);

            sql.ExecuteNonQuery();
            conexion.Close();
         }
         catch (Exception error)
         {
            throw error;
         }
      }

      // PRODUTO. ALTERAR DATOS.
      public void alterar(Produto pProduto)
      {
         try
         {
            NpgsqlConnection conexion = Servidor.conectar();

            NpgsqlCommand sql = new NpgsqlCommand("update produto set pro_descr = @descripcion, pro_ventamay = @ventamay, pro_ventamin = @ventamin, id_marca = @marca, id_grupo = @grupo, id_subgrupo = @subgrupo, pro_unidad = @unidad, pro_cantmin = @stminimo, pro_moneda = @moneda, pro_iva = @iva, pro_obs = @observacion, pro_costocon = @costocont, pro_costoadm = @costoadm where  id_produto = @codigo", conexion);

            sql.Parameters.AddWithValue("@codigo", pProduto.codigo);
            sql.Parameters.AddWithValue("@descripcion", pProduto.descr);
            sql.Parameters.AddWithValue("@ventamay", pProduto.ventamay);
            sql.Parameters.AddWithValue("@ventamin", pProduto.ventamin);
            sql.Parameters.AddWithValue("@marca", pProduto.marca);
            sql.Parameters.AddWithValue("@grupo", pProduto.grupo);
            sql.Parameters.AddWithValue("@subgrupo", pProduto.subgrupo);
            sql.Parameters.AddWithValue("@unidad", pProduto.unidad);
            sql.Parameters.AddWithValue("@stminimo", pProduto.st_minimo);
            sql.Parameters.AddWithValue("@moneda", pProduto.moneda);
            sql.Parameters.AddWithValue("@iva", pProduto.iva);
            sql.Parameters.AddWithValue("@observacion", pProduto.observacion);
            sql.Parameters.AddWithValue("@costocont", pProduto.costocon);
            sql.Parameters.AddWithValue("@costoadm", pProduto.costoadm);

            sql.ExecuteNonQuery();
            conexion.Close();
         }
         catch (Exception erro)
         {
            throw erro;
         }
      }


      // METODO LISTA PRODUTOS.
       // A mesma consulta direto no banco demora 34ms y no C# 3 segundos.
      public DataTable listar()
      {
         try
         {
            NpgsqlConnection conexion = Servidor.conectar();

            // executa a instrucao 
            NpgsqlCommand sql = new NpgsqlCommand("SELECT produto.id_produto, produto.pro_descr, produto.pro_ventamay, produto.pro_ventamin, st_marca.st_marca, st_grupo.st_grupo, st_subgrupo.st_subgrupo, produto.pro_unidad, produto.pro_cantmin, produto.pro_moneda, produto.pro_iva, produto.pro_obs, pro_costocon, produto.pro_costoadm FROM produto, st_grupo, st_marca, st_subgrupo WHERE produto.id_grupo = st_grupo.id_grupo AND produto.id_marca = st_marca.id_marca AND produto.id_subgrupo = st_subgrupo.id_subgrupo order by produto.id_produto", conexion);

            NpgsqlDataAdapter dt_adapter = new NpgsqlDataAdapter();
            dt_adapter.SelectCommand = sql;

            DataTable dt_lista_produto = new DataTable();
            dt_adapter.Fill(dt_lista_produto);

            conexion.Close();
            return dt_lista_produto;
         }
         catch (Exception error)
         {
            throw error;
         }
      }

      public DataTable listar_algunos()
      {
          try
          {
              NpgsqlConnection conexion = Servidor.conectar();

              // executa a instrucao 
              NpgsqlCommand sql = new NpgsqlCommand("SELECT produto.id_produto, produto.pro_descr, produto.pro_ventamay, produto.pro_ventamin, st_marca.st_marca, st_grupo.st_grupo, st_subgrupo.st_subgrupo, produto.pro_unidad, produto.pro_cantmin, produto.pro_moneda, produto.pro_iva, produto.pro_obs, pro_costocon, produto.pro_costoadm FROM produto, st_grupo, st_marca, st_subgrupo WHERE produto.id_grupo = st_grupo.id_grupo AND produto.id_marca = st_marca.id_marca AND produto.id_subgrupo = st_subgrupo.id_subgrupo AND produto.id_produto < 50 ORDER BY produto.id_produto", conexion);

              NpgsqlDataAdapter dt_adapter = new NpgsqlDataAdapter();
              dt_adapter.SelectCommand = sql;

              DataTable ls = new DataTable();
              dt_adapter.Fill(ls);

              conexion.Close();
              return ls;
          }
          catch (Exception error)
          {
              throw error;
          }
      }

      // METODO BUSCAR...
      public DataTable Buscar(string produto)
      {
         try
         {
            NpgsqlConnection conexion = Servidor.conectar();

            NpgsqlCommand sql = new NpgsqlCommand(string.Format("SELECT produto.id_produto, produto.pro_descr, produto.pro_ventamay, produto.pro_ventamin, st_marca.st_marca, st_grupo.st_grupo, st_subgrupo.st_subgrupo, produto.pro_unidad, produto.pro_cantmin, produto.pro_moneda, produto.pro_iva, produto.pro_obs, pro_costocon, produto.pro_costoadm FROM produto, st_grupo, st_marca, st_subgrupo WHERE produto.id_grupo = st_grupo.id_grupo AND produto.id_marca = st_marca.id_marca AND produto.id_subgrupo = st_subgrupo.id_subgrupo AND produto.pro_descr LIKE '%{0}%' order by produto.id_produto", produto), conexion);

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

      // public DataTable dt_busca { get; set; }
      /*
      public List<Produto> Buscar(string produto)
      {
         List<Produto> _lista = new List<Produto>();

         try
         {
            NpgsqlConnection conexion = Servidor.conectar();

            NpgsqlCommand _comando = new NpgsqlCommand(string.Format("SELECT produto.id_produto, produto.pro_descr, produto.pro_ventamay, produto.pro_ventamin, produto.pro_orig, produto.pro_fabr, st_marca.st_marca, st_grupo.st_grupo, st_subgrupo.st_subgrupo, produto.pro_ean, produto.pro_unidad, produto.pro_cantmin, produto.pro_moneda, produto.pro_iva, produto.pro_obs, pro_costocon, produto.pro_costoadm FROM produto, st_grupo, st_marca, st_subgrupo WHERE produto.id_grupo = st_grupo.id_grupo AND produto.id_marca = st_marca.id_marca AND produto.id_subgrupo = st_subgrupo.id_subgrupo AND produto.pro_descr LIKE '%{0}%' order by produto.id_produto", produto), conexion);

            NpgsqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())
            {
               Produto obj = new Produto();
               obj.codigo = _reader.GetInt32(0);
               obj.descr = _reader.GetString(1);
               //obj.ventamay = _reader.GetDouble(2);
               //obj.ventamin = _reader.GetDouble(3);
               obj.orig = _reader.GetString(4);
               obj.fabr = _reader.GetString(5);
               obj.Nmarcar = _reader.GetString(6); 
               obj.Ngrupo = _reader.GetString(7);
               obj.Nsubgrupo = _reader.GetString(8);
               obj.ean = _reader.GetString(9);
               obj.unidad = _reader.GetString(10);
               //obj.st_minimo = _reader.GetInt32(11);
               obj.moneda = _reader.GetInt32(12);
               //obj.iva = _reader.GetInt32(13);
               obj.observacion = _reader.GetString(14);
               /*obj.costocon = _reader.GetDouble(15);
               obj.costoadm = _reader.GetDouble(16);
               
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
*/

      
   }
}
