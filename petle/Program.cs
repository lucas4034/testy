using System;

namespace petle
{
    class Program
    {
        static void Main(string[] args)
        {


            /*
             *  pętle:
             *  for (int i=0; i<10;i++ )
             *      
             *      
             *      
             */
             for (int i=0;i<4;i++) //zmienna i istnieje tylko wewnątrz pętli;
            {
                Console.WriteLine("HELLo " + i);

            }

            int b = 1;


             for (;b<10;b++) //mozna pomijac elementy np for ( ; ;) <- petla nieskonczona
            {
                Console.WriteLine("Jedziemy z b " + b);
            }

            Console.WriteLine("Hello World!");

            // Console.WriteLine(i);
            Console.ReadLine();

        }
    }
}
