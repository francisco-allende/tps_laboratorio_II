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

namespace TPFinal_Heladeria_Froddo
{
    public partial class FormAuxStock : Form
    {
        private Postre postre;
        public Postre Postre { get => postre; }
        private List<Postre> lista;

        public FormAuxStock(List<Postre> lista)
        {
            InitializeComponent();
            this.lista = lista;
            this.SetTipos();
        }

        private void FormAuxStock_Load(object sender, EventArgs e)
        {

        }

        private void SetTipos()
        {
            this.comboBoxTipo.Items.Add("Helado");
            this.comboBoxTipo.Items.Add("Yogur");
        }

        private bool PosiblesIds(int id)
        {
            foreach (Postre item in lista)
            {
                if(item.Id == id)
                {
                    return false;
                }
            }
            return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool idParseable = int.TryParse(textBoxId.Text, out int id);
            string sabor = textBoxSabor.Text;
            string tipo = comboBoxTipo.Text;
            bool cantidadParseable = double.TryParse(textBoxCantidad.Text, out double cantidad);

            if (idParseable && cantidadParseable && sabor != string.Empty && tipo != string.Empty
                && id > 0 && cantidad > 0)
            {
                bool idNoRepetido = PosiblesIds(id);
                if(idNoRepetido)
                {
                    this.postre = new Postre(id, cantidad, tipo, sabor);
                }
                else
                {
                    MessageBox.Show("No se pueden repetir ids!");
                }
            }
            else
            {
                throw new Exception();
            }

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
