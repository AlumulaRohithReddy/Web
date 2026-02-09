namespace Delegatesdemo
{
    internal class Program
    {
        delegate void Print();
        class Money
        {
            protected int note;
            protected int coin;
            public Money(int n, int c)
            {
                this.note = n;
                this.coin = c;
            }
        }
        class Rupee : Money
        {
            public Rupee(int rupees, int paise) : base(rupees, paise) { }
            public void Display()
            {
                Console.WriteLine("Rs.{0}.{1}", note, coin);
            }
        }
        class Dollar : Money
        {
            public Dollar(int dollar, int cent) : base(dollar, cent) { }
            public void Info()
            {
                Console.WriteLine("${0}.{1}", note, coin);
            }
        }
        class Pound : Money
        {
            public Pound(int pound, int cent) : base(pound, cent) { }
            public void Info()
            {
                Console.WriteLine("£{0}.{1}", note, coin);
            }
        }
        class Test
        {
            static void write(Print[] p)
            {
                p[0]();
                p[1]();
                p[2]();
            }
            static void Main(string []Args)
            {
                Rupee m1 = new Rupee(1000, 55); 
                Dollar m2 = new Dollar(100, 75); 
                Pound m3=new Pound(123, 100);
                Print[] p = new Print[3];
                p[0] = new Print(m1.Display); 
                p[1] = new Print(m2.Info);
                p[2] = new Print(m3.Info);
                write(p);
            }
            
        }
    }
}
