using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb; // biblioteca para coneccion con datos.

namespace sistema_cbs
{
    public class modelo_datos
    {
        // Registros de usuarios.
        String user_codigo, user_nombre, user_tel1, user_usuario, user_cedula, user_email, user_clave;

        // PRODUTOS. GRUPO, SUBGRUPO, MARCA. Utilizando los mismos campos del db.
        int id_produto, pro_moneda, pro_iva, pro_cantmin;
                
        String pro_ean, pro_orig, pro_fabr, pro_desc, pro_aplic, pro_unidad, pro_obs  ;
        long pro_costoadm, pro_costocon, pro_ventamay, pro_ventamin;
        
        /*#####################################################################################*/
        // USUARIOS.

        public String codigo
        {
            get { return user_codigo; }
            set { user_codigo = value;}
        }

        public String nombre
        {
            get { return user_nombre; }
            set { user_nombre = value; }
        }

        public String telefono1
        {
            get { return user_tel1; }
            set { user_tel1 = value; }
        }

        public String usuario   // Nick para login del usuario.
        {
            get { return user_usuario; }
            set { user_usuario = value; }
        }

        public String cedula
        {
            get { return user_cedula; }
            set { user_cedula = value; }
        }

        public String email
        {
            get { return user_email; }
            set { user_email = value; }
        }

        public String clave
        {
            get { return user_clave; }
            set { user_clave = value; }
        }

        
         
        /*#####################################################################################*/
        // PRODUTOS
        public long ProdVentaMin
        {
            get { return pro_ventamin; }
            set { pro_ventamin = value; }
        }

        public long ProdVentaMay
        {
            get { return pro_ventamay; }
            set { pro_ventamay = value; }
        }

        public long ProdCostoCon
        {
            get { return pro_costocon; }
            set { pro_costocon = value; }
        }

        public long ProdCostoAdm
        {
            get { return pro_costoadm; }
            set { pro_costoadm = value; }
        }

        public String ProdObs
        {
            get { return pro_obs; }
            set { pro_obs = value; }
        }

        public String ProdUnidad
        {
            get { return pro_unidad; }
            set { pro_unidad = value; }
        }

        public String ProdAplic
        {
            get { return pro_aplic; }
            set { pro_aplic = value; }
        }

        public String ProdDesc
        {
            get { return pro_desc; }
            set { pro_desc = value; }
        }

        public String ProdFabr
        {
            get { return pro_fabr; }
            set { pro_fabr = value; }
        }

        public String ProdOrig
        {
            get { return pro_orig; }
            set { pro_orig = value; }
        }


        public String ProdEan
        {
            get { return pro_ean; }
            set { pro_ean = value; }
        }

        public int ProdCod
        {
            get { return id_produto; }
            set { id_produto = value; }
        }

        public int ProdMoneda
        {
            get { return pro_moneda; }
            set { pro_moneda = value; }
        }

        public int ProdIva
        {
            get { return pro_iva; }
            set { pro_iva = value; }
        }

        public int ProdCantMin
        {
            get { return pro_cantmin; }
            set { pro_cantmin = value; }
        }
    }
}
