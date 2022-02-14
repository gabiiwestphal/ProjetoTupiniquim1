using System;

namespace ProjetoTupiniquim.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //robo 1
            String comando = "EMEMEMEMM";
            char sentido = 'N';
            int localizacaoX = 1;
            int localizacaoY = 2;


            char[] instrucoes = comando.ToCharArray();

            for (int posicao = 0; posicao < instrucoes.Length; posicao++)
            {

                if (instrucoes[posicao] == 'M')
                {
                    if (sentido == 'N')
                    {
                        localizacaoY = localizacaoY + 1;
                    }
                    else if (sentido == 'S')
                    {
                        localizacaoY = localizacaoY - 1;
                    }
                    else if (sentido == 'L')
                    {
                        localizacaoX = localizacaoX + 1;
                    }
                    else if (sentido == 'O')
                    {
                        localizacaoX = localizacaoX - 1;
                    }
                }

                if (instrucoes[posicao] == 'E')
                {

                    if (sentido == 'N')
                    {
                        sentido = 'O';
                    }
                    else if (sentido == 'S')
                    {
                        sentido = 'L';
                    }
                    else if (sentido == 'L')
                    {
                        sentido = 'N';
                    }
                    else if (sentido == 'O')
                    {
                        sentido = 'S';
                    }
                }

                if (instrucoes[posicao] == 'D')
                {
                    if (sentido == 'N')
                    {
                        sentido = 'L';
                    }
                    else if (sentido == 'S')
                    {
                        sentido = 'O';
                    }
                    else if (sentido == 'L')
                    {
                        sentido = 'S';
                    }
                    else if (sentido == 'O')
                    {
                        sentido = 'N';
                    }
                }
            }
            Console.WriteLine(localizacaoX + " " + localizacaoY + " " + sentido);
            Console.ReadKey();


            //robo 2
            String comando2 = "MMDMMDMDDM";
            char sentido2 = 'L';
            int localizacaoX2 = 3;
            int localizacaoY2 = 3;

            char[] instrucoes2 = comando2.ToCharArray();

            for (int posicao2 = 0; posicao2 < instrucoes2.Length; posicao2++)
            {

                if (instrucoes2[posicao2] == 'M')
                {
                    if (sentido2 == 'N')
                    {
                        localizacaoY2 = localizacaoY2 + 1;
                    }
                    else if (sentido2 == 'S')
                    {
                        localizacaoY2 = localizacaoY2 - 1;
                    }
                    else if (sentido2 == 'L')
                    {
                        localizacaoX2 = localizacaoX2 + 1;
                    }
                    else if (sentido2 == 'O')
                    {
                        localizacaoX2 = localizacaoX2 - 1;
                    }
                }

                if (instrucoes2[posicao2] == 'E')
                {

                    if (sentido2 == 'N')
                    {
                        sentido2 = 'O';
                    }
                    else if (sentido2 == 'S')
                    {
                        sentido2 = 'L';
                    }
                    else if (sentido2 == 'L')
                    {
                        sentido2 = 'N';
                    }
                    else if (sentido2 == 'O')
                    {
                        sentido2 = 'S';
                    }
                }

                if (instrucoes2[posicao2] == 'D')
                {
                    if (sentido2 == 'N')
                    {
                        sentido2 = 'L';
                    }
                    else if (sentido2 == 'S')
                    {
                        sentido2 = 'O';
                    }
                    else if (sentido2 == 'L')
                    {
                        sentido2 = 'S';
                    }
                    else if (sentido2 == 'O')
                    {
                        sentido2 = 'N';
                    }
                }
            }
            Console.WriteLine(localizacaoX2 + " " + localizacaoY2 + " " + sentido2);
            Console.ReadKey();
        }

    }
}
        
    

