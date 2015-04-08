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
    public partial class frm_registro_servicios : Form
    {
        public frm_registro_servicios()
        {
            InitializeComponent();
        }

        // Declaraciones de variables.
        validar_datos v1 = new validar_datos();
        public int codigo, c_grupo;
        public string descripcion, observacion, grupo;
        public Double precio;

        private void frm_registro_servicios_Load(object sender, EventArgs e)
        {
            // orden de tabindex, focus, etc.
            txt_codigo.Text = Convert.ToString(codigo);
            txt_codigo.Enabled = false;
            txt_descripcion.Focus();
            txt_descripcion.TabIndex = 0;
            txt_venta.TabIndex = 1;
            cmbgrupo.TabIndex = 2;
            btnGrupo.TabIndex = 3;
            btnGrupo.Enabled = false;
            txt_obser.TabIndex = 4;
            btn_guardar.TabIndex = 5;
            btn_salir.TabIndex = 6;

            // verifico si o codigo e igual a cero ou distinto que zero.
            if (txt_codigo.Text != "0")
            {
                // Carga para EDITAR.
                // MessageBox.Show("DISTINTO DE CERO");
                
                ServiciosDal ls_grupo = new ServiciosDal();

                cmbgrupo.DataSource = ls_grupo.ObtenerListaGrupo();
                cmbgrupo.ValueMember = "id_grupo";
                cmbgrupo.DisplayMember = "Grupo";

                txt_codigo.Text = Convert.ToString(codigo);
                txt_descripcion.Text = Convert.ToString(descripcion);
                txt_venta.Text = Convert.ToString(precio);
                txt_obser.Text = Convert.ToString(observacion);
                cmbgrupo.Text = Convert.ToString(grupo);

                txt_venta.Text = string.Format("{0:N0}", Convert.ToDouble(txt_venta.Text));
            }

            else
            {
                // Carga para gravar.
                // CARREGAR COMBO MARCA.

                ServiciosDal ls_grupo = new ServiciosDal();

                cmbgrupo.DataSource = ls_grupo.ObtenerListaGrupo();
                cmbgrupo.ValueMember = "id_grupo";
                cmbgrupo.DisplayMember = "Grupo";

                txt_codigo.Text = Convert.ToString(codigo);
                txt_descripcion.Text = Convert.ToString(descripcion);
                txt_venta.Text = Convert.ToString(precio);
                txt_obser.Text = Convert.ToString(observacion);
            }
        }


        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (txt_codigo.Text != "0")
            {
                // EDITA
                // MessageBox.Show("VAI EDITAR");

                if (txt_descripcion.Text == "")
                {
                    txt_descripcion.BackColor = Color.Aqua;
                    txt_descripcion.Focus();
                }
                else
                {
                    txt_descripcion.BackColor = Color.White;

                    if (txt_venta.Text == "0" || txt_venta.Text == "")
                    {
                        txt_venta.Text = "1";
                    }

                    // Descripcion del Servicio.
                    descripcion = txt_descripcion.Text.ToString();
                    descripcion = descripcion.ToUpper();
                    descripcion = descripcion.Trim();

                    // Precio del Servicio. 
                    precio = Convert.ToDouble(txt_venta.Text);

                    // Observacion del Servicio.
                    observacion = txt_obser.Text.ToString();
                    observacion = observacion.Trim();


                    c_grupo = Convert.ToInt32(cmbgrupo.SelectedValue);
                    // MessageBox.Show(""+cmbgrupo.SelectedValue);

                    try
                    {
                        // Crea el objeto Servicio.
                        Servicios obj = new Servicios();

                        obj.codigo = codigo;
                        obj.descripcion = descripcion;
                        obj.precio = precio;
                        obj.observacion = observacion;
                        obj.id_grupo = c_grupo;

                        // chamando clase para gravar os dados. 
                        //ProdutoDal editar = new ProdutoDal();
                        //editar.alterar(obj);

                        MessageBox.Show("PRODUCTO ALTERADO EXITOSAMENTE");

                        this.Close();
                        frm_tabla_servicios fr = new frm_tabla_servicios();
                        fr.Show();
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("ERROR AL GUARDAR PRODUCTO" + erro);
                    }
                }
            }

            else
            {
                // GRAVAR
                // MessageBox.Show("VAI GRAVAR");
                if (txt_descripcion.Text == "")
                {
                    txt_descripcion.BackColor = Color.Aqua;
                    txt_descripcion.Focus();
                }
                else
                {
                    txt_descripcion.BackColor = Color.White;


                    txt_descripcion.BackColor = Color.White;

                    if (txt_venta.Text == "0" || txt_venta.Text == "")
                    {
                        txt_venta.Text = "1";
                    }

                    // Descripcion del Servicio.
                    descripcion = txt_descripcion.Text.ToString();
                    descripcion = descripcion.ToUpper();
                    descripcion = descripcion.Trim();

                    // Precio del Servicio. 
                    precio = Convert.ToDouble(txt_venta.Text);

                    // Observacion del Producto.
                    observacion = txt_obser.Text.ToString();
                    observacion = observacion.Trim();


                    c_grupo = Convert.ToInt32(cmbgrupo.SelectedValue);
                    // MessageBox.Show(""+cmbgrupo.SelectedValue);

                    try
                    {
                        // Crea el objeto Servicio.
                        Servicios obj = new Servicios();
                        obj.descripcion = descripcion;
                        obj.precio = precio;
                        obj.observacion = observacion;
                        obj.id_grupo = c_grupo;


                        // chamando clase para gravar os dados. 
                        ServiciosDal gravar = new ServiciosDal();
                        gravar.gravar(obj);

                        MessageBox.Show("SERVICIO GRAVADO EXITOSAMENTE");

                        this.Close();
                        frm_tabla_servicios fr = new frm_tabla_servicios();
                        fr.Show();

                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("ERROR AL GRAVAR EL SERVICIO" + erro);
                    }
                }
            }
        }


        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_tabla_servicios fr = new frm_tabla_servicios();
            fr.Show();
        }



        private void txt_venta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cmbgrupo.Focus();
            }
            else
            {
                v1.solonumeros(e);
            }
        }

        private void txt_venta_Leave(object sender, EventArgs e)
        {
            txt_venta.Text = string.Format("{0:N0}", Convert.ToDouble(txt_venta.Text));
        }

        private void txt_descripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt_venta.Focus();
            }
        }

        private void cmbgrupo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt_obser.Focus();
            }
        }

        private void txt_obser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btn_guardar.Focus();
            }
        }

       

       

        
    }
}
