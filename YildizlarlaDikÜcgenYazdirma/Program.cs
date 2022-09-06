namespace YildizlarlaDikÜcgenYazdirma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dik ücgen yazdirma
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();    
            }

            // Ters dik ücgen yazdirma
            for (int i = 0; i < 5; i++)
            {
                for (int k = 5; k >= i; k--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}