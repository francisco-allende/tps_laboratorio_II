using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1_Entidades_Prueba;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        #region Initialize and Load
        /// <summary>
        /// Metodo por defecto que inicializa mi objeto formulario
        /// </summary>
        public FormCalculadora()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metodo por defecto que carga mi objeto formulario. Ademas, lo limpio y quito los botones de agrandar y achicar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;

            Limpiar();
        }

        #endregion

        #region Metodos
        /// <summary>
        /// Llama al metodo estatico operar de la clase Calculadora. Carga los objetos Operando con los numeros recibidos
        /// </summary>
        /// <param name="nro1">Valor numerico en string a cargar en el constructor del primer numero tipo Operando </param>
        /// <param name="nro2">Valor numerico en string a cargar en el constructor del seegundo numero tipo Operando </param>
        /// <param name="selectedOperator">Simbolo del operador</param>
        /// <returns>Resultado de la operacion entre ambos numeros segun el operador seleccionado</returns>
        private static double Operar(string nro1, string nro2, char selectedOperator)
        {
            Operando primerNumero = new Operando(nro1);
            Operando segundoNumero = new Operando(nro2);

            return Calculadora.Operar(primerNumero, segundoNumero, selectedOperator);
        }

        /// <summary>
        /// Vacia la informacion de los componentes, incluyendo el texto del label en 0 y el listbox vaciado
        /// </summary>
        private void Limpiar()
        {
            
            textNumero1.Text = string.Empty;
            textNumero2.Text = string.Empty;
            listBoxOperaciones.Items.Clear();
            comboBoxOperadores.Text = string.Empty;
            labelResult.Text = "0";
        }

        /// <summary>
        /// Alerta al usuario de si esta seguro de cerrar o no la aplicacion. 
        /// "Si" cierra la aplicacion, "No" cierra el recuadro y sigue la ejecucion de la aplicacion con normalidad
        /// </summary>
        private void preguntarAntesDeCerrar()
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

        /// <summary>
        /// Evitando repetir logica, sobrecargo un metodo print que muestra las operaciones del listbox y resultado del label
        /// </summary>
        /// <param name="resultado">Resultado a printear en el label</param>
        /// <param name="historial">Operacion y resultado a mostrar en el listbox</param>
        private void Print(string resultado, string historial)
        {
            labelResult.Text = resultado;
            listBoxOperaciones.Items.Add(historial);
        }

        /// <summary>
        /// Metodo sobrecargado. Printea el mensaje de error o la conversion binaria o decimal tanto en el listbox como en el label
        /// </summary>
        /// <param name="conversionOrError"></param>
        private void Print(string conversionOrError)
        {
            labelResult.Text = conversionOrError;
            listBoxOperaciones.Items.Add(conversionOrError);
        }
        #endregion

        #region Eventos
        /// <summary>
        /// Boton que se encarga de limpiar al formulario llamando a dicho metodo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// Boton que se encarga de operar entre dos numeros y el operador seleccionado llmando al metodo Operar. 
        /// Antes de llamar a dicho metodo, valida que si haya operador, ambos numeros, y que no hayan letras
        /// Si se cumple la validacion, printeo el resultado y la operacion 
        /// Si no se cumple la validacion, printeo "Valor invalido"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOperar_Click(object sender, EventArgs e)
        {
            string numero1 = textNumero1.Text;
            string numero2 = textNumero2.Text;
            bool noTieneLetrasNumero1 = double.TryParse(numero1, out double n1);
            bool noTieneLetrasNumero2 = double.TryParse(numero2, out double n2);
            

            if (comboBoxOperadores.Text != string.Empty && numero1 != string.Empty && numero2 != string.Empty && noTieneLetrasNumero1 && noTieneLetrasNumero2)
            {
                char operador = comboBoxOperadores.Text.ToCharArray()[0]; //casteo de char a string
                double result = Operar(numero1, numero2, operador);

                string historialOperaciones = $"{numero1} {operador} {numero2} = {result}";
                Print(result.ToString(), historialOperaciones);
            }
            else
            {
                Print("Valor inválido");
            }
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            preguntarAntesDeCerrar();
        }

        /// <summary>
        /// Boton que convierte el resultado decimal en pantalla a numero binario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonConvertirABinario_Click(object sender, EventArgs e)
        {
            if(labelResult.Text != string.Empty)
            {
                Operando numeroAConvertir = new Operando(labelResult.Text);

                Print(numeroAConvertir.DecimalBinario(labelResult.Text));
            }
        }

        /// <summary>
        /// Boton que convierte el numero binario (ya convertido antes) a un decimal entero positivo. 
        /// Si no fue convertido el numero a binario previamente, printeara valor inválido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonConvertirADecimal_Click(object sender, EventArgs e)
        {
            if (labelResult.Text != string.Empty)
            {
                Operando numeroAConvertir = new Operando(labelResult.Text);

                Print(numeroAConvertir.BinarioDecimal(labelResult.Text));
            }
        }
        #endregion

    }
}
