using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sistema_cbs
{
    public partial class frm_registro_personas : Form
    {
        public frm_registro_personas()
        {
            InitializeComponent();
        }

        // INSTANCIANDO CLASE PARA VALIDAR NUMEROS Y LETRAS.
        validar_datos v1 = new validar_datos();

        // VARIABLES DEL REGISTRO DE PERSONAS.
        public int codigo;
        public String ruc, cedula, nombre, fantasia, direccion, tel1, tel2, correo, fnacimento, clt, prov, obs, func, ciudad;

        private void frm_reg_personas_Load(object sender, EventArgs e)
        {
           txt_codigo.Text = Convert.ToString(codigo);
           // padleft primero parametro tamanho textbox y segundo parametro caracter a imprimir.
           // txt_codigo.Text = txt_codigo.Text.PadLeft(5, '0');
           txt_nombre.Text = Convert.ToString(nombre);
           txt_fantasia.Text = Convert.ToString(fantasia);
           txt_cedula.Text = Convert.ToString(cedula);
           txt_ruc.Text = Convert.ToString(ruc);
           txt_tel1.Text = Convert.ToString(tel1);
           txt_tel2.Text = Convert.ToString(tel2);
           txt_correo.Text = Convert.ToString(correo);
           txt_direccion.Text = Convert.ToString(direccion);
           txt_nacimiento.Text = Convert.ToString(fnacimento);
           txtCiudad.Text = Convert.ToString(ciudad);
           txt_cliente.Text = Convert.ToString(clt);
           txt_proveedor.Text = Convert.ToString(prov);
           txt_funcionario.Text = Convert.ToString(func);
           txt_observacion.Text = Convert.ToString(obs);
        }


       // EVENTOS KEYPRESS DE LOS TEXTBOX.
        /*
        private void txt_ruc_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (e.KeyChar == Convert.ToChar(Keys.Enter))
           {
              txt_cedula.Focus();
           }
           v1.solonumeros(e);
        }
        */

        private void txt_cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (e.KeyChar == Convert.ToChar(Keys.Enter))
           {
              txt_nombre.Focus();
           }

           v1.solonumeros(e);
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (e.KeyChar == Convert.ToChar(Keys.Enter))
           {
              txt_fantasia.Focus();
           }
        }

        private void txt_fantasia_KeyPress_1(object sender, KeyPressEventArgs e)
        {
           if (e.KeyChar == Convert.ToChar(Keys.Enter))
           {
              txt_direccion.Focus();
           }
        }

        private void txt_direccion_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (e.KeyChar == Convert.ToChar(Keys.Enter))
           {
              txtCiudad.Focus();
           }
        }

        private void txtCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (e.KeyChar == Convert.ToChar(Keys.Enter))
           {
              txt_tel1.Focus();
           }
        }

        private void txt_tel1_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (e.KeyChar == Convert.ToChar(Keys.Enter))
           {
              txt_tel2.Focus();
           }
           v1.solonumeros(e);
        }

        private void txt_tel2_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (e.KeyChar == Convert.ToChar(Keys.Enter))
           {
               txt_nacimiento.Focus();
           }

           v1.solonumeros(e);
        }

        private void txt_nacimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (e.KeyChar == Convert.ToChar(Keys.Enter))
           {
              txt_correo.Focus();
           }

           v1.solonumeros(e);
        }

        private void txt_correo_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (e.KeyChar == Convert.ToChar(Keys.Enter))
           {
              txt_observacion.Focus();
           }
        }

        private void txt_cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (e.KeyChar == Convert.ToChar(Keys.Enter))
           {
              txt_proveedor.Focus();
           }
        }

        private void txt_proveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (e.KeyChar == Convert.ToChar(Keys.Enter))
           {
              txt_funcionario.Focus();
           }
        }
        
       private void txt_funcionario_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (e.KeyChar == Convert.ToChar(Keys.Enter))
           {
              btn_guardar.Focus();
           }
        }
               

        private void btn_salir_Click(object sender, EventArgs e)
        {
           frm_tabla_personas fr = new frm_tabla_personas();
           fr.Show();

           this.Close();
           /*

           if (txt_funcionario.Text == "S")
           {
              frmFuncionarios fr = new frmFuncionarios();
              fr.Show();

              this.Close();
           }

           if (txt_proveedor.Text == "S")
           {
              frmProveedor fr = new frmProveedor();
              fr.Show();

              this.Close();
           }
           */
        }

        // PINTA LOS CAMPOS DE LAS VALIDACIONES.
        private void txt_nombre_Leave(object sender, EventArgs e)
        {
           // Validad o campo txt_nombre caso este vacio. Si esta vacio pinta de un color y vuelve el focus en el campo.
           if (txt_nombre.Text == "")
           {
              txt_nombre.BackColor = Color.Aqua;
              txt_nombre.Focus();
           }
           else
           {
              txt_nombre.BackColor = Color.White;
           }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           frm_reg_ciudad fr = new frm_reg_ciudad();
           fr.Show();
        }


       // EVENTOS DE LOS BOTONES GUARDAR Y SALIR.


        private void btn_guardar_Click(object sender, EventArgs e)
        {
           if (txt_codigo.Text != "0")
           {
              // si txtcodigo es distinto que 0, entonces lo que hace es editar el registro.
              // editar
              
              txt_codigo.Text = codigo.ToString();
              codigo = Convert.ToInt32(codigo);
              //MessageBox.Show("EDITAR "+codigo);

              if (txt_nombre.Text == "")
              {
                 txt_nombre.BackColor = Color.Aqua;
                 txt_nombre.Focus();
              }
              else
              {
                 txt_nombre.BackColor = Color.White;
                 txt_fantasia.Text = txt_nombre.Text.Trim();

                 // ruc
                 ruc = txt_ruc.Text.ToString();
                 ruc = ruc.Trim();

                 // cedula 
                 cedula = txt_cedula.Text.ToString();
                 cedula = cedula.Trim();

                 // nombre
                 nombre = txt_nombre.Text.ToString();
                 nombre = nombre.ToUpper();
                 nombre = nombre.Trim();

                 // fantasia
                 fantasia = txt_fantasia.Text.ToString();
                 fantasia = fantasia.ToUpper();
                 fantasia = fantasia.Trim();

                 // direccion 
                 direccion = txt_direccion.Text.ToString();
                 direccion = direccion.ToUpper();
                 direccion = direccion.Trim();

                 // tel1 
                 tel1 = txt_tel1.Text.ToString();
                 tel1 = tel1.Trim();

                 // tel2 
                 tel2 = txt_tel2.Text.ToString();
                 tel2 = tel2.Trim();

                 // correo 
                 correo = txt_correo.Text.ToString();
                 correo = correo.ToUpper();
                 correo = correo.Trim();

                 // observacion 
                 obs = txt_observacion.Text.ToString();
                 obs = obs.Trim();

                 // CIUDAD
                 if (txtCiudad.Text == "")
                 {
                    ciudad = "VARIOS";
                    //ciudad = ciudad.Trim();
                 }
                 else
                 {
                    ciudad = txtCiudad.Text.ToString();
                    ciudad = ciudad.Trim();
                 }

                 // CLIENTE
                 if (txt_cliente.Text == "")
                 {
                    clt = "S";
                 }
                 else
                 {
                    clt = txt_cliente.Text.ToString();
                 }

                 // PROVEEDOR
                 if (txt_proveedor.Text == "")
                 {
                    prov = "N";
                 }
                 else
                 {
                    prov = txt_proveedor.Text.ToString();
                 }

                 // FUNCIONARIO
                 if (txt_funcionario.Text == " ")
                 {
                    //func = "N";
                    txt_funcionario.Text = "N";
                    func = txt_funcionario.Text.ToString();
                 }
                 else
                 {
                    func = txt_funcionario.Text.ToString();
                 }


                 // instancio o modelo datos y gravo via get y set.
                 PersonaDal obj = new PersonaDal();
                 obj.idPersona = codigo;
                 obj.nombre = nombre;
                 obj.ruc = ruc;
                 obj.fantasia = fantasia;
                 obj.cedula = cedula;
                 obj.direccion = direccion;
                 obj.tel1 = tel1;
                 obj.tel2 = tel2;
                 obj.email = correo;
                 obj.nacimento = txt_nacimiento.Text.ToString();
                 obj.cliente = clt;
                 obj.proveedor = prov;
                 obj.funcionario = func;
                 obj.observacion = obs;
                 obj.ciudad = ciudad;

                 // chamando clase para gravar os dados. 
                 PersonaDal editar = new PersonaDal();
                 editar.alterar(obj);

                 this.Close();
                 frm_tabla_personas fr = new frm_tabla_personas();
                 fr.Show();
                
              }
           }
                
           else
           {
              try
              {
                 //MessageBox.Show("GRAVAR" + codigo);
                 // ruc
                 ruc = txt_ruc.Text.ToString();
                 ruc = ruc.Trim();

                 // cedula 
                 cedula = txt_cedula.Text.ToString();
                 cedula = cedula.Trim();

                 // nombre
                 nombre = txt_nombre.Text.ToString();
                 nombre = nombre.ToUpper();
                 nombre = nombre.Trim();

                 // fantasia
                 fantasia = txt_fantasia.Text.ToString();
                 fantasia = fantasia.ToUpper();
                 fantasia = fantasia.Trim();

                 // direccion 
                 direccion = txt_direccion.Text.ToString();
                 direccion = direccion.ToUpper();
                 direccion = direccion.Trim();

                 // tel1 
                 tel1 = txt_tel1.Text.ToString();
                 tel1 = tel1.Trim();

                 // tel2 
                 tel2 = txt_tel2.Text.ToString();
                 tel2 = tel2.Trim();

                 // correo 
                 correo = txt_correo.Text.ToString();
                 correo = correo.ToUpper();
                 correo = correo.Trim();

                 // observacion 
                 obs = txt_observacion.Text.ToString();
                 obs = obs.Trim();

                 // CIUDAD
                 if (txtCiudad.Text == "")
                 {
                    ciudad = "VARIOS";
                    //ciudad = ciudad.Trim();
                 }
                 else
                 {
                    ciudad = txtCiudad.Text.ToString();
                    ciudad = ciudad.Trim();
                 }

                 // CLIENTE
                 if (txt_cliente.Text == "")
                 {
                    clt = "S";
                 }
                 else
                 {
                    clt = txt_cliente.Text.ToString();
                 }

                 // FUNCIONARIO
                 if (txt_funcionario.Text == "")
                 {
                    func = "N";
                 }
                 else
                 {
                    func = txt_funcionario.Text.ToString();
                 }

                 // PROVEEDOR
                 if (txt_proveedor.Text == "")
                 {
                    prov = "N";
                 }
                 else
                 {
                    prov = txt_proveedor.Text.ToString();
                 }
                 if (txt_nombre.Text == "")
                 {
                    txt_nombre.BackColor = Color.Aqua;
                    txt_nombre.Focus();
                 }
                 else
                 {
                    txt_nombre.BackColor = Color.White;
                    txt_fantasia.Text = txt_nombre.Text.Trim();

                    // instancio o modelo datos y gravo via get y set.
                    PersonaDal obj = new PersonaDal();
                    obj.nombre = nombre;
                    obj.ruc = ruc;
                    obj.fantasia = fantasia;
                    obj.cedula = cedula;
                    obj.direccion = direccion;
                    obj.tel1 = tel1;
                    obj.tel2 = tel2;
                    obj.email = correo;
                    obj.nacimento = txt_nacimiento.Text.ToString();
                    obj.cliente = clt;
                    obj.proveedor = prov;
                    obj.funcionario = func;
                    obj.observacion = obs;
                    obj.ciudad = ciudad;

                    // chamando clase para gravar os dados. 
                    PersonaDal gravar = new PersonaDal();
                    gravar.gravar(obj);

                    this.Close();
                    frm_tabla_personas fr = new frm_tabla_personas();
                    fr.Show();
                    
                 }
              }
              catch (Exception erro)
              {
                 MessageBox.Show("ERROR AL GUARDAR PERSONA" + erro);
              }

           }
        }

        
       /*
        private void txt_cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            // si la tecla presionada es distinto de S O N suspendera el evento, si es igual a S o N escribira en el textbox
            // MessageBox.Show("TECLA ES "+e.KeyChar);
            if ((e.KeyChar) != 'S' && (e.KeyChar) != 'N')
            {
                //MessageBox.Show("SOLO SE PERMITEN VALORES SI = 'S', NO = 'N'");
                e.Handled = true;

            }
        }

        private void txt_proveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            // si la tecla presionada es distinto de S O N suspendera el evento, si es igual a S o N escribira en el textbox
            // MessageBox.Show("TECLA ES "+e.KeyChar);
            if ((e.KeyChar) != 'S' && (e.KeyChar) != 'N')
            {
                //MessageBox.Show("SOLO SE PERMITEN VALORES SI = 'S', NO = 'N'");
                e.Handled = true;

            }
        }

        private void txt_funcionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            // si la tecla presionada es distinto de S O N suspendera el evento, si es igual a S o N escribira en el textbox
            // MessageBox.Show("TECLA ES "+e.KeyChar);
            if ((e.KeyChar) != 'S' && (e.KeyChar) != 'N')
            {
                //MessageBox.Show("SOLO SE PERMITEN VALORES SI = 'S', NO = 'N'");
                e.Handled = true;

            }
        }
       */

    }
}
