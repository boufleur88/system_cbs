using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace sistema_cbs
{
    class CuentaDal
    {
     // Metodo Gravar
        public void gravar(Cuenta cuenta)
        {
            try
            {
                // instanciar a conexao
                NpgsqlConnection conexion = Servidor.conectar();

                // comando insert sql para o banco                       
                NpgsqlCommand sql = new NpgsqlCommand("INSERT INTO plancta (codcta, c_descr, c_moeda, c_impu, c_user) VALUES (@codigo, @cuenta, @moeda, @imput, @user);", conexion);
                sql.Parameters.AddWithValue("@codigo", cuenta.codigo);
                sql.Parameters.AddWithValue("@cuenta", cuenta.cuenta);
                sql.Parameters.AddWithValue("@moeda", cuenta.moeda);
                sql.Parameters.AddWithValue("@imput", cuenta.imput);
                sql.Parameters.AddWithValue("@user", cuenta.user);

                sql.ExecuteNonQuery();

                conexion.Close();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        // EDITAR
        public void alterar(Cuenta cuenta)
        {
            try
            {
                NpgsqlConnection conexion = Servidor.conectar();

                NpgsqlCommand sql = new NpgsqlCommand("UPDATE plancta SET codcta = @codigo, c_descr = @cuenta, c_moeda = @moeda, c_impu = @imput, c_user = @user where id_cta = @id", conexion);
                sql.Parameters.AddWithValue("@codigo", cuenta.codigo);
                sql.Parameters.AddWithValue("@cuenta", cuenta.cuenta);
                sql.Parameters.AddWithValue("@moeda", cuenta.moeda);
                sql.Parameters.AddWithValue("@imput", cuenta.imput);
                sql.Parameters.AddWithValue("@user", cuenta.user);

                sql.ExecuteNonQuery();

                conexion.Close();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        // METODO LISTA PERSONAS.
        public DataTable listar()
        {
            try
            {
                NpgsqlConnection conexion = Servidor.conectar();

                // executa a instrucao 
                NpgsqlCommand sql = new NpgsqlCommand("SELECT codcta, c_descr FROM plancta ORDER BY codcta", conexion);
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
