using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Lesson_2
{
    class Question
    {
        public void q1()
        {
            int[] A = new int[5];
            double[,] B = new double[3, 4];
            int a;
            double maximum = 0.0;
            char maxLetter = 'E';
            double minimum = 1000000;
            char minLetter = 'E';
            double sum = 0;
            int sumA = 0;
            double mul = 0;
            double sumB = 0;
            for (int i = 0; i< 5; i++)
            {
                Console.WriteLine("Enter value: \n");
                a = Convert.ToInt32(Console.ReadLine());
                A[i] = a;
                
            }
            var rnd = new Random();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int s = rnd.Next(100);
                    int q = rnd.Next(100);
                    B[i, j] = Math.Round(Convert.ToDouble(s)/Convert.ToDouble(q), 3);
                }
            }
            for (int i = 0; i < 5; i++)
            {
                Console.Write(Convert.ToString(A[i])+ "  ");
                if(A[i] > maximum)
                {
                    maximum = A[i];
                    maxLetter = 'A';
                }
                if (A[i] < minimum)
                {
                    minimum = A[i];
                    minLetter = 'A';
                }
                sum = sum + A[i];
                if (i == 0)
                {
                    mul = A[i];
                }
                else
                {
                    mul = mul * A[i];
                }
                if (A[i]%2 == 0)
                {
                    sumA += A[i];
                }

            }
            Console.WriteLine("\n", "\n");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(Convert.ToString(B[i, j])+ "  ");
                    if (B[i, j] > maximum)
                    {
                        maximum = B[i, j];
                        maxLetter = 'B';
                    }
                    if (B[i, j] < minimum)
                    {
                        minimum = B[i, j];
                        minLetter = 'B';
                    }
                    sum = sum + B[i, j];
                    mul = mul * B[i, j];
                    if(j%2 != 0)
                    {
                        sumB += B[i, j];
                    }
                }
                Console.WriteLine("\n");


            }
            Console.WriteLine("Maximum is "+ Convert.ToString(maximum)+ " from array "+ maxLetter);
            Console.WriteLine("Minimum is "+ Convert.ToString(minimum)+ " from array "+ minLetter);
            Console.WriteLine("Sum is "+ Convert.ToString(Math.Round(sum, 3)));
            Console.WriteLine("Product of multiplication is "+ Convert.ToString(Math.Round(mul, 3)));
            Console.WriteLine("Sum  of even numbers in array A is "+ Convert.ToString(sumA));
            Console.WriteLine("Sum  of odd columns in array B is "+ Convert.ToString(Math.Round(sumB, 3)));
        }

        public void q2()
        {
            int[,] arr = new int[5, 5];
            int min = 101;
            int max = -101;
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arr[i,j] = rnd.Next(-100, 100);
                    Console.Write(Convert.ToString(arr[i,j]+ "\t"));
                    if (arr[i, j]< min)
                    {
                        min = arr[i,j];
                    }
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                    }
                }
                Console.WriteLine("\n");


            }
            bool toggle = false;
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (arr[i, j] == min)
                    {
                        toggle = true;
                    }
                    if (arr[i, j] == max)
                    {
                        toggle = false;
                    }
                    if(toggle == true)
                    {
                        sum += arr[i, j];
                    }
                }
            }
            Console.WriteLine("Maximum is " + Convert.ToString(max));
            Console.WriteLine("Minimum is " + Convert.ToString(min));
            Console.WriteLine("Sum between Min and Max is " + Convert.ToString(sum));

        }

        public void q3()
        {
            char[] str;
            string input;
            int key;
            string choice = "e";
            bool dum = true;
            Console.WriteLine("Enter text:");
            input = Console.ReadLine();
            str = input.ToCharArray();
            Console.WriteLine("Enter key:");
            key = Convert.ToInt32(Console.ReadLine());
            while (dum)
            {
                Console.WriteLine("Do you want to:\na- Encrypt\nb- Decrypt");
                choice = Console.ReadLine();
                if (choice == "a" || choice == "b")
                {
                    dum = false;break;
                }
                else
                {
                    Console.WriteLine("ERROR. Wrong input.");
                }
            }
            if(choice == "b")
            {
                key = key * -1;
            }

            for(int i = 0; i < str.Length;i++) 
            {
                char letter = str[i];
                
                if (letter <= 'z' && letter >='a') {
                    letter = (char)(letter + key);
                    if(letter > 'z')
                    {
                        letter = (char)(letter - 26);
                    }
                    if (letter < 'a')
                    {
                        letter = (char)(letter + 26);
                    }
                }
                else if (letter <= 'Z' && letter >= 'A')
                {
                    letter = (char)(letter + key);
                    if (letter > 'Z')
                    {
                        letter = (char)(letter - 26);
                    }
                    if (letter < 'A')
                    {
                        letter = (char)(letter + 26);
                    }
                }
                
                
                str[i] = letter;

            }
            Console.WriteLine(str);
        }
        static int[,] fill(int[,] arr)
        {
            Console.WriteLine("a)");
            arr[0, 0] =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b)");
            arr[0, 1] =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("c)");
            arr[1, 0] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b)");
            arr[1, 1] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            return arr;
        }
        static void display(int[,] arr)
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("|" + Convert.ToString(arr[i, 0]) + "\t" + Convert.ToString(arr[i, 1]) + "|");
            }
        }
        public void q4()
        {
            int[,] A = new int[2, 2];
            int[,] B = new int[2, 2];
            int[,] C = new int[2, 2];
            string choice;
            Console.WriteLine("Enter values for matrix A: \n\t|a b|\n\t|c d|");
            A = fill(A);
            Console.WriteLine("What do you want to do to the matrix?\n1- Multiply it by integer\n2- Add 2 matrices together\n3- Multiply 2 matrices together");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine("\nA:");
                display(A);
                Console.WriteLine("Enter integer value to multiply by");
                int val = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        A[i, j] = A[i, j] * val;
                    }
                }
                Console.WriteLine("Result:");
                display(A);


            }
            else
            {


                Console.WriteLine("Enter values for matrix B: \n\t|a b|\n\t|c d|");
                B = fill(B);
                Console.WriteLine("\nA:");
                display(A);
                Console.WriteLine("\nB:");
                display(B);
                if(choice == "2")
                {
                    for (int i = 0; i < 2; i++)
                    {
                        for (int j = 0; j < 2; j++)
                        {
                            A[i, j] = A[i, j] + B[i, j];
                        }
                    }
                    Console.WriteLine("\nResult:");
                    display(A);
                }
                else if (choice == "3")
                {
                    
                    C[0, 0] = (A[0, 0] * B[0, 0]) + (A[0, 1] * B[1, 0]);
                    C[0, 1] = (A[0, 0] * B[0, 1]) + (A[0, 1] * B[1, 1]);
                    C[1, 0] = (A[1, 0] * B[0, 0]) + (A[1, 1] * B[1, 0]);
                    C[1, 1] = (A[1, 0] * B[0, 1]) + (A[1, 1] * B[1, 1]);

                    Console.WriteLine("\nResult:");
                    display(C);
                }
            }

        }

        public void q5()
        {
            char[] str;
            string input;
            bool flagErr = false;
            bool flagCont = true;
            bool flagSec = true;
            Console.WriteLine("Enter question (only + and - symbols and integers are supported):");
            input = Console.ReadLine();
            str = input.ToCharArray();
            int sum= 0;
            int val = 0;
            char oper = ']';
            for(int i = 0; i < str.Length; i++)
            {
                flagCont = true;
                if (str[i] >= '0' && str[i] <= '9')
                {
                    val = str[i]-'0';
                    while (flagCont)
                    {


                        if (i < str.Length - 1)
                        {
                            i++;
                            if (str[i] >= '0' && str[i] <= '9')
                            {
                                val = (val * 10) + str[i] - '0';
                            }
                            else
                            {
                                i--;
                                flagCont = false;

                            }
                        }
                        else
                        {
                            flagCont = false;
                        }
                    }

                flagSec = true;
                }
                if(flagSec == true)
                {
                    if (oper == ']')
                    {
                        sum = val;
                    }
                    if (oper == '-')
                    {
                        sum = sum - val;
                    }
                    if (oper == '+')
                    {
                        sum = sum + val;
                    }

                    flagSec = false;
                }
                else 
                {


                    if (str[i] == '-')
                    {
                        oper = '-';

                    }
                    if (str[i] == '+')
                    {
                        oper = '+';

                    }

                }
            
            }
            Console.WriteLine("Result: "+Convert.ToString(sum));
        }

        public void q6()
        {
            char[] str;
            string input;
            Console.WriteLine("Enter line: ");
            input = Console.ReadLine();
            str = input.ToCharArray();
            bool flag = false;
            for (int i = 0; i < str.Length; i++)
            {

                if (str[i] == '.' && (str[i+2]>='a' && str[i+2]<='z'))
                {
                    flag = true;
                }
                    if (((str[i] <= 'z' && str[i] >= 'a')&&flag ==true) || (str[i] == 'i'))
                    {
                    
                        int letter = str[i];
                    letter = 'A' + (letter - 'a');

                    str[i] = (char)letter;
                    flag = false;

                    }
                
                if (i == 0 && str[i]!= 'I')
                {
                    int letter = str[i];
                    letter = 'A' + (letter - 'a');

                    str[i] =(char)letter;

                }
            }
            input = new string(str);
            Console.WriteLine("Result: \n" + input);
        }
        public void q7()
        {
            char[] str;
            string input;
            string bad1 = " ";
            string bad2 = "";
            int count = 0;
            Console.WriteLine("Enter line: ");
            input = Console.ReadLine();
            string check = input;
            Console.WriteLine("Enter word to censor: ");
            bad1 = Console.ReadLine();
            for(int i = 0; i < bad1.Length; i++)
            {
                bad2 = bad2 + "*";
            }
            input = input.Replace(bad1, bad2);
            bool flag = false;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '*')
                {
                    flag= true;
                    while (flag)
                    {
                        if( i != input.Length-1)
                        {
                            i++;
                        }
                        else
                        {
                            break;
                        }
                        if (input[i] != '*')
                        {
                            flag = false;
                        }
                    }
                    count++;
                }
            }
            Console.WriteLine("Result: \n" + input+"\n Replaced: "+Convert.ToString(count)+" words " + bad1);
        }
    }

}
