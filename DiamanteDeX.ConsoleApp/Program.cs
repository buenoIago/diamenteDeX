/*
● O programa deve solicitar ao usuário um número inteiro.
● O número deve ser ímpar. Caso contrário, o programa deve informar que
a entrada é inválida e solicitar um novo número.
● O número de linhas e colunas deve ser igual ao número ímpar
fornecido.
● A linha central do diamante deve conter o número máximo de Xs.
*/

using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

class Program
{
   static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();

            System.Console.WriteLine("----------------------------------");
            System.Console.WriteLine("DIAMANTE DE X");
            System.Console.WriteLine("----------------------------------\n");

            Console.Write("Informe um número inteiro ímpar: ");
            Diamante.tamanhoDiamante = Convert.ToInt32(Console.ReadLine());

            if (Diamante.tamanhoDiamante % 2 == 0)
            {
                Console.Write("Você informou um número par. O número precisa ser ímpar");
                return;
            }

        Diamante.Configurar(Diamante.tamanhoDiamante);

        Diamante.ExecutarDiamante();

        System.Console.WriteLine("\nDiamante finalizado.\nPressione ENTER para continuar\n");
        Console.ReadLine();

        if (!UsuarioDesejaContinuar())
            break;

        }
    }   

        static bool UsuarioDesejaContinuar()
        {

            System.Console.WriteLine("Deseja criar outro diamante? (s/N:)");
            string? opcao = Console.ReadLine()?.ToUpper();

            if (opcao != "S")
            {
                System.Console.WriteLine("Encerrando o programa...");
                Thread.Sleep(1000);
                return false;
            }
            else
            return true;

        }

                    
}
