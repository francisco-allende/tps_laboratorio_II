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
using DAO_y_Archivos;

namespace TPFinal_Heladeria_Froddo
{
    public partial class Form_MenuPrincipal : Form//, IBaseDeDatos
    {
        //Al ser atributos de este form principal, puedo compartirlo con otros forms
        //Los valores siempre se guardaran ya que actua por referencia
        private Heladera<Postre> heladeraStock;
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
                this.heladeraStock = new Heladera<Postre>();
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
            try
            {
                switch (tipoForm)
                {
                    case "TomarPedido":
                        TomarPedido formVender = new TomarPedido(this, this.ventas);
                        this.Hide();
                        formVender.Show();
                        break;

                    case "Stock":
                        Stock formStock = new Stock(this, this.heladeraStock);
                        this.Hide();
                        formStock.Show();
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo abrir el formulario");
            }
   
        }

        /// <summary>
        /// Si el archivo existe, los desearilza y carga a su respectiva lista desde un xml
        /// Mesas y cafe no usan herencia, por ende, van con json
        /// Sino, lo hardcodea y lo carga hardcodeado
        /// </summary>
        private void FillList()
        {
            try
            {
                this.heladeraStock.ListaGenerica = PostreDAO.Leer();
                this.ventas.ListaVentas = VentasDAO.Leer();
            }
            catch (Exception ex)
            {
                DialogResult ok = MessageBox.Show("Error al conectarse con la base de datos. Se cerrara el programa " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }


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
