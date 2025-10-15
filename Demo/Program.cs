
using System.ComponentModel.Design;
using System.Transactions;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Banking App 01
            ////Data Store (مخزن البيانات )
            //    //transfer account id 1 - 1                    
            //                    //  0       1           2
            //string[] UserName = { "usif", "hossam", "Masad" };
            //string[] Password = { "123", "456", "789" };
            //decimal[] Balance = { 1000 , 20000 ,30000  };
            //bool isAuthenticated = false;
            //int userIndex = -1;
            ////------------------------------------------
            ////login system 
            //do {
            //    Console.WriteLine("\t\t\t Welcome to Bank Muscat ");
            //    Console.WriteLine("\t\t\t ------------------------ ");
            //    Console.WriteLine("\t \t \t ---------------------------------");
            //    Console.WriteLine("\t \t \t Login Page ");
            //    Console.Write(" \t \t  UserName : ");
            //    string userValue = Console.ReadLine();
            //    Console.WriteLine();
            //    Console.Write(" \t \t  Password : ");
            //    string userPass = Console.ReadLine();

            //    for (int i = 0; i < UserName.Length; i++)
            //    {
            //        if (!(userValue == UserName[i] && userPass == Password[i]))
            //        {
            //            if (UserName.Length == i)
            //            {
            //                Console.WriteLine("Invalid username or password");
            //            }
            //        }
            //        else if(userValue == UserName[i] && userPass == Password[i])
            //        {
            //            isAuthenticated = true;
            //            userIndex = i;
            //            break;
            //        }         
            //    }
            //}
            //while(!isAuthenticated);

            //    Console.WriteLine($" Welcome mr{UserName[userIndex]}" +
            //        $" \n your balance is {Balance[userIndex]} ");


            //string menu = "1- for deposite option enter (1) \n 2- for withDraw enter (2) \n 3- for Balance information enter (3):";
            //Console.WriteLine(menu);
            //int val = int.Parse(Console.ReadLine());
            //switch (val)
            //{
            //    case 1:
            //        Console.WriteLine("Welcome to the Deposite ");
            //        Console.WriteLine("------------------------");
            //        Console.WriteLine($"your bank account amount {Balance[userIndex]}");
            //        Console.WriteLine("please enter your amount for deposite : ");
            //        int amount = int.Parse(Console.ReadLine());//only read the value as string
            //        if (amount <= 0)
            //        {
            //            Console.WriteLine("invalid amount ");
            //        }
            //        else
            //        {
            //            Balance[userIndex] = amount;
            //            Console.WriteLine($"your new Balance is {Balance[userIndex]}");
            //        }
            //        break;
            //    case 2:
            //        Console.WriteLine("Welcome to the Withdraw ");
            //        Console.WriteLine("------------------------");
            //        Console.WriteLine($"your bank account amount {Balance[userIndex]}");
            //        Console.WriteLine("please enter your amount for withdraw : ");
            //        amount = int.Parse(Console.ReadLine());//only read the value as string
            //        if (amount <= 0)
            //        {
            //            Console.WriteLine("invalid amount ");
            //        }
            //        else
            //        {
            //            Balance[userIndex] -= amount;
            //            Console.WriteLine($"your new Balance is {Balance[userIndex]}");
            //        }
            //        break;
            //    case 3:
            //        Console.WriteLine($"your current total balance is : {Balance[userIndex]}");
            //        break;
            //    default:
            //        Console.WriteLine("invalid input ");
            //        break;
            //} 
            #endregion


            //Assignment 8: Movie Theatre Seat Booking System
            //DataStore Decleration 
            string[,] seatBooking = new string[5, 5];
            int TotalSeatCount = 25;
            int UserInput;

            Console.WriteLine("\t\t\t welcome to Makeen Cinema ");
            Console.WriteLine("\t\t\t ------------------------- ");
            Console.WriteLine("Please Enter your query : ");
            string menu = "1-show Avaliable Seats \n 2-Book a seat  \n 3-Cancel Booking \n 4-show Seat Count  \n 5- Exit";
            Console.WriteLine(menu); 
            int desiredRow, desiredColumn; 
            //Array Filling and Visualization 
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    seatBooking[i, j] = $"A({i+1},{j+1})";
                    
                }
                
            }
            do{
            UserInput = int.Parse(Console.ReadLine());
                switch (UserInput)
                {
                    case 1:
                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 5; j++)
                            {

                                Console.Write($"\t\t {seatBooking[i, j]}");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 2:
                        Console.WriteLine("\t\t\t Welcome to booking system ");
                        Console.WriteLine("\t\t\t please choose from Available  seats your seat  (rows and column) to book  ");
                        Console.WriteLine("enter the Row : ");
                        desiredRow = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter the Column : ");
                        desiredColumn = int.Parse(Console.ReadLine());
                        seatBooking[desiredRow-1, desiredColumn-1] = "X";
                        TotalSeatCount--;
                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 5; j++)
                            {

                                Console.Write($"\t\t {seatBooking[i, j]}");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 3:
                        Console.WriteLine("\t\t\t Welcome to cancelation system  ");
                        Console.WriteLine("\t\t\t please choose from bellow seat (rows and column) to cancel  ");
                        Console.WriteLine("enter the Row : ");
                        desiredRow = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter the Column : ");
                        desiredColumn = int.Parse(Console.ReadLine());
                        seatBooking[desiredRow - 1, desiredColumn - 1] = $"A({desiredRow},{desiredColumn})";
                        TotalSeatCount++;
                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 5; j++)
                            {

                                Console.Write($"\t\t {seatBooking[i, j]}");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 4:
                        Console.WriteLine($"\t\t\t number of available seats is {TotalSeatCount}  ");

                        break;
                    default:
                        if(UserInput!=5)
                            Console.WriteLine("invalid input ");
                        break;
                }
            }
            while (UserInput != 5) ;


            // Operations (Avilable Seat - Book - Cancel Booking  - Exit )






        }
    }
}
