namespace methods_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1 Area methods
            Console.WriteLine("Dairenin sahesi: " + Area(2));
            Console.WriteLine("Dairenin sahesi: " + Area(2,3));
            Console.WriteLine("Duzbucaqlinin sahesi: " + Area(2, 4f)); //Dairenin sahesinin 2 ci usulu ile tek ferqi datatype olduquna gore daxil ederken tipi qeyd edirik
            Console.WriteLine("Duzbucaqlinin sahesi: " + Area(2, b:4)); // yadaki parametr daxil ederken deyisenin adini qeyd etmeliyik 
            Console.WriteLine("Duzbucaqli paralelipipedin tam sethinin sahesi: " + Area(2, 3, 4));
            Console.WriteLine("Ucbucaqin daxiline cekilmis dairenin sahesi: "+Area(2,3,4,5));

            //Task a calculator method
            Calc(2, 3, '+');
            Calc(2, 3, '-');
            Calc(2, 3, '*');
            Calc(2, 3, '/');

            //Task b Pow method
            Console.WriteLine("Pow default qiymeti: "+Pow(3));
            Console.WriteLine("Pow: " + Pow(3, 4));

            //Task c Overload methods
            PrintInfo("Rusif");
            PrintInfo("Rusif", "Safarov");
            PrintInfo("Rusif", "Safarov","Mahir");


            //Sinifdeki task sade vuruqlara ayir
            Console.WriteLine("Sade vuruqlari: ");
            PrimeNum(12);

        }
        //TAsk 1
        static float Area(float radius)                             //Dairenin sahesini tapir  
        {
            int p = 3;
            return p * radius * radius;
        }

        static float Area(float radius, int p = 3)                 //Dairenin sahesini tapir  bu halda "p" ni float versek arqumentler duzbucaqlinin sahesi ile eyni olacaq
        {
            return p * radius * radius;
        }


        static float Area(float a, float b)                        //Duzbucaqlinin sahesini tapir
        {
            return a*b;
        }

        static float Area(float a, float b, float c)               //Duzbucaqli paralelipipedin tam sethinin sahesini tapir     
        {
            return 2 * (a * b + a * c + b * c);
        }
        static float Area(float a,float b, float c, float r)       //Ucbucaqin daxiline cekilmis dairenin sahesini tapir
        {
            return (PerimeterTriangle(a,b,c)/ 2)*r;
        }

        static float PerimeterTriangle(float a, float b, float c)  //ucbucaqin perimetrini tapir
        {
            return a+b+c;
        }


        //TAsk a
        static void Calc(float a, float b, char Operator)
        {
            switch (Operator)
            {
            
                case '+':
                    {
                    Console.WriteLine("2 ve 3 un cemi: " + (a+b));
                    break;
                    }
                case '-':
                    {
                    Console.WriteLine("2 ve 3 un ferqi: " + (a-b));
                        break;
                    }
                case '*':
                    {
                    Console.WriteLine("2 ve 3 un hasili: " + (a * b));
                    break;
                    }
                case '/':
                    {
                    Console.WriteLine("2 ve 3 un nisbeti: " + (a / b));
                    break;
                    }
            }
        }

        //TAsk b
        static int Pow(int n, int m=2)
        {
            int l = 1;
            for (int i = 0; i < m; i++)
            {
                l = l * n;
            }
            return l;
        }




        // Task c
        static void PrintInfo(string name)
        {
            Console.WriteLine(name);
        }
        static void PrintInfo(string name, string surname)
        {
            Console.WriteLine(surname+" "+ name);
        }
        static void PrintInfo(string name, string surname, string FName)
        {
            Console.WriteLine(name[0]+". "+surname+" "+FName);
        }


     




        //Sinifdeki task  sade vuruqlara ayir
        static void PrimeNum(int n)
        {
            int i = 2;
            for (; true;)
            {

                if (n == 1)
                {
                    break;
                }
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                    n = n / i;
                }
                else
                {
                    i++;
                }
            }
        }



    }
}