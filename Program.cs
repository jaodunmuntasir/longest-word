namespace Program9
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
            //string k3 = Convert.ToString(c3.Length);
            //Console.WriteLine(k3);
            //int x = 1;

            /*bool b1 = true;
            bool b2 = true;*/
            /*while (k1 == k1)
             {
                 if (k1 > k2 && k1 > k3)
                 {
                     Console.WriteLine("The longest word is {0}", c1);
                     break;
                 }
            //Console.WriteLine("The longest word is {0}", c1);
                 if (k2 > k3 && k2 > k1)
                 {
                     Console.WriteLine("The longest word is {0}", c2);
                     break;
                 }
            //Console.WriteLine("The longest word is {0}", c2);
                 if (k3 > k1 && k3 > k2)
                 {
                     Console.WriteLine("The longest word is {0}", c3);
                     break;
                 }
            //Console.WriteLine("The longest word is {0}", c3);
                break;
            }*/

            //string output = "";

            /*if (k1 > k2 && k1 > k3)
            {
                //output = c1;
                Console.WriteLine("The longest word is {0}", c1);
                //break;
            }
            else if (k2 > k3 && k2 > k1)
            {
                //output = c2;
                Console.WriteLine("The longest word is {0}", c2);
                //break;
            }
            else if (k3 > k1 && k3 > k2)
            {
                //output = c3;
                Console.WriteLine("The longest word is {0}", c3);
                //break;
            }*/

            //Console.WriteLine("The longest word is {0}", output);

            /*for (int i = 0; i < 1; i++)
            {
                if (k1 > k2 && k1 > k3)
                {
                    //Console.WriteLine("The longest word is {0}", c1);
                    break;
                }
                Console.WriteLine("The longest word is {0}", c1);
                if (k2 > k3 && k2 > k1)
                {
                    //Console.WriteLine("The longest word is {0}", c2);
                    break;
                }
                Console.WriteLine("The longest word is {0}", c2);
                if (k3 > k1 && k3 > k2)
                {
                    //Console.WriteLine("The longest word is {0}", c3);
                    break;
                }
                Console.WriteLine("The longest word is {0}", c3);
            }*/

            //int count = 0;

            /*foreach (string c in wordsagain)
            {
                count++;
                Console.WriteLine("{0}", count);
            }*/

            /*if (k1 > 1)
            {
                if (k1 > k2 && k1 > k3)
                {
                    //output = c1;
                    Console.WriteLine("The longest word is {0}", c1);
                    //break;
                    goto SkipToEnd;
                }
                else if (k2 > k3 && k2 > k1)
                {
                    //output = c2;
                    Console.WriteLine("The longest word is {0}", c2);
                    //break;
                    goto SkipToEnd;
                }
                else if (k3 > k1 && k3 > k2)
                {
                    //output = c3;
                    Console.WriteLine("The longest word is {0}", c3);
                    //break;
                    goto SkipToEnd;
                }
            }
                SkipToEnd:
                Console.WriteLine("Thank you");*/

            /*while (k1 > k2 && k1 > k3)
            {
                Console.WriteLine("The longest word is {0}", c1);
                break;
            }

            while (k2 > k3 && k2 > k1)
            {
                Console.WriteLine("The longest word is {0}", c2);
                break;
            }

            while (k3 > k1 && k3 > k2)
            {
                Console.WriteLine("The longest word is {0}", c3);
                break;
            }*/

            /*if (k1 > k2 && k1 > k3)
            {
                Console.WriteLine("The longest word is {0}", c1);  
            }
            if (k2 > k3 && k2 > k1)
            {
                Console.WriteLine("The longest word is {0}", c2);
            }
            if (k3 > k1 && k3 > k2)
            {
                Console.WriteLine("The longest word is {0}", c3);
            }*/

            /*string m1 = Convert.ToString(k1);
            string m2 = Convert.ToString(k2);
            string m3 = Convert.ToString(k3);

            string[] m = {m1, m2, m3};

            int max = Convert.ToInt32(m.Max());

            //Console.WriteLine(" " + max);

            if (max == k1)
                Console.WriteLine("The longest word is " + c1);
            else if (max == k2)
                Console.WriteLine("The longest word is " + c2);
            else if (max == k3)
                Console.WriteLine("The longest word is " + c3);*/
/*
            if (k1 > k2 && k1 > k3)
            {
                Console.WriteLine("The longest word is {0}", c1);
                
            }
            //Console.WriteLine("The longest word is {0}", c1);
            else if (k2 > k3 && k2 > k1)
            {
                Console.WriteLine("The longest word is {0}", c2);
                
            }
            //Console.WriteLine("The longest word is {0}", c2);
            else if (k3 > k1 && k3 > k2)
            {
                Console.WriteLine("The longest word is {0}", c3);
                
            }*/

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