using System;

namespace LinkedListSolu
{
    class Program
    {
        /// <summary>
        /// UC2-Insert at last in linked list.
        /// </summary>
        /// <param name="args">The arguments.</param>

        static void Main(string[] args)
        {
            int Choice,data,p;
            
            Console.WriteLine("Welcome to Linked List operation");
            LinkedList list = new LinkedList();

            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();

            while (true)
            {
                Console.WriteLine("1.enter the element to inserted");
                Console.WriteLine("2.Display List");
                Console.WriteLine("3.Insert in empty Begining.");

                Console.WriteLine("enter your Choice=");
                Choice = Convert.ToInt32(Console.ReadLine());

                if (Choice == 4)
                    break;
                switch (Choice)
                {                   
                    case 1:
                        Console.WriteLine("enter the element to inserted");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtLast(data);
                        break;
                    case 2:
                        list.Display();
                        break;
                    case 3:
                        Console.WriteLine("Enter the element to searched");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtBegining(data);
                        break;
                    default:
                        Console.WriteLine("wrong choise");
                        break;

                }
                Console.WriteLine("Exit");
            }


        }
    }
}