using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Lesson_2
{
    class Program
    {
        static void run(Question use)
        {
            string choice = "";
            bool dum = true;
            Console.WriteLine("Enter number to choose a Question:\n1- 1d 1nd 2d array\n2- 2d array\n3- Caesar cipher\n4- Matrix\n5- Algoritm\n6- Add capital letters\n7- Censor text\n8 - *EXIT*:\n");
            choice = Console.ReadLine();
            if(choice == "1")
            {
                use.q1();
            }
            else if (choice == "2")
            {
                use.q2();
            }
            else if (choice == "3")
            {
                use.q3();
            }
            else if (choice == "4")
            {
                use.q4();
            }
            else if (choice == "5")
            {
                use.q5();
            }
            else if (choice == "6")
            {
                use.q6();
            }
            else if (choice == "7")
            {
                use.q7();
            }

        }
        static void Main()
        {

            run(new Question());
        }
    }
}
