using System;

namespace ClassLibrary1_Entidades_Prueba
{
    public static class Calculadora
    {
        /// <summary>
        /// Realiza una operacion aritmetica entre dos numeros segun el operador. Si el operador no es aceptado, por defecto suma
        /// </summary>
        /// <param name="num1"> Primer numero a operar </param>
        /// <param name="num2"> Segundo numero a operar</param>
        /// <param name="operador"> Simbolo que representa el operando a emplear </param>
        /// <returns> Retorna el resultado de la operacion entre los dos numeros</returns>
        public static double Operar(Operando num1, Operando num2, char operador)
        { 
            operador = Calculadora.ValidarOperador(operador);
            double resultado = 0;
            
            switch(operador)
            {
                case '+':
                    resultado = num1 + num2;
                    break;

                case '-':
                    resultado = num1 - num2;
                    break;

                case '*':
                    resultado = num1 * num2;
                    break;

                case '/':
                    resultado = num1 / num2;
                    break;
            }

            return resultado;
        }

        /// <summary>
        /// Valida que el operador sea valido siendo +,-, / y * los validos. 
        /// </summary>
        /// <param name="operador">Simbolo del operador a validar</param>
        /// <returns>Retorna el operador validad en cuestion. Caso contrario, si no es valido, retorna +</returns>
        private static char ValidarOperador(char operador)
        {
            switch (operador)
            {
                case '+':

                    return '+';

                case '-':

                    return '-';

                case '*':

                    return '*';

                case '/':

                    return '/';

                default:
                    return '+';
            }
        }
    }
}
