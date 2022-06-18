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
using System.IO;
using Biblio_Interfaces;

namespace TPFinal_Heladeria_Froddo
{
    public partial class Form_MenuPrincipal : Form, IBaseDeDatos
    {
        //Al ser atributos de este form principal, puedo compartirlo con otros forms
        //Los valores siempre se guardaran ya que actua por referencia
        private Heladera<Postre> heladeraStock;
        private Heladera<Postre> removidosStock;
        private Ventas ventas;

        public Form_MenuPrincipal()
        {
            InitializeComponent();
        }

        private void Form_MenuPrincipal_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
            try
            {
                this.heladeraStock = new Heladera<Postre>(500);
                this.removidosStock = new Heladera<Postre>(15);
                this.ventas = new Ventas();
                this.ventas.ListaVentas =  new List<Pedido>();
                this.FillList();
            }
            catch (Exception)
            {
                DialogResult ok =  MessageBox.Show("Error al conectarse con la base de datos. Se cerrara el programa", "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        #region eventos

        private void btn_TomarPedido_Click(object sender, EventArgs e)
        {
            this.GenerateSecondaryForm("TomarPedido");
        }

        private void btn_AdminStock_Click(object sender, EventArgs e)
        {
            this.GenerateSecondaryForm("Stock");
        }

        private void button_Salir_Click(object sender, EventArgs e)
        {
            this.PreguntarAntesDeCerrar();
        }

        #endregion

        #region metodos
        /// <summary>
        /// Genera un nuevo form segun el parametro
        /// </summary>
        private void GenerateSecondaryForm(string tipoForm)
        {
            //meter try catch
            switch (tipoForm)
            {
                case "TomarPedido":
                    TomarPedido formVender = new TomarPedido(this, this.heladeraStock, this.ventas);
                    this.Hide();
                    formVender.Show();
                    break;

                case "Stock":
                    Stock formStock = new Stock(this, this.heladeraStock, this.removidosStock);
                    this.Hide();
                    formStock.Show();
                    break;
            }
        }

        /// <summary>
        /// Si el archivo existe, los desearilza y carga a su respectiva lista desde un xml
        /// Mesas y cafe no usan herencia, por ende, van con json
        /// Sino, lo hardcodea y lo carga hardcodeado
        /// </summary>
        private void FillList()
        {
            string directoryPath = Serializador.RutaBase;
            string nameFileStock = "Lista_Stock_Heladera.xml";
            string nameFileRemovidos = "Lista_Removidos_Heladera.xml";
            string nameFileVentas = "Lista_Ventas.xml";

            try
            {
                if (File.Exists(directoryPath + nameFileStock) 
                    && File.Exists(directoryPath + nameFileRemovidos)
                    && File.Exists(directoryPath + nameFileVentas))
                {
                    this.heladeraStock.ListaGenerica = Serializador.DeserializarXML(nameFileStock, this.heladeraStock.ListaGenerica);
                    this.removidosStock.ListaGenerica = Serializador.DeserializarXML(nameFileRemovidos, this.removidosStock.ListaGenerica);
                    this.ventas.ListaVentas = Serializador.DeserializarXML(nameFileVentas, this.ventas.ListaVentas);
                }
                else
                {
                    //No existe la ruta al directorio, por ende, hardcodeo la lista y creo el directorio
                    this.HardcodearListaPostres();
                    this.HardcodearListaVentas();
                    this.SaveAndExport();
                }
            }
            catch (Exception ex)
            {
                DialogResult ok = MessageBox.Show("Error al conectarse con la base de datos. Se cerrara el programa " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        #region Hardcodeo listas si no existen
        /// <summary>
        /// Hardcodea una lista caso de que no se haye el archivo en el escritorio
        /// </summary>
        private void HardcodearListaPostres()
        {
            Helado helado0 = new(0, 25, ETipoPostre.Helado, ESaboresHelado.Chocolate);
            Helado helado1 = new(1, 10, ETipoPostre.Helado, ESaboresHelado.Chocolate_Amargo);
            Helado helado2 = new(2, 25, ETipoPostre.Helado, ESaboresHelado.Crema_Americana);
            Helado helado3 = new(3, 30, ETipoPostre.Helado, ESaboresHelado.DulceDeLeche);
            Helado helado4 = new(4, 28, ETipoPostre.Helado, ESaboresHelado.DulceDeLeche_Granizado);
            Helado helado5 = new(5, 30, ETipoPostre.Helado, ESaboresHelado.Frutilla_Agua);
            Helado helado6 = new(6, 15, ETipoPostre.Helado, ESaboresHelado.Frutilla_Crema);
            Helado helado7 = new(7, 10, ETipoPostre.Helado, ESaboresHelado.Maracuya);
            Helado helado8 = new(8, 10, ETipoPostre.Helado, ESaboresHelado.Sambayon);
            Helado helado9 = new(9, 12, ETipoPostre.Helado, ESaboresHelado.Tiramisu);
            Helado helado10 = new(10, 30, ETipoPostre.Helado, ESaboresHelado.Vainilla);
            Yogur yogur1 = new(11, 52, ETipoPostre.Yogur, ESaboresYogur.Natural);
            Yogur yogur2 = new(12, 1, ETipoPostre.Yogur, ESaboresYogur.Frutilla);
            Yogur yogur3 = new(13, 8, ETipoPostre.Yogur, ESaboresYogur.Vainilla);
            Yogur yogur4 = new(14, 5, ETipoPostre.Yogur, ESaboresYogur.Durazno);

            heladeraStock.ListaGenerica.Add(helado0);
            heladeraStock.ListaGenerica.Add(helado1);
            heladeraStock.ListaGenerica.Add(helado2);
            heladeraStock.ListaGenerica.Add(helado3);
            heladeraStock.ListaGenerica.Add(helado4);
            heladeraStock.ListaGenerica.Add(helado5);
            heladeraStock.ListaGenerica.Add(helado6);
            heladeraStock.ListaGenerica.Add(helado7);
            heladeraStock.ListaGenerica.Add(helado8);
            heladeraStock.ListaGenerica.Add(helado9);
            heladeraStock.ListaGenerica.Add(helado10);
            heladeraStock.ListaGenerica.Add(yogur1);
            heladeraStock.ListaGenerica.Add(yogur2);
            heladeraStock.ListaGenerica.Add(yogur3);
            heladeraStock.ListaGenerica.Add(yogur4);
        }

        /// <summary>
        /// Hardcodea una lista caso de que no se haye el archivo en el escritorio
        /// </summary>
        private void HardcodearListaVentas()
        {
            Cliente cliente1 = new Cliente(1234567880, "Gerado", "Av. Crisologo Larralde 1200");
            Cliente cliente2 = new Cliente(0987654321, "Mariana", "Boyaca 4321");

            Pedido pedido1 = new Pedido(1234, cliente1, "Helado", "Vainilla", 1, 800);
            Pedido pedido2 = new Pedido(5678, cliente2, "Yogur", "Natural", 1, 200);

            this.ventas.ListaVentas.Add(pedido1);
            this.ventas.ListaVentas.Add(pedido2);
        }

        #endregion

        #region IBaseDeDatos
        /// <summary>
        /// Exporta las listas segun formato indicado
        /// </summary>
        public void SaveAndExport()
        {
            if (heladeraStock.ListaGenerica != null)
            {
                Serializador.SerializarXML("Lista_Stock_Heladera.xml", this.heladeraStock.ListaGenerica);
            }

            if (heladeraStock.ListaGenerica != null)
            {
                Serializador.SerializarXML("Lista_Removidos_Heladera.xml", this.removidosStock.ListaGenerica);
            }

            if(this.ventas.ListaVentas != null)
            {
                Serializador.SerializarXML("Lista_Ventas.xml", this.ventas.ListaVentas);
            }
        }

        #endregion



        /// <summary>
        /// Alerta al usuario de si esta seguro de cerrar o no la aplicacion. 
        /// "Si" cierra la aplicacion, "No" cierra el recuadro y sigue la ejecucion de la aplicacion con normalidad
        /// </summary>
        public void PreguntarAntesDeCerrar()
        {
            string pregunta = "¿Seguro de querer salir?";
            string titulo = "Salir";
            MessageBoxButtons opciones = MessageBoxButtons.YesNo;
            MessageBoxIcon icono = MessageBoxIcon.Question;

            DialogResult respuesta = MessageBox.Show(pregunta, titulo, opciones, icono);

            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }
        #endregion
    }
}
