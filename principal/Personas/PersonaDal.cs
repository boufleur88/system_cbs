using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Npgsql;
using System.Data;

namespace sistema_cbs
{
   class PersonaDal : Persona
   {
       /*   Adicionar nueva columna personas.
            ALTER TABLE persona ADD COLUMN per_situacion CHAR(1) DEFAULT 'A'; 
        */

      public void gravar(Persona persona)
      {
         try
         {
            // instanciar a conexao
            NpgsqlConnection conexion = Servidor.conectar();
           
            // comando insert sql para o banco                       
            NpgsqlCommand sql = new NpgsqlCommand("insert into persona (per_ruc, per_nombre, per_ci, per_fant, per_dir, per_tel1, per_tel2, per_email, per_nac, per_clt, per_prov, per_func, per_obs, per_ciudad, per_situacion, per_pais) values (@per_ruc, @per_nombre, @per_ci, @per_fant, @per_dir, @per_tel1, @per_tel2, @per_email, @per_nac, @per_clt, @per_prov, @per_func, @per_obs, @per_ciudad, @per_situacion, @per_pais);", conexion);
            sql.Parameters.AddWithValue("@per_ruc", persona.ruc);
            sql.Parameters.AddWithValue("@per_nombre", persona.nombre);
            sql.Parameters.AddWithValue("@per_ci", persona.cedula);
            sql.Parameters.AddWithValue("@per_fant", persona.fantasia);
            sql.Parameters.AddWithValue("@per_dir", persona.direccion);
            sql.Parameters.AddWithValue("@per_tel1", persona.tel1);
            sql.Parameters.AddWithValue("@per_tel2", persona.tel2);
            sql.Parameters.AddWithValue("@per_email", persona.email);
            sql.Parameters.AddWithValue("@per_nac", persona.nacimento);
            sql.Parameters.AddWithValue("@per_clt", persona.cliente);
            sql.Parameters.AddWithValue("@per_prov", persona.proveedor);
            sql.Parameters.AddWithValue("@per_func", persona.funcionario);
            sql.Parameters.AddWithValue("@per_obs", persona.observacion);
            sql.Parameters.AddWithValue("@per_ciudad", persona.ciudad);
            sql.Parameters.AddWithValue("@per_situacion", persona.situacion);
            sql.Parameters.AddWithValue("@per_pais", persona.pais);

            sql.ExecuteNonQuery();

            conexion.Close();
         }
         catch (Exception erro)
         {
            throw erro;
         }
        
      }


      // EDITAR
      public void alterar(Persona persona)
      {
         try
         {
            NpgsqlConnection conexion = Servidor.conectar();
            
            NpgsqlCommand sql = new NpgsqlCommand("update persona set per_nombre = @nombre, per_fant = @fantasia, per_ruc = @ruc, per_ci = @cedula, per_tel1 = @tel1, per_tel2 = @tel2, per_email = @email, per_dir = @dir, per_ciudad = @ciudad, per_nac = @nacimento, per_clt = @cliente, per_prov = @proveedor, per_func = @funcionario, per_obs = @obs, per_situacion = @situacion, per_pais = @pais where id_per = @codigo", conexion);
            
            sql.Parameters.AddWithValue("@codigo", persona.idPersona);
            sql.Parameters.AddWithValue("@nombre", persona.nombre);
            sql.Parameters.AddWithValue("@fantasia", persona.fantasia);
            sql.Parameters.AddWithValue("@ruc", persona.ruc);
            sql.Parameters.AddWithValue("@cedula", persona.cedula);
            sql.Parameters.AddWithValue("@tel1", persona.tel1);
            sql.Parameters.AddWithValue("@tel2", persona.tel2);
            sql.Parameters.AddWithValue("@email", persona.email);
            sql.Parameters.AddWithValue("@dir", persona.direccion);
            sql.Parameters.AddWithValue("@ciudad", persona.ciudad);
            sql.Parameters.AddWithValue("@nacimento", persona.nacimento);
            sql.Parameters.AddWithValue("@cliente", persona.cliente);
            sql.Parameters.AddWithValue("@proveedor", persona.proveedor);
            sql.Parameters.AddWithValue("@funcionario", persona.funcionario);
            sql.Parameters.AddWithValue("@obs", persona.observacion);
            sql.Parameters.AddWithValue("@situacion", persona.situacion);
            sql.Parameters.AddWithValue("@pais", persona.pais);

            sql.ExecuteNonQuery();

            conexion.Close();
         }
         catch (Exception erro)
         {
            throw erro;
         }
      }

      // METODO LISTA PERSONAS.
      public DataTable lista_personas()
      {
         try
         {
            NpgsqlConnection conexion = Servidor.conectar();
           
            // executa a instrucao 
            NpgsqlCommand sql = new NpgsqlCommand("select id_per, per_nombre, per_fant, per_ruc, per_ci, per_tel1, per_tel2, per_email, per_dir, per_ciudad, per_nac, per_clt, per_prov, per_func, per_obs, per_situacion, per_pais from persona order by id_per desc", conexion);
            NpgsqlDataAdapter dt_adapter_personas = new NpgsqlDataAdapter();
            dt_adapter_personas.SelectCommand = sql;
       
            
            DataTable dt_lista_personas = new DataTable();
            dt_adapter_personas.Fill(dt_lista_personas);

            conexion.Close();
            return dt_lista_personas;

         }
         catch (Exception error)
         {
            throw error;
         }
      }


      public DataTable lista_personas_Desc()
      {
          try
          {
              NpgsqlConnection conexion = Servidor.conectar();

              // executa a instrucao 
              NpgsqlCommand sql = new NpgsqlCommand("select id_per, per_nombre, per_fant, per_ruc, per_ci, per_tel1, per_tel2, per_email, per_dir, per_ciudad, per_nac, per_clt, per_prov, per_func, per_obs, per_situacion, per_pais from persona order by id_per", conexion);
              NpgsqlDataAdapter dt_adapter_personas = new NpgsqlDataAdapter();
              dt_adapter_personas.SelectCommand = sql;


              DataTable dt_lista_personas = new DataTable();
              dt_adapter_personas.Fill(dt_lista_personas);

              conexion.Close();
              return dt_lista_personas;

          }
          catch (Exception error)
          {
              throw error;
          }
      }
      
      // METODO LISTA PERSONAS.
      public DataTable listaProveedorCompra()
      {
          try
          {
              NpgsqlConnection conexion = Servidor.conectar();

              // executa a instrucao 
              NpgsqlCommand sql = new NpgsqlCommand("SELECT id_per, per_nombre, per_ruc, per_tel1 FROM persona WHERE per_prov = 'S' ORDER BY id_per;", conexion);
              NpgsqlDataAdapter dt_adapter_personas = new NpgsqlDataAdapter();
              dt_adapter_personas.SelectCommand = sql;


              DataTable dt_lista_personas = new DataTable();
              dt_adapter_personas.Fill(dt_lista_personas);

              conexion.Close();
              return dt_lista_personas;

          }
          catch (Exception error)
          {
              throw error;
          }
      }


      // METODO LISTA PERSONAS.
      public DataTable listaClientesVentas()
      {
          try
          {
              NpgsqlConnection conexion = Servidor.conectar();

              // executa a instrucao 
              NpgsqlCommand sql = new NpgsqlCommand("SELECT id_per, per_nombre, per_ruc, per_tel1 FROM persona WHERE per_clt = 'S' AND per_situacion = 'A' ORDER BY id_per;", conexion);
              NpgsqlDataAdapter dt_adapter_personas = new NpgsqlDataAdapter();
              dt_adapter_personas.SelectCommand = sql;


              DataTable dt_lista_personas = new DataTable();
              dt_adapter_personas.Fill(dt_lista_personas);

              conexion.Close();
              return dt_lista_personas;

          }
          catch (Exception error)
          {
              throw error;
          }
      }

      // METODO LISTA PERSONAS.
      public DataTable lista_algunos()
      {
          try
          {
              NpgsqlConnection conexion = Servidor.conectar();

              // executa a instrucao 
              NpgsqlCommand sql = new NpgsqlCommand("SELECT id_per, per_nombre, per_fant, per_ruc, per_ci, per_tel1, per_tel2, per_email, per_dir, per_ciudad, per_nac, per_clt, per_prov, per_func, per_obs, per_situacion, per_pais FROM persona WHERE per_situacion = 'A' ORDER BY id_per desc; ", conexion); //AND id_per < 50 ORDER BY
              NpgsqlDataAdapter dt_adapter_personas = new NpgsqlDataAdapter();
              dt_adapter_personas.SelectCommand = sql;


              DataTable dt_lista_algunos = new DataTable();
              dt_adapter_personas.Fill(dt_lista_algunos);

              conexion.Close();
              return dt_lista_algunos;

          }
          catch (Exception error)
          {
              throw error;
          }
      }
      
      // EXCLUIR DATOS...
      public void excluir(Persona persona)
      {
         try
         {
            NpgsqlConnection conexion = Servidor.conectar();
            
            NpgsqlCommand sql = new NpgsqlCommand("delete from persona where id_per = @codigo", conexion);
            sql.Parameters.AddWithValue("@codigo", persona.idPersona);

            sql.ExecuteNonQuery();
            conexion.Close();
         }
         catch (Exception error)
         {
            throw error;
         }
      }


      // METODO BUSCAR PERSONAS.
      public DataTable Buscar(string persona, string fantasia)
      {
         try
         {
            NpgsqlConnection conexion = Servidor.conectar();

            // executa a instrucao 
            NpgsqlCommand sql = new NpgsqlCommand(string.Format("select id_per, per_nombre, per_fant, per_ruc, per_ci, per_tel1, per_tel2, per_email, per_dir, per_ciudad, per_nac, per_clt, per_prov, per_func, per_obs, per_situacion, per_pais from persona WHERE per_situacion = 'A' AND per_nombre LIKE '%{0}%' OR per_fant LIKE '%{1}%' order by per_nombre", persona, fantasia), conexion);
            NpgsqlDataAdapter dt_adapter_personas = new NpgsqlDataAdapter();
            dt_adapter_personas.SelectCommand = sql;


            DataTable dt_buscar = new DataTable();
            dt_adapter_personas.Fill(dt_buscar);

            conexion.Close();
            return dt_buscar;

         }
         catch (Exception error)
         {
            throw error;
         }
      }
      
      /*
      // metodo buscar cliente. FUNCIONANDO...
      public List<Persona> Buscar(string persona)
      {
         List<Persona> _lista = new List<Persona>();

         try
         {
            NpgsqlConnection conexion = Servidor.conectar();
            
            // select id_per, per_nombre, per_fant, per_ruc, per_ci, per_tel1, per_tel2, per_email, per_dir, per_ciudad, per_pais, per_nac from persona
            NpgsqlCommand _comando = new NpgsqlCommand(string.Format("select id_per, per_nombre, per_fant, per_ruc, per_ci, per_tel1, per_tel2, per_email, per_dir, per_ciudad, per_nac from persona WHERE per_nombre LIKE '%{0}%' order by per_nombre", persona), conexion);

            NpgsqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())
            {
               Persona objeto = new Persona();
               objeto.id = _reader.GetInt32(0);
               objeto.nombre = _reader.GetString(1);
               objeto.fantasia = _reader.GetString(2);
               objeto.ruc = _reader.GetString(3);
               objeto.cedula = _reader.GetString(4);
               objeto.tel1 = _reader.GetString(5);
               objeto.tel2 = _reader.GetString(6);
               objeto.email = _reader.GetString(7);
               objeto.direccion = _reader.GetString(8);
               objeto.ciudad = _reader.GetString(9);
               objeto.nacimento = _reader.GetString(11);
               
               _lista.Add(objeto);
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
        
      // LISTA FUNCIONARIOS.
      public DataTable lista_funcionarios()
      {
         try
         {
            NpgsqlConnection conexion = Servidor.conectar();
            
            // executa a instrucao 
            NpgsqlCommand sql = new NpgsqlCommand("select id_per, per_nombre, per_fant, per_ruc, per_ci, per_tel1, per_tel2, per_email, per_dir, per_ciudad, per_nac, per_clt, per_prov, per_func, per_obs from persona where per_func='S' order by id_per", conexion);
            NpgsqlDataAdapter dt_adapter_personas = new NpgsqlDataAdapter();
            dt_adapter_personas.SelectCommand = sql;

            DataTable dt_lista_personas = new DataTable();
            dt_adapter_personas.Fill(dt_lista_personas);

            conexion.Close();
            return dt_lista_personas;
         }
         catch (Exception error)
         {
            throw error;
         }
      }

      // LISTA FUNCIONARIOS.
      public DataTable lista_proveedor()
      {
         try
         {
            NpgsqlConnection conexion = Servidor.conectar();
            
            // executa a instrucao 
            NpgsqlCommand sql = new NpgsqlCommand("select id_per, per_nombre, per_fant, per_ruc, per_ci, per_tel1, per_tel2, per_email, per_dir, per_ciudad, per_nac, per_clt, per_prov, per_func, per_obs from persona where per_prov='S' order by id_per", conexion);
            NpgsqlDataAdapter dt_adapter_personas = new NpgsqlDataAdapter();
            dt_adapter_personas.SelectCommand = sql;

            DataTable dt_lista_personas = new DataTable();
            dt_adapter_personas.Fill(dt_lista_personas);

            conexion.Close();
            return dt_lista_personas;
         }
         catch (Exception error)
         {
            throw error;
         }
      }
   }
}
