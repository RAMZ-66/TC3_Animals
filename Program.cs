using System;

namespace Animals
{
    class Program
    {
        // En POO, las funciones y procedimientos se llaman métodos
        // En todo programa, se debe incluir un punto inicial
        // El nombre estándar para el método que inicia un programa
        // es "main": static void Main
        // 
        // void -> no devuelve ningún valor (es un procedimiento)
        // static -> entorno estático; trabajando a nivel clase en vez de objeto
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            DecirHolaMundo();
            
            // string nombre;
            // Usar clase como tipo de variable
            // new -> construir algo
            // new Mapache() -> Llamar al método constructor y crear un nuevo Mapache
            Mapache mapache1 = new Mapache(true, 40f, 3.5f, "gris", "Alucard");

            Mapache mapache2 = new Mapache(true, 45f, 4f, "cafe", "Carlos");

            Mapache mapache3 = new Mapache (true,47f,3.9f,"negro", "Rodolfo");

            Mapache mapache4 = new Mapache(false, 50f, 4.5f, "gris", null);

            
            
            //TODO: Crear 2 mapaches distintos
            // Mapache mapache2 = new Mapache();

            //TODO: Agregar propiedad nombre a cada Mapache

            Console.WriteLine("Mapache #3");
            Console.WriteLine("Color: " + mapache3.color);
            Console.WriteLine("Nombre " + mapache3.nombre);
            // TODO: imprimir datos del mapache sin nombre
            Console.WriteLine("Mapache #4");
            Console.WriteLine("Color: " + mapache4.color);
            Console.WriteLine("Nombre " + mapache4.nombre);

            // Acciones
            mapache1.Moverse();
            mapache4.Moverse();

            mapache1.Comer();
            mapache4.Comer();

            mapache1.Trepar();
            mapache4.Trepar();

            // Información general de mapaches
            Console.WriteLine("---------------");
            Console.WriteLine("Información general sobre mapaches");
            Console.WriteLine("");

            if (Mapache.viviparo)
            {
                Console.WriteLine("Vivíparo");
            }
            else
            {
                Console.WriteLine("Ovíparo");
            }

            if(Mapache.tipoAlimentacion == TipoAlimentacion.CARNIVORO)
            {
                Console.WriteLine("Carnívoro");
            }
            else if(Mapache.tipoAlimentacion == TipoAlimentacion.HERBIVORO)
            {
                Console.WriteLine("Hervíboro");
            }
            else if(Mapache.tipoAlimentacion == TipoAlimentacion.OMNIVORO)
            {
                Console.WriteLine("Omnívoro");
            }





        }

        static string ObtenerTextoAMostrar()
        {
            return "Hello World!";
        }
        
        static void DecirHolaMundo()
        {
            string textoAMostrar = ObtenerTextoAMostrar();
            Console.WriteLine(textoAMostrar);
        }






        
    }
}