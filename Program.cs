/*Haz un programa que funcione como un editor de texto básico. El usuario debe poder abrir un archivo 
 * de texto, ver su contenido, seleccionar una línea y modificarla, así como insertar texto en una posición
 * específica de cualquier línea. Además, el programa debe permitir al usuario guardar los cambios realizados
 * en el archivo.*/

namespace Ejercicio6Fic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n\tIntroduzca la ruta del archivo que desea editar: ");
            string ruta=Console.ReadLine();

            string[] lineas=File.ReadAllLines(ruta);

            Console.WriteLine("\n");

            foreach (string line in lineas)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine("\n\tIntroduzca una linea: ");
            int numeroLinea=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\tIntroduzca un texto para modificar esa línea: ");
            string texto = Console.ReadLine();

            Console.WriteLine("\n\tIntroduzca la posición donde quiere introducir el texto nuevo: ");
            int posicion=Convert.ToInt32(Console.ReadLine());

            if (numeroLinea > lineas.Length)
            {
                Console.WriteLine("\n\tEl número de línea está fuera de rango.");
                return;
            }

            if (posicion > lineas[numeroLinea - 1].Length)
            {
                Console.WriteLine("La posición está fuera de rango.");
                return;
            }

            // Insertar el texto en la posición especificada
            lineas[numeroLinea - 1] = lineas[numeroLinea - 1].Insert(posicion, texto);

            Console.WriteLine("\n\t¿Quiere guardar estos cambios(S||N)?");
            string respuesta = Console.ReadLine();

            if (respuesta == "S" || respuesta == "s")
            {
                // Escribir las líneas actualizadas en el archivo
                File.WriteAllLines(ruta, lineas);

                Console.WriteLine("\n\tTexto insertado exitosamente.");
            }


            Console.WriteLine("\n\tFinal del programa.");


        }

    }
}
