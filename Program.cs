namespace RealEstate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<RealEstate> list = new List<RealEstate>();

            int inputsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputsCount; i++)
            {
                string city = Console.ReadLine();
                string street = Console.ReadLine();
                int roomsCount = int.Parse(Console.ReadLine());
                double price = double.Parse(Console.ReadLine());

                RealEstate re = new RealEstate(city, street, roomsCount, price);
                list.Add(re);
            }

            string filterCity = Console.ReadLine();

            foreach (RealEstate re in list)
            {
                if (re.City == filterCity)
                {
                    Console.WriteLine($"{re.Street} {re.RoomsCount} £{re.Price}");
                }
            }
        }
    }
}