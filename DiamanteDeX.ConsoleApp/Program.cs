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

            Console.Write("Informe um número inteiro ímpar: ");
            int tamanhoDiamante = Convert.ToInt32(Console.ReadLine());

            if (tamanhoDiamante % 2 == 0)
            {
                Console.Write("Você informou um número par. O número precisa ser ímpar");
                return;
            }

            int linhaSuperior = (tamanhoDiamante - 1) / 2;
            int qtdEspaco = (tamanhoDiamante - 1) / 2;
            int qtdX = 1;

            for(int linha = 0; linha < linhaSuperior; linha++)
            {

                for (int c1 = 0; c1 < qtdEspaco; c1++)
                {
                    Console.Write(" ");                     
                }

                for (int c2 = 0; c2 < qtdX; c2++)
                {
                    Console.Write("X");          
                }
                    qtdEspaco -= 1;
                    qtdX += 2;
            System.Console.WriteLine();
            }

            for (int linhaMeio = 0; linhaMeio < tamanhoDiamante; linhaMeio++)
            {          
                Console.Write("X");      
            }
            System.Console.WriteLine();
        
            int qtdEspacoInferior = 1;
            int qtdXInferior = tamanhoDiamante - 2;

            for(int linha = 0; linha < linhaSuperior; linha++)
            {

                for (int c1 = 0; c1 < qtdEspacoInferior; c1++)
                {
                    Console.Write(" ");                     
                }

                for (int c2 = 0; c2 < qtdXInferior; c2++)
                {
                    Console.Write("X");          
                }

                qtdEspacoInferior++;
                qtdXInferior -= 2;
                
                System.Console.WriteLine();
            }        
        }
    }
}
