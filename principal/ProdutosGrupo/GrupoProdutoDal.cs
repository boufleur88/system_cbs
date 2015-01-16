using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Npgsql;
using System.Data;


namespace cbs_sistema
{
   class GrupoProdutoDal : GrupoProduto
   {

      public void gravar(GrupoProduto pGrupo)
      {
         try
         {
            // NpgsqlConnection conexion = Servidor.conectar();
            NpgsqlConnection conexion = Servidor.conectar();

            NpgsqlCommand sql = new NpgsqlCommand("insert into st_grupo (st_grupo) values (@st_grupo)", conexion);
            sql.Parameters.AddWithValue("@st_grupo", pGrupo.Grupo);

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

            NpgsqlCommand consulta_grupo = new NpgsqlCommand("select id_grupo, st_grupo from st_grupo order by id_grupo", conexion);
            NpgsqlDataAdapter dt_adapter_grupo = new NpgsqlDataAdapter();
            dt_adapter_grupo.SelectCommand = consulta_grupo;

            DataTable dt_lista_grupo = new DataTable();
            dt_adapter_grupo.Fill(dt_lista_grupo);

            conexion.Close();

            return dt_lista_grupo;
         }
         catch (Exception error)
         {
            throw error;
         }

      }

      public void alterar(GrupoProduto pGrupo)
      {
         try
         {
            NpgsqlConnection conexion = Servidor.conectar();

            // update per_grupo set per_grupo = 'TESTE' where id_grupo = '1'
            NpgsqlCommand sql = new NpgsqlCommand("update st_grupo set st_grupo = @grupo where id_grupo = @codigo", conexion);
            sql.Parameters.AddWithValue("@codigo", pGrupo.Id);
            sql.Parameters.AddWithValue("@grupo", pGrupo.Grupo);

            sql.ExecuteNonQuery();

            conexion.Close();

         }
         catch (Exception erro)
         {
            throw erro;
         }
      }

      // EXCLUIR DATOS...
      public void excluir(GrupoProduto pGrupo)
      {
         try
         {
            NpgsqlConnection conexion = Servidor.conectar();

            NpgsqlCommand sql = new NpgsqlCommand("delete from st_grupo where id_grupo = @codigo", conexion);
            sql.Parameters.AddWithValue("@codigo", pGrupo.Id);

            sql.ExecuteNonQuery();

            conexion.Close();

         }
         catch (Exception error)
         {
            throw error;
         }
      }


      public DataTable Buscar(string pGrupo)
      {
         try
         {
            NpgsqlConnection conexion = Servidor.conectar();

            NpgsqlCommand consulta_grupo = new NpgsqlCommand(string.Format("select id_grupo, st_grupo from st_grupo WHERE st_grupo LIKE '%{0}%' order by id_grupo", pGrupo), conexion);
            NpgsqlDataAdapter dt_adapter_grupo = new NpgsqlDataAdapter();
            dt_adapter_grupo.SelectCommand = consulta_grupo;

            DataTable dt_bucar = new DataTable();
            dt_adapter_grupo.Fill(dt_bucar);

            conexion.Close();

            return dt_bucar;
         }
         catch (Exception error)
         {
            throw error;
         }

      }


      // OBTENER LISTA COMBO BOX REGISTRO DE PRODUTOS.
      public List<GrupoProduto> ObtenerListaGrupo()
      {
         List<GrupoProduto> _lista = new List<GrupoProduto>();

         NpgsqlConnection conexion = Servidor.conectar();

         NpgsqlCommand sql = new NpgsqlCommand("select id_grupo, st_grupo from st_grupo order by id_grupo", conexion);
         NpgsqlDataReader _reader = sql.ExecuteReader();

         while (_reader.Read())
         {
            GrupoProduto pGrupo = new GrupoProduto();

            pGrupo.Id = _reader.GetInt32(0);
            pGrupo.Grupo = _reader.GetString(1);

            _lista.Add(pGrupo);
         }

         conexion.Close();
         return _lista;
      }

      /*
       Función para buscar mientras escribas en el textbox. Cargar una nueva tabla Datagrid y buscar en la tabla directamente.
       * query es la consulta.
       * dataset donde cargara los datos.
       * tabla es el resulado.
       */
      public void Buscar_datos(string query, ref DataSet dstprincipal, string tabla)
      {
         try
         {
            NpgsqlConnection conexion = Servidor.conectar();

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
