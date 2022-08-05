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
using System.IO;
using Biblio_Interfaces;
using DAO_y_Archivos;

namespace TPFinal_Heladeria_Froddo
{
    public partial class Stock : Form, ITabla, IBaseDeDatos
    {
        private Heladera<Postre> heladera;
        private Heladera<Postre> removidos;
        private Form_MenuPrincipal formPrincipal;

        public Stock(Form_MenuPrincipal formPrincipal, Heladera<Postre> heladera, Heladera<Postre> removidos)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
            this.heladera = heladera;
            this.removidos = removidos;
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.PrintTabla();
        }

        #region eventos

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                this.AddToTabla();
                this.RefreshTabla();
            }
            catch(SinEspacioEnLaHeladeraExcepcion ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ItemNoEncontradoException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("\nNo se pudo agregar el elemento\n");
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
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ItemNoEncontradoException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message + "\nNo se pudo remover el elemento\n");
            }
            catch (Exception)
            {
                MessageBox.Show("\nNo se pudo remover el elemento");
            }
        }

        private void btn_EditCantidad_Click(object sender, EventArgs e)
        {
            try
            {
                this.EditCantidad();
                this.RefreshTabla();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("\nNo se pudo editar el elemento\n");
            }
            catch (ItemNoEncontradoException ex)
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

        private void btn_SortId_Click(object sender, EventArgs e)
        {
            try
            {
                this.heladera.ListaGenerica.Sort(Postre.SortById);
                this.RefreshTabla();
            }
            catch (Exception)
            {
                MessageBox.Show("\nNo se pudo ordenar la tabla\n");
            }

        }

        private void btn_SortCantidad_Click(object sender, EventArgs e)
        {
            try
            {
                this.heladera.ListaGenerica.Sort(Postre.SortByCantidad);
                this.RefreshTabla();
            }
            catch (Exception)
            {
                MessageBox.Show("\nNo se pudo ordenar la tabla\n");
            }

        }

        private void btn_Guardar_Click(object sender, EventArgs e)
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
        /// Printea la tabla con los valores correspondientes
        /// </summary>
        public void PrintTabla()
        {
            int index = 0;
            heladera.CapacidadOcupada = 0;

            foreach (Postre item in heladera.ListaGenerica)
            {
                datagrid_Stock.Rows.Add();
                datagrid_Stock.Rows[index].Cells["Id"].Value = item.Id;
                datagrid_Stock.Rows[index].Cells["Tipo"].Value = item.Tipo;
                datagrid_Stock.Rows[index].Cells["Sabor"].Value = item.Sabor;
                datagrid_Stock.Rows[index].Cells["Cantidad"].Value = item.CantidadStock;
                heladera.CapacidadOcupada += item.CantidadStock;

                index++;
            }

            labelCapacidadMaxima.Text = heladera.CapacidadMaxima.ToString();
            labelCapacidadOcupada.Text = heladera.CapacidadOcupada.ToString();
            labelCapacidadDisponible.Text = (heladera.CapacidadMaxima - heladera.CapacidadOcupada).ToString();
        }

        private int GetId()
        {
            if (datagrid_Stock.SelectedRows.Count > 0)
            {
                int index = datagrid_Stock.CurrentCell.RowIndex;
                int id = (int)datagrid_Stock.Rows[index].Cells["Id"].Value;
                return id;
            }
            return -1;
        }

        /// <summary>
        /// Añade a la tabla un elemento previamente removido, no la cantidad.
        /// </summary>
        public void AddToTabla()
        {
            try
            {
                FormAuxStock form = new FormAuxStock(this.heladera.ListaGenerica);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    double espacioDisponible = heladera.CapacidadMaxima - heladera.CapacidadOcupada;
                    if (espacioDisponible >= form.Postre.CantidadStock)
                    {
                        heladera.Agregar(form.Postre);
                        this.RefreshTabla();
                    }
                    else
                    {
                        throw new SinEspacioEnLaHeladeraExcepcion("Sin espacio en la heladera!");
                    }
                }
            }
            catch(SinEspacioEnLaHeladeraExcepcion ex)
            {
                throw ex;
            }
            catch (NullReferenceException ex)
            {
                throw ex;
            }
            catch (ItemNoEncontradoException ex)
            {
                throw ex;
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
                int id = this.GetId();
                if (id != -1)
                {
                    Postre postreARemover = Postre.findPostre(id, this.heladera);
                    heladera.Remover(postreARemover);
                    removidos.ListaGenerica.Add(postreARemover);
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
            this.ClearTabla();
            this.PrintTabla();
        }

        /// <summary>
        /// Limpia la tabla 
        /// </summary>
        public void ClearTabla()
        {
            datagrid_Stock.Rows.Clear();
        }

        #endregion

        #region IBaseDeDatos

        /// <summary>
        /// Serialzia las listas usadas a XML, Json y Txt
        /// </summary>
        public void SaveAndExport()
        {
            if (heladera.ListaGenerica != null)
            {
                Serializador.SerializarXML("Lista_Stock_Heladera.xml", this.heladera.ListaGenerica);
            }

            if (removidos.ListaGenerica != null)
            {
                Serializador.SerializarXML("Lista_Removidos_Heladera.xml", this.removidos.ListaGenerica);
            }
        }

        #endregion

        #region Metodos
        /// <summary>
        /// Permite editar la cantidad de stock
        /// </summary>
        public void EditCantidad()
        {
            try
            {
                double espacioDisponible = heladera.CapacidadMaxima - heladera.CapacidadOcupada;
                int id = this.GetId();
                if (id != -1)
                {
                    Postre postreEditar = Postre.findPostre(id, this.heladera);

                    if (postreEditar != null)
                    {
                        string input = this.GenerateMessageBox("Editar producto", $"{postreEditar.ToString()}\nIngrese la nueva cantidad de Stock (en kilos): ");
                        bool parseable = double.TryParse(input, out double cantidad);
                        if (parseable)
                        {
                            if (espacioDisponible >= cantidad)
                            {
                                postreEditar.CantidadStock = cantidad;
                            }
                            else
                            {
                                throw new SinEspacioEnLaHeladeraExcepcion("Sin espacio en la heladera!");
                            }
                        }
                        else
                        {
                            throw new FormatException("Cantidad no valida");
                        }
                    }
                }
            }
            catch(SinEspacioEnLaHeladeraExcepcion ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ItemNoEncontradoException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                throw ex;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        /// <summary>
        /// Sobrecargo dos modelos distintos de message box
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
        /// Alerta al usuario de si esta seguro de cerrar o no la aplicacion. 
        /// "Si" cierra la aplicacion, "No" cierra el recuadro y sigue la ejecucion de la aplicacion con normalidad
        /// </summary>
        private void PreguntarAntesDeCerrar()
        {
            DialogResult respuesta = this.GenerateMessageBox("¿Seguro de querer salir?", "Salir",
                                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                this.PreguntarGuardarCambios();
                Application.Exit();
            }
        }

        /// <summary>
        /// Pregunta con message box si antes se desean guardar los cambios
        /// </summary>
        private void PreguntarGuardarCambios()
        {
            DialogResult respuesta = this.GenerateMessageBox("¿Desea Guardar los Cambios antes de Salir?", "Guardar Cambios",
                                                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                this.SaveAndExport();
            }
        }

 
        #endregion
    }
}
