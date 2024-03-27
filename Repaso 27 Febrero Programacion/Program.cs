using System;

class Program
{
    static void Main(string[] args)
    {
        // datos de las rutas
        string ruta = "Ruta 101";
        double precioBase = 2.50;
        double distancia = 10; // en kilómetros

        // informaciones de rutas
        Console.WriteLine($"Bienvenido a la {ruta}");
        Console.WriteLine($"Distancia de la ruta: {distancia} km");
        Console.WriteLine($"Precio base del pasaje: ${precioBase}");

        // se solicita el numero de pasajeros
        Console.Write("Ingrese la cantidad de pasajeros: ");
        int cantidadPasajeros = Convert.ToInt32(Console.ReadLine());

        // calculo del cobro
        double totalAPagar = precioBase * cantidadPasajeros;

        // total de cobro
        Console.WriteLine($"Total a pagar por {cantidadPasajeros} pasajeros: ${totalAPagar}");

        // espera de input de usuario
        Console.WriteLine("Presione cualquier tecla para salir...");
        Console.ReadKey();
    }
}
