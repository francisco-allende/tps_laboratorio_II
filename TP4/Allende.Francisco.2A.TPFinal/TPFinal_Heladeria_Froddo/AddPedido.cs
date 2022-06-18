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

namespace TPFinal_Heladeria_Froddo
{
    public partial class AddPedido : Form
    {
        private Heladera<Postre> heladeraStock;
        private Ventas ventas;
        private TomarPedido formPadre;

        public AddPedido(Heladera<Postre> heladeraStock, Ventas ventas, TomarPedido formPadre)
        {
            InitializeComponent();
            this.heladeraStock = heladeraStock;
            this.ventas = ventas;
            this.formPadre = formPadre;
        }

        private void AddPedido_Load(object sender, EventArgs e)
        {

            this.SetTipos();
            this.SetSabores();
            this.SetCantidades();
        }

        private void SetTipos()
        {
            this.cmb_Tipo.Items.Add("Helado");
            this.cmb_Tipo.Items.Add("Yogur");
        }

        private void SetSabores()
        {
            foreach (Postre item in this.heladeraStock.ListaGenerica)
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
                    if(Validator.NoContieneNumeros(textBox_Nombre.Text) 
                        && int.TryParse(textBox_DNI.Text, out int num))
                    {
                        if(textBox_Nombre.Text.Length < 51 || textBox_Direccion.Text.Length < 101)
                        {
                            if(textBox_DNI.Text.Length == 10)
                            {
                                if(Validator.ValidateSabor(cmb_Tipo.Text, cmb_Sabor.Text))
                                {
                                    //Cargo los valores
                                    pedido = this.CargarPedido();

                                    //Valido que haya stock antes de venderlo
                                    if (Validator.HayStock(this.heladeraStock.ListaGenerica, pedido))
                                    {   
                                        this.ventas.ListaVentas.Add(pedido);
                                        this.formPadre.pedido = pedido;
                                        DialogResult = DialogResult.OK;
                                    }
                                    else
                                    {
                                        throw new SinEspacioEnLaHeladeraExcepcion();
                                    }
                                }
                                else
                                {
                                    throw new FormatException("Sabor no disponible para dicho postre");
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

      

        private Pedido CargarPedido()
        {
            int idPedido = Pedido.AsignarId();
            double cantidad = double.Parse(cmb_Cantidad.Text);
            double precio = Pedido.CalcularPrecio(cmb_Tipo.Text, cantidad);

            Cliente cliente = new Cliente
                (
                    int.Parse(textBox_DNI.Text),
                    textBox_Nombre.Text,
                    textBox_Direccion.Text
                );

            Pedido pedido = new Pedido(
                idPedido,
                cliente,
                cmb_Tipo.Text,
                cmb_Sabor.Text,
                cantidad,
                precio
                );
            
            return pedido;
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
