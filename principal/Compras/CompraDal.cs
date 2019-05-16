using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data; // organizar clases que trabalha com datos.
using Npgsql; // proveedor banco de datos postgresql.

namespace sistema_cbs
{
    class CompraDal : Compra
    {
 
        public int GeraCodigo()
        {
            int codigo = 0;

            try
            {
                // conectar ao banco de datos.
                NpgsqlConnection conexion = Servidor.conectar();

                NpgsqlCommand sql = new NpgsqlCommand("SELECT id_compra FROM compras where id_compra = (select max(id_compra) from compras);", conexion);

                codigo = (int)sql.ExecuteScalar();
            }
            catch
            { 
                
            }
            return codigo + 1;
        }



      // funcion para gravar la compra.
      public void gravar_cabecera(Compra pCompra)
      {
         try
         {
             // conectar ao banco de datos.
            NpgsqlConnection conexion = Servidor.conectar();

            // comando insert sql para o banco                       
            NpgsqlCommand sql = new NpgsqlCommand("INSERT INTO compras (c_inclusion, c_vencimiento, c_factura, id_cliente, id_usuario, c_iva00, c_iva05, c_iva10, c_total, c_obs, id_moneda, id_sucursal, id_status) VALUES (@inclusion, @vencimiento, @factura, @persona, @usuario, @iva00, @iva05, @iva10, @total, @obs, @moneda, @sucursal, @status);", conexion);
            sql.Parameters.AddWithValue("@inclusion", pCompra.f_inclusion);
            sql.Parameters.AddWithValue("@vencimiento", pCompra.f_vencimiento);
            sql.Parameters.AddWithValue("@factura", pCompra.factura);
            sql.Parameters.AddWithValue("@persona", pCompra.pid);
            sql.Parameters.AddWithValue("@usuario", pCompra.uid);
            sql.Parameters.AddWithValue("@iva00", pCompra.iva00);
            sql.Parameters.AddWithValue("@iva05", pCompra.iva05);
            sql.Parameters.AddWithValue("@iva10", pCompra.iva10);
            sql.Parameters.AddWithValue("@total", pCompra.totalCompra);
            sql.Parameters.AddWithValue("@obs", pCompra.observacion);
            sql.Parameters.AddWithValue("@moneda", pCompra.moneda);
            sql.Parameters.AddWithValue("@sucursal", pCompra.sucursal);
            sql.Parameters.AddWithValue("@status", pCompra.status);

            sql.ExecuteNonQuery();
            conexion.Close();
         }
         catch (Exception erro)
         {
            throw erro;
         }
      }

        // funcion para gravar la compra.
        public void gravar_itens(Compra itCompra)
        {
            try
            {
                // conectar ao banco de datos.
                NpgsqlConnection conexion = Servidor.conectar();

                // comando insert sql para o banco                       
                NpgsqlCommand sql = new NpgsqlCommand("INSERT INTO itemcompras (NumCom, CodPro, it_desc, it_cant, it_costo1) " +
                                                     " VALUES (@idCompra, @idProduto, @descricao, @cantidad, @costo);", conexion);
                sql.Parameters.AddWithValue("@idCompra", itCompra.cid);
                sql.Parameters.AddWithValue("@idProduto", itCompra.it_codigo);
                sql.Parameters.AddWithValue("@descricao", itCompra.it_description);
                sql.Parameters.AddWithValue("@cantidad", itCompra.it_cantidad);
                sql.Parameters.AddWithValue("@costo", itCompra.it_costo);
                
                sql.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        // METODO LISTA COMPRAS.
        public DataTable listar_Compras()
        {
            try
            {
                NpgsqlConnection conexion = Servidor.conectar();

                // executa a instrucao 
                NpgsqlCommand sql = new NpgsqlCommand("SELECT c.id_compra, c.c_inclusion, c.c_vencimiento, c.id_cliente, p.per_nombre, c.c_total, c.c_obs, p.per_tel1, p.per_ruc " +
                                                       "FROM compras AS c, persona AS p " +
                                                      "WHERE c.id_cliente = p.id_per " +
                                                      "ORDER BY c.id_compra desc LIMIT 20;", conexion);

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

        // METODO LISTAR ITEMS COMPRAS.
        public DataTable listarItemsCompras(string ultimoCodigo)
        {
            try
            {
                NpgsqlConnection conexion = Servidor.conectar();

                // executa a instrucao 
                string consulta = "";
                consulta = "SELECT CodPro, it_desc, it_cant, it_costo1, (it_cant * it_costo1) as TOTAL FROM itemcompras WHERE NumCom = '" + ultimoCodigo + "'";

                NpgsqlCommand sql = new NpgsqlCommand(consulta, conexion);

                NpgsqlDataAdapter dt_adapter = new NpgsqlDataAdapter();
                dt_adapter.SelectCommand = sql;

                DataTable dtItem = new DataTable();
                dt_adapter.Fill(dtItem);

                conexion.Close();
                return dtItem;
            }
            catch (Exception error)
            {
                throw error;
            }
        }


        // PRODUTO. ALTERAR DATOS.
        public void ultimo_id(Compra pCompra)
        {
            
            try
            {
                NpgsqlConnection conexion = Servidor.conectar();

                NpgsqlCommand sql = new NpgsqlCommand("SELECT id_compra FROM compras where id_compra = (select max(id_compra) from compras);", conexion);
               
                NpgsqlDataAdapter dt_adapter = new NpgsqlDataAdapter();
                dt_adapter.SelectCommand = sql;

                DataTable dt_lista = new DataTable();
                dt_adapter.Fill(dt_lista);

                conexion.Close();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

    }

}
