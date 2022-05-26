using System;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {

            Calculadora calc = new Calculadora();
            System.Console.WriteLine("Resultado da primeira soma" + calc.Somar(10, 10));
            System.Console.WriteLine("Resultado da primeira soma" + calc.Somar(10, 10, 10));

            // Aluno p1 = new Aluno();
            // p1.Nome = "Bob";
            // p1.Idade = 20;
            // p1.Documento = "123456";
            // p1.Nota = 10;

            // p1.Apresentar();

            // Professor p2 = new Professor();
            // p2.Nome = "Bob";
            // p2.Idade = 20;
            // p2.Documento = "123456";
            // p2.Salario = 2000;

            // p2.Apresentar();


            // //Valores válidos
            // Retangulo r = new Retangulo();
            // r.DefinirMedidas(30, 30);
            // r.ObterArea();
            // System.Console.WriteLine($"Área: {r.ObterArea()}");

            // //Valores válidos
            // Retangulo r2 = new Retangulo();
            // r.DefinirMedidas(0, 0);
            // r.ObterArea();
            // System.Console.WriteLine($"Área: {r2.ObterArea()}");


        }
    }
}