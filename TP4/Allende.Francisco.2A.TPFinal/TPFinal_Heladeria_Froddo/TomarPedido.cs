using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Biblio_Excepciones;
using Biblio_Interfaces;
using DAO_y_Archivos;

namespace TPFinal_Heladeria_Froddo
{
    public partial class TomarPedido : Form, ITabla, IExport
    {
        private Form_MenuPrincipal formPrincipal;
        private Ventas ventas;
        public Pedido pedido;

        /// <summary>
        /// Recibe atributos del form padre, guardando asi todos los cambios aun sin serializar
        /// </summary>
        public TomarPedido(Form_MenuPrincipal formPrincipal, Ventas ventas)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
            this.ventas = ventas;
            try
            {
                this.RefreshTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Carga o instancia todos sus atributos 
        /// </summary>
        private void Vender_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            try
            {
                this.pedido = new Pedido(); 
                dataGrid_Pedidos.Columns[3].Width = 200;
                dataGrid_Pedidos.Columns[5].Width = 200;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region Eventos

        private void btn_AgregarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                this.AddToTabla();
            }
            catch (Exception)
            {
                MessageBox.Show("Sucedio un error inesperado al querer agregar un pedido");
            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Modificar();
                this.RefreshTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Remover_Click(object sender, EventArgs e)
        {
            try
            {
                this.RemoveFromTabla();
                this.RefreshTabla();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (NumeroNegativoException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ItemNoEncontradoException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Sucedio un error inesperado intentando remover el pedido");
            }
        }

        private void btn_Cobrar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cobrar();
                this.RefreshTabla();
                textBox_Total.Text = String.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void btn_Volver_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                this.formPrincipal.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("No se puedo volver a la pagina principal");
            }
        }
        
        private void btn_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                this.PreguntarAntesDeCerrar();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo cerrar el programa por las buenas. Se cerrara forzosamente");
                Application.Exit();
            }
        }

        #endregion

        #region IExport
        /// <summary>
        /// Guarda las facturas de las ventas en un txt
        /// </summary>
        public async void SaveAndExport()
        {
            label_Factura.Text = "Aguarde...";
            this.ventas.ListaVentas = await GestionarArchivos.CargarYOrdenarVentas();
            label_Factura.Text = "Factura";

            if (this.ventas.ListaVentas != null)
            {
                Serializador.SerializadorJson("Lista_Ventas.json", this.ventas.ListaVentas);

                List<Pedido> factura = new List<Pedido>();

                foreach (Pedido item in this.ventas.ListaVentas)
                {
                    if (this.pedido.Dni == item.Dni)
                    {
                        factura.Add(item);
                    }
                }

                GestionarArchivos.Escribir("Facturas.txt", factura);
            }
        }

        #endregion

        #region ITabla

        /// <summary>
        /// Ya confirmada la compra, se añade a la tabla el pedido
        /// </summary>
        public void AddToTabla()
        {
            try
            {
                AuxiliarFormPedido frm = new AuxiliarFormPedido("Agregar", this);

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    frm.Hide();
                    this.RefreshTabla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sucedio un error al querer cargar los datos a la tabla ", ex.Message);
            }
        }

        public void Modificar()
        {
            try
            {
                if (dataGrid_Pedidos.SelectedRows.Count > 0)
                {
                    this.pedido = (Pedido)dataGrid_Pedidos.CurrentRow.DataBoundItem;

                    AuxiliarFormPedido frm = new AuxiliarFormPedido("Modificar", this);

                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        frm.Hide();
                        this.RefreshTabla();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sucedio un error al querer modificar los datos del pedido ", ex.Message);
            }
        }

        /// <summary>
        /// Se remueve un pedido de la tabla
        /// </summary>
        public void RemoveFromTabla()
        {
            try
            {
                if (dataGrid_Pedidos.SelectedRows.Count > 0)
                {
                    Pedido pedido = (Pedido)dataGrid_Pedidos.CurrentRow.DataBoundItem;
                    VentasDAO.Eliminar(pedido.Id); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sucedio un error al querer cargar los datos a la tabla ", ex.Message);
            }
        }

        /// <summary>
        /// Refresca la tabla al vaciarla y actualizarla con la nueva data
        /// </summary>
        public void RefreshTabla()
        {
            try
            {
                dataGrid_Pedidos.DataSource = VentasDAO.Leer();
                dataGrid_Pedidos.Refresh();
                dataGrid_Pedidos.Update();
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region Metodos
        /// <summary>
        /// Exporto los datos en un xml y los cargo a la lista
        /// Cobro el total al imprimr una factura 
        /// </summary>
        private void Cobrar()
        {
            this.SaveAndExport();
            this.PrintFactura();
            MessageBox.Show("Venta realizada y guardada con exito!");

            //Vacio todo y vuelvo a comenzar
            listBox_Factura.Items.Clear();
            this.pedido = new Pedido();
        }

        /// <summary>
        /// Imprime en el list box los datos de la facturacion y calcula el total
        /// Simula el tiempo de impresion
        /// </summary>
        private async void PrintFactura()
        {
            double total = 0;
            label_Factura.Text = "Imprimiendo...";

            await Task.Run(() =>
            {
                foreach (Pedido item in this.ventas.ListaVentas)
                {
                    if (item.Dni == this.pedido.Dni)
                    {
                        //Thread.Sleep(3000);
                        listBox_Factura.Items.Add(item.ToString());
                        total += item.Precio;
                    }
                }
            });
            label_Factura.Text = "Factura";
            textBox_Total.Text = total.ToString();
        }

        /// <summary>
        /// Modelo de Message box
        /// </summary>*/
        private DialogResult GenerateMessageBox(string texto, string titulo, MessageBoxButtons btn, MessageBoxIcon icono)
        {
            return MessageBox.Show(texto, titulo, btn, icono);
        }

        /// <summary>
        /// Pregunta si se desea salir
        /// </summary>
        private void PreguntarAntesDeCerrar()
        {
            DialogResult respuesta = this.GenerateMessageBox("¿Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        #endregion
    }
}
