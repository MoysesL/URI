using System; 

class URI {

    static void Main(string[] args) { 

            int numberCases = int.Parse(Console.ReadLine());
            int j = 0;

            for (var i = 0; i < 1000; i++)
            {
                if (j >= numberCases)
                {
                    j = 0;
                }

                Console.Write("N[{0}] = {1}\n", i, j);
                j++;
            }

    }

}