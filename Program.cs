namespace longest_word_finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter three words: ");
            string words = Console.ReadLine();

            string c1 = words.Split(' ')[0];
            string c2 = words.Split(' ')[1];
            string c3 = words.Split(' ')[2];

            int k1 = c1.Length;
            int k2 = c2.Length;
            int k3 = c3.Length;

            if (k1 > k2 && k1 > k3)
            {
                Console.WriteLine("The longest word is {0}", c1);
            }
            else if (k2 >= k1)
            {
                Console.WriteLine("The longest word is {0}", c2);
            }
            else
            {
                Console.WriteLine("The longest word is {0}", c3);
            }
        }   
    }
}
