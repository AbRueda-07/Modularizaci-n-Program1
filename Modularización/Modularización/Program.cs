using System;

namespace Modularización
{
    class Program
    {
        static void Main()
        {
            string opcion;
            do
            {

                Console.WriteLine(" \n -MENÚ DE OPCIÓNES- \n");
                Console.WriteLine("1. Calculadora básica.");
                Console.WriteLine("2. Validación de contraseña.");
                Console.WriteLine("3. Números primos.");
                Console.WriteLine("4. Suma de números pares.");
                Console.WriteLine("5. Conversión de temperaturas.");
                Console.WriteLine("6. Contador de vocales.");
                Console.WriteLine("7. Cálculo de factorial.");
                Console.WriteLine("8. Juego de adivinanza.");
                Console.WriteLine("9. Paso por referencia.");
                Console.WriteLine("10. Tabla de multiplicar.");
                Console.WriteLine("0. Salir");
                Console.WriteLine("\nSeleccione una opción: ");

                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Calcbasic();
                        break;
                    case "2":
                        ValidarContrasenia();
                        break;
                    case "3":
                        NumerosPrimos();
                        break;
                    case "4":
                        SumaPares();
                        break;
                    case "5":
                        ConversionTemperaturas();
                        break;
                    case "6":
                        ContadorVocales();
                        break;
                    case "7":
                        Factorial();
                        break;
                    case "8":
                        JuegoAdivinanza();
                        break;
                    case "9":
                        PasoPorReferencia();
                        break;
                    case "10":
                        TablaMultiplicar();
                        break;
                    case "0":
                        Console.WriteLine("\nGracias por usar el programa, Adiós.");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            } while (opcion != "0");
        }
        static void Calcbasic()
        {
            Console.Write("\nIngrese el primer número:\n ");
            if (!double.TryParse(Console.ReadLine(), out double n1))
            {
                Console.WriteLine("Número inválido. Intente nuevamente.");
                return;
            }

            Console.Write("\nIngrese el segundo número:\n");
            if (!double.TryParse(Console.ReadLine(), out double n2))
            {
                Console.WriteLine("Número inválido. Intente nuevamente.");
                return;
            }

            Console.WriteLine("\nSeleccione una operación:");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine(" \nIngresa la opcíon seleccionada");
            double operacion = double.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (operacion)
            {
                case 1:
                    Console.WriteLine($"\nEl resultado de la suma es: {n1 + n2}");
                    break;
                case 2:
                    Console.WriteLine($"\nEl resultado de la resta es: {n1 - n2}");
                    break;
                case 3:
                    Console.WriteLine($"\nEl resultado de la multiplicación es: {n1 * n2}");
                    break;
                case 4:
                    if (n2 != 0)
                        Console.WriteLine($"\nEl resultado de la división es: {n1 / n2}");
                    else
                        Console.WriteLine("\nNo se puede dividir entre 0.");
                    break;
                default:
                    Console.WriteLine("Operación no válida.");
                    break;
            }
        }

        static void ValidarContrasenia()
        {
            string contrasenia;
            do
            {
                Console.Write("\nIngrese la contraseña: ");
                contrasenia = Console.ReadLine();
                if (contrasenia != "0011")
                {
                    Console.WriteLine("Acceso denegado. Vuelva a intentarlo.");
                }
            } while (contrasenia != "0011");
            Console.WriteLine("Acceso concedido.");
        }

        static void NumerosPrimos()
        {
            Console.Write("Ingrese un número: ");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                bool esPrimo = num > 1;
                for (int i = 2; i <= Math.Sqrt(num) && esPrimo; i++)
                    if (num % i == 0)
                        esPrimo = false;
                Console.WriteLine(esPrimo ? "El número es primo." : "El número no es primo.");
            }
            else
            {
                Console.WriteLine("Número no válido.");
            }
        }

        static void SumaPares()
        {
            int suma = 0;
            int num;
            do
            {
                Console.Write("Ingrese un número (0 para terminar): ");
                if (int.TryParse(Console.ReadLine(), out num) && num % 2 == 0)
                    suma += num;
            } while (num != 0);
            Console.WriteLine($"Suma de números pares: {suma}");

        }

        static void ConversionTemperaturas()
        {
            Console.WriteLine("1. Celsius a Fahrenheit (C° A F°).");
            Console.WriteLine("2. Fahrenheit a Celsius (F° a C°).");
            Console.WriteLine("Seleccione una opción: ");
            string opcion = Console.ReadLine();
            Console.Write("Ingrese la temperatura: ");

            if (double.TryParse(Console.ReadLine(), out double temp))
            {
                if (opcion == "1")
                    Console.WriteLine($"Temperatura en Fahrenheit: {(temp * 9 / 5) + 32}");
                else if (opcion == "2")
                    Console.WriteLine($"Temperatura en Celsius: {(temp - 32) * 5 / 9}");
                else
                    Console.WriteLine("Opción no válida.");
            }
            else
            {
                Console.WriteLine("Dato no válida.");
            }
        }
        static void ContadorVocales()
        {
            Console.Write("Ingrese una palabra: ");
            string palabra = Console.ReadLine().ToLower();
            int contador = 0;
            foreach (char letra in palabra)
            {
                if ("aeiou".Contains(letra))
                    contador++;
            }
            Console.WriteLine($"Número de vocales: {contador}");
        }

        static void Factorial()
        {
            Console.Write("Ingrese un número: ");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                int factorial = 1;
                for (int i = 1; i <= num; i++)
                    factorial *= i;
                Console.WriteLine($"El factorial de {num} es: {factorial}");
            }
            else
            {
                Console.WriteLine("Número no válido.");
            }
        }

        static void JuegoAdivinanza()
        {
            Random aleatorio = new Random();
            int numSecreto = aleatorio.Next(1, 11);
            int intento = 0;
            int num;
            do
            {
                Console.Write("Adivina el número entre  1 y 10: ");
                if (int.TryParse(Console.ReadLine(), out intento))
                {

                    if (intento > numSecreto)
                        Console.WriteLine("Demasiado alto.");
                    else if (intento < numSecreto)
                        Console.WriteLine("Demasiado bajo.");
                }
                else
                {
                    Console.WriteLine("Número no válido.");
                }
            } while (intento != numSecreto);
            Console.WriteLine("¡Correcto! Has adivinado el número.");
        }

        static void PasoPorReferencia()
        {
            Console.Write("Ingrese el primer número: ");
            if (int.TryParse(Console.ReadLine(), out int numero1))
            {
                Console.Write("Ingrese el segundo número: ");
                if (int.TryParse(Console.ReadLine(), out int numero2))
                {

                    Console.WriteLine($"Antes del intercambio: numero1 = {numero1}, numero2 = {numero2}");
                    Intercambiar(ref numero1, ref numero2);
                    Console.WriteLine($"Después del intercambio: numero1 = {numero1}, numero2 = {numero2}");
                }
                else
                {
                    Console.WriteLine("Número no válido");
                }
            }
            else
            {
                Console.WriteLine("Número no válido");
            }
        }
        static void Intercambiar(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }


        static void TablaMultiplicar()
        {
            Console.Write("Ingrese un número: ");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                for (int i = 1; i <= 10; i++)
                    Console.WriteLine($"{num} x {i} = {num * i}");
            }
            else
            {
                Console.WriteLine("Número no válido.");
            }
        }
    }

}










