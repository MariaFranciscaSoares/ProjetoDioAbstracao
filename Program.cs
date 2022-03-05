using System;
using ProjetoJogoRpg.src.Entities;

namespace ProjetoJogoRpg
{
  class Program
  {
    static void Main(string[] args)
    {
      Thriller thriller = new Thriller("Ilha do medo, ", 2010, "Suspense");
      Romance romance = new Romance("A Saga Crepúsculo - Lua Nova, ", 2009, "Romance");
      Comedy comedy = new Comedy("Minha Mãe È Uma Peça, ", 2013, "Comédia");
      Horror horror = new Horror("A Epidemia, ", 2010, "Terrror");

      int option = 0;
      while (option != 1)
      {
        Console.WriteLine(@"
          DIGITE O NUMERO DO GENERO DE FILME QUE GOSTARIA DE ASSISTIR:
          1- ROMANCE
          2- COMEDIA
          3- SUSPENSE
          4- TERROR");
        int number = int.Parse(Console.ReadLine());

        switch (number)
        {
          case 1:
            Console.WriteLine(romance);
            Console.WriteLine("Sinopce do Filme: " + romance.Synopsis() + "\n");
            break;
          case 2:
            Console.WriteLine(comedy);
            Console.WriteLine("Sinopce do Filme: " + comedy.Synopsis() + "\n");
            break;
          case 3:
            Console.WriteLine(thriller);
            Console.WriteLine("Sinopce do Filme: " + thriller.Synopsis() + "\n");
            break;
          case 4:
            Console.WriteLine(horror);
            Console.WriteLine("Sinopce do Filme: " + horror.Synopsis() + "\n");
            break;
          default:
               Console.WriteLine("Digite um numero valido - Opções de 1 a 4: ");
            break;

        }
    
        if (number > 0 && number <= 4)
        {
          Console.WriteLine(@"
          DIGITE 1 - PARA ASSISTIR O FILME 
          DIGITE 2 - PARA VOLTAR");
          option = int.Parse(Console.ReadLine());
        }
      }
      Console.WriteLine("\n" + "BOA SESSÃO!");

    }
  }
}

