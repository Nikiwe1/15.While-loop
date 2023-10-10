namespace _15.While_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int index = 0;

            Console.WriteLine("This is the while loop");
            while (index <= 5) {

                Console.WriteLine(index);
                index++;

                Console.WriteLine("This is a do while loop");

                int index2 = 0;
                do { Console.WriteLine(index2); } while (index2 <= 5);

                Console.ReadLine();
            }
        }
    }
}