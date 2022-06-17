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
    public partial class TomarPedido : Form, ITabla, IBaseDeDatos
    {
        private Form_MenuPrincipal formPrincipal;
        private Heladera<Postre> heladeraStock;
        private List<Mesa> listaMesas;
        private Ventas ventas;
        private Pedido pedido;
        private Cafeteria cafeteria;
        private bool esPrimerPedido;
        private int constanteIdCliente;

        /// <summary>
        /// Recibe atributos del form padre, guardando asi todos los cambios aun sin serializar
        /// </summary>
        public TomarPedido(Form_MenuPrincipal formPrincipal, Heladera<Postre> heladeraStock, Ventas ventas, List<Mesa> listaMesas, Cafeteria cafeteria)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
            this.heladeraStock = heladeraStock;
            this.cafeteria = cafeteria;
            this.ventas = ventas;
            this.listaMesas = listaMesas;
        }

        /// <summary>
        /// Carga o instancia todos sus atirbutos 
        /// </summary>
        private void Vender_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.pedido = new Pedido(); //instancio primero el pedido, sino su cliente es null
            this.pedido.ClienteQuePide = new Cliente();
            this.pedido.ClienteQuePide.IdPedido = new List<int>();
            this.esPrimerPedido = true;
            this.constanteIdCliente = 0;
        }

        #region Eventos

        private void btn_NombreCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.pedido.ClienteQuePide.Nombre != null)
                {
                    throw new NoEditarElPedidoException("No se puede editar el pedido una vez comenzado. Cancele y vuelva a empezar o siga como está ahora");
                }
                if(this.esPrimerPedido) //Solo accedo una vez. Ya que los pedidos son un pedido a la vez para un solo cliente
                {
                    this.SaveClientName();
                }
                else
                {
                    throw new NoEsPrimerPedidoException("Un pedido a la vez para un mismo cliente.\nMismo cliente, no se modifica el nombre");
                }
            }
            catch(NoEditarElPedidoException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(NoEsPrimerPedidoException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(ItemNoSeleccionadoException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sucedio un error inesperado ", ex.Message);
            }
          
        }

        private void btn_ChooseType_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.esPrimerPedido) //Si no es el primer pedido, no le pido el nombre, no quiero que se modifique
                {
                    if (this.pedido.ClienteQuePide.Nombre == null || this.pedido.ClienteQuePide.Nombre == String.Empty)
                    {
                        throw new ItemNoSeleccionadoException("Para comenzar a tomar el pedido debe ingresar el nombre del cliente");
                    }
                }
            
                if (this.pedido.Tipo != null)
                {
                    throw new NoEditarElPedidoException("No se puede editar el pedido una vez comenzado. Cancele y vuelva a empezar o siga como está ahora");
                }
                this.ChooseType();
            }
            catch(NoEditarElPedidoException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(ItemNoSeleccionadoException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error mientras se elegia el producto a vender");
            }
        }

        private void btn_ChooseSabor_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.pedido.Sabor != null)
                {
                    throw new NoEditarElPedidoException("No se puede editar el pedido una vez comenzado. Cancele y vuelva a empezar o siga como está ahora");
                }
                this.ChooseSabor();
            }
            catch (NoEditarElPedidoException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ItemNoSeleccionadoException ex)
            {
                MessageBox.Show(ex.Message);
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
                MessageBox.Show("Sucedio un error al querer seleccionar el sabor");
            }
        }

        private void btn_ChooseCantidad_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.pedido.Sabor == null || this.pedido.Sabor == String.Empty)
                {
                    throw new ItemNoSeleccionadoException("Antes debe elegir un tipo y sabor");
                }
                if (this.pedido.Cantidad != 0)
                {
                    throw new NoEditarElPedidoException("No se puede editar el pedido una vez comenzado. Cancele y vuelva a empezar o siga como está ahora");
                }
                this.ChooseCantidad();
            }
            catch(NoEditarElPedidoException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(ItemNoSeleccionadoException ex)
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
            catch (ItemNoEncontradoException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(SinEspacioEnLaHeladeraExcepcion ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Sucedio un error inesperado");
            }
        }

        private void btn_PlaceToConsume_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.esPrimerPedido)
                {
                    throw new NoEsPrimerPedidoException("Mesa ya elegida\nUn mismo cliente no puede tener dos mesas distintas");
                }
                if (this.pedido.Cantidad == 0)
                {
                    throw new ItemNoSeleccionadoException("Antes debe elegir un tipo, sabor y cantidad");
                }
                if(this.pedido.ClienteQuePide.DondeConsume != null)
                {
                    throw new NoEditarElPedidoException("No se puede editar el pedido una vez comenzado. Cancele y vuelva a empezar o siga como está ahora");
                }
                this.PlaceToConsume();
            }
            catch(NoEditarElPedidoException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (NoEsPrimerPedidoException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ItemNoSeleccionadoException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception)
            {
                MessageBox.Show("Sucedio un error inesperado");
            }
        }

        private void btn_ChooseTable_Click(object sender, EventArgs e)
        {
            try
            {
                if(!this.esPrimerPedido)
                {
                    throw new NoEsPrimerPedidoException("Mesa ya elegida\nUn mismo cliente no puede tener dos mesas distintas");
                }
                if (this.pedido.ClienteQuePide.DondeConsume == null || this.pedido.ClienteQuePide.DondeConsume == String.Empty)
                {
                    throw new ItemNoSeleccionadoException("Antes debe elegir un tipo, sabor, cantidad y donde consume");
                }
                if (this.pedido.ClienteQuePide.NroMesa != 0)
                {
                    throw new NoEditarElPedidoException("No se puede editar el pedido una vez comenzado. Cancele y vuelva a empezar o siga como está ahora");
                }
                this.ChooseTable();
            }
            catch(ItemNoSeleccionadoException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(NoEditarElPedidoException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (NoEsPrimerPedidoException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (MesaOcupadaException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(ItemNoEncontradoException ex)
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
            catch (Exception)
            {
                MessageBox.Show("Sucedió un error inesperado");
            }
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.esPrimerPedido && this.pedido.ClienteQuePide.DondeConsume == null)
                {
                    throw new ItemNoSeleccionadoException("Antes debe elegir el tipo, sabor, cantidad y lugar a consumir");
                }
                if(!this.esPrimerPedido && this.pedido.Cantidad == 0)
                {
                    throw new ItemNoSeleccionadoException("Antes debe elegir el tipo, sabor, cantidad");
                }
                this.AddToTabla();

                //instancio de nuevo si es el segundo pedido o mas
                if (!this.esPrimerPedido)
                {
                    this.pedido = new Pedido();
                    this.pedido.ClienteQuePide = new Cliente();
                }
            }
            catch(ItemNoSeleccionadoException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Sucedio un error al querer confirmar el pedido");
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

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = this.GenerateMessageBox("¿Seguro de querer Cancelar el pedido?\nEl proceso de venta de este pedido volvera a comnezar",
                "Cancelar Pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            try
            {
                if (respuesta == DialogResult.Yes)
                {
                    this.BorrarDatos(false);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sucedio un error inesperado al intentar cancelar el pedido");
            }
        }

        private void btn_Cobrar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cobrar();
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
        /// Serializa las ventas a un xml, json y txt
        /// </summary>
        public void SaveAndExport()
        {
            if (this.ventas.ListaVentas != null)
            {
                Serializador.SerializarXML("Lista_Ventas.xml", this.ventas.ListaVentas);
                Serializador.SerializadorJson("Lista_Ventas.json", this.ventas.ListaVentas);
                GestionarArchivos.Escribir("Lista_Ventas.txt", this.ventas.ListaVentas);
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
                //Valido Id o muestra todos los pedidos y no solo los de este cliente
                if (item.ClienteQuePide.Id == this.constanteIdCliente)
                {
                    dataGrid_Pedidos.Rows.Add();
                    dataGrid_Pedidos.Rows[index].Cells["IdCliente"].Value = item.ClienteQuePide.Id;
                    dataGrid_Pedidos.Rows[index].Cells["IdPedido"].Value = item.Id;
                    dataGrid_Pedidos.Rows[index].Cells["NombreCliente"].Value = item.ClienteQuePide.Nombre;
                    dataGrid_Pedidos.Rows[index].Cells["Tipo"].Value = item.Tipo;
                    dataGrid_Pedidos.Rows[index].Cells["Sabor"].Value = item.Sabor;
                    dataGrid_Pedidos.Rows[index].Cells["Cantidad"].Value = item.RetornarCantidadEscrito(item.Tipo, item.Cantidad);
                    dataGrid_Pedidos.Rows[index].Cells["Donde_Consume"].Value = item.ClienteQuePide.DondeConsume;
                    dataGrid_Pedidos.Rows[index].Cells["Nro_Mesa"].Value = item.RetornarNroMesa(item.ClienteQuePide.NroMesa);
                    dataGrid_Pedidos.Rows[index].Cells["Precio"].Value = item.Precio;
                    dataGrid_Pedidos.Rows[index].Cells["Total"].Value = item.ClienteQuePide.TotalAPagar; //falta calcularlo aun

                    index++;
                }
            }

            this.esPrimerPedido = false;
        }

        /// <summary>
        /// Ya confirmada la compra, se añade a la tabla el cliente con su pedido
        /// </summary>
        public void AddToTabla()
        {
            //Restar stock
            if (this.pedido.Tipo == "Helado" || this.pedido.Tipo == "Yogur")
            {
                foreach (Postre item in this.heladeraStock.ListaGenerica)
                {
                    if (item.Sabor == this.pedido.Sabor) //previamente asignado con cantidad o sabor
                    {
                        item.CantidadStock = item.CantidadStock - this.pedido.Cantidad;
                        break;
                    }
                }
            }
            else if (this.pedido.Tipo == "Cafe")
            {
                foreach (Cafe item in this.cafeteria.ListaCafes)
                {
                    if (item.Sabor.ToString() == this.pedido.Sabor)
                    {
                        item.CantidadStock = item.CantidadStock - this.pedido.Cantidad;
                        break;
                    }
                }
            }
            else
            {
                throw new ItemNoEncontradoException("No se pudo encontrar el tipo del producto");
            }

            //Asigno Id real del pedido
            this.pedido.Id = Pedido.AsignarId();
            this.pedido.ClienteQuePide.IdPedido = new List<int>();
            this.pedido.ClienteQuePide.IdPedido.Add(this.pedido.Id);

            //Solo le asigno el id si es su primer pedido. Guardo estos datos para asignarselo al proximo pedido
            if (this.esPrimerPedido)
            {
                this.pedido.ClienteQuePide.Id = Cliente.AsignarId();
                this.pedido.ClienteQuePide.TotalAPagar = this.pedido.Precio;
                this.constanteIdCliente = this.pedido.ClienteQuePide.Id;

                //Ocupo la mesa si come aca
                if (this.pedido.ClienteQuePide.DondeConsume == "Consume aca")
                {
                    foreach (Mesa item in this.listaMesas)
                    {
                        if (this.pedido.ClienteQuePide.NroMesa == item.Id)
                        {
                            item.EstaLibre = false;
                        }
                    }
                }
            }
            else
            {
                this.pedido.ClienteQuePide.Id = this.constanteIdCliente;

                foreach (Pedido item in ventas.ListaVentas)
                {
                    if (item.ClienteQuePide.Id == this.constanteIdCliente)
                    {
                        this.pedido.ClienteQuePide.Nombre = item.ClienteQuePide.Nombre;
                        this.pedido.ClienteQuePide.NroMesa = item.ClienteQuePide.NroMesa;
                        this.pedido.ClienteQuePide.DondeConsume = item.ClienteQuePide.DondeConsume;
                        this.pedido.ClienteQuePide.TotalAPagar = item.ClienteQuePide.TotalAPagar + this.pedido.Precio;
                    }
                }
            }

        
            //Sumo a la lista de ventas
            this.ventas.ListaVentas.Add(this.pedido);

            //sumar total. Sera un atributo de ventas que sume el precio de los pedidos si matchea con el id de cliente
            try
            {
                this.RefreshTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sucedio un error al querer cargar los datos a la tabla ", ex.Message);
            }

            this.BorrarDatos(true);
        }

        /// <summary>
        /// Se remueve un cliente de la tabla
        /// </summary>
        public void RemoveFromTabla()
        {
            string input = this.GenerateMessageBox("Remover Pedido", "Ingrese el id del pedido a remover");
            int id = 0;
            bool encontrado = false;

            id = Validator.NoEsNegativoNiCaracter(input, id);

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
                throw new ItemNoEncontradoException("No se encontro ningún Pedido con ese Id");
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
        /// Guarda el nombre del cliente. 
        /// Un cliente por vez se atiende, por lo que despuesd e la primera no se ejecuta hasta que
        /// se confirme la compra o se cierre el programa
        /// </summary>
        private void SaveClientName()
        {
            string name = textBox_NombreCliente.Text;

            if(name == String.Empty)
            {
                throw new ItemNoSeleccionadoException("No se puede dejar este campo vacio");
            }
            if(!Validator.NoContieneNumeros(name))
            {
                throw new FormatException("No se pueden ingresar numeros en este campo");
            }
            if(name.Length > 120)
            {
                throw new IndexOutOfRangeException("Nombre demasiado largo");
            }

            this.pedido.ClienteQuePide.Nombre = name;
        }

        /// <summary>
        /// Permite elegir el tipo, helado, cafe o yogur
        /// </summary>
        private void ChooseType()
        {
            string chosenType = String.Empty;

            if (radioBtn_Helado.Checked)
            {
                chosenType = "Helado";
            }
            else if (radioBtn_Yogur.Checked)
            {
                chosenType = "Yogur";
            }
            else if (radioBtn_Cafe.Checked)
            {
                chosenType = "Cafe";
            }
            else
            {
                throw new ItemNoSeleccionadoException("Error. Ningun item fue seleccionado");
            }

            //Nunca se va a cargar vacio, ya que antes romperia con la excepcion
            this.pedido.Tipo = chosenType;
            textBox_Tipo.Text = this.pedido.Tipo;
        }

        /// <summary>
        /// Permite elegir el sabor del tipo elegido
        /// </summary>
        private void ChooseSabor()
        {
            int id = -1;
            StringBuilder sb = new StringBuilder();
            
            sb.Append(this.MostrarYCargar(this.pedido.Tipo, id, "Mostrar", 0));

            string input = this.GenerateMessageBox("Ver opciones", sb.ToString());
            id = Validator.NoEsNegativoNiCaracter(input, id);
      

            //Matcheo cual es y que sea un id valido. Si lo es, cargo
            this.MostrarYCargar(this.pedido.Tipo, id, "CargarSabor", 0);

            if(this.pedido.Sabor == null || this.pedido.Sabor == String.Empty)
            {
                throw new ItemNoEncontradoException("Id invalido, no coincide con ningun caso segun tipo elegido");
            }
        }

        /// <summary>
        /// Permite elegir la cantidad del producto a consumir, cuanto se consume
        /// Segun tipo, sabor (para el cafe) y cantidad, se calcula e imprime el precio del pedido
        /// </summary>
        private void ChooseCantidad()
        {
            string input = String.Empty;
            int cantidadACargar = 0;

            
            if(this.pedido.Tipo == "Helado" || this.pedido.Tipo == "Yogur")
            {
                input = this.GenerateMessageBox("Elegir cantidad", "Elija segun Nro de opción:\n1) Un  Kilo\n2) Un Medio\n3) Un Cuarto");    
            }
            else if(this.pedido.Tipo == "Cafe")
            {
                input = this.GenerateMessageBox("Elegir cantidad", "Elija en unidades. El tamaño es unico y es mediano:");
            }
            else
            {
                throw new ItemNoSeleccionadoException("Falto elegir el tipo");
            }

            cantidadACargar = Validator.NoEsCeroNiCaracter(input, cantidadACargar);


            if(this.pedido.Tipo == "Helado" || this.pedido.Tipo == "Yogur")
            {
                if(cantidadACargar > 3 || cantidadACargar < 1)
                {
                    throw new IndexOutOfRangeException("Opcion inválida. Fuera del rango de opciones");
                }
            }

            //matchear por id y si hay stock suficiente, cargo
            this.MostrarYCargar(this.pedido.Tipo, this.pedido.Id, "CargarCantidad", cantidadACargar);

            //Ya con tipo, sabor en caso del cafe y cantidad, puedo calcular el precio
            this.pedido.Precio = Pedido.CalcularPrecio(this.pedido);
            textBox_Precio.Text = this.pedido.Precio.ToString();
        }

        /// <summary>
        /// Muestra opciones de sabor
        /// Carga el sabor
        /// Carga la cantidad, y la guarda en formato escrito
        /// </summary>
        private string MostrarYCargar(string tipo, int id, string queHacer, double cantidadACargar)
        {
            StringBuilder sb = new StringBuilder();

            if (tipo == "Helado" || tipo == "Yogur")
            {
                foreach (Postre item in heladeraStock.ListaGenerica)
                {
                    switch (queHacer)
                    {
                        case "Mostrar":
                            if (tipo == item.Tipo)
                            {
                                sb.Append($"*Id: {item.Id} Sabor: {item.Sabor}\n\n");
                            }
                            break;

                        case "CargarSabor":
                            if (tipo == this.pedido.Tipo && id == item.Id)
                            {
                                this.pedido.Id = item.Id;
                                this.pedido.Sabor = item.Sabor.ToString();

                                if (tipo == "Helado")
                                {
                                    textBox_SaborHelado.Text = item.Sabor.ToString();
                                }
                                else if(tipo == "Yogur")
                                {
                                    if(id > 14 || id < 11)
                                    {
                                        throw new IndexOutOfRangeException("Opcion inválida. Fuera del rango de opciones");
                                    }
                                    else
                                    {
                                        textBox_SaborYogur.Text = item.Sabor.ToString();
                                    }
                                }
                            }
                            break;

                        case "CargarCantidad":
                            if (tipo == this.pedido.Tipo && id == item.Id)
                            {
                                double verdaderaCantidad = 0;
                                switch(cantidadACargar)
                                {
                                    case 1: //en este caso si coincide la ocion con la cantidad
                                        if (cantidadACargar > item.CantidadStock)
                                        {
                                            throw new SinEspacioEnLaHeladeraExcepcion("No tenemos suficiente stock");
                                        }
                                        textBox_CantidadPostre.Text = "Un Kilo";
                                        this.pedido.Cantidad = cantidadACargar;
                                        break;

                                    case 2:
                                        verdaderaCantidad = 0.5f;
                                        if (verdaderaCantidad > item.CantidadStock)
                                        {
                                            throw new SinEspacioEnLaHeladeraExcepcion("No tenemos suficiente stock");
                                        }
                                        textBox_CantidadPostre.Text = "Un Medio";
                                        this.pedido.Cantidad = verdaderaCantidad;
                                        break;

                                    case 3:
                                        verdaderaCantidad = 0.25f;
                                        if (verdaderaCantidad > item.CantidadStock)
                                        {
                                            throw new SinEspacioEnLaHeladeraExcepcion("No tenemos suficiente stock");
                                        }
                                        textBox_CantidadPostre.Text = "Un Cuarto";
                                        this.pedido.Cantidad = verdaderaCantidad;
                                        break;
                                }
                            }
                            break;

                        default:
                            break;
                    }
                } 
            }
            else if (tipo == "Cafe")
            {
                foreach (Cafe item in cafeteria.ListaCafes)
                {
                    switch (queHacer)
                    {
                        case "Mostrar":          
                            sb.Append($"*Id: {item.Id} Sabor: {item.Sabor}\n\n");
                            break;

                        case "CargarSabor":
                            if (id == item.Id)
                            {
                                textBox_SaborCafe.Text = item.Sabor.ToString();
                                this.pedido.Id = item.Id;
                                this.pedido.Sabor = item.Sabor.ToString();
                            }
                            break;

                        case "CargarCantidad":
                            if (id == item.Id)
                            {
                                if (cantidadACargar > item.CantidadStock)
                                {
                                    throw new SinEspacioEnLaHeladeraExcepcion($"No tenemos suficiente stock");
                                }
                                else
                                {
                                    textBox_CantidadCafe.Text = cantidadACargar.ToString();
                                    this.pedido.Cantidad = cantidadACargar;
                                }
                            }
                            break;

                        default:
                            break;
                    }
                }
            }
            else
            {
                throw new ItemNoSeleccionadoException("Elija antes el tipo");
            }
 
            return sb.ToString();
        }

        /// <summary>
        /// Dos opciones, o se come en el local (elige mesa) 
        /// O se lo lleva a su casa (no elige mesa)
        /// </summary>
        private void PlaceToConsume()
        {
            if (radioBtn_ParaLlevar.Checked)
            {
                this.pedido.ClienteQuePide.DondeConsume = "Se lo lleva";
            }
            else if (radioBtn_ComerAca.Checked)
            {
                this.pedido.ClienteQuePide.DondeConsume = "Consume aca";
            }
            else
            {
                throw new ItemNoSeleccionadoException("Error. Item no seleccionado");
            }
        }

        /// <summary>
        /// Solo es necesario si se come en el local.
        /// Pide una mesa a ocupar
        /// Valida que la mesa este libre
        /// Si esta libre, la carga a la lista de mesas como ocupada. Sino, se vuelve a intentar
        /// </summary>
        private void ChooseTable()
        {
            if (this.pedido.ClienteQuePide.DondeConsume == "Consume aca")
                {
                    StringBuilder sb = new StringBuilder();
                    int mesaElegida = -1;
                    bool almenosUnaMesaLibre = false;
                    bool laMesaExiste = false;

                    foreach (Mesa item in this.listaMesas)
                    {
                        if (item.EstaLibre)
                        {
                            sb.Append($"Mesa nro: {item.Id} Esta Libre\n\n");
                            almenosUnaMesaLibre = true;
                        }
                    }

                    if (!almenosUnaMesaLibre)
                    {
                        throw new MesaOcupadaException("No quedaron mesas disponibles, todas se encuentran ocupadas");
                    }

                    string input = this.GenerateMessageBox("Elegir mesa", sb.ToString());
                    mesaElegida = Validator.NoEsNegativoNiCaracter(input, mesaElegida);


                    foreach (Mesa item in this.listaMesas)
                    {
                        if (item.Id == mesaElegida && item.EstaLibre)
                        {
                            laMesaExiste = true;
                            this.pedido.ClienteQuePide.NroMesa = item.Id;
                            textBox_Mesa.Text = item.Id.ToString();
                            break;
                        }
                        else if (item.Id == mesaElegida && !item.EstaLibre)
                        {
                            throw new MesaOcupadaException($"La mesa nro {mesaElegida} ya se encuentra ocupada, intenete con una libre");
                        }
                    }

                    if (!laMesaExiste)
                    {
                        throw new ItemNoEncontradoException($"La mesa nro {mesaElegida} no existe");
                    }
                }
            else
            {
                throw new ItemNoSeleccionadoException("No se puede elegir una mesa si el cliente se lleva el pedido");
            }
        }

        /// <summary>
        /// Cobra el total al imrpimr una factura, 
        /// agregar a la lista de ventas confirmadas al pedido
        /// Y resetea todo para un nuevo cliente
        /// </summary>
        private void Cobrar()
        {
            this.SaveAndExport();
            this.PrintFactura();
            MessageBox.Show("Venta realizada con exito!\nFactura imprimiendose\nPresione Aceptar para comenzar de nuevo y tomar un nuevo pedido");

            //Vacio todo y vuelvo a comenzar
            this.constanteIdCliente = 0;
            this.esPrimerPedido = true;
            listBox_Factura.Items.Clear();
            this.BorrarDatos(false);
            this.ClearTabla();
        }

        /// <summary>
        /// Borra los datos del form 
        /// y opcionalmente, instancia un cliente y pedido nuevo 
        /// </summary>
        private void BorrarDatos(bool soloBorrarCamposForm)
        {
            //Vacio todos los campos 
            textBox_NombreCliente.Text = String.Empty;
            textBox_Tipo.Text = String.Empty;
            textBox_SaborHelado.Text = String.Empty;
            textBox_SaborYogur.Text = String.Empty;
            textBox_SaborCafe.Text = String.Empty;
            textBox_CantidadCafe.Text = String.Empty;
            textBox_CantidadPostre.Text = String.Empty;
            textBox_Mesa.Text = String.Empty;
            textBox_Precio.Text = String.Empty;

            //Vacio los valores cargados del objeto y lo re-instancio
            if(!soloBorrarCamposForm)
            {
                this.pedido = new Pedido();
                this.pedido.ClienteQuePide = new Cliente();
            }
        }

        /// <summary>
        /// Imprime en el lsit box los datos de la facturacion ya cobrado el/los pedido/s
        /// </summary>
        private void PrintFactura()
        {
            foreach (Pedido item in ventas.ListaVentas)
            {
                if(item.ClienteQuePide.Id == this.constanteIdCliente)
                {
                    listBox_Factura.Items.Add(item.ToString());
                    listBox_Factura.Items.Add(item.ClienteQuePide.ToString());
                }
            }
        }

        /// <summary>
        /// Sobrecargo dos messagebox con formato distinto
        /// </summary>
        private DialogResult GenerateMessageBox(string texto, string titulo, MessageBoxButtons btn, MessageBoxIcon icono)
        {
            return MessageBox.Show(texto, titulo, btn, icono);
        }

        private string GenerateMessageBox(string titulo, string texto)
        {
            return Microsoft.VisualBasic.Interaction.InputBox(texto, titulo);
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
                if(!this.esPrimerPedido)
                {
                    DialogResult respuesta2 = this.GenerateMessageBox("¿Desea Cobrar el Pedido?", "Cobrar antes de Salir",
                                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuesta2 == DialogResult.Yes)
                    {
                        this.Cobrar();
                    }
                }
                Application.Exit();
            }
        }

        #endregion
    }
}
