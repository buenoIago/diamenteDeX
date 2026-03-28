public static class Diamante
    {
        public static int tamanhoDiamante;
        public static int linhaSuperior;
        public static int qtdEspaco = (tamanhoDiamante - 1) / 2;
        public static int qtdX = 1;
        public static int qtdEspacoInferior = 1;
        public static int qtdXInferior = tamanhoDiamante - 2;

    public static void Configurar(int tamanhoDiamante1)
    {
        tamanhoDiamante = tamanhoDiamante1;
        linhaSuperior = (tamanhoDiamante - 1) / 2;
        qtdEspaco = (tamanhoDiamante - 1) / 2;
        qtdX = 1;
        qtdEspacoInferior = 1;
        qtdXInferior = tamanhoDiamante - 2;

    }

    public static void ExecutarDiamante()
    {
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