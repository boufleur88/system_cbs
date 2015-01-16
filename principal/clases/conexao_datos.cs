using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Npgsql;
using System.Data;

namespace cbs_sistema
{
    class conexao_datos : modelo_datos
    {
        String conexao_banco = "Server=localhost; Port=5432; User id=postgres; Password=kikiu159; Database=cbs_master";
        // crear conexao con o banco. nombre banco = cbs_master
        NpgsqlConnection conexao = null;
        // funcao para conectar con o banco de datos.
        public void conectar()
        {
            conexao = new NpgsqlConnection(conexao_banco); // pego a conexao que creamos na variavel acima conexao banco.
        }


        /*****************************************************************************************************************************************************/   
        // USUARIOS...
        public DataTable lista_usuarios()
        {
            try
            {
                conexao = new NpgsqlConnection(conexao_banco);
                // executa a instrucao 
                NpgsqlCommand consulta_usuarios = new NpgsqlCommand("select * from usuarios", conexao);
                NpgsqlDataAdapter dt_adapter_usuario = new NpgsqlDataAdapter();
                dt_adapter_usuario.SelectCommand = consulta_usuarios;
                DataTable dt_lista_usuario = new DataTable();
                dt_adapter_usuario.Fill(dt_lista_usuario);
                return dt_lista_usuario;
            }
            catch (Exception error)
            {
                throw error;
            }
            finally
            {
                conexao.Close();
            }

        }

        public void grava_datos_usuarios(modelo_datos usuario)
        {
            try
            {
                conexao = new NpgsqlConnection(conexao_banco);
                NpgsqlCommand grava_usuarios = new NpgsqlCommand("insert into usuarios values (@user_codigo, @user_nombre, @user_usuario, @user_clave, @user_ci, @user_tel1, @user_email)", conexao);
                grava_usuarios.Parameters.AddWithValue("@user_codigo", usuario.codigo);
                grava_usuarios.Parameters.AddWithValue("@user_nombre", usuario.nombre);
                grava_usuarios.Parameters.AddWithValue("@user_usuario", usuario.usuario);
                grava_usuarios.Parameters.AddWithValue("@user_clave", usuario.clave);
                grava_usuarios.Parameters.AddWithValue("@user_ci", usuario.cedula);
                grava_usuarios.Parameters.AddWithValue("@user_tel1", usuario.telefono1);
                grava_usuarios.Parameters.AddWithValue("@user_email", usuario.email);
                conexao.Open();
                grava_usuarios.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                throw error;
            }
            finally
            {
                conexao.Close();
            }
            
        }

        public void excluir_usuario(modelo_datos usuario)
        {
            try
            {
                conexao = new NpgsqlConnection(conexao_banco);
                NpgsqlCommand excluir_usuarios = new NpgsqlCommand("delete from usuarios where user_codigo = @user_codigo", conexao);
                excluir_usuarios.Parameters.AddWithValue("@user_codigo", usuario.codigo);

                conexao.Open();
                excluir_usuarios.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                throw error;
            }
            finally
            {
                conexao.Close();
            }
        }

       /*#############################################################################################################################   
       // PRODUTOS
       // METODOS PARA GRAVAR PRODUTOS
       public void grava_datos_produto(modelo_datos produto)
       {
           try
           {
               conexao = new NpgsqlConnection(conexao_banco);
               // comando insert sql para o banco                       
               NpgsqlCommand sql_produto = new NpgsqlCommand("insert into produto (pro_ean, pro_orig, pro_fabr, pro_descr, pro_aplic, pro_unidad, pro_moneda, pro_iva, pro_costocon, pro_costoadm, pro_ventamay, pro_ventamin, pro_cantmin, pro_obs) values (@pro_ean, @pro_orig, @pro_fabr, @pro_descr, @pro_aplic, @pro_unidad, @pro_moneda, @pro_iva, @pro_costocon, @pro_costoadm, @pro_ventamay, @pro_ventamin, @pro_cantmin, @pro_obs);", conexao);
               sql_produto.Parameters.AddWithValue("@pro_ean", produto.ProdEan);
               sql_produto.Parameters.AddWithValue("@pro_orig", produto.ProdOrig);
               sql_produto.Parameters.AddWithValue("@pro_fabr", produto.ProdFabr);
               sql_produto.Parameters.AddWithValue("@pro_descr", produto.ProdDesc);
               sql_produto.Parameters.AddWithValue("@pro_aplic", produto.ProdAplic);
               sql_produto.Parameters.AddWithValue("@pro_unidad", produto.ProdUnidad);
               sql_produto.Parameters.AddWithValue("@pro_moneda", produto.ProdMoneda);
               sql_produto.Parameters.AddWithValue("@pro_iva", produto.ProdIva);
               sql_produto.Parameters.AddWithValue("@pro_costocon", produto.ProdCostoCon);
               sql_produto.Parameters.AddWithValue("@pro_costoadm", produto.ProdCostoAdm);
               sql_produto.Parameters.AddWithValue("@pro_ventamay", produto.ProdVentaMay);
               sql_produto.Parameters.AddWithValue("@pro_ventamin", produto.ProdVentaMin);
               sql_produto.Parameters.AddWithValue("@pro_cantmin", produto.ProdCantMin);
               sql_produto.Parameters.AddWithValue("@pro_obs", produto.ProdObs);
                


               conexao.Open();
               sql_produto.ExecuteNonQuery();
           }
           catch (Exception erro)
           {
               throw erro;
           }
           finally
           {
               conexao.Close();
           }
       }


       // METODO LISTA PRODUTOS.
       public DataTable lista_produtos()
       {
           try
           {
               conexao = new NpgsqlConnection(conexao_banco);
               // executa a instrucao 
               NpgsqlCommand sql_produtos = new NpgsqlCommand("select id_pro, pro_descr, pro_ventamay, pro_ventamin, pro_orig, pro_fabr, pro_marca, pro_grupo, pro_subgrupo, pro_ean, pro_unidad, pro_cantmin, pro_moneda, pro_iva, pro_obs, pro_costocon, pro_costoadm from produto order by id_pro", conexao);
               NpgsqlDataAdapter dt_adapter_produto = new NpgsqlDataAdapter();
               dt_adapter_produto.SelectCommand = sql_produtos;

               DataTable dt_lista_produto = new DataTable();
               dt_adapter_produto.Fill(dt_lista_produto);
               return dt_lista_produto;
           }
           catch (Exception error)
           {
               throw error;
           }
           finally
           {
               conexao.Close();
           }
       }

       // PRODUCTOS - EXCLUIR DATOS...
       public void excluir(modelo_datos pProduto)
       {
          try
          {
             conexao = new NpgsqlConnection(conexao_banco);


             NpgsqlCommand sql = new NpgsqlCommand("delete from produto where id_pro = @codigo", conexao);
             sql.Parameters.AddWithValue("@codigo", pProduto.ProdCod);

             conexao.Open();
             sql.ExecuteNonQuery();
          }
          catch (Exception error)
          {
             throw error;
          }
          finally
          {
             conexao.Close();
          }
       }

      // PRODUTO. ALTERAR DATOS.
       public void alterar(modelo_datos pProduto)
       {
          try
          {
             conexao = new NpgsqlConnection(conexao_banco);

             NpgsqlCommand sql = new NpgsqlCommand("update produto set pro_descr = @descripcion, pro_ventamay = @ventamay, pro_ventamin = @ventamin, pro_orig = @original, pro_fabr = @fabricante, pro_marca = @marca, pro_subgrupo = @subgrupo, pro_ean = @ean, pro_unidad = @unidad, pro_cantmin = @stminimo, pro_moneda = @moneda, pro_iva = @iva, pro_obs = @observacion, pro_costocon = @costocont, pro_costoadm = @costoadm where  id_pro = @codigo", conexao);

             sql.Parameters.AddWithValue("@codigo", pProduto.ProdCod);
             sql.Parameters.AddWithValue("@descripcion", pProduto.ProdDesc);
             sql.Parameters.AddWithValue("@ventamay", pProduto.ProdVentaMay);
             sql.Parameters.AddWithValue("@ventamin", pProduto.ProdVentaMin);
             sql.Parameters.AddWithValue("@original", pProduto.ProdOrig);
             sql.Parameters.AddWithValue("@fabricante", pProduto.ProdFabr);
             //sql.Parameters.AddWithValue("@marca", pProduto.MarcaProd);
             // sql.Parameters.AddWithValue("@subgrupo", pProduto.SubGrupoProd);
             sql.Parameters.AddWithValue("@ean", pProduto.ProdEan );
             sql.Parameters.AddWithValue("@unidad", pProduto.ProdUnidad);
             sql.Parameters.AddWithValue("@stminimo", pProduto.ProdCantMin);
             sql.Parameters.AddWithValue("@moneda", pProduto.ProdMoneda);
             sql.Parameters.AddWithValue("@iva", pProduto.ProdIva);
             sql.Parameters.AddWithValue("@observacion", pProduto.ProdObs);
             sql.Parameters.AddWithValue("@costocont", pProduto.ProdCostoCon);
             sql.Parameters.AddWithValue("@costoadm", pProduto.ProdCostoAdm);

             conexao.Open();
             sql.ExecuteNonQuery();
          }
          catch (Exception erro)
          {
             throw erro;
          }
          finally
          {
             conexao.Close();
          }
       }
      */

    }
}
