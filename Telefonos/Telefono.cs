using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefonos
{
    internal class Telefono
    {
        // 3. Agregale los siguientes ATRIBUTOS:
        //      Modelo string.
        //      Marca string.
        //      NumeroTelefonico string.
        //      CodigoOperador int (1, 2 o 3).

        // 4. Agregale las PROPIEDADES correspondientes.Podés hacer el formato largo o el corto.
        //      Modelo: solo lectura. Es decir, solo get.
        //      Marca: solo lectura.
        //      NumeroTelefonico: lectura y escritura.
        //      CodigoOperador: lectura y escritura. Validar escritura que solo admita 1, 2 o 3, caso contrario escribir un cero.

        // ATRIBUTOS y PROPIEDADES
        public string Modelo { get; }
        public string Marca { get; }
        public string NumeroTelefonico { get; set; }

        public int codOperador;
        public int CodOperador
        {
            get { return codOperador; }
            set
            {
                if (value > 0 && value < 4)
                    codOperador = value;
                else
                    codOperador = -1;
            }
        }

        public string Contacto { get; set; }

        // 5. Agregar CONSTRUCTOR que reciba Modelo y Marca.

        // CONSTRUCTORES
        public Telefono(string Modelo, string Marca)
        {
            this.Modelo = Modelo;
            this.Marca = Marca;
        }
        // 7. Agregar MÉTODO Llamar() sin parámetros que devuelva un string con la leyenda "Realizando llamada...".

        // MÉTODO
        public string Llamar()
        {
            return "Realizando llamada...";
        }

        // 8. Sobrecargar el método Llamar(string contacto) para que reciba un contacto
        // y devuelva un string con la leyenda "Llamando a " + contacto

        // SOBRECARGA DE METODO - llamar al otro n°

        public string Llamar(object Contacto)
        {
            return "Llamando a " + Contacto;
        }

        public string Llamar(string Contacto)
        {
            return "Llamando a " + Contacto;
        }
    }
}
