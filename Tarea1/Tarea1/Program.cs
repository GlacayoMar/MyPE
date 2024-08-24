using System;


namespace Tarea1
{
    internal class Program
    {
        static void HolaMundo()
        {
            Console.Clear();
            Console.WriteLine("Hola mundo");
            Console.ReadKey();
        }

        static void Saludar()
        {
            Console.Clear();
            Console.WriteLine("¿Cual es tu nombre?");
            string nombre = Console.ReadLine();

            Console.WriteLine("Que nota prix");
            Console.ReadKey();
        }

        static void SumaDeDosNumeros()
        {
            Console.Clear();
            Console.Write("Ingrese el primer numero: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el segundo numero: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            int suma = numero1 + numero2;

            Console.WriteLine("La suma de {0} y {1} es {2}.", numero1, numero2, suma);
            Console.ReadKey();
        }

        static void FigurasGeometricas()
        {
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("Seleccione la figura para calcular el área:");
                Console.WriteLine("1. Círculo");
                Console.WriteLine("2. Cuadrado");
                Console.WriteLine("3. Triángulo");
                Console.WriteLine("4. Volver al menú principal");
                Console.Write("Opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        RadioDeCirculo();
                        break;
                    case "2":
                        AreaCuadrado();
                        break;
                    case "3":
                        AreaTriangulo();
                        break;
                    case "4":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida, por favor intente de nuevo.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void RadioDeCirculo()
        {
            Console.Clear();
            Console.Write("Digite el radio del círculo: ");
            double radio = Convert.ToDouble(Console.ReadLine());
            double area = 3.14 * (radio * radio);
            Console.WriteLine($"El área del círculo con radio de {radio} es de: {area}");
            Console.ReadKey();
        }

        static void AreaCuadrado()
        {
            Console.Clear();
            Console.Write("Digite el lado del cuadrado: ");
            double lado = Convert.ToDouble(Console.ReadLine());
            double area = lado * lado;
            Console.WriteLine($"El área del cuadrado con lado de {lado} es de: {area}");
            Console.ReadKey();
        }

        static void AreaTriangulo()
        {
            Console.Clear();
            Console.Write("Digite la base del triángulo: ");
            double baseTriangulo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite la altura del triángulo: ");
            double altura = Convert.ToDouble(Console.ReadLine());
            double area = (baseTriangulo * altura) / 2;
            Console.WriteLine($"El área del triángulo con base de {baseTriangulo} y altura de {altura} es de: {area}");
            Console.ReadKey();
        }

        static void AumentarSalario()
        {
            Console.Clear();
            Console.WriteLine("Digite su nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Digite su salario");
            double salarioInicial = Convert.ToDouble(Console.ReadLine());

            double salario = salarioInicial + (salarioInicial * 0.10);

            Console.WriteLine($"Estimado {nombre}, su salario actual es de {salario}");

            Console.ReadKey();
        }

        static void NumeroParImpar()
        {
            Console.Clear();
            Console.Write("Ingrese el numero");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("El numero que ingreso es par");
            }
            else
            {
                Console.WriteLine("El numero que ingreso es impar");
            }
            Console.ReadKey();
        }

        static void NumeroMayor()
        {
         Console.Clear();
         Console.WriteLine("Ingrese el primer numero");
         int numero1 = Convert.ToInt32(Console.ReadLine());

         Console.WriteLine("Ingrese el segundo numero");
         int numero2 = Convert.ToInt32(Console.ReadLine());

         Console.WriteLine("Ingrese el tercer numero");
         int numero3 = Convert.ToInt32(Console.ReadLine());

         int mayor = DeterminarNum(numero1, numero2, numero3, out bool mismawea);

            if (mismawea)
            {
             Console.WriteLine("Los numeros ingresados son iguales");
            }
            else
            {
             Console.WriteLine($"El numero mayor es {mayor}.");
            }
            Console.ReadKey();
        }

        // funcion que determina cual numero es mayor o si todos los numeros ingresados son el mismo
        static int DeterminarNum(int numero1, int numero2, int numero3, out bool mismawea)
        {
            Console.Clear();
            
            // esta variable se encarga de determinar por medio de la operacion or si los numeros ingresados son el mismo o no
            mismawea = (numero1 == numero2 && numero1 == numero3 && numero2 == numero3);

            int mayor;

            // por medio de la estructura if else, else if se encuentra cual numero es el mayor
            if (numero1 >= numero2 && numero3 >= numero3)
            {
                mayor = numero1;
            }
            else if (numero2 >= numero1 && numero2 >= numero3)
            {
                mayor = numero2;
            }
            else
            {
                mayor = numero3;
            }
            return mayor;
           
        }


        static void Menu()
        {
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("Seleccione la opción que desea visualizar:");
                Console.WriteLine("1......Hola Mundo");
                Console.WriteLine("2......Saludar");
                Console.WriteLine("3......Suma de números pares");
                Console.WriteLine("4......Áreas de figuras geométricas");
                Console.WriteLine("5......Aumento de salario (Ah claro, por el 20%)");
                Console.WriteLine("6......Número par e impar");
                Console.WriteLine("7......Número mayor");
                Console.WriteLine("8......Salir");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        HolaMundo();
                        break;
                    case "2":
                        Saludar();
                        break;
                    case "3":
                        SumaDeDosNumeros();
                        break;
                    case "4":
                        FigurasGeometricas();
                        break;
                    case "5":
                        AumentarSalario();
                        break;
                    case "6":
                        NumeroParImpar();
                        break;
                    case "7":
                        NumeroMayor();
                        break;
                    case "8":
                        continuar = false; // Sale del bucle y termina el programa
                        break;
                    default:
                        Console.WriteLine("Opción no válida, por favor intente de nuevo.");
                        Console.ReadKey();
                        break;
                }
            }
        }



        static void Main(string[] args)
        {
            Menu();
        }
    }
}