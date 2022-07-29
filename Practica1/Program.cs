using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Practica1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //permitir entrada de numeros con punto y tambien con coma
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

            // horas a minutos y segundos
            Console.WriteLine("-----------Ejercicio 1 -----------------------");
            int horas, segundos, minutos;

            Console.WriteLine("Ingrese la cantidad de horas: ");
            horas = int.Parse(Console.ReadLine());

            segundos = horas * 3600;
            minutos = horas * 60;

            Console.WriteLine("La cantidad de minutos es: " + minutos);
            Console.WriteLine("La cantidad de segundos es: " + segundos);

            //ejercicio II

            //calcular Area

            //A=B.H/2
            Console.WriteLine("\n-----------Ejercicio 2 -----------------------\n");
            double baseTriangulo, altura, area;

            Console.WriteLine("Ingrese la base del triángulo: ");
            baseTriangulo = Double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese  la altura del triángulo: ");
            altura = Double.Parse(Console.ReadLine());

            area = (baseTriangulo * altura) / 2;

            Console.WriteLine("El area del triángulo es: " + area);


            //calcular perimetro

            //a+b+c
            double valorA, valorB, valorC, perimetro;
            Console.WriteLine("\nCalcular perímetro \n");
            Console.WriteLine("Ingrese el valor de a: ");
            valorA = Double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de b: ");
            valorB = Double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de c: ");
            valorC = Double.Parse(Console.ReadLine());

            perimetro = valorA + valorB + valorC;

            Console.WriteLine("El perimetro del triángulo es: " + perimetro);

            //ejercicio III calcular area y volumen de un cilindro
            //a=2PI*R(h+R)
            //V=PI*R2*h
            Console.WriteLine("\n---Ejercicio 3-------\n");

            Console.WriteLine("\nÁrea y volumen de un cilindro\n");

            double radioCilindro, alturaCilindro, areaCilindro, volumenCilindro;

            Console.WriteLine("Ingrese el Radio: ");

            radioCilindro = Double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la altura: ");
            alturaCilindro = Double.Parse(Console.ReadLine());

            areaCilindro = 2 * Math.PI * radioCilindro * (alturaCilindro + radioCilindro);

            volumenCilindro = Math.PI * (radioCilindro * radioCilindro) * alturaCilindro;

            Console.WriteLine("\nEl  área del cilindro es: " + area + "\nEl volumen del cilindro es: " + volumenCilindro);

            //ejercicio IV
            //operaciones
            Console.WriteLine("\n-----------Ejercicio 4 -----------------------\n");

            double num1, num2, resultado;

            Console.WriteLine("-----Suma-----");

            Console.WriteLine("Ingrese el primer número: ");

            num1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número: ");

            num2 = Double.Parse(Console.ReadLine());

            resultado = num1 + num2;

            Console.WriteLine("\nEl resultado de la suma es: " + resultado);


            Console.WriteLine("\n-----Resta---");

            Console.WriteLine("Ingrese el primer número: ");

            num1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número: ");

            num2 = Double.Parse(Console.ReadLine());

            resultado = num1 - num2;

            Console.WriteLine("\nEl resultado de la resta es: " + resultado);


            Console.WriteLine("\n-----Multiplicación-----");

            Console.WriteLine("Ingrese el primer número: ");

            num1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número: ");

            num2 = Double.Parse(Console.ReadLine());

            resultado = num1 * num2;

            Console.WriteLine("\nEl resultado de la multiplicación es: " + resultado);


            Console.WriteLine("\n-----División-----");

            Console.WriteLine("Ingrese el primer número: ");

            num1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número: ");

            num2 = Double.Parse(Console.ReadLine());

            resultado = num1 / num2;

            Console.WriteLine("\nEl resultado de la división es: " + resultado);


            //ejercicio 5
            Console.WriteLine("\n-----------Ejercicio 5 -----------------------\n");
            string nombre, tipoDeSangre;
            int edad;
            double peso, estatura;



            Console.WriteLine("Ingrese su nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su edad: ");
            edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su peso: ");
            peso = Double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su estatura: ");
            estatura = Double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su tipo de sangre: ");
            tipoDeSangre = Console.ReadLine();


            Console.WriteLine("\nNombre: " + nombre + "\nEdad: " + edad + "\nPeso: " + peso + "\nEstatura: " + estatura + "\nTipo de sangre: " + tipoDeSangre);

        }
    }
}
