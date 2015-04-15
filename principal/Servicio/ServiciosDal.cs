using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Npgsql;
using sistema_cbs.Servicio;

namespace sistema_cbs
{
    class ServiciosDal : Servicios
    {
        // Metodo que grava en el banco de datos.
        public void gravar(Servicios pServicio)
        {
            try
            {
                NpgsqlConnection conexion = Servidor.conectar();

                // comando insert sql para o banco                       
                NpgsqlCommand sql = new NpgsqlCommand("INSERT INTO servicio (descripcion, costo, precio_min, precio, observacion, id_sgrupo) values (@sDescripcion, @sCosto, @sPrecioMin, @sPrecio, @sObservacion, @sGrupo);", conexion);
                sql.Parameters.AddWithValue("@sDescripcion", pServicio.descripcion);
                sql.Parameters.AddWithValue("@sCosto", pServicio.costo);
                sql.Parameters.AddWithValue("@sPrecioMin", pServicio.preciomin);
                sql.Parameters.AddWithValue("@sPrecio", pServicio.precio);
                sql.Parameters.AddWithValue("@sObservacion", pServicio.observacion);
                sql.Parameters.AddWithValue("@sGrupo", pServicio.id_grupo);
                
                sql.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        // SERVICIOS. ALTERAR DATOS.
        public void alterar(Servicios pServicio)
        {
            try
            {
                NpgsqlConnection conexion = Servidor.conectar();

                NpgsqlCommand sql = new NpgsqlCommand("UPDATE servicio SET descripcion = @sDescripcion, costo = @sCosto, precio_min = @sPrecioMin, precio = @sPrecio, observacion = @sObservacion, id_sgrupo = @sGrupo WHERE id_servicio = @sIdServicio;", conexion);

                sql.Parameters.AddWithValue("@sIdServicio", pServicio.id_servicio);
                sql.Parameters.AddWithValue("@sDescripcion", pServicio.descripcion);
                sql.Parameters.AddWithValue("@sCosto", pServicio.costo);
                sql.Parameters.AddWithValue("@sPrecioMin", pServicio.preciomin);
                sql.Parameters.AddWithValue("@sPrecio", pServicio.precio);
                sql.Parameters.AddWithValue("@sObservacion", pServicio.observacion);
                sql.Parameters.AddWithValue("@sGrupo", pServicio.id_grupo);

                sql.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }





        // OBTENER LISTA COMBO BOX REGISTRO DE PRODUTOS.
        public List<Servicios> ObtenerListaGrupo()
        {
            List<Servicios> _lista = new List<Servicios>();

            NpgsqlConnection conexion = Servidor.conectar();

            NpgsqlCommand sql = new NpgsqlCommand("SELECT id_sgrupo, sgrupo FROM ser_grupo ORDER BY id_sgrupo;", conexion);
            NpgsqlDataReader _reader = sql.ExecuteReader();

            while (_reader.Read())
            {
                Servicios sGrupo = new Servicios();

                sGrupo.id_grupo = _reader.GetInt32(0);
                sGrupo.grupo = _reader.GetString(1);

                _lista.Add(sGrupo);
            }
            return _lista;
        }


        // METODO LISTA SERVICIOS.
        public DataTable listar()
        {
            try
            {
                NpgsqlConnection conexion = Servidor.conectar();

                // executa a instrucao 
                NpgsqlCommand sql = new NpgsqlCommand("SELECT s.id_servicio, s.descripcion, s.costo, s.precio_min, s.precio, g.sgrupo, s.observacion FROM servicio AS s LEFT JOIN ser_grupo AS g ON s.id_sgrupo = g.id_sgrupo ORDER BY id_servicio;", conexion);

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

        // METODO BUSCAR...
        public DataTable Buscar(string servicio)
        {
            try
            {
                NpgsqlConnection conexion = Servidor.conectar();

                NpgsqlCommand sql = new NpgsqlCommand(string.Format("SELECT	s.id_servicio, s.descripcion, s.costo, s.precio_min, s.precio, g.sgrupo, s.observacion FROM servicio AS s LEFT JOIN ser_grupo AS g ON	s.id_sgrupo = g.id_sgrupo WHERE s.descripcion LIKE '%{0}%' ORDER BY id_servicio", servicio), conexion);

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

    }
}
