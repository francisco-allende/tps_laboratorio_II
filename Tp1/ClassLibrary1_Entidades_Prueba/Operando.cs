using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1_Entidades_Prueba
{
    public class Operando
    {
        private double numero;


        #region Setter
        /// <summary>
        /// Setteo el valor del atributo privado double numero. Valido, sino, no setteo nada
        /// </summary>
        public string Numero
        {
            set
            {
                double numeroPorSettear = this.ValidarOperando(value); //Valido. Unico lugar en el que es llamado

                if (numeroPorSettear != 0) //Me da 0 si NO es un numero
                {
                    this.numero = numeroPorSettear;
                }
            }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Construye el objeto de tipo Operando con un unico parametro
        /// </summary>
        /// <param name="numero">numero en formato double</param>
        public Operando(double numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// Construye el objeto de tipo Operando con un unico parametro. Al ser string, uso mi setter que valida 
        /// </summary>
        /// <param name="numero">numero en formato string, si no es numero, setea con un 0</param>
        public Operando(string numero)
        {
            this.Numero = numero;
        }

        /// <summary>
        /// Construye el objeto de tipo Operando. No posee parametros. Sobrecargo con el que recibe un double y mando un 0
        /// </summary>
        public Operando() : this(0)
        {

        }
        #endregion

        #region Sobrecarga de operadores
        /// <summary>
        /// Sobrecargo el operador + para poder sumar objetos de tipo Operando entre si
        /// </summary>
        /// <param name="n1">Primer numero</param>
        /// <param name="n2">Segundo numero</param>
        /// <returns>Resultado de la suma entre ambos numeros</returns>
        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }

        /// <summary>
        /// Sobrecargo el operador - para poder restar objetos de tipo Operando entre si
        /// </summary>
        /// <param name="n1">Primer numero</param>
        /// <param name="n2">Segundo numero</param>
        /// <returns>Resultado de la resta entre ambos numeros</returns>
        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }

        /// <summary>
        /// Sobrecargo el operador * para poder multiplicar objetos de tipo Operando entre si
        /// </summary>
        /// <param name="n1">Primer numero</param>
        /// <param name="n2">Segundo numero</param>
        /// <returns>Resultado de la multiplicacion entre ambos numeros</returns>
        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }

        /// <summary>
        /// Sobrecargo el operador / para poder multiplicar objetos de tipo Operando entre si. Valido que el segundo numero no sea 0
        /// </summary>
        /// <param name="n1">Primer numero</param>
        /// <param name="n2">Segundo numero</param>
        /// <returns>Si es valida la division, su resultado. Si no es valida, el double.MinValue a forma de error</returns>
        public static double operator /(Operando n1, Operando n2)
        {
            if(n2.numero != 0)
            {
                return n1.numero / n2.numero;
            }
    
            return double.MinValue;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Valida que el string recibido pueda ser parseado a un numero double. Caso contrario, retorna 0
        /// </summary>
        /// <param name="strNumero">String a parsear que deberia contener un numero</param>
        /// <returns>Si es parseable, ese mismo numero en formato double. Sino es parseable, el 0</returns>
        private double ValidarOperando(string strNumero)
        {
            if(double.TryParse(strNumero, out double doubleNumero))
            {
                return doubleNumero;
            }

            return 0;
        }

        /// <summary>
        /// Valida que el string recibido sea un numero binario
        /// </summary>
        /// <param name="binario">String a parsear que deberia contener un numero binario</param>
        /// <returns>Si es binario, retorna true. Si no lo es, retorna false</returns>
        private bool EsBinario(string binario)
        {
            for (int i = 0; i < binario.Length; i++)
            {
                if (binario[i] != '1' && binario[i] != '0')
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Convierte un numero binario a decimal
        /// </summary>
        /// <param name="binario">Strig del numero binario a convetir. Previamente valido con EsBinario</param>
        /// <returns>Si es binario, retorna ese numero en formato string. Sino, retorna "Valor invalido"</returns>
        public string BinarioDecimal(string binario)
        {
            if(EsBinario(binario))
            { 
                int baseIntDecimal = 0;
                int cantidadDePosiciones = binario.Length;
                int potencia = cantidadDePosiciones;
                potencia--; //la posicion es uno menos que el length

                for (int i = 0; i < cantidadDePosiciones; i++)
                {
                    if (binario[i] == '1') //valido que sea 1 para convertir, 0 no me sirve
                    {
                        baseIntDecimal += (int)Math.Pow(2, potencia); //Math pow recibe 2 doubles, por eso casteo a int
                    }
                    potencia--; //entre o no, la potencia debe bajar
                }

                return baseIntDecimal.ToString();
            }
            else
            {
                return "Valor inválido";
            }
        }

        /// <summary>
        /// Convierte un numero decimal a binario
        /// </summary>
        /// <param name="numero">Numero decimal en tipo de dato double a convertir a binario</param>
        /// <returns>Si es mayor a 0 es convertirble y retorna el binario en formato string. Sino, retorna "Valor invalido"</returns>
        public string DecimalBinario(double numero)
        {
            numero = (int)numero;

            if (numero >= 0)
            {
                string binario = Convert.ToString((int)numero, 2);

                return binario;
            }
            else
            {
                return "Valor inválido";
            }
        }

        /// <summary>
        /// Convierte un numero dedcimal a binario. Sobrecarga del metodo previo, reutilizando ese metodo para no repetir logica
        /// </summary>
        /// <param name="numero">String con el numero binario</param>
        /// <returns>Si se puede parsear el string a un numero, y este luego es positivo, retorna ese numero binario en formato string. 
        /// Sino, retorna "Valor invalido"
        /// </returns>
        public string DecimalBinario(string numero)
        {
            double miNum;

            if (double.TryParse(numero, out miNum)) //Si puede parsearlo, llamo al otro metodo y retorno el binario en string
            {
                return DecimalBinario(miNum);
            }
            else
            {
                return "Valor inválido";
            }
        }
        #endregion
    }
}
