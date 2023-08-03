// PRACTICA DE OBJETOS
// 1. Crear un proyecto de consola.Net Framework.
// 2. Crear la clase Telefono.
// 3. Agregale los siguientes atributos:
//      - Modelo string.
//      - Marca string.
//      - NumeroTelefonico string.
//      - CodigoOperador int (1, 2 o 3).
// 4. Agregale las propiedades correspondientes.Podés hacer el formato largo o el corto.
//      - Modelo: solo lectura. Es decir, solo get.
//      - Marca: solo lectura.
//      - NumeroTelefonico: lectura y escritura.
//      - CodigoOperador: lectura y escritura.Validar escritura que solo admita 1, 2 o 3, caso contrario escribir un cero.
// 5. Agregar Constructor que reciba Modelo y Marca.
// 6. Crear algunos objetos en el main de Program y probar escribirle datos y mostrar en pantalla el estado del Telefono.
// 7. Agregar método Llamar() sin parámetros que devuelva un string con la leyenda "Realizando llamada...".
// 8. Sobrecargar el método Llamar(string contacto) para que reciba un contacto y devuelva un string con la leyenda "Llamando a " + contacto
// 9. Probar métodos en el main mostrando en pantalla el comportamiento de los objetos.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefonos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 6. Crear algunos objetos en el main de Program y probar escribirle datos y mostrar en pantalla el estado del Telefono.

            // CREAMOS EL OBJETO

            Telefono T1 = new Telefono("C115", "Motorola");

            // LE DAMOS VALORES A NRO Y OPERADOR

            T1.NumeroTelefonico = "156100486";
            T1.CodOperador = 2;

            // CREAMOS OTRO OBJETO

            Telefono T2 = new Telefono("W200", "Sony Ericsson");
            T2.NumeroTelefonico = "156863440";
            T2.CodOperador = 4;

            // DEVOLVEMOS LOS DATOS

            Console.WriteLine("Los datos del primer teléfono son:");
            Console.WriteLine("Marca: " + T1.Marca);
            Console.WriteLine("Modelo: " + T1.Modelo);
            Console.WriteLine("Número: " + T1.NumeroTelefonico);
            Console.WriteLine("Empresa: " + T1.CodOperador);
            Console.WriteLine(" ");
            Console.WriteLine("Los datos del segundo teléfono son:");
            Console.WriteLine("Marca: " + T2.Marca);
            Console.WriteLine("Modelo: " + T2.Modelo);
            Console.WriteLine("Número: " + T2.NumeroTelefonico);
            Console.WriteLine("Empresa: " + T2.CodOperador);

            // 9. Probar métodos en el main mostrando en pantalla el comportamiento de los objetos.

            // APLICAMOS METODO

            Console.WriteLine(" ");
            Console.WriteLine(T1.Llamar());

            // APLICAMOS SOBRECARGA DEL METODO

            Console.WriteLine(T1.Llamar(T2.NumeroTelefonico));
            Console.WriteLine(T1.Llamar("Dani"));


            Console.ReadKey();
        }
    }
}
