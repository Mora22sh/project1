namespace project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many Small and Large carpets need to be cleaned?");
            

            int S =Convert.ToInt32 (Console.ReadLine());
            int L = Convert.ToInt32 (Console.ReadLine());

            Console.WriteLine("Estimate for carpet cleaning service\r\n");

            Console.WriteLine($"Price per small room: $25\r\n Price per large room: $35\r\n");

            
            double cost = ( S * 25) + ( L * 35);
            double tax = cost * 0.06;
            double total = cost + tax;


            Console.WriteLine($"Cost: {cost} ");
            Console.WriteLine($"Tax: {tax}");
            Console.WriteLine($"Total estimate: {total}");
            Console.WriteLine("This estimate is valid for 30 days");









        }
    }
}
