namespace JCD1._5._2
{
    internal class Program
    {
        static void Main()
        {
            //Criar uma matriz para armazenar os números 
            int[] numeros = new int[5];

            //Receber cinco números do usuário
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Digite o número {0}: ", i + 1);
                numeros[i] = int.Parse(Console.ReadLine());
            }

            //Ordenar a matriz
            Array.Sort(numeros);

            //Exibir os números ordenados
            Console.WriteLine("\nNúmeros ordenados:");
            foreach (var numero in numeros)
            {
                Console.Write(numero + " ");
            }

            Console.ReadLine();
        }
    }
}