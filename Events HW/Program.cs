using System;

namespace Events_HW
{
    delegate void LengthCheck();

    delegate void StudentDiscount();

    class Program
    {
        static void Print()
        {
            Console.WriteLine("\nthe name is over 10 characters\n");
        }

        static void Main(string[] args)
        {
            #region exercise 1

            TooLongNameEvent = Print;
            ClassWithNameProp classWithName = new();
            Console.WriteLine("Please enter a name under 10 characters\n");
            classWithName.Name = Console.ReadLine();
            if (classWithName.Name.Length >= 10)
            {
                TooLongNameEvent();
            }

            #endregion

            #region exercise 2

            int luckyNumber = 999;
            Console.WriteLine("Please enter a number between 1 to 1000\n");
            int userInput = int.Parse(Console.ReadLine());
            while (userInput != luckyNumber)
            {
                Console.WriteLine("Oops! Try again\n");
                userInput = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"\nCongrats the lucky number is {luckyNumber}\n");

            #endregion

            #region exercise 3

            
            while (true)
            {
                for (int count = 0; count < 5; count++)
                {
                    Student newStudent = new();
                    Console.Write("Enter First name: ");
                    newStudent.FirstName = Console.ReadLine();
                    Console.Write("Enter Last name: ");
                    newStudent.LastName = Console.ReadLine();
                    StudentsList.students.Add(newStudent);
                    Console.WriteLine();
                }
                DiscountClass.IsDiscountEventRaised(Discount);
            };

            #endregion
        }
        public static event LengthCheck TooLongNameEvent;
        public static event StudentDiscount Discount;
    }
}
