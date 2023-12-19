class Program 
{
    public static void Main(string[] args)
    {
        int Choise = -1; 
        while (Choise!=0)
        {
            Console.WriteLine("Nhap mot ky tu tu ban phim: "); 
            Console.WriteLine("1. Draw the triangle: ");
            Console.WriteLine("2. Draw the square: ");
            Console.WriteLine("3. Draw the rectangle: ");
            Console.WriteLine("0. Exit ");
            Console.WriteLine("Enter your choice: ");
            Choise = Convert.ToInt32(Console.ReadLine());
            switch (Choise)
            {
                case 1: 
                {
                    Console.WriteLine("************");
                    Console.WriteLine("**********");
                    Console.WriteLine("********");
                    Console.WriteLine("*******");
                    Console.WriteLine("******");
                    Console.WriteLine("*****");
                    Console.WriteLine("****");
                    Console.WriteLine("***");
                    Console.WriteLine("**");
                    Console.WriteLine("*");
                }
                break;
                case 2:
                {
                    Console.WriteLine("************");
                    Console.WriteLine("************");
                    Console.WriteLine("************");
                    Console.WriteLine("************");
                    Console.WriteLine("************");
                }
                break;
                case 3:
                {
                    Console.WriteLine("************");
                    Console.WriteLine("************");
                    Console.WriteLine("************");
                }
                break;
                case 4:
                {
                    Environment.Exit(0);
                    
                }
                break;

                default: Console.WriteLine("Nhap lai");
                break;
            }
        }
    }
}