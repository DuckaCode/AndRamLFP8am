namespace Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OPERADORES
            //Operadores Numericos
            //Cambio de signo
            int num1 = 5;
            int num2 = -num1;
            int num3 = +num2;
            int num4 = -num3;
            
            Console.WriteLine(num1 + "//"+num2+"//"+num3+"//"+num4);


            //Aritmeticos

            int num5 = 3 + 5;//suma
            Console.WriteLine(num5);
            int num6 = 100 - 26;//resta 
            Console.WriteLine(num6);
            int num7 = 4 * 2;//producto
            Console.WriteLine(num7);
            float num8 = 5f / 3f;//division
            /*float num8 = 5 / 3f;
            float num8 = 5f / 3;
            float num8 = (float) 5 / 3;*/
            Console.WriteLine(num8);
            double num9 = 100f / 4;
            Console.WriteLine(num9);
            decimal num10 = 50m / 6;
            Console.WriteLine(num10);

            //incremento decremento
            num10++; //num10 = num10 + 1; incremento
            Console.WriteLine(num10);
            num1--;//num1= num1 - 1; decremento
            Console.WriteLine(num1);
            num2 += 5;// num2= num2 + 5;
            Console.WriteLine(num2);
            num3 -= 5;// num3= num3 - 5;
            Console.WriteLine(num3);
            num4 *= 5;// num4= num4 * 5;
            Console.WriteLine(num4);
            num5 /= num1;// num5= num5 / num1;
            Console.WriteLine(num5);


            //ordende evaluacion operadores aritmeticos
            float num11 = 4f * 3 / 2;
            Console.WriteLine(num11);
            float num12 = 4 / 3 * 2f;
            Console.WriteLine(num12);
            float num13 = (4 * 3) / 2;
            Console.WriteLine(num13);
            float num14 = 4 + 6 * 2;
            Console.WriteLine(num14);
            float num15 = 4 + 6 * (2 - 1);
            Console.WriteLine(num15);


            //OPERADORES LOGICOS

            //Conjuncion - AND - y - &&
            Console.WriteLine("TABLA DE VERDAD CONJUNCION");
            Console.WriteLine($"V && V ={true && true}");
            Console.WriteLine($"V && F ={true && false}");
            Console.WriteLine($"F && V ={false && true}");
            Console.WriteLine($"F && F ={false && false}");


            //Disjuncion - OR - ||
            Console.WriteLine("TABLA DE VERDAD CONJUNCION");
            Console.WriteLine($"V || V ={true || true}");
            Console.WriteLine($"V || F ={true || false}");
            Console.WriteLine($"F || V ={false || true}");
            Console.WriteLine($"F || F ={false || false}");

            bool exp1 = true;
            bool exp2 = false;
            bool exp3 = exp1 && exp2;
            bool exp4 = !exp2;
            bool exp5 = !exp3 || exp4;
            Console.WriteLine($"exp1={exp1}, exp2={exp2}, exp3={exp3}, exp4={exp4}, exp5={exp5}");
            //console.readkey();


        }
    }
}
