namespace Events
{
    internal class Program
    {
        class ProduceMango
        {
            public event EventHandler<MangoEventArgs> MangoInfo; string Mango;
            public ProduceMango(string type)
            {
                Mango = type;
            }
            public void FreshLot()
            {
                int i = new Random().Next(1000); 
                string mangoinfo = i + " " + Mango + " mangoes produced "; 
                Console.WriteLine(mangoinfo); if (MangoInfo != null)
                {
                    MangoInfo(this, new MangoEventArgs(Mango, i));
                }
            }
        }
        class MangoEventArgs : EventArgs
        {
            public MangoEventArgs(string type, int number)
            {
                MangoInfo = type;
                Number = number;
            }
            public string MangoInfo { get; private set; }
            public int Number { get; private set; }
        }
        class ConsumeMango
        {
            public void SqueeezeMango(object sender, MangoEventArgs e)
            {
                Console.WriteLine("Squeezing " + e.Number
                + " of " + e.MangoInfo + " mangoes");
            }
        }
        static void Main(string[] args)
        {
            {
                ConsumeMango Slice = new ConsumeMango(); 
                ProduceMango SalemFarms = new ProduceMango("Alphanso");
                // Slice registers event with SalemFarms
                SalemFarms.MangoInfo += Slice.SqueeezeMango;
                SalemFarms.FreshLot();
            }
        }
    }
}
