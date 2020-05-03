using System;
using System.Globalization;

namespace AreaRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Retangulo ret = new Retangulo();

                Console.WriteLine("Dados do retângulo");
                Console.Write("Largura: ");
                ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Altura: ");
                ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine(ret);
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Erro de formatação: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro inesperado: {e.Message}");
            }
        }
    }
}
