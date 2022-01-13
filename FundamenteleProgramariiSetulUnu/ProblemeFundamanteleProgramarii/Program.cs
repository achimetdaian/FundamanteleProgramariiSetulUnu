using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemeSet1
{
    class Program
    {
        static void p1()
        {
            float a, b, x;
            Console.WriteLine("Dati valoare lui a");
            a = float.Parse(Console.ReadLine());

            Console.WriteLine("Dati valoare lui b");
            b = float.Parse(Console.ReadLine());

            if (a != 0)
            {
                x = -b / a;
                Console.WriteLine("Valoarea necunoscuta este {0}", x);
            }
            else
                Console.WriteLine("Nu este ecuatie!");
            Console.ReadLine();
        }
        static void p2()
        {
            double a, b, c;
            Console.WriteLine("Dati valoare lui a");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Dati valoare lui b");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Dati valoare lui c");
            c = double.Parse(Console.ReadLine());


            if ( a == 0)
            {
                if (b == 0)
                    Console.WriteLine("Nu este ecuatie");
                else
                {
                    double x;
                    x = (-c / b);
                    Console.WriteLine("Solutia este {0}", x);
                }

            }
            else
            {
                double delta = b * b - (4 * a * c);
                if(delta == 0)
                {
                    double x = -b / 2 * a;
                }
                else if (delta < 0)
                    Console.WriteLine("Nu are solutie reala");
                else
                {
                    double x1, x2;
                    x1 = (-b + Math.Sqrt(delta)) / 2 * a;
                    x2 = (-b - Math.Sqrt(delta)) / 2 * a;
                    Console.WriteLine("Solutiile sunt {0} si {1}", x1, x2);

                }
            }
        }
        static void p3()
        {
            int x,k;
            Console.WriteLine("Dati valoare lui x");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati valoare lui k");
            k = int.Parse(Console.ReadLine());
            if(x % k == 0)
            Console.WriteLine("{0} se divide la {1}",x,k);
            else 
            Console.WriteLine("{0} nu se divide la {1}",x,k);
            Console.ReadLine();
        }
        static void p4()
        {
            int y;
            Console.Write("Dati anul curent\n>>> ");
            y = int.Parse(Console.ReadLine());

            if(y % 4 == 0)
            {
                if (y % 100 != 0)
                    Console.WriteLine("Anul {0} este an bisect.", y);
                else
                {
                    if (y % 400 == 0)
                        Console.WriteLine("Anul {0} este an bisect.", y);
                    else
                        Console.WriteLine("Anul {0} este an obisnuit.", y);
                }
            }
             else
                 Console.WriteLine("Anul {0} este an obisnuit", y);
            Console.ReadLine();
        }

        static bool apartine(int k, int n)
        {
            int cifre=0;
            while(n!=0)
            {
                n/=10;
                cifre++;
            }
            if(cifre>=k)
                return true;
            return false;
        }
        static void p5()
        {
            int n, k;
            Console.Write("Dati valoarea lui n: ");
            n=int.Parse(Console.ReadLine());
            
            Console.Write("\nDati valoarea lui k: ");
            k=int.Parse(Console.ReadLine());

            if(apartine(k,n)==true)
            {
                int copie_k=k, copie_n=n;
                while(k!=1)
                {
                    n/=10;
                    k--;
                }
                Console.WriteLine("Al {0}-lea cifra al numarului {1} este {2}",copie_k, copie_n, n%10);
            }
            else
                Console.WriteLine("Numarul nu are cel putin {0} termeni ",k);
            Console.ReadLine();
        }

        static void schimbare(ref float a,ref float b)
        {
            float aux=a;
            a=b;
            b=aux;
        }
        static void p7()
        {
            float a, b;
            Console.Write("Dati valoarea lui a: ");
            a=float.Parse(Console.ReadLine());
            
            Console.Write("\nDati valoarea lui b: ");
            b=float.Parse(Console.ReadLine());


            schimbare(ref a,ref b);
            Console.WriteLine("Valorile dupa swap sunt {0} si {1} ", a,b);
            Console.ReadLine();

        }
        static void schimbare_maibuna(ref float x,ref float y)
        {
            x=x+y;
            y=x-y;
            x=x-y;
        }
        static void p8()
        {
            float a, b;
            Console.Write("Dati valoarea lui a: ");
            a=float.Parse(Console.ReadLine());
            
            Console.Write("\nDati valoarea lui b: ");
            b=float.Parse(Console.ReadLine());


            schimbare_maibuna(ref a,ref b);
            Console.WriteLine("Valorile dupa swap sunt {0} si {1} ", a,b);
            Console.ReadLine();

        }
        static void p9()
        {
            int n;
            Console.Write("Dati valoarea lui n: ");
            n=int.Parse(Console.ReadLine());

            int div=2;
            Console.WriteLine("Divizorii lui {0} sunt: ", n);
            Console.Write("1, ");
            while(div*div<=Math.Sqrt(n))
            {
                if(n%div==0)
                    Console.Write("{0}, ",div);
                div++;
            }
            Console.Write("{0}", n);
            Console.ReadLine();
        }

        static void p10()
        {
            int n;
            Console.Write("Dati valoarea lui n: ");
            n=int.Parse(Console.ReadLine());

            int div=2;
            if(n==0 || n==1)
                Console.WriteLine("Numarul {0} nu este prim ",n);
            else if(n%div==0 && div!=n)
                Console.WriteLine("Numarul {0} nu este prim", n);
            else
            {
                bool prim=true;
                div=3;
                while(div<n/2)
                {
                    if(n%div==0)
                    {
                        prim=false;
                        break;
                    }
                    div+=2;
                }
                if(prim==true)
                    Console.WriteLine("Numarul {0} este prim",n);
                else
                    Console.WriteLine("Numarul {0} nu este prim",n);
            }
            Console.ReadLine();
        }
        static void p11()
        {
            int n;
            Console.Write("Dati valoarea lui n: ");
            n=int.Parse(Console.ReadLine());

            Console.Write("Cifrele numarului sunt: ");
            while(n!=0)
            {
                Console.Write("{0} ", n%10);
                n=n/10;
            }
            Console.ReadLine();

        }

        static void p12()
        {
            int a, b, n, s=0;
            Console.Write("Dati valoarea lui a: ");
            a=int.Parse(Console.ReadLine());

            Console.Write("Dati valoarea lui b: ");
            b=int.Parse(Console.ReadLine());

            Console.Write("Dati valoarea lui n: ");
            n=int.Parse(Console.ReadLine());

            for(int i=a; i<=b; i++)
            {
                if(i%n==0)
                    s++;
            }

            Console.WriteLine("Numarul de numere intregi divizibile la {0} este {1}",n,s);
            Console.ReadLine();
        }

        static bool verificare_an_bisect(int y)
        {
            if(y % 4 == 0)
            {
                if (y % 100 != 0)
                    return true;
                else
                {
                    if (y % 400 == 0)
                        return true;
                    else
                        return false;
                }
            }
             else
                 return false;
        }
        
        static void p13()
        {
            int y1, y2;
            Console.WriteLine("Dati primul an: ");
            y1=int.Parse(Console.ReadLine());

            Console.WriteLine("Dati al doilea an: ");
            y2=int.Parse(Console.ReadLine());

            if(y1>y2)
            {
                y1=y1+y2;
                y2=y1-y2;
                y1=y1-y2;
            }

            int caut=y1, suma=0;
            while(caut<=y2)
            {
                if(verificare_an_bisect(caut)==true)
                {
                    for(int i=caut; i<=y2; i+=4)
                    {
                        suma++;
                    }
                    break;
                }
                caut++;
            }
            Console.WriteLine("Exista {0} ani bisecti intre {1} si {2}.",suma,y1,y2);
            Console.ReadLine();
            
        }

        static int oglindit(int n) //returneaza oglinditul(inversul) lui n
        {
            int rezultat=0;
            while(n!=0)
            {
                rezultat=rezultat*10+n%10;
                n/=10;
            }
            return rezultat;
            Console.ReadLine();
        }

        static void p14()
        {
            int n;
            Console.WriteLine("Dati valoarea lui n: ");
            n=int.Parse(Console.ReadLine());

            if(oglindit(n)==n)
                Console.WriteLine("Numarul {0} este palindrom. ",n);
            else
                Console.WriteLine("Numarul {0} nu este palindrom. ", n);
            Console.ReadLine();
        }

        static void schimbare_mai_mic(ref int x, ref int y)//schimba valorile dintre x si y daca x este mai mare decat y
        {
            if(x>y)
            {
                x=x+y;
                y=x-y;
                x=x-y;
            }
        }
        
      
        
        static void Main(string[] args)
        {
            //p1();
            //p2();
            //p3();
            //p4();
            //p5();
            //p7();
            //p8();
            //p9();
            //p10();
            //p11();
            //p12();
            //p13();
            p14();
        }

    }
}
