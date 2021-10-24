using System;

namespace ExercicioDoadorDeSangue
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      string idade, peso;
      int idadeNR, pesoNR;
      Console.WriteLine("- - - Veja se você pode ou não ser um doador de sangue - - -");
      Console.WriteLine("---RESULTADO ESTRITAMENTE EDUCACIONAL.");
      Console.WriteLine($"http://www.prosangue.sp.gov.br/artigos/requisitos_basicos_para_doacao.html\n");


      Console.Write("Digite sua idade: ");
      idade = Console.ReadLine();
      bool Idadereal = Int32.TryParse(idade, out idadeNR);

      Console.Write("Digite seu peso: ");
      peso = Console.ReadLine();
      bool pesoreal = Int32.TryParse(peso, out pesoNR);

      if (!Idadereal || !pesoreal)
      {
        Console.WriteLine($"\nDigite um numero valido.");
        Environment.Exit(-1);
      }
      if (idadeNR < 0 || idadeNR > 125)
      {
        Console.WriteLine("\nDigite uma idade valida");
        Environment.Exit(-1);
      }
      if (idadeNR < 16 || idadeNR > 69)
      {
        Console.WriteLine("\nVocê não pode ser doador de sangue.");
      }

      if (idadeNR >= 18 && idadeNR <= 69)
      {
        if (idadeNR == 69)
        {
          Console.WriteLine("\ntudo bem, desde que a primeira doação tenha sido feita até 60 anos.");
        }
        if (pesoNR < 50)
        {
          Console.WriteLine("\nDoadores tem que ter pelo menos 50kg");
        }
        else if (pesoNR >= 50)
        {
          Console.WriteLine($"\nVocê pode doar sangue // idade: {idadeNR} peso: {pesoNR}");
        }
      }
      if (idadeNR >= 16 && idadeNR < 18)
      {
        if (pesoNR < 50)
        {
          Console.WriteLine("\nDoadores tem que ter pelo menos 50kg");
        }
        else if (pesoNR >= 50)
        {
          Console.WriteLine("\nVocê tem permissão de seus responsaveis? Digite [S] para sim e outro para nao.");
          bool Permissao = Console.ReadLine().ToUpper() == "S";

          if (!Permissao)
          {
            Console.WriteLine("\nEspere mais alguns anos");
          }
          else
          {
            Console.WriteLine("\nVá com seus responsaveis ao banco de sangue.");
          }

        }


      }



    }
  }
}
