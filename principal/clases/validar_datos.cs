using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cbs_sistema
{
    class validar_datos
    {
        /* Jerarquia de Herencia System.Object / System.EventArgs / Sistem.Windows.Forms.KeyPressEventArg
 * using System.Windows.Forms; para que pueda utlizar el contructor KeyPressEventArgs
 * e variable que recibo de los textbox. 
 * 
 * Constructores. Es una subrutina cuya mision es inicializar un objeto de una clase. Se asigna los valores iniciales del nuevo objeto.
 * KeyPressEventArgs    = inicializa una nueva instancia de la clase de keypresseventargs.
 * 
 * Propiedades
 * Handled              = Obtiene o establece un valor que indica si el evento de KeyPress se controlo.
 * KeyChar              = Obtiene o establece el caracter correspondiente a la tecla precionada
 * 
 * Metodos
 * Equals(object)       = Determina si el objeto especificado es igual al objeto actual. (hereda del object).
 * Finalize             = Permite que un objeto intente liberar recursos y realizar otras operaciones de limpieza antes de ser reclamado por la recoleccion de elementos no utilizados. (hereda el object).
 * GetHasCode           = Actua como funcion hash para un tipo concreto. (hereda del object).
 * GetType              = Obtiene el objeto Type de la instancia actual. (hereda del object).
 * MemberwiseClone      = Crea una copia superficial del Object actual. (Hereda del object).
 * ToString             = Devuelve una cadena que represnta el objeto actual. (Hereda del object).
 * 
 * CHAR
 * IsDigit              = Indica si el caracter unicode especificado se clasifica com un caracter de control.
 * IsLetter             = Indica si el caracter unicode especificado se clasifica como una letra unicode.
 * IsControl            = Especifica si el caracter unicode especificado se clasifica como un caracter de control.
 * MaxValue             = representa el mayor valor posible de un Char. Este campo es constante.
 * MinValue             = representa el menor valor posible de un Char. Este campo es constante.
 * 
 * Unicode              = universalidad, uniformidad y unicidad. Estandar en Java, XML, Sistemas operativos modernos. Caracteres = 109.449.
 * 
 * Metodo sololetras    = verifica si las teclas precionadas son caracteres
 */

        public void sololetras(KeyPressEventArgs e)
        {
            char letras;
            letras = e.KeyChar;

            if (char.IsLetter(letras))
            {
                e.Handled = false;
            }
            else if (char.IsControl(letras))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }
        public void solonumeros(KeyPressEventArgs e)
        {
            char letras;
            letras = e.KeyChar;

            if (char.IsDigit(letras))
            {
                e.Handled = false;
            }
            else if (char.IsControl(letras))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }


    }
}
