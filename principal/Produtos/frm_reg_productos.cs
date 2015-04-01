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

        validar_datos v1 = new validar_datos();
        public int codigo;
        public string grupo, subgrupo, marca, aplicacion, descripcion, iva, moneda, observacion, medida, stminimo;
        public Double costo_adm, costo_cont, ventamay, ventamin;


        private void btn_alterar_Click(object sender, EventArgs e)
        {
            frm_tabla_stock fr = new frm_tabla_stock();
            fr.Show();
            this.Hide();
        }

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
              txt_costoadmin.Text = Convert.ToString(costo_adm);
              txt_costocont.Text = Convert.ToString(costo_cont);
              txt_ventamay.Text = Convert.ToString(ventamay); 
              txt_ventamin.Text = Convert.ToString(ventamin);
              txt_obser.Text = Convert.ToString(observacion);
              txt_iva.Text = Convert.ToString(iva);
              txt_medida.Text = Convert.ToString(medida);
              cmbmarca.Text = Convert.ToString(marca);
              cmbgrupo.Text = Convert.ToString(grupo);
              cmbsubgrupo.Text = Convert.ToString(subgrupo);

              txt_ventamay.Text = string.Format("{0:N0}", Convert.ToDouble(txt_ventamay.Text));
              txt_ventamin.Text = string.Format("{0:N0}", Convert.ToDouble(txt_ventamin.Text));
              txt_costoadmin.Text = string.Format("{0:N0}", Convert.ToDouble(txt_costoadmin.Text));
              txt_costocont.Text = string.Format("{0:N0}", Convert.ToDouble(txt_costocont.Text));
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
              txt_costoadmin.Text = Convert.ToString(costo_adm);
              txt_costocont.Text = Convert.ToString(costo_cont);
              txt_ventamay.Text = Convert.ToString(ventamay);
              txt_ventamin.Text = Convert.ToString(ventamin);
              txt_obser.Text = Convert.ToString(observacion);
              txt_iva.Text = Convert.ToString(iva);
              txt_medida.Text = Convert.ToString(medida);  
           }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            String descr, medida, obs;
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

                  if (txt_costocont.Text == "0" || txt_costocont.Text == "")
                  {
                     txt_costocont.Text = "1";
                     
                  }

                  if (txt_costoadmin.Text == "0" || txt_costoadmin.Text == "")
                  {
                     txt_costoadmin.Text = "1";
                  }

                  if (txt_ventamay.Text == "0" || txt_ventamay.Text == "")
                  {
                     txt_ventamay.Text = "1";
                  }

                  if (txt_ventamin.Text == "0" || txt_ventamin.Text == "")
                  {
                     txt_ventamin.Text = "1";
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
                  coscont = Convert.ToDouble(txt_costocont.Text);

                  // Costo Administrativo del producto.
                  cosadm = Convert.ToDouble(txt_costoadmin.Text);

                  // Precio de Venta Mayorista. 
                  venmay = Convert.ToDouble(txt_ventamay.Text);

                  // Precio de Venta Minorista.
                  venmin = Convert.ToDouble(txt_ventamin.Text);

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

                     if (txt_costocont.Text == "0" || txt_costocont.Text == "")
                     {
                        txt_costocont.Text = "1";
                     }
                     
                     if (txt_costoadmin.Text == "0" || txt_costoadmin.Text == "")
                     {
                        txt_costoadmin.Text = "1";
                     }

                     if (txt_ventamay.Text == "0" || txt_ventamay.Text == "")
                     {
                        txt_ventamay.Text = "1";
                     }

                     if (txt_ventamin.Text == "0" || txt_ventamin.Text == "")
                     {
                        txt_ventamin.Text = "1";
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
                     coscont = Convert.ToDouble(txt_costocont.Text);

                     // Costo Administrativo del producto.
                     cosadm = Convert.ToDouble(txt_costoadmin.Text);

                     // Precio de Venta Mayorista. 
                     venmay = Convert.ToDouble(txt_ventamay.Text);

                     // Precio de Venta Minorista.
                     venmin = Convert.ToDouble(txt_ventamin.Text);

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


        private void txt_peso_KeyPress(object sender, KeyPressEventArgs e)
        {
            v1.solonumeros(e);
        }

        private void txt_ventamay_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (e.KeyChar == Convert.ToChar(Keys.Enter))
           {
              txt_ventamin.Focus();
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
              txt_costoadmin.Focus();
           } 
           v1.solonumeros(e);
        }

        private void txt_costoadmin_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (e.KeyChar == Convert.ToChar(Keys.Enter))
           {
              txt_ventamay.Focus();
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
              txt_costocont.Focus();
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
           txt_costocont.Text = string.Format("{0:N0}", Convert.ToDouble(txt_costocont.Text));
        }

        private void txt_costoadmin_Leave(object sender, EventArgs e)
        {
           txt_costoadmin.Text = string.Format("{0:N0}", Convert.ToDouble(txt_costoadmin.Text));
        }

        private void txt_ventamay_Leave(object sender, EventArgs e)
        {
           txt_ventamay.Text = string.Format("{0:N0}", Convert.ToDouble(txt_ventamay.Text));
        }

        private void txt_ventamin_Leave(object sender, EventArgs e)
        {
           txt_ventamin.Text = string.Format("{0:N0}", Convert.ToDouble(txt_ventamin.Text));
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

    }
}
