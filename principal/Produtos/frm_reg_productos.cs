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
    public partial class frm_reg_productos : Form
    {
        public frm_reg_productos()
        {
            InitializeComponent();
        }

        // Declaraciones de variables.
        validar_datos v1 = new validar_datos();
        
        // Variables del Sistema de Catastro de Productos
        public double codigo = 0, porc1 = 0, porc2 = 0 , porc3 = 0;
        public int iva = 0, moneda = 0, stminimo = 0, stmaximo = 0;
        
        public string grupo = " ", subgrupo = " ",  marca =" ", aplicacion = "", descripcion = " ", observacion = " ", medida = " ";
        
        public double costo = 0, venta1 = 0, venta2 = 0, venta3 = 0;


        private void frm_reg_productos_Load(object sender, EventArgs e)
        {
            // verifico si o codigo e igual a cero ou distinto que zero.
            txt_codigo.Text = Convert.ToString(codigo);

            if (txt_codigo.Text != "0")
            {

                ProdutoMarcaDal ls_marca = new ProdutoMarcaDal();

                cmbmarca.DataSource = ls_marca.ObtenerLista();
                cmbmarca.ValueMember = "codigo";
                cmbmarca.DisplayMember = "marca";

                GrupoProdutoDal ls_grupo = new GrupoProdutoDal();

                cmbgrupo.DataSource = ls_grupo.ObtenerListaGrupo();
                cmbgrupo.ValueMember = "Id";
                cmbgrupo.DisplayMember = "Grupo";


                ProdutoSubGrupoDal ls_subgrupo = new ProdutoSubGrupoDal();

                cmbsubgrupo.DataSource = ls_subgrupo.ObtenerLista();
                cmbsubgrupo.ValueMember = "Id";
                cmbsubgrupo.DisplayMember = "Subgrupo";

                // Carga para EDITAR.
                // MessageBox.Show("DISTINTO DE CERO");

                txt_codigo.Text = Convert.ToString(codigo);
                txt_descripcion.Text = Convert.ToString(descripcion);
                txtPrecio1.Text = Convert.ToString(costo);
                txtCosto.Text = Convert.ToString(venta1);
                txtPrecio2.Text = Convert.ToString(venta2);
                txtPrecio3.Text = Convert.ToString(venta3);
                txt_obser.Text = Convert.ToString(observacion);
                txt_iva.Text = Convert.ToString(iva);
                txt_medida.Text = Convert.ToString(medida);
                cmbmarca.Text = Convert.ToString(marca);
                cmbgrupo.Text = Convert.ToString(grupo);
                cmbsubgrupo.Text = Convert.ToString(subgrupo);

                txtCosto.Text = string.Format("{0:N0}", Convert.ToDouble(txtCosto.Text));
                txtPrecio1.Text = string.Format("{0:N0}", Convert.ToDouble(txtPrecio1.Text));
                txtPrecio2.Text = string.Format("{0:N0}", Convert.ToDouble(txtPrecio2.Text));
                txtPrecio3.Text = string.Format("{0:N0}", Convert.ToDouble(txtPrecio3.Text));

            }

            else
            {
                // Carga para gravar.
                // CARREGAR COMBO MARCA.
                ProdutoMarcaDal ls_marca = new ProdutoMarcaDal();

                cmbmarca.DataSource = ls_marca.ObtenerLista();
                cmbmarca.ValueMember = "codigo";
                cmbmarca.DisplayMember = "marca";

                GrupoProdutoDal ls_grupo = new GrupoProdutoDal();

                cmbgrupo.DataSource = ls_grupo.ObtenerListaGrupo();
                cmbgrupo.ValueMember = "Id";
                cmbgrupo.DisplayMember = "Grupo";


                ProdutoSubGrupoDal ls_subgrupo = new ProdutoSubGrupoDal();

                cmbsubgrupo.DataSource = ls_subgrupo.ObtenerLista();
                cmbsubgrupo.ValueMember = "Id";
                cmbsubgrupo.DisplayMember = "Subgrupo";

                txt_codigo.Text = Convert.ToString(codigo);
                txt_descripcion.Text = Convert.ToString(descripcion);
                txtPrecio1.Text = Convert.ToString(costo);
                txtCosto.Text = Convert.ToString(venta1);
                txtPrecio2.Text = Convert.ToString(venta2);
                txtPrecio3.Text = Convert.ToString(venta3);
                txt_obser.Text = Convert.ToString(observacion);
                txt_iva.Text = Convert.ToString(iva);
                txt_medida.Text = Convert.ToString(medida);
            }
        }


        private void btn_alterar_Click(object sender, EventArgs e)
        {
            frm_tabla_stock fr = new frm_tabla_stock();
            fr.Show();
            this.Hide();
        }
        
        private void txt_peso_KeyPress(object sender, KeyPressEventArgs e)
        {
            v1.solonumeros(e);
        }

        private void txt_ventamay_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (e.KeyChar == Convert.ToChar(Keys.Enter))
           {
              txtPrecio3.Focus();
           } 
           v1.solonumeros(e);
        }

        private void txt_ventamin_KeyPress(object sender, KeyPressEventArgs e)
        {

           if (e.KeyChar == Convert.ToChar(Keys.Enter))
           {
              txt_obser.Focus();
           }
           v1.solonumeros(e);
        }

        private void txt_costocont_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (e.KeyChar == Convert.ToChar(Keys.Enter))
           {
              txtPrecio1.Focus();
           } 
           v1.solonumeros(e);
        }

        private void txt_costoadmin_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (e.KeyChar == Convert.ToChar(Keys.Enter))
           {
              txtPrecio2.Focus();
           } 
           v1.solonumeros(e);
        }

        private void txt_moneda_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (e.KeyChar == Convert.ToChar(Keys.Enter))
           {
              txt_iva.Focus();
           } 
           v1.solonumeros(e);
        }

        private void txt_iva_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (e.KeyChar == Convert.ToChar(Keys.Enter))
           {
              txtCosto.Focus();
           } 
           v1.solonumeros(e);
        }

        private void txt_stcokmin_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (e.KeyChar == Convert.ToChar(Keys.Enter))
           {
              txt_moneda.Focus();
           } 
           v1.solonumeros(e);
        }

        private void txt_medida_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (e.KeyChar == Convert.ToChar(Keys.Enter))
           {
              txt_stcokmin.Focus();
           }

            v1.sololetras(e);
        }

        private void txt_descripcion_Leave(object sender, EventArgs e)
        {
            // Validad o campo txt_nombre caso este vacio. Si esta vacio pinta de un color y vuelve el focus en el campo.
            if (txt_descripcion.Text == "")
            {
                txt_descripcion.BackColor = Color.Aqua;
                txt_descripcion.Focus();
            }
            else
            {
                txt_descripcion.BackColor = Color.White;
            }
        }

        private void btnmarca_Click(object sender, EventArgs e)
        {
           frm_reg_marca fr = new frm_reg_marca();
           fr.Show();
        }

        private void btngrupo_Click(object sender, EventArgs e)
        {
           frm_reg_grupo fr = new frm_reg_grupo();
           fr.Show();
        }

        private void btnsubgrupo_Click(object sender, EventArgs e)
        {
           frm_reg_subgrupo fr = new frm_reg_subgrupo();
           fr.Show();
        }

       // EVENTOS KEY PRESS
        private void txt_descripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (e.KeyChar == Convert.ToChar(Keys.Enter))
           {
              cmbmarca.Focus();
           }
        }

        private void cmbmarca_KeyPress(object sender, KeyPressEventArgs e)
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
              cmbsubgrupo.Focus();
           }
        }

        private void cmbsubgrupo_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (e.KeyChar == Convert.ToChar(Keys.Enter))
           {
              txt_medida.Focus();
           }
        }

        private void txt_costocont_Leave(object sender, EventArgs e)
        {
           txtCosto.Text = string.Format("{0:N0}", Convert.ToDouble(txtCosto.Text));
        }

        private void txtPrecio1_Leave(object sender, EventArgs e)
        {
           txtPrecio1.Text = string.Format("{0:N0}", Convert.ToDouble(txtPrecio1.Text));
        }

        private void txtPrecio2_Leave(object sender, EventArgs e)
        {
           txtPrecio2.Text = string.Format("{0:N0}", Convert.ToDouble(txtPrecio2.Text));
        }

        private void txtPrecio3_Leave(object sender, EventArgs e)
        {
           txtPrecio3.Text = string.Format("{0:N0}", Convert.ToDouble(txtPrecio3.Text));
        }

        private void btnMarca_Click_1(object sender, EventArgs e)
        {
           
           frm_reg_marca fr = new frm_reg_marca();
           fr.ShowDialog();
        }

        private void btnGrupo_Click_1(object sender, EventArgs e)
        {
           frm_reg_grupo fr = new frm_reg_grupo( );
           fr.ShowDialog();

        }

        private void btnSubGrupo_Click_1(object sender, EventArgs e)
        {
           frm_reg_subgrupo fr = new frm_reg_subgrupo();
           fr.ShowDialog();
        }

        private void btnMarca_Leave(object sender, EventArgs e)
        {
           ProdutoMarcaDal ls_marca = new ProdutoMarcaDal();

           cmbmarca.DataSource = ls_marca.ObtenerLista();
           cmbmarca.ValueMember = "codigo";
           cmbmarca.DisplayMember = "marca";
        }

        private void btnGrupo_Leave(object sender, EventArgs e)
        {
           GrupoProdutoDal ls_grupo = new GrupoProdutoDal();

           cmbgrupo.DataSource = ls_grupo.ObtenerListaGrupo();
           cmbgrupo.ValueMember = "Id";
           cmbgrupo.DisplayMember = "Grupo";
        }

        private void btnSubGrupo_Leave(object sender, EventArgs e)
        {
           ProdutoSubGrupoDal ls_subgrupo = new ProdutoSubGrupoDal();

           cmbsubgrupo.DataSource = ls_subgrupo.ObtenerLista();
           cmbsubgrupo.ValueMember = "Id";
           cmbsubgrupo.DisplayMember = "Subgrupo";
        }


        private void btn_guardar_Click_1(object sender, EventArgs e)
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


                    if (txt_moneda.Text == "")
                    {
                        txt_moneda.Text = "1";
                    }

                    if (txt_iva.Text == "")
                    {
                        txt_iva.Text = "10";
                    }

                    if (txtCosto.Text == "0" || txtCosto.Text == "")
                    {
                        txtCosto.Text = "1";

                    }

                    if (txtPrecio1.Text == "0" || txtPrecio1.Text == "")
                    {
                        txtPrecio1.Text = "1";
                    }

                    if (txtPrecio2.Text == "0" || txtPrecio2.Text == "")
                    {
                        txtPrecio2.Text = "1";
                    }

                    if (txtPrecio3.Text == "0" || txtPrecio3.Text == "")
                    {
                        txtPrecio3.Text = "1";
                    }

                    if (txt_stcokmin.Text == "")
                    {
                        txt_stcokmin.Text = "0";
                    }

                    // UNIDAD.
                    if (txt_medida.Text == "")
                    {
                        txt_medida.Text = "UN";
                    }

                    // Descripcion del Producto.
                    descripcion = txt_descripcion.Text.ToString();
                    descripcion = descripcion.ToUpper();
                    descripcion = descripcion.Trim();

                    // Unidad de medida del Producto.
                    // medida = Convert.ToInt32(txt_medida.Text);
                    
                    // Moneda
                    // moneda = Convert.ToInt32(txt_moneda.Text);

                    // IVA.
                    // iva = Convert.ToInt32(txt_iva.Text);

                    // Costo Contable del producto.
                    costo = Convert.ToDouble(txtCosto.Text);

                    // Costo Administrativo del producto.
                    venta1 = Convert.ToDouble(txtPrecio1.Text);

                    // Precio de Venta Mayorista. 
                    venta2 = Convert.ToDouble(txtPrecio2.Text);

                    // Precio de Venta Minorista.
                    venta3 = Convert.ToDouble(txtPrecio3.Text);

                    // Cantidad minima.
                    stminimo = Convert.ToInt32(txt_stcokmin.Text);

                    // Observacion del Producto.
                    observacion = txt_obser.Text.ToString();
                    observacion = observacion.Trim();

                    // marca
                    // marca = Convert.ToInt32(cmbmarca.SelectedValue);
                    // MessageBox.Show("" + cmbmarca.SelectedValue);

                    // grupo = Convert.ToInt32(cmbgrupo.SelectedValue);
                    // MessageBox.Show(""+cmbgrupo.SelectedValue);

                    // subgrupo = Convert.ToInt32(cmbsubgrupo.SelectedValue);
                    // MessageBox.Show("" + cmbsubgrupo.SelectedValue);

                    try
                    {
                        Produto obj = new Produto();
                        obj.codigo = codigo;
                        obj.descr = descripcion;
                        // obj.unidad = medida;
                        // obj.moneda = moneda;
                        // obj.iva = iva;
                        obj.costocon = costo;
                        obj.costoadm = venta1;
                        obj.ventamay = venta2;
                        obj.ventamin = venta3;
                        obj.st_minimo = stminimo;
                        obj.observacion = observacion;
                        // obj.marca = marca;
                        // obj.grupo = grupo;
                        // obj.subgrupo = subgrupo;


                        // chamando clase para gravar os dados. 
                        ProdutoDal editar = new ProdutoDal();
                        editar.alterar(obj);

                        MessageBox.Show("PRODUCTO ALTERADO EXITOSAMENTE");

                        this.Close();
                        frm_tabla_stock fr = new frm_tabla_stock();
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


                    if (txt_moneda.Text == "")
                    {
                        txt_moneda.Text = "1";
                    }

                    if (txt_iva.Text == "")
                    {
                        txt_iva.Text = "10";
                    }

                    if (txtCosto.Text == "0" || txtCosto.Text == "")
                    {
                        txtCosto.Text = "1";
                    }

                    if (txtPrecio1.Text == "0" || txtPrecio1.Text == "")
                    {
                        txtPrecio1.Text = "1";
                    }

                    if (txtPrecio2.Text == "0" || txtPrecio2.Text == "")
                    {
                        txtPrecio2.Text = "1";
                    }

                    if (txtPrecio3.Text == "0" || txtPrecio3.Text == "")
                    {
                        txtPrecio3.Text = "1";
                    }

                    if (txt_stcokmin.Text == "")
                    {
                        txt_stcokmin.Text = "0";
                    }

                    // UNIDAD.
                    if (txt_medida.Text == "")
                    {
                        txt_medida.Text = "UN";
                    }

                    // Descripcion del Producto.
                    // descr = txt_descripcion.Text.ToString();
                    // descr = descr.ToUpper();
                    // descr = descr.Trim();

                    // Unidad de medida del Producto.
                    // medida = txt_medida.Text.ToString();
                    // medida = medida.ToUpper();
                    // medida = medida.Trim();

                    // Moneda
                    // moneda = Convert.ToInt32(txt_moneda.Text);

                    // IVA.
                    // iva = Convert.ToInt32(txt_iva.Text);

                    // Costo Contable del producto.
                    // coscont = Convert.ToDouble(txtCosto.Text);

                    // Costo Administrativo del producto.
                    // cosadm = Convert.ToDouble(txtPrecio1.Text);

                    // Precio de Venta Mayorista. 
                    // venmay = Convert.ToDouble(txtPrecio2.Text);

                    // Precio de Venta Minorista.
                    // venmin = Convert.ToDouble(txtPrecio3.Text);

                    // Cantidad minima.
                    // stmin = Convert.ToInt32(txt_stcokmin.Text);

                    // Observacion del Producto.
                    // obs = txt_obser.Text.ToString();
                    // obs = obs.Trim();

                    // marca
                    // marca = Convert.ToInt32(cmbmarca.SelectedValue);
                    //MessageBox.Show("" + cmbmarca.SelectedValue);
                    // grupo = Convert.ToInt32(cmbgrupo.SelectedValue);
                    // MessageBox.Show(""+cmbgrupo.SelectedValue);
                    // subgrupo = Convert.ToInt32(cmbsubgrupo.SelectedValue);
                    //MessageBox.Show("" + cmbsubgrupo.SelectedValue);
                    try
                    {
                        Produto obj = new Produto();
                       // obj.descr = descr;
                       // obj.unidad = medida;
                       // obj.moneda = moneda;
                       // obj.iva = iva;
                       // obj.costocon = coscont;
                       // obj.costoadm = cosadm;
                       // obj.ventamay = venmay;
                       // obj.ventamin = venmin;
                       // obj.st_minimo = stmin;
                       // obj.observacion = obs;
                       // obj.marca = marca;
                       // obj.grupo = grupo;
                       // obj.subgrupo = subgrupo;
                       //

                        // chamando clase para gravar os dados. 
                        ProdutoDal gravar = new ProdutoDal();
                        gravar.gravar(obj);

                        MessageBox.Show("PRODUCTO GRABADO EXITOSAMENTE");

                        this.Close();
                        frm_tabla_stock fr = new frm_tabla_stock();
                        fr.Show();

                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("ERROR AL GUARDAR PRODUCTO" + erro);
                    }
                }
            } String descr, medida, obs;
            int moneda, iva, stmin, marca, grupo, subgrupo;
            Double coscont, cosadm, venmay, venmin;


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


                    if (txt_moneda.Text == "")
                    {
                        txt_moneda.Text = "1";
                    }

                    if (txt_iva.Text == "")
                    {
                        txt_iva.Text = "10";
                    }

                    if (txtCosto.Text == "0" || txtCosto.Text == "")
                    {
                        txtCosto.Text = "1";

                    }

                    if (txtPrecio1.Text == "0" || txtPrecio1.Text == "")
                    {
                        txtPrecio1.Text = "1";
                    }

                    if (txtPrecio2.Text == "0" || txtPrecio2.Text == "")
                    {
                        txtPrecio2.Text = "1";
                    }

                    if (txtPrecio3.Text == "0" || txtPrecio3.Text == "")
                    {
                        txtPrecio3.Text = "1";
                    }

                    if (txt_stcokmin.Text == "")
                    {
                        txt_stcokmin.Text = "0";
                    }

                    // UNIDAD.
                    if (txt_medida.Text == "")
                    {
                        txt_medida.Text = "UN";
                    }

                    // Descripcion del Producto.
                    descr = txt_descripcion.Text.ToString();
                    descr = descr.ToUpper();
                    descr = descr.Trim();

                    // Unidad de medida del Producto.
                    medida = txt_medida.Text.ToString();
                    medida = medida.ToUpper();
                    medida = medida.Trim();

                    // Moneda
                    moneda = Convert.ToInt32(txt_moneda.Text);

                    // IVA.
                    iva = Convert.ToInt32(txt_iva.Text);

                    // Costo Contable del producto.
                    coscont = Convert.ToDouble(txtCosto.Text);

                    // Costo Administrativo del producto.
                    cosadm = Convert.ToDouble(txtPrecio1.Text);

                    // Precio de Venta Mayorista. 
                    venmay = Convert.ToDouble(txtPrecio2.Text);

                    // Precio de Venta Minorista.
                    venmin = Convert.ToDouble(txtPrecio3.Text);

                    // Cantidad minima.
                    stmin = Convert.ToInt32(txt_stcokmin.Text);

                    // Observacion del Producto.
                    obs = txt_obser.Text.ToString();
                    obs = obs.Trim();

                    // marca
                    marca = Convert.ToInt32(cmbmarca.SelectedValue);
                    // MessageBox.Show("" + cmbmarca.SelectedValue);

                    grupo = Convert.ToInt32(cmbgrupo.SelectedValue);
                    // MessageBox.Show(""+cmbgrupo.SelectedValue);

                    subgrupo = Convert.ToInt32(cmbsubgrupo.SelectedValue);
                    // MessageBox.Show("" + cmbsubgrupo.SelectedValue);

                    try
                    {
                        Produto obj = new Produto();
                        obj.codigo = codigo;
                        obj.descr = descr;
                        obj.unidad = medida;
                        obj.moneda = moneda;
                        obj.iva = iva;
                        obj.costocon = coscont;
                        obj.costoadm = cosadm;
                        obj.ventamay = venmay;
                        obj.ventamin = venmin;
                        obj.st_minimo = stmin;
                        obj.observacion = obs;
                        obj.marca = marca;
                        obj.grupo = grupo;
                        obj.subgrupo = subgrupo;


                        // chamando clase para gravar os dados. 
                        ProdutoDal editar = new ProdutoDal();
                        editar.alterar(obj);

                        MessageBox.Show("PRODUCTO ALTERADO EXITOSAMENTE");

                        this.Close();
                        frm_tabla_stock fr = new frm_tabla_stock();
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


                    if (txt_moneda.Text == "")
                    {
                        txt_moneda.Text = "1";
                    }

                    if (txt_iva.Text == "")
                    {
                        txt_iva.Text = "10";
                    }

                    if (txtCosto.Text == "0" || txtCosto.Text == "")
                    {
                        txtCosto.Text = "1";
                    }

                    if (txtPrecio1.Text == "0" || txtPrecio1.Text == "")
                    {
                        txtPrecio1.Text = "1";
                    }

                    if (txtPrecio2.Text == "0" || txtPrecio2.Text == "")
                    {
                        txtPrecio2.Text = "1";
                    }

                    if (txtPrecio3.Text == "0" || txtPrecio3.Text == "")
                    {
                        txtPrecio3.Text = "1";
                    }

                    if (txt_stcokmin.Text == "")
                    {
                        txt_stcokmin.Text = "0";
                    }

                    // UNIDAD.
                    if (txt_medida.Text == "")
                    {
                        txt_medida.Text = "UN";
                    }

                    // Descripcion del Producto.
                    descr = txt_descripcion.Text.ToString();
                    descr = descr.ToUpper();
                    descr = descr.Trim();

                    // Unidad de medida del Producto.
                    medida = txt_medida.Text.ToString();
                    medida = medida.ToUpper();
                    medida = medida.Trim();

                    // Moneda
                    moneda = Convert.ToInt32(txt_moneda.Text);

                    // IVA.
                    iva = Convert.ToInt32(txt_iva.Text);

                    // Costo Contable del producto.
                    coscont = Convert.ToDouble(txtCosto.Text);

                    // Costo Administrativo del producto.
                    cosadm = Convert.ToDouble(txtPrecio1.Text);

                    // Precio de Venta Mayorista. 
                    venmay = Convert.ToDouble(txtPrecio2.Text);

                    // Precio de Venta Minorista.
                    venmin = Convert.ToDouble(txtPrecio3.Text);

                    // Cantidad minima.
                    stmin = Convert.ToInt32(txt_stcokmin.Text);

                    // Observacion del Producto.
                    obs = txt_obser.Text.ToString();
                    obs = obs.Trim();

                    // marca
                    marca = Convert.ToInt32(cmbmarca.SelectedValue);
                    //MessageBox.Show("" + cmbmarca.SelectedValue);
                    grupo = Convert.ToInt32(cmbgrupo.SelectedValue);
                    //MessageBox.Show(""+cmbgrupo.SelectedValue);
                    subgrupo = Convert.ToInt32(cmbsubgrupo.SelectedValue);
                    //MessageBox.Show("" + cmbsubgrupo.SelectedValue);
                    try
                    {
                        Produto obj = new Produto();
                        obj.descr = descr;
                        obj.unidad = medida;
                        obj.moneda = moneda;
                        obj.iva = iva;
                        obj.costocon = coscont;
                        obj.costoadm = cosadm;
                        obj.ventamay = venmay;
                        obj.ventamin = venmin;
                        obj.st_minimo = stmin;
                        obj.observacion = obs;
                        obj.marca = marca;
                        obj.grupo = grupo;
                        obj.subgrupo = subgrupo;


                        // chamando clase para gravar os dados. 
                        ProdutoDal gravar = new ProdutoDal();
                        gravar.gravar(obj);

                        MessageBox.Show("PRODUCTO GRABADO EXITOSAMENTE");

                        this.Close();
                        frm_tabla_stock fr = new frm_tabla_stock();
                        fr.Show();

                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("ERROR AL GUARDAR PRODUCTO" + erro);
                    }
                }
            } 
            // String descr, medida, obs;
            // int moneda, iva, stmin, marca, grupo, subgrupo;
            // Double coscont, cosadm, venmay, venmin;


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


                    if (txt_moneda.Text == "")
                    {
                        txt_moneda.Text = "1";
                    }

                    if (txt_iva.Text == "")
                    {
                        txt_iva.Text = "10";
                    }

                    if (txtCosto.Text == "0" || txtCosto.Text == "")
                    {
                        txtCosto.Text = "1";

                    }

                    if (txtPrecio1.Text == "0" || txtPrecio1.Text == "")
                    {
                        txtPrecio1.Text = "1";
                    }

                    if (txtPrecio2.Text == "0" || txtPrecio2.Text == "")
                    {
                        txtPrecio2.Text = "1";
                    }

                    if (txtPrecio3.Text == "0" || txtPrecio3.Text == "")
                    {
                        txtPrecio3.Text = "1";
                    }

                    if (txt_stcokmin.Text == "")
                    {
                        txt_stcokmin.Text = "0";
                    }

                    // UNIDAD.
                    if (txt_medida.Text == "")
                    {
                        txt_medida.Text = "UN";
                    }

                    // Descripcion del Producto.
                    descr = txt_descripcion.Text.ToString();
                    descr = descr.ToUpper();
                    descr = descr.Trim();

                    // Unidad de medida del Producto.
                    medida = txt_medida.Text.ToString();
                    medida = medida.ToUpper();
                    medida = medida.Trim();

                    // Moneda
                    moneda = Convert.ToInt32(txt_moneda.Text);

                    // IVA.
                    iva = Convert.ToInt32(txt_iva.Text);

                    // Costo Contable del producto.
                    coscont = Convert.ToDouble(txtCosto.Text);

                    // Costo Administrativo del producto.
                    cosadm = Convert.ToDouble(txtPrecio1.Text);

                    // Precio de Venta Mayorista. 
                    venmay = Convert.ToDouble(txtPrecio2.Text);

                    // Precio de Venta Minorista.
                    venmin = Convert.ToDouble(txtPrecio3.Text);

                    // Cantidad minima.
                    stmin = Convert.ToInt32(txt_stcokmin.Text);

                    // Observacion del Producto.
                    obs = txt_obser.Text.ToString();
                    obs = obs.Trim();

                    // marca
                    marca = Convert.ToInt32(cmbmarca.SelectedValue);
                    // MessageBox.Show("" + cmbmarca.SelectedValue);

                    grupo = Convert.ToInt32(cmbgrupo.SelectedValue);
                    // MessageBox.Show(""+cmbgrupo.SelectedValue);

                    subgrupo = Convert.ToInt32(cmbsubgrupo.SelectedValue);
                    // MessageBox.Show("" + cmbsubgrupo.SelectedValue);

                    try
                    {
                        Produto obj = new Produto();
                        obj.codigo = codigo;
                        obj.descr = descr;
                        obj.unidad = medida;
                        obj.moneda = moneda;
                        obj.iva = iva;
                        obj.costocon = coscont;
                        obj.costoadm = cosadm;
                        obj.ventamay = venmay;
                        obj.ventamin = venmin;
                        obj.st_minimo = stmin;
                        obj.observacion = obs;
                        obj.marca = marca;
                        obj.grupo = grupo;
                        obj.subgrupo = subgrupo;


                        // chamando clase para gravar os dados. 
                        ProdutoDal editar = new ProdutoDal();
                        editar.alterar(obj);

                        MessageBox.Show("PRODUCTO ALTERADO EXITOSAMENTE");

                        this.Close();
                        frm_tabla_stock fr = new frm_tabla_stock();
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


                    if (txt_moneda.Text == "")
                    {
                        txt_moneda.Text = "1";
                    }

                    if (txt_iva.Text == "")
                    {
                        txt_iva.Text = "10";
                    }

                    if (txtCosto.Text == "0" || txtCosto.Text == "")
                    {
                        txtCosto.Text = "1";
                    }

                    if (txtPrecio1.Text == "0" || txtPrecio1.Text == "")
                    {
                        txtPrecio1.Text = "1";
                    }

                    if (txtPrecio2.Text == "0" || txtPrecio2.Text == "")
                    {
                        txtPrecio2.Text = "1";
                    }

                    if (txtPrecio3.Text == "0" || txtPrecio3.Text == "")
                    {
                        txtPrecio3.Text = "1";
                    }

                    if (txt_stcokmin.Text == "")
                    {
                        txt_stcokmin.Text = "0";
                    }

                    // UNIDAD.
                    if (txt_medida.Text == "")
                    {
                        txt_medida.Text = "UN";
                    }

                    // Descripcion del Producto.
                    descr = txt_descripcion.Text.ToString();
                    descr = descr.ToUpper();
                    descr = descr.Trim();

                    // Unidad de medida del Producto.
                    medida = txt_medida.Text.ToString();
                    medida = medida.ToUpper();
                    medida = medida.Trim();

                    // Moneda
                    moneda = Convert.ToInt32(txt_moneda.Text);

                    // IVA.
                    iva = Convert.ToInt32(txt_iva.Text);

                    // Costo Contable del producto.
                    coscont = Convert.ToDouble(txtCosto.Text);

                    // Costo Administrativo del producto.
                    cosadm = Convert.ToDouble(txtPrecio1.Text);

                    // Precio de Venta Mayorista. 
                    venmay = Convert.ToDouble(txtPrecio2.Text);

                    // Precio de Venta Minorista.
                    venmin = Convert.ToDouble(txtPrecio3.Text);

                    // Cantidad minima.
                    stmin = Convert.ToInt32(txt_stcokmin.Text);

                    // Observacion del Producto.
                    obs = txt_obser.Text.ToString();
                    obs = obs.Trim();

                    // marca
                    marca = Convert.ToInt32(cmbmarca.SelectedValue);
                    //MessageBox.Show("" + cmbmarca.SelectedValue);
                    grupo = Convert.ToInt32(cmbgrupo.SelectedValue);
                    //MessageBox.Show(""+cmbgrupo.SelectedValue);
                    subgrupo = Convert.ToInt32(cmbsubgrupo.SelectedValue);
                    //MessageBox.Show("" + cmbsubgrupo.SelectedValue);
                    try
                    {
                        Produto obj = new Produto();
                        obj.descr = descr;
                        obj.unidad = medida;
                        obj.moneda = moneda;
                        obj.iva = iva;
                        obj.costocon = coscont;
                        obj.costoadm = cosadm;
                        obj.ventamay = venmay;
                        obj.ventamin = venmin;
                        obj.st_minimo = stmin;
                        obj.observacion = obs;
                        obj.marca = marca;
                        obj.grupo = grupo;
                        obj.subgrupo = subgrupo;


                        // chamando clase para gravar os dados. 
                        ProdutoDal gravar = new ProdutoDal();
                        gravar.gravar(obj);

                        MessageBox.Show("PRODUCTO GRABADO EXITOSAMENTE");

                        this.Close();
                        frm_tabla_stock fr = new frm_tabla_stock();
                        fr.Show();

                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("ERROR AL GUARDAR PRODUCTO" + erro);
                    }
                }
            }

        }

        

       

       

    }
}
