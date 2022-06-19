using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Biblio_Excepciones;
using Biblio_Interfaces;
using DAO_y_Archivos;

namespace TPFinal_Heladeria_Froddo
{
    public partial class AuxiliarFormPedido : Form
    {
        private string keyword;
        private TomarPedido formPadre;

        public AuxiliarFormPedido(string keyword, TomarPedido formPadre)
        {
            InitializeComponent();
            this.keyword = keyword;
            this.formPadre = formPadre;
        }

        private void AddPedido_Load(object sender, EventArgs e)
        {
            try
            {
                this.SetTipos();
                this.SetSabores();
                this.SetCantidades();
                if (keyword == "Modificar")
                {
                    this.CargarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo mostrar el formulario " + ex.Message);
            }
        }

        private void SetTipos()
        {
            this.cmb_Tipo.Items.Add("Helado");
            this.cmb_Tipo.Items.Add("Yogur");
        }

        private void SetSabores()
        {
            List<Postre> lista = PostreDAO.Leer();

            foreach (Postre item in lista)
            {
                this.cmb_Sabor.Items.Add(item.Sabor);
            }
        }

        private void SetCantidades()
        {
            this.cmb_Cantidad.Items.Add(1);
            this.cmb_Cantidad.Items.Add(0.5);
            this.cmb_Cantidad.Items.Add(0.25);
        }

        /// <summary>
        /// Valida la data ingresada y, si pasa las validaciones, se añade a la lista de ventas 
        /// Y se oculta este form
        /// </summary>
        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();

            try
            {
                if (this.ValidarCamposLlenos())
                {

                    if (Validator.NoContieneNumeros(textBox_Nombre.Text)
                        && int.TryParse(textBox_DNI.Text, out int num))
                    {
                        if (textBox_Nombre.Text.Length < 51 || textBox_Direccion.Text.Length < 101)
                        {
                            if (textBox_DNI.Text.Length == 10)
                            {
                                //Cargo los valores
                                pedido = this.CargarPedido();

                                //Valido que haya stock antes de venderlo
                                if (Validator.HayStock(PostreDAO.Leer(), pedido))
                                {
                                    if (this.keyword == "Agregar")
                                    {
                                        VentasDAO.Guardar(pedido);
                                        this.formPadre.pedido = pedido;
                                        DialogResult = DialogResult.OK;
                                    }
                                    else if (this.keyword == "Modificar")
                                    {
                                        this.formPadre.pedido = pedido;
                                        VentasDAO.Modificar(this.formPadre.pedido);
                                        DialogResult = DialogResult.OK;
                                    }
                                    else
                                    {
                                        throw new Exception();
                                    }
                                }
                                else
                                {
                                    throw new SinEspacioEnLaHeladeraExcepcion();
                                }
                            }
                            else
                            {
                                throw new IndexOutOfRangeException("El DNI debe tener un numero de 10 digitos");
                            }
                        }
                        else
                        {
                            throw new IndexOutOfRangeException("Nombre o Direccion demasiado largas");
                        }
                    }
                    else
                    {
                        throw new FormatException("DNI o Nombre con caracteres invalidos");
                    }
                }
                else
                {
                    throw new CamposVaciosException();
                }
            }
            catch (CamposVaciosException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(NumeroNegativoException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(SinEspacioEnLaHeladeraExcepcion ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Sucedio un error inesperado");
            }    
        }

        private void CargarCampos()
        {
            textBox_Nombre.Text = this.formPadre.pedido.Nombre;
            textBox_DNI.Text = this.formPadre.pedido.Dni.ToString();
            cmb_Tipo.Text = this.formPadre.pedido.Tipo;
            cmb_Sabor.Text = this.formPadre.pedido.Sabor;
            cmb_Cantidad.Text = this.formPadre.pedido.Cantidad.ToString();
            textBox_Direccion.Text = this.formPadre.pedido.Direccion;
        }

        private Pedido CargarPedido()
        {
            int id = this.formPadre.pedido.Id;
            double cantidad = double.Parse(cmb_Cantidad.Text);
            double precio = Pedido.CalcularPrecio(cmb_Tipo.Text, cantidad);

            if (this.keyword == "Modificar")
            {
                Pedido pedidoMod = new Pedido(
                id,
                int.Parse(textBox_DNI.Text),
                textBox_Nombre.Text,
                textBox_Direccion.Text,
                cmb_Tipo.Text,
                cmb_Sabor.Text,
                cantidad,
                precio
                );

                return pedidoMod;
            }
            else if(this.keyword == "Agregar")
            {
                Pedido pedidoAdd = new Pedido(
                   int.Parse(textBox_DNI.Text),
                   textBox_Nombre.Text,
                   textBox_Direccion.Text,
                   cmb_Tipo.Text,
                   cmb_Sabor.Text,
                   cantidad,
                   precio
                   );

                return pedidoAdd;
            }

            return null;
        }

        private bool ValidarCamposLlenos()
        {
            if (textBox_Nombre.Text != String.Empty && textBox_DNI.Text != String.Empty &&
                cmb_Tipo.Text != String.Empty && cmb_Sabor.Text != String.Empty &&
                cmb_Cantidad.Text != String.Empty && textBox_Direccion.Text != String.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
