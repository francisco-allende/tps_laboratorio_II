﻿using System;
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
    public partial class TomarPedido : Form, ITabla, IBaseDeDatos
    {
        private Form_MenuPrincipal formPrincipal;
        private Heladera<Postre> heladeraStock;
        private Ventas ventas;
        public Pedido pedido;

        /// <summary>
        /// Recibe atributos del form padre, guardando asi todos los cambios aun sin serializar
        /// </summary>
        public TomarPedido(Form_MenuPrincipal formPrincipal, Heladera<Postre> heladeraStock, Ventas ventas)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
            this.heladeraStock = heladeraStock;
            this.ventas = ventas;
        }


        /// <summary>
        /// Carga o instancia todos sus atirbutos 
        /// </summary>
        private void Vender_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.pedido = new Pedido(); //instancio primero el pedido, sino su cliente es null
            this.pedido.ClienteQuePide = new Cliente();
        }

        #region Eventos

        private void btn_AgregarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                AddPedido frm = new AddPedido(this.heladeraStock, this.ventas, this);

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    frm.Hide();
                    this.AddToTabla();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sucedio un error inesperado al querer agregar un pedido");
            }
        }

        private void btn_Remover_Click(object sender, EventArgs e)
        {
            try
            {
                this.RemoveFromTabla();
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
                labelPrecioTotal.Text = "0";
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
        
        #region IBaseDeDatos
        /// <summary>
        /// Guarda las facturas de las ventas en un txt
        /// </summary>
        
        public void SaveAndExport()
        {
            if (this.ventas.ListaVentas != null)
            {
                Serializador.SerializarXML("Lista_Ventas.xml", this.ventas.ListaVentas);

                List<Pedido> factura = new List<Pedido>();

                foreach (Pedido item in this.ventas.ListaVentas)
                {
                    if(this.pedido.ClienteQuePide.Dni == item.ClienteQuePide.Dni)
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
        /// Carga la tabla con los valores correspondientes
        /// </summary>
        public void PrintTabla()
        {
            int index = 0;

            foreach (Pedido item in this.ventas.ListaVentas)
            {
                if(item.ClienteQuePide.Dni == this.pedido.ClienteQuePide.Dni)
                {
                    dataGrid_Pedidos.Rows.Add();
                    dataGrid_Pedidos.Rows[index].Cells["IdPedido"].Value = item.Id;
                    dataGrid_Pedidos.Rows[index].Cells["NombreCliente"].Value = item.ClienteQuePide.Nombre;
                    dataGrid_Pedidos.Rows[index].Cells["DNI"].Value = item.ClienteQuePide.Dni;
                    dataGrid_Pedidos.Rows[index].Cells["Tipo"].Value = item.Tipo;
                    dataGrid_Pedidos.Rows[index].Cells["Sabor"].Value = item.Sabor;
                    dataGrid_Pedidos.Rows[index].Cells["Cantidad"].Value = item.RetornarCantidadEscrito(item.Cantidad);
                    dataGrid_Pedidos.Rows[index].Cells["Direccion"].Value = item.ClienteQuePide.Direccion;
                    dataGrid_Pedidos.Rows[index].Cells["Precio"].Value = item.Precio;
                    labelPrecioTotal.Text = item.CalcularTotal(this.ventas.ListaVentas, item).ToString();

                    index++;
                }
            }
        }

        /// <summary>
        /// Ya confirmada la compra, se añade a la tabla el cliente con su pedido
        /// </summary>
        public void AddToTabla()
        {
            try
            {
                this.RefreshTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sucedio un error al querer cargar los datos a la tabla ", ex.Message);
            }
        }

        private int GetId()
        {
            if (dataGrid_Pedidos.SelectedRows.Count > 0)
            {
                int index = dataGrid_Pedidos.CurrentCell.RowIndex;
                int id = (int)dataGrid_Pedidos.Rows[index].Cells["IdPedido"].Value;
                return id;
            }
            return -1;
        }

        /// <summary>
        /// Se remueve un cliente de la tabla
        /// </summary>
        public void RemoveFromTabla()
        {
            int id = this.GetId();
            bool encontrado = false;
            if (id != -1)
            {
                foreach (Pedido item in ventas.ListaVentas)
                {
                    if (id == item.Id)
                    {
                        ventas.ListaVentas.Remove(item);
                        this.RefreshTabla();
                        encontrado = true;
                        break;
                    }
                }
                if (!encontrado)
                {
                    throw new ItemNoEncontradoException();
                }
            }
        }

        /// <summary>
        /// Refresca la tabla al vaciarla y actualizarla con la nueva data
        /// </summary>
        public void RefreshTabla()
        {
            this.ClearTabla();
            this.PrintTabla();
        }

        /// <summary>
        /// Limpia la tabla
        /// </summary>
        public void ClearTabla()
        {
            dataGrid_Pedidos.Rows.Clear();
        }
        #endregion

        #region Metodos
        
       
        /// <summary>
        /// Cobra el total al imrpimr una factura, 
        /// agregar a la lista de ventas confirmadas al pedido
        /// Y resetea todo para un nuevo cliente, quitando de la lista lo ya vendido
        /// </summary>
        private void Cobrar()
        {
            if(dataGrid_Pedidos.RowCount > 0)
            {
                this.SaveAndExport();
                this.PrintFactura();
                MessageBox.Show("Venta realizada con exito!\nFactura imprimiendose\nPresione Aceptar para comenzar de nuevo y tomar un nuevo pedido");

                //Vacio todo y vuelvo a comenzar. Borro la venta del listado, ya fue concretada
                this.SacarPedidosDeLaLista();
                listBox_Factura.Items.Clear();
                this.pedido = new Pedido();
                this.ClearTabla();
            }
            else
            {
                MessageBox.Show("No se pueden cobrar pedidos vacios");
            }
        }

        private void SacarPedidosDeLaLista()
        {
            List<Pedido> aRemover = new List<Pedido>();

            foreach (Pedido item in ventas.ListaVentas)
            {
                if (item.ClienteQuePide.Dni == this.pedido.ClienteQuePide.Dni)
                {
                    aRemover.Add(item);
                }
            }
            if(aRemover.Count > 0 && aRemover != null)
            {
                this.ventas.ListaVentas.RemoveAll(aRemover.Contains);
            }
        }

        /// <summary>
        /// Imprime en el lsit box los datos de la facturacion ya cobrado el/los pedido/s
        /// </summary>
        private void PrintFactura()
        {
            foreach (Pedido item in ventas.ListaVentas)
            {
                if (item.ClienteQuePide.Dni == this.pedido.ClienteQuePide.Dni)
                {
                    listBox_Factura.Items.Add(item.ToString());
                    listBox_Factura.Items.Add(item.ClienteQuePide.ToString());
                }
            }
        }

        /// <summary>
        /// Sobrecargo dos messagebox con formato distinto
        /// </summary>*/
        private DialogResult GenerateMessageBox(string texto, string titulo, MessageBoxButtons btn, MessageBoxIcon icono)
        {
            return MessageBox.Show(texto, titulo, btn, icono);
        }

        /// <summary>
        /// Si no se cobro aun, y hay un pedido
        /// y se clickea en salir, pregunta si antes no quiere cobrar
        /// Si dice que si, cobra y cierra
        /// Sino, solo cierra sin cobrar
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
