namespace Topic_3___Variables___Assignemt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Teddy
            String learning = "I am learning a bit about Computer Science", firstName, lastName;
            firstName = "Teddy";
            lastName = "Becker";
            int room, gradYear;
            room = 29;
            gradYear = 2028;
            const double Pi = 3.14, Radius = 5;
            double item1Price = 2.99, area = Pi * Radius * Radius;
            

            Console.WriteLine("This is room " + room);
            Console.WriteLine("The price is " + item1Price);
            Console.WriteLine(learning);

            Console.WriteLine("My name is " + firstName + " " + lastName + " and I'll graduate in " + gradYear + ".");
            Console.WriteLine("The area of this circle is " + area);   

        }
    }
}
