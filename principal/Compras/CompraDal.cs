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

      // funcion para gravar la compra.
      public void gravar_cabecera(Compra pCompra)
      {
         try
         {
             // conectar ao banco de datos.
            NpgsqlConnection conexion = Servidor.conectar();

            // comando insert sql para o banco                       
            NpgsqlCommand sql = new NpgsqlCommand("INSERT INTO compras (d_inclusion, n_factura, id_cliente, id_user, total, observacion) VALUES (@c_fecha, @c_factura, @c_persona, @c_usuario, @c_total, @c_obs);", conexion);
            sql.Parameters.AddWithValue("@c_fecha", pCompra.f_inclusion);
            sql.Parameters.AddWithValue("@c_factura", pCompra.factura);
            sql.Parameters.AddWithValue("@c_persona", pCompra.pid);
            sql.Parameters.AddWithValue("@c_usuario", pCompra.uid);
            sql.Parameters.AddWithValue("@c_total", pCompra.totalCompra);
            sql.Parameters.AddWithValue("@c_obs", pCompra.observacion);

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
                NpgsqlCommand sql = new NpgsqlCommand("SELECT c.id_compra, c.d_inclusion, p.per_nombre, c.total, c.observacion FROM compras AS c, persona AS p WHERE c.id_cliente = p.id_per ORDER BY c.id_compra;", conexion);

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
                // return dt_lista;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }


        /* COMPRAS - OBTENER ULTIMO ID DE COMPRAS.
        public ultimo_id()
        {
            try
            {
                NpgsqlConnection conexion = Servidor.conectar();

                NpgsqlCommand sql = new NpgsqlCommand("SELECT id_compra FROM compras where id_compra = (select max(id_compra) from compras);", conexion);
                return Convert.ToInt32(sql.ExecuteScalar());

                conexion.Close();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        */

        public void Teste()
        {
            // instanciar compra.
            Compra NovaCompra = new Compra();
            NovaCompra.cid = 10;
        }
    }

}
