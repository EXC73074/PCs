using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABMproductosRicardo
{
    public partial class Form1 : Form
    {
        Conexiones classconexion = new Conexiones(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\Ricardo\Desktop\Facu\Programacion\Programacion II\DBFProducto.mdb");
        bool bnuevo = false;
        

        const int tam = 20;
        ProductosRicardo[] PR = new ProductosRicardo[tam];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarcombo(cboMarca,"marca");
            cargarlista("producto");
            btninicial(false);
            habilitar(false);
            
            

        }

        private void btninicial(bool t)
        {
            btnNuevo.Enabled = !t;
            btnEditar.Enabled = !t;
            btnBorrar.Enabled = t;
            btnGrabar.Enabled = t;
            btnCancelar.Enabled = t;
            btnSalir.Enabled = !t;
            
        }

        private void habilitar(bool t)
        {
            txtCodigo.Enabled = t;
            txtDetalle.Enabled = t;
            cboMarca.Enabled = t;
            rbtNoteBook.Enabled = t;
            rbtNetBook.Enabled = t;
            txtPrecio.Enabled = t;
            dtpFecha.Enabled = t;
        }

        private void limpiar()
        {
            txtCodigo.Clear();
            txtDetalle.Clear();
            cboMarca.SelectedIndex = -1;
            rbtNetBook.Checked = false;
            rbtNoteBook.Checked = false;
            txtPrecio.Clear();
            dtpFecha.Value = DateTime.Today;
        }


        private void asignarcombo(ComboBox combo)
        {
            combo.DataSource = classconexion.Ptabla;
            combo.DisplayMember = classconexion.Ptabla.Columns[1].ColumnName;
            combo.ValueMember = classconexion.Ptabla.Columns[0].ColumnName;
        }

        private void cargarcombo(ComboBox combo, string nombretabla)
        {
            
            classconexion.Consultartabla(nombretabla);
            asignarcombo(combo);
            combo.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void actualizarcampos(int posicion)
        {
            txtCodigo.Text = PR[posicion].Pcodigo.ToString();
            txtDetalle.Text = PR[posicion].Pdetalle;
            cboMarca.SelectedIndex = PR[posicion].Pmarca;
            if(PR[posicion].Ptipo==1)
            {
                rbtNoteBook.Checked = true;
            }
            else
            {
                rbtNetBook.Checked = true;
            }
            txtPrecio.Text = PR[posicion].Pprecio.ToString();
            dtpFecha.Value = PR[posicion].Pfecha;
        }

        private void ValidaVacio()
        {
            if (txtCodigo.Text == "" ||
                txtDetalle.Text == "" ||
                cboMarca.SelectedIndex == -1 ||
                rbtNoteBook.Checked == false && rbtNetBook.Checked ==false||
                txtPrecio.Text==""||
                dtpFecha.Value > DateTime.Now)
            {
                btnGrabar.Enabled = false;
            }
            else
            {
                btnGrabar.Enabled = true;
            }
        }


        private void cargarlista(string nombretabla)
        {
            
            classconexion.Leertabla(nombretabla);
            int c = 0;
            while(classconexion.Plector.Read())
            {
                ProductosRicardo pr = new ProductosRicardo();
                if (!classconexion.Plector.IsDBNull(0))
                    pr.Pcodigo = classconexion.Plector.GetInt32(0);
                if (!classconexion.Plector.IsDBNull(1))
                    pr.Pdetalle = classconexion.Plector.GetString(1);
                if (!classconexion.Plector.IsDBNull(2))
                    pr.Ptipo = classconexion.Plector.GetInt32(2);
                if (!classconexion.Plector.IsDBNull(3))
                    pr.Pmarca = classconexion.Plector.GetInt32(3);
                if (!classconexion.Plector.IsDBNull(4))
                    pr.Pprecio = classconexion.Plector.GetDouble(4);
                if (!classconexion.Plector.IsDBNull(5))
                    pr.Pfecha = classconexion.Plector.GetDateTime(5);
                PR[c] = pr;
                c++;
            }
            classconexion.Plector.Close();
            classconexion.desconectar();
            lstProducto.Items.Clear();
            for (int i = 0;i<c;i++)
            {
                lstProducto.Items.Add(PR[i].ToStringProductosRicardo());
            }

            
        }

        private void lstProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarcampos(lstProducto.SelectedIndex);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btninicial(true);
            habilitar(true);
            limpiar();
            btnBorrar.Enabled = false;
            lstProducto.Enabled = false;
            bnuevo = true;
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitar(true);
            btnEditar.Enabled = false;
            txtCodigo.Enabled = false;
            btnBorrar.Enabled = true;
            btnNuevo.Enabled = false;
            lstProducto.Enabled = true;
            btnCancelar.Enabled = true; 
            bnuevo = false;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Esta seguro de Eliminar el Producto " + PR[lstProducto.SelectedIndex].Pdetalle + "?",
                                            "BORRAR",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Warning,
                                            MessageBoxDefaultButton.Button2);
            if(DialogResult==DialogResult.Yes)
            {
                string sql = "delete producto where codigo= " + PR[lstProducto.SelectedIndex].Pcodigo;
                classconexion.consultas(sql);
                btninicial(false);
                habilitar(false);
                cargarlista("producto");
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            
            ProductosRicardo PR = new ProductosRicardo();
            PR.Pcodigo = Convert.ToInt32(txtCodigo.Text);
            PR.Pdetalle = txtDetalle.Text;
            if (rbtNoteBook.Checked)
                PR.Ptipo = 1;
            else
                PR.Ptipo = 2;
            PR.Pmarca = Convert.ToInt32(cboMarca.SelectedValue)- 1;
            PR.Pprecio = Convert.ToDouble(txtPrecio.Text);
            PR.Pfecha = dtpFecha.Value;

            string sql;

            if(bnuevo == true)
            {
                if(!existe(PR.Pcodigo))
                {
                    sql = "insert into producto values (" + PR.Pcodigo + ",'" +
                                                        PR.Pdetalle + "'," +
                                                        PR.Pmarca + "," + 
                                                        PR.Ptipo + "," +
                                                        PR.Pprecio + ",'" +
                                                        PR.Pfecha + "')";
                    classconexion.consultas(sql);
                    cargarlista("producto");
                }
                else
                {
                    MessageBox.Show("Este producto ya se encuentra registrado", "ADVERTENCIA");
                }
            }
            else
            {
                sql = "Update producto set        detalle='" + PR.Pdetalle + "',"
                                               + "tipo=" + PR.Ptipo + ","
                                               + "marca=" + PR.Pmarca + ","
                                               + "precio=" + PR.Pprecio + ","
                                               + "fecha='" + PR.Pfecha + "' "
                                               + "Where codigo=" + PR.Pcodigo;
                classconexion.consultas(sql);
                cargarlista("producto");
            }

            btninicial(false);
            habilitar(false);
            limpiar();
        }

        private bool existe(int pk)
        {
            for(int i =0; i<lstProducto.Items.Count; i++)
            {
                if(PR[i].Pcodigo==pk)
                {
                    return true;
                }              
            }
            return false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Esta seguro de Cancelar?", "CANCELAR", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button2);
            if(DialogResult==DialogResult.Yes)
            {
                limpiar();
                btninicial(false);
                habilitar(false);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Desea Salir del programa?","SALIR",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
            if(DialogResult==DialogResult.Yes)
            {
                Close();
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            ValidaVacio();
        }

        private void txtDetalle_TextChanged(object sender, EventArgs e)
        {
            ValidaVacio();
        }

        private void cboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidaVacio();
        }

        private void rbtNoteBook_CheckedChanged(object sender, EventArgs e)
        {
            ValidaVacio();
        }

        private void rbtNetBook_CheckedChanged(object sender, EventArgs e)
        {
            ValidaVacio();
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            ValidaVacio();
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            ValidaVacio();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if(Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }

        }

        private void txtDetalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if(Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    if(Char.IsSeparator(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if(Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                   if(Char.IsPunctuation(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                   else
                    {
                        e.Handled=true;
                    }
                }
            }
        }
    }
}
