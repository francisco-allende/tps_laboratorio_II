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
using System.IO;
using Biblio_Interfaces;
using DAO_y_Archivos;

namespace TPFinal_Heladeria_Froddo
{
    public partial class Stock : Form, ITabla, IExport
    {
        private Heladera<Postre> heladera;
        private Form_MenuPrincipal formPrincipal;

        public Stock(Form_MenuPrincipal formPrincipal, Heladera<Postre> heladera)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
            this.heladera = heladera;
            try
            {
                this.RefreshTabla();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo mostrar la tabla");
            }
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            try
            {
                datagrid_Stock.Columns[1].Width = 150;
                datagrid_Stock.Columns[3].Width = 180;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region eventos

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                this.AddToTabla();
                this.RefreshTabla();
            }
            catch (Exception)
            {
                MessageBox.Show("\nNo se pudo agregar el elemento");
            }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                this.RemoveFromTabla();
                this.RefreshTabla();
            }
            catch (Exception)
            {
                MessageBox.Show("\nNo se pudo remover el elemento");
            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Modificar();
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
            catch (SinEspacioEnLaHeladeraExcepcion ex)
            {
                MessageBox.Show(ex.Message + "\nIntente de nuevo con un valor mas bajo\n");
            }
            catch (Exception)
            {
                MessageBox.Show("\nNo se pudo editar el elemento");
            }
        }

        private void btn_Exportar_Click(object sender, EventArgs e)
        {
            try
            {
                this.SaveAndExport();
                this.GenerateMessageBox("Se guardaron los cambios y se creo una carpeta en el escritorio", "Guardado con éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Error inesperado");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.PreguntarAntesDeCerrar();
            }
            catch (Exception)
            {
                MessageBox.Show("Error inesperado");
            }
        }

        #endregion

        #region ITabla
        /// <summary>
        /// Añade a la tabla un elemento nuevo ingresado por el usuario en un formulario auxiliar
        /// </summary>
        public void AddToTabla()
        {
            try
            {
                AuxiliarFormStock aux = new AuxiliarFormStock("Agregar", new Postre());

                if(aux.ShowDialog() == DialogResult.OK)
                {
                    this.RefreshTabla();
                }
            }
            catch (Exception)
            {
                throw new Exception("No se encontró el postre");
            }
        }
        
        /// <summary>
        /// Remueve de la tabla un elemento. Luego se puede volver a traer con el Add
        /// al guardarlo en una lsita de removidos, nunca pierdo la informacion
        /// </summary>
        public void RemoveFromTabla()
        {
            try
            {
                if (datagrid_Stock.SelectedRows.Count > 0)
                {
                    //me traigo ese objeto y lo casteo a postre
                    Postre postre = (Postre)datagrid_Stock.CurrentRow.DataBoundItem;
                    PostreDAO.Eliminar(postre.Id); //accedo a su id y lo envio para eliminarlo
                }
            }
            catch (ItemNoEncontradoException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new Exception("No se encontró el postre.\n" + ex.Message);
            }
        }

        /// <summary>
        /// Refresca la tabla al limpiarla y cargarla de nuevo con los valores actualziados
        /// </summary>
        public void RefreshTabla()
        {
            try
            {
                datagrid_Stock.DataSource = PostreDAO.Leer();
                datagrid_Stock.Refresh();
                datagrid_Stock.Update();
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region IExport

        /// <summary>
        /// Serialzia las listas usadas a XML, Json y Txt
        /// </summary>
        public void SaveAndExport()
        {
            if (heladera.ListaGenerica != null)
            {
                this.heladera.ListaGenerica = PostreDAO.Leer();
                Serializador.SerializarXML("Lista_Stock_Heladera.xml", this.heladera.ListaGenerica);
            }
        }

        #endregion

        #region Metodos
        /// <summary>
        /// Permite editar la cantidad de stock
        /// </summary>
        public void Modificar()
        {
            try
            {
                if (datagrid_Stock.SelectedRows.Count > 0)
                {
                    Postre postre = (Postre)datagrid_Stock.CurrentRow.DataBoundItem;

                    AuxiliarFormStock aux = new AuxiliarFormStock("Modificar", postre);

                    if (aux.ShowDialog() == DialogResult.OK)
                    {
                        this.RefreshTabla();
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        /// <summary>
        /// Modelo de message box
        /// </summary>
        private DialogResult GenerateMessageBox(string texto, string titulo, MessageBoxButtons btn, MessageBoxIcon icono)
        {
            return MessageBox.Show(texto, titulo, btn, icono);
        }

        /// <summary>
        /// Alerta al usuario de si esta seguro de cerrar o no la aplicacion. 
        /// "Si" cierra la aplicacion, "No" cierra el recuadro y sigue la ejecucion de la aplicacion con normalidad
        /// </summary>
        private void PreguntarAntesDeCerrar()
        {
            DialogResult respuesta = this.GenerateMessageBox("¿Seguro de querer salir?", "Salir",
                                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        #endregion
    }
}
