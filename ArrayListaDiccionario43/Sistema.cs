using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListaDiccionario43
{
    public class Sistema
    {
        public void MenuPrincipal()
        {
            Validador.Bienvenida();

            int cantidad = Validador.PedirInt("Ingrese la cantidad de elementos que tendra el arreglo");

            int[] arregloNumero = new int[cantidad];

            Validador.RegistrarNumero(ref arregloNumero);

            Validador.MostrarListado(arregloNumero);

            Console.WriteLine("\n Aplicamos Las operaciones matemáticas Correspondientes: ");

            int maximo = arregloNumero.Max();

            Console.WriteLine("\n El máximo número de estos elementos es: " + maximo);

            int minimo = arregloNumero.Min();

            Console.WriteLine("\n El mínimo número de estos elementos es: " + minimo);

            decimal promedio = arregloNumero.Sum() / arregloNumero.Length;

            Console.WriteLine("\n El número promedio de estos elementos es: " + promedio);


            int suma = arregloNumero.Sum();

            Console.WriteLine("\n La suma de estos elementos es: " + suma);

            Validador.Despedida();

        }



        public void Iniciar()
        {
            MenuPrincipal();
        }

    }
}
