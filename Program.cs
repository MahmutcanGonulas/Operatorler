using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //atama ve işlemli atama
            int x=3;
            int y=3;
            Console.WriteLine("x --> {0}\ny--> {1}",x,y);
            y=y+2;
            //işlemli atama
            y+=2;
            y/=3;
            x*=2;
            Console.WriteLine("x --> {0}\ny--> {1}",x,y);

            //Mantıksal Operatorler ||,&&, !
            bool isSuccess=true;
            bool isCompleted=false;
            if(isSuccess &&  isCompleted){
                Console.WriteLine("Perfect");
            }
            if(isSuccess ||  isCompleted){
                Console.WriteLine("|| Perfect");
            }
            if(isSuccess &&  !isCompleted){
                Console.WriteLine("&&! Perfect");
            }

            //ilişkisel operatorler
            // <, > ,<= ,>= , ==,!=

            int a=3;
            int b=4;
            bool result=a<b;
            Console.WriteLine("a<b == {0}",result);
            result=a>b;
            Console.WriteLine("a>b == {0} ",a>b);
            result= a==b;
            Console.WriteLine("a==b == {0} ",a==b);
            result= a!=b;
            Console.WriteLine("a!=b == {0} ",result);


            //Aritmetik Operatorler
            // /,*,+,-,%
            int sayi1=10;
            int sayi2=5;
            int result2=sayi1/sayi2;
            Console.WriteLine("/ {0}",result2);
            result2=sayi1+sayi2;
            Console.WriteLine("+ {0}",result2);
            result2=sayi1%sayi2;
            Console.WriteLine("% {0}",result2);
            result2=sayi1*sayi2;
            Console.WriteLine("* {0}",result2);

            
        }
    }
}