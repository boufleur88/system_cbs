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
        public Double costo, preciomin, precio;

        private void frm_registro_servicios_Load(object sender, EventArgs e)
        {
            // orden de tabindex, focus, etc.
            txtCodigo.Text = Convert.ToString(codigo);
            txtCodigo.Enabled = false;
            txtDescripcion.Focus();
            txtDescripcion.TabIndex = 0;
            cmbgrupo.TabIndex = 1;
            btnGrupo.TabIndex = 2;
            btnGrupo.Enabled = false;
            txtCosto.TabIndex = 3;
            txtPrecioMinimo.TabIndex = 4;
            txtVenta.TabIndex = 5;
            txtObservacion.TabIndex = 6;
            btn_guardar.TabIndex = 7;
            btn_salir.TabIndex = 8;

            // verifico si o codigo e igual a cero ou distinto que zero.
            if (txtCodigo.Text != "0")
            {
                // Carga para EDITAR.
                // MessageBox.Show("DISTINTO DE CERO");
                
                ServiciosDal ls_grupo = new ServiciosDal();

                cmbgrupo.DataSource = ls_grupo.ObtenerListaGrupo();
                cmbgrupo.ValueMember = "id_grupo";
                cmbgrupo.DisplayMember = "Grupo";

                txtCodigo.Text = Convert.ToString(codigo);
                txtDescripcion.Text = Convert.ToString(descripcion);
                txtCosto.Text = Convert.ToString(costo);
                txtPrecioMinimo.Text = Convert.ToString(preciomin);
                txtVenta.Text = Convert.ToString(precio);
                txtObservacion.Text = Convert.ToString(observacion);
                cmbgrupo.Text = Convert.ToString(grupo);

                txtCosto.Text = string.Format("{0:N0}", Convert.ToDouble(txtCosto.Text));
                txtPrecioMinimo.Text = string.Format("{0:N0}", Convert.ToDouble(txtPrecioMinimo.Text));
                txtVenta.Text = string.Format("{0:N0}", Convert.ToDouble(txtVenta.Text));
            }

            else
            {
                // Carga para gravar.
                // CARREGAR COMBO MARCA.

                ServiciosDal ls_grupo = new ServiciosDal();

                cmbgrupo.DataSource = ls_grupo.ObtenerListaGrupo();
                cmbgrupo.ValueMember = "id_grupo";
                cmbgrupo.DisplayMember = "Grupo";

                txtCodigo.Text = Convert.ToString(codigo);
                txtDescripcion.Text = Convert.ToString(descripcion);
                txtCosto.Text = Convert.ToString(costo);
                txtPrecioMinimo.Text = Convert.ToString(preciomin);
                txtVenta.Text = Convert.ToString(precio);
                txtObservacion.Text = Convert.ToString(observacion);
            }
        }


        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "0")
            {
                // EDITA
                // MessageBox.Show("VAI EDITAR");

                if (txtDescripcion.Text == "")
                {
                    txtDescripcion.BackColor = Color.Aqua;
                    txtDescripcion.Focus();
                }
                else
                {
                    txtDescripcion.BackColor = Color.White;

                    if (txtVenta.Text == "0" || txtVenta.Text == "")
                    {
                        txtVenta.Text = "1";
                    }

                    // Descripcion del Servicio.
                    descripcion = txtDescripcion.Text.ToString();
                    descripcion = descripcion.ToUpper();
                    descripcion = descripcion.Trim();

                    // Precios del Servicio. 
                    costo = Convert.ToDouble(txtCosto.Text);
                    preciomin = Convert.ToDouble(txtPrecioMinimo.Text);
                    precio = Convert.ToDouble(txtVenta.Text);

                    // Observacion del Servicio.
                    observacion = txtObservacion.Text.ToString();
                    observacion = observacion.Trim();

                    c_grupo = Convert.ToInt32(cmbgrupo.SelectedValue);
                    // MessageBox.Show(""+cmbgrupo.SelectedValue);

                    try
                    {
                        if (descripcion == "")
                        {
                            txtDescripcion.BackColor = Color.Aqua;
                            txtDescripcion.Focus();
                        }
                        else
                        {
                            // Crea el objeto Servicio.
                            Servicios obj = new Servicios();

                            obj.id_servicio = codigo;
                            obj.descripcion = descripcion;
                            obj.costo = costo;
                            obj.preciomin = preciomin;
                            obj.precio = precio;
                            obj.observacion = observacion;
                            obj.id_grupo = c_grupo;

                            // chamando clase para gravar os dados. 
                            ServiciosDal editar = new ServiciosDal();
                            editar.alterar(obj);

                            MessageBox.Show("SERVICIO ALTERADO EXITOSAMENTE", "CBS INFORMATICA");


                            this.Close();
                            frm_tabla_servicios fr = new frm_tabla_servicios();
                            fr.Show();
                        }
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
                if (txtDescripcion.Text == "")
                {
                    txtDescripcion.BackColor = Color.Aqua;
                    txtDescripcion.Focus();
                }
                else
                {
                    txtDescripcion.BackColor = Color.White;

                    if (txtVenta.Text == "0" || txtVenta.Text == "")
                    {
                        txtVenta.Text = "1";
                    }

                    // Descripcion del Servicio.
                    descripcion = txtDescripcion.Text.ToString();
                    descripcion = descripcion.ToUpper();
                    descripcion = descripcion.Trim();

                    // Precio del Servicio. 
                    costo = Convert.ToDouble(txtCosto.Text);
                    preciomin = Convert.ToDouble(txtPrecioMinimo.Text);
                    precio = Convert.ToDouble(txtVenta.Text);

                    // Observacion del Producto.
                    observacion = txtObservacion.Text.ToString();
                    observacion = observacion.Trim();


                    c_grupo = Convert.ToInt32(cmbgrupo.SelectedValue);
                    // MessageBox.Show(""+cmbgrupo.SelectedValue);

                    try
                    {
                        if (descripcion == "")
                        {
                            txtDescripcion.BackColor = Color.Aqua;
                            txtDescripcion.Focus();
                        }
                        else
                        { 
                        // Crea el objeto Servicio.
                        Servicios obj = new Servicios();
                        obj.id_servicio = codigo;
                        obj.descripcion = descripcion;
                        obj.costo = costo;
                        obj.preciomin = preciomin;
                        obj.precio = precio;
                        obj.observacion = observacion;
                        obj.id_grupo = c_grupo;

                        // chamando clase para gravar os dados. 
                        ServiciosDal gravar = new ServiciosDal();
                        gravar.gravar(obj);

                        MessageBox.Show("SERVICIO GRAVADO EXITOSAMENTE","CBS INFORMATICA");

                        this.Close();
                        frm_tabla_servicios fr = new frm_tabla_servicios();
                        fr.Show();
                        }
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

        // EVENTOS KEYPress.
        private void txt_descripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cmbgrupo.Focus();
            }
        }

        private void cmbgrupo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtCosto.Focus();
            }
        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtPrecioMinimo.Focus();
            }
            else
            {
                v1.solonumeros(e);
            }
        }

        private void txtPrecioMinimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtVenta.Focus();
            }
            else
            {
                v1.solonumeros(e);
            }
        }

        private void txt_venta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtObservacion.Focus();
            }
            else
            {
                v1.solonumeros(e);
            }
        }

        private void txt_obser_KeyPress(object sender, KeyPressEventArgs e)
        {
            // COMO DETECTAR DOS ENTER SEGUIDOS.
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                    btn_guardar.Focus();
            }
        }

        // EVENTOS Leave.

        private void txtDescripcion_Leave(object sender, EventArgs e)
        {
            // Validad o campo txt_nombre caso este vacio. Si esta vacio pinta de un color y vuelve el focus en el campo.
            if (txtDescripcion.Text == "")
            {
                txtDescripcion.BackColor = Color.Aqua;
                txtDescripcion.Focus();
            }
            else
            {
                txtDescripcion.BackColor = Color.White;
            }
        }
        
        private void txtCosto_Leave(object sender, EventArgs e)
        {
            txtCosto.Text = string.Format("{0:N0}", Convert.ToDouble(txtCosto.Text));
        }

        private void txtPrecioMinimo_Leave(object sender, EventArgs e)
        {
            txtPrecioMinimo.Text = string.Format("{0:N0}", Convert.ToDouble(txtPrecioMinimo.Text));
        }

        private void txt_venta_Leave(object sender, EventArgs e)
        {
            txtVenta.Text = string.Format("{0:N0}", Convert.ToDouble(txtVenta.Text));
        }

       

        
        
    }
}
