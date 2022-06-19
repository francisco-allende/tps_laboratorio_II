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
using DAO_y_Archivos;
using Biblio_Excepciones;

namespace TPFinal_Heladeria_Froddo
{
    public partial class AuxiliarFormStock : Form
    {
        private string keyword;
        private Postre postreModify;

        public AuxiliarFormStock(string keyword, Postre postre)
        {
            InitializeComponent();
            this.keyword = keyword;
            this.postreModify = postre;
        }

        private void AuxiliarForm_Load(object sender, EventArgs e)
        {
            cmb_CantidadStock.Items.AddRange(Enumerable.Range(1, 500).Select(i => (object)i).ToArray());
            this.SetTipos();
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCamposLlenos())
                {
                    if(this.keyword == "Agregar")
                    {
                        PostreDAO.Guardar(new Postre(
                            Convert.ToInt32(cmb_CantidadStock.Text),
                            cmb_Tipo.Text,
                            textBox_Sabor.Text
                            ));

                        DialogResult = DialogResult.OK;
                    }
                    else if(this.keyword == "Modificar")
                    {
                        this.postreModify.CantidadStock = Convert.ToInt32(cmb_CantidadStock.Text);
                        this.postreModify.Tipo = cmb_Tipo.Text;
                        this.postreModify.Sabor = textBox_Sabor.Text;

                        PostreDAO.Modificar(this.postreModify);

                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
            }
            catch(CamposVaciosException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void SetTipos()
        {
            this.cmb_Tipo.Items.Add("Helado");
            this.cmb_Tipo.Items.Add("Yogur");
        }

        private bool ValidarCamposLlenos()
        {
            if(cmb_CantidadStock.Text != String.Empty && cmb_Tipo.Text != String.Empty
                && textBox_Sabor.Text != String.Empty)
            {
                if(Validator.NoContieneNumeros(textBox_Sabor.Text))
                {
                    return true;
                }
                else
                {
                    throw new FormatException("No pueden ingresarse numeros en el campo de sabores");
                }
            }
            else
            {
                throw new CamposVaciosException();
            }
        }
    }
}
