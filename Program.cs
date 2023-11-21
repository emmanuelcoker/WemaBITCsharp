using WemaBITCsharp.Models;

namespace WemaBITCsharp
{
    public class UserPaymentApp
    {
        public static void Main(string[] args)
        {
            
            //create user
            Users newUser = new Users();
            newUser.FirstName = "John";
            newUser.LastName = "Snow";  
            newUser.CreateUser();

            newUser.FirstName = "Mary";
            newUser.LastName = "Doe";
            newUser.CreateUser();

            newUser.FirstName = "Bruce";
            newUser.LastName = "Wayne";
            newUser.CreateUser();


            Payment newPayment = new Payment();

            Console.WriteLine("User Records: ");
            //show all users
            foreach (var user in newUser.GetUsers())
            {
                newPayment.UserId = user.Id;
                newPayment.Amount = new Random().Next((int)1000, (int)9999);
                newPayment.AddPayment(); //store payment record

                Console.WriteLine("id: " + user.Id + ", Firstname: " + user.FirstName + ", LastName: " + user.LastName);                                
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("----- Payment Section -----");

            Console.WriteLine("Payment Records: ");
            //show all payment records
            foreach (var payment in newPayment.GetPaymentRecord())
            {
                Console.WriteLine("id: " + payment.Id + ", UserId: " + payment.UserId + ", Amount: " + payment.Amount);
            }


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("------Triangle Section ------");

            //Triangle
            var triangle = new Triangle();
            // Input for Side A
            double SideA;
            do
            {
                Console.Write("Enter the length of Side A of the Triangle: ");
            } while (!double.TryParse(Console.ReadLine(), out SideA));

            Console.WriteLine();

            // Input for Side B
            double SideB;
            do
            {
                Console.Write("Enter the length of Side B of the Triangle: ");
            } while (!double.TryParse(Console.ReadLine(), out SideB));

            Console.WriteLine();

            // Input for Side C
            double SideC;
            do
            {
                Console.Write("Enter the length of Side C of the Triangle: ");
            } while (!double.TryParse(Console.ReadLine(), out SideC));

            Console.WriteLine();


            triangle.SideA = SideA;
            triangle.SideB = SideB;
            triangle.SideC = SideC;

            Console.WriteLine("Area of Triangle is: " + triangle.Area);

        }

    }
}