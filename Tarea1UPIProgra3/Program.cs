using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1UPIProgra3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            do // Primero ejecuta y luego evalua
            {
                Console.Clear();
                Console.WriteLine("1-  Ejercicio 1 ");
                Console.WriteLine("2-  Ejercicio 2 ");
                Console.WriteLine("3-  Ejercicio 3 ");
                Console.WriteLine("4-  Salir");
                Console.WriteLine("Digite una opción");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                        case 1: Ejercicio1(); break;
                        case 2: Ejercicio2(); break;  
                        case 3: Ejercicio3(); break;
                        case 4: break;
                        default:
                        Console.Clear();
                        Console.WriteLine(" Opcion Incorrecta");
                        Console.ReadLine();
                        break;

                }
            } while (opcion!=4); // Primero evalua y luego ejecuta

        }
        // 1 camisa sin descuento
        // 2 a 5 camisas 15% descuento
        // Más de 5 camisas con 20% de descuento
        public static void Ejercicio1()
        {
            float precio = 0f;
            int cantidad;
            Console.WriteLine("Digite el precio: ");
            precio= float.Parse(Console.ReadLine());    
            Console.WriteLine("Digite la cantidad de camisas: ");
            cantidad=int.Parse(Console.ReadLine());
            if (cantidad==1)// SI la cantidad es 1 no hay descuento
            {
                Console.WriteLine($"El precio de la camisa es de {cantidad * precio}");
            }
            if (cantidad>=2 && cantidad<=5)
            {
                Console.WriteLine($"El precio de la camisa es de {((precio -((precio*0.15f))*cantidad))} con descuento del 15% ");
            }
            if (cantidad > 5)
            {
                Console.WriteLine($"El precio de la camisa es de {((precio - (precio * 0.20f)) * cantidad)} con descuento del 20% ");
            }
            Console.ReadLine ();
        }
        public static void Ejercicio2()
        {

                Console.Write("Ingrese el carnet del estudiante: ");
                string carnet = Console.ReadLine();

                Console.Write("Ingrese el nombre del estudiante: ");
                string nombre = Console.ReadLine();

                Console.Write("Ingrese la nota del Primer Quiz: ");
                float Quiz1 = float.Parse(Console.ReadLine());

                Console.Write("Ingrese la nota del Segundo Quiz: ");
                float Quiz2 = float.Parse(Console.ReadLine());

                Console.Write("Ingrese la nota del Tercer Quiz: ");
                float Quiz3 = float.Parse(Console.ReadLine());

                Console.Write("Ingrese la nota de la Primera Tarea: ");
                float Tarea1 = float.Parse(Console.ReadLine());

                Console.Write("Ingrese la nota de la Segunda Tarea: ");
                float Tarea2 = float.Parse(Console.ReadLine());

                Console.Write("Ingrese la nota de la Tercera Tarea: ");
                float Tarea3 = float.Parse(Console.ReadLine());
              
                Console.Write("Ingrese la nota del Primer Examen: ");
                float Examen1 = float.Parse(Console.ReadLine());

                Console.Write("Ingrese la nota del Segunda Examen: ");
                float Examen2 = float.Parse(Console.ReadLine());

                Console.Write("Ingrese la nota del Tercer Examen: ");
                float Examen3 = float.Parse(Console.ReadLine());

                
                float PorcentajeQuices = ((Quiz1 + Quiz2 + Quiz3) / 3f) * 25f/100;
          
                float PorcentajeTareas = ((Tarea1 + Tarea2 + Tarea3) / 3f) * 30f/100;
        
                float PorcentajeExamenes = ((Examen1 + Examen2 + Examen3) / 3f) * 45f / 100;
           
                float Promedio_Final = PorcentajeQuices + PorcentajeTareas + PorcentajeExamenes;

               
                string condicion = "";
                if (Promedio_Final >= 70)
                {
                    condicion = "Aprobado";
                }
                else if (Promedio_Final >= 50)
                {
                    condicion = "Aplazado";
                }
                else
                {
                    condicion = "Reprobado";
                }
                
                Console.WriteLine("Carnet número: " + carnet+ " del estudiante "+nombre);   
                Console.WriteLine("Su porcentaje de Quices es de: " + PorcentajeQuices + "%");
                Console.WriteLine("Su Porcentaje de Tareas es de: " + PorcentajeTareas + "%");
                Console.WriteLine("Su Porcentaje de Exámenes es de: " + PorcentajeExamenes + "%");
                Console.WriteLine("Su Promedio Final es de : " + Promedio_Final);
                Console.WriteLine("Su Condición es : " + condicion);
                Console.ReadLine();


        }
    public static void Ejercicio3()
        {
   
                Console.Write("Ingrese la cantidad de artículos a comprar: ");
                int CantidadArticulos = int.Parse(Console.ReadLine());
                double Precio_Articulo;               

                if (CantidadArticulos <= 10)
                {
                Precio_Articulo = 20; 
                }
                else
                {
                Precio_Articulo = 15; 
                }
                double PrecioTotal = CantidadArticulos * Precio_Articulo;

                Console.WriteLine($"El precio del artículo es de : ${Precio_Articulo}");
                Console.WriteLine($"El Precio de los {CantidadArticulos} artículos es de : ${PrecioTotal}");
                Console.ReadLine() ;    
            
        }


    }
}
