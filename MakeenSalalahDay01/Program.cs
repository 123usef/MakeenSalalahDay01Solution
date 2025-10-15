using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace MakeenSalalahDay01
{
    class Program
    {
        static void Main()
        {
            #region C#Program
            //string FirstName; 
            //string SecondName
            //string LastName;
            //string JobTitle;
            //string Dob;

            //string FirstName, SecondName, LastName, Title, DOB;
            // Console.WriteLine("enter your first name : ");
            // FirstName = Console.ReadLine();
            // Console.WriteLine("enter your Second name : ");
            // SecondName = Console.ReadLine();
            // Console.WriteLine("enter your Last Name : ");
            // LastName = Console.ReadLine();
            // Console.WriteLine("enter your job title : ");
            // Title = Console.ReadLine();
            // Console.WriteLine("enter your DOB : ");
            // DOB = Console.ReadLine();

            // Console.WriteLine("Welcome to Makeen " + FirstName + 
            //     " " + SecondName + " " +
            //     LastName + "your job Title is " + Title +
            //     "your Date of birth is " + DOB );
            /*
                Create a c# Console application that takes form the user 
             Variables   FirstName , SecondName , SurName  , dateofBirth , jobTitle 
                and say hello to him with his informations 
               
             */
            /*
                      Logical steps To Solve
            
                    * Requirment Analysis 
                    * identifying what is the input and what is the output?
                    * break it  into small steps 
                        *declare the Variables 
                        *output message input value 
                        *output the final result 
             
             */

            #endregion
            #region Variables and Datatype
            //console.writeline("hello from first project");
            //string name = "yousif"; //variable declration + initializeations
            //string job; // decelartion 
            //string title, familyname, mothername;
            //name = "ahmed";

            //bool hasWork; // boolean value 
            //hasWork = true;
            //hasWork = false;
            //Console.WriteLine("please enter your name : ");
            //string name =  Console.ReadLine(); // input as string only  
            //Console.WriteLine("Welcome to programming "+name + "hamda helal");
            //refrence type we should use new 
            //Object obj1;
            //obj1 = new Object();

            //String hamada = new String("hello world ");
            //string shss = "skhdkjas";
            /*
             
            hello 
            world 
            comment Multi Line Comment
             */
            #endregion

            #region value and refrence type memory prespective
            //int x = 1;
            //int y = 3;
            //x = y;
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //string bom = "hello ";
            //string takh = "world";
            //bom = takh;
            //Console.WriteLine(bom);
            //Console.WriteLine(takh);
            //bom = "yousif";
            //Console.WriteLine(bom);
            //Console.WriteLine(takh); 
            #endregion


            #region DayBefore05
            //string name = "yousif";
            //string greaqtingmssage = $"hello world {name}";
            //Console.WriteLine(greaqtingmssage);
            ////<datatype> <varName> ;|| = "value" ;


            //// var  || dynamic 
            ////compilation time 
            //var x = "yousif"; //string
            //x = "hossam";
            ////x = 12;
            //var y = 170000; //int

            ////dynamic -> runtime  (when i run the program)
            //dynamic userValue = "SoftwareEngineer";
            //userValue = 12;

            //== ,3>3 , < , != , >= , <=  ==>conditions , loops ,

            //Console.WriteLine(3==3);
            //Console.WriteLine(4<3);

            //bool output = true | false;
            //bool ouputand = false & true;




            //Console.WriteLine();


            /*
                لو جوجو نجحت و طلعت من الاوائل هجيبلها 


            // */
            //bool isPassed = true;
            //bool isTop10 = true;
            ////ternary operator syntax 
            //// (condition) ? "result when true" : "result when false
            //string output = 
            //    ((isPassed == true) && (isTop10 == true))
            //    ? "you will have a bicycle " 
            //    : "you will not have a bicycle";

            //Console.WriteLine(output);

            //----------------------------------------
            /*
                array 
                    Decleration
                <Datatype><[]> <Array Name> = new Datatype[size];
             */

            //string[] StudentsName = new string[5];
            //int[] StudentGrade = [20,10,30,40,50];
            /* one Dimensional Array  */
            //string[] StudentsName = new string[5];
            //int[] StudentGrade = new int[5];

            //StudentsName[0] = "Ahmed";
            //StudentGrade[0] = 20;

            //StudentsName[1] = "Mosad";
            //StudentGrade[1] = 18;

            //StudentsName[2] = "Hossam";
            //StudentGrade[2] = 15;

            //StudentsName[3] = "Fadl";
            //StudentGrade[3] = 12;

            //StudentsName[4] = "Fayadh";
            //StudentGrade[4] = 10;
            //string perfect = (StudentGrade[1] >= 20) ? "Congrtulation you got full mark " : "" ;
            //Console.WriteLine($"Student Name is : {StudentsName[1]} " +
            //    $"has grade {StudentGrade[1]} {perfect} ");

            // is even or odd 

            //int x = 10;
            //int y = 2;
            //Console.WriteLine((x / y == 0) ?"Even" : "Odd");
            //Console.WriteLine((x % y == 0) ?"Even" : "Odd");
            //int? x = null ;
            //long? y = null; 
            //Console.WriteLine(x);

            //string UserName = null;
            //Console.WriteLine("Please enter your Name or leave Empty");
            //UserName = Console.ReadLine();
            ////Console.WriteLine((UserName==null || UserName=="")? $"welcome Mr.Anonymous " : $"Welcome mr {UserName}");
            //Console.WriteLine((String.IsNullOrEmpty(UserName))? $"welcome Mr.Anonymous " : $"Welcome mr {UserName}");
            //--------------------------------------------

            // () ? true : false ; 

            //() ?? value ; // بيسأل لو انتا ب null 

            #region BlockScope and NullCollasion
            //string Fname = null;

            ////Console.WriteLine((Fname ?? "Anonymous1321"));
            //Console.WriteLine(Fname?.ToUpper());
            //Console.WriteLine(Fname?.ToLower());


            //{
            //    bool hasJob = false;
            //    Console.WriteLine(hasJob);
            //    Console.WriteLine(Fname);
            //}
            //Console.WriteLine(hasJob); 
            #endregion

            ////postfix
            //int x = 2;
            //Console.WriteLine(x); //2
            //Console.WriteLine(x++); //2
            //Console.WriteLine(x); //3
            ////preFix 
            //Console.WriteLine("------------------------");
            //int y = 2;
            //Console.WriteLine(y); //2
            //Console.WriteLine(++y);//3
            //Console.WriteLine(y);//3
            //--------------------------
            //int mark = 25;
            //if (mark >=60)
            //{
            //    Console.WriteLine("B");
            //}else if ((mark >=40) && (mark <60))
            //{
            //    Console.WriteLine("c");
            //}
            ////else if ()
            ////{

            ////}
            //else
            //{
            //   //  كل الطرق التانية 
            //    Console.WriteLine("assignment increased ");
            //}
            #region SwitchOldATM
            //int userValue;
            //int userBalance = 10000;
            //Console.WriteLine("\t \t \t Welcome to Makeen Bank");
            //Console.WriteLine("--------------------------------");
            //string menu = "1- for deposite option enter (1) \n 2- for withDraw enter (2) \n 3- for Balance information enter (3):";
            //Console.WriteLine(menu);
            //userValue = int.Parse(Console.ReadLine());
            //switch (userValue)
            //{
            //    case 1:
            //        Console.WriteLine("Welcome to the Deposite ");
            //        Console.WriteLine("------------------------");
            //        Console.WriteLine($"your bank account amount {userBalance}");
            //        Console.WriteLine("please enter your amount for deposite : ");
            //        int amount = int.Parse(Console.ReadLine());//only read the value as string
            //        if(amount <= 0)
            //        {
            //            Console.WriteLine("invalid amount ");
            //        }
            //        else
            //        {
            //            userBalance += amount;
            //            Console.WriteLine($"your new Balance is {userBalance}");
            //        }
            //        break;
            //    case 2:
            //        Console.WriteLine("Welcome to the Withdraw ");
            //        Console.WriteLine("------------------------");
            //        Console.WriteLine($"your bank account amount {userBalance}");
            //        Console.WriteLine("please enter your amount for withdraw : ");
            //         amount = int.Parse(Console.ReadLine());//only read the value as string
            //        if (amount <= 0)
            //        {
            //            Console.WriteLine("invalid amount ");
            //        }
            //        else
            //        {
            //            userBalance -= amount;
            //            Console.WriteLine($"your new Balance is {userBalance}");
            //        }
            //        break;
            //        case 3:
            //        Console.WriteLine($"your current total balance is : {userBalance}");
            //        break;
            //    default:
            //        Console.WriteLine("invalid input ");
            //        break;
            //} 
            #endregion

            //object o = false;

            //o = Console.ReadLine(); // string 

            //switch (o)
            //{
            //    case int i:
            //        Console.WriteLine($"the value power 2 is : {i*i}");
            //        break;
            //    case string s:
            //        Console.WriteLine($"the upper case is {s.ToUpper()}");
            //        break;
            //    case bool flag:
            //        Console.WriteLine((flag ) ? "the weather is good": "the weather is bad");
            //        break;
            //    default:
            //        Console.WriteLine("unknown datatype");
            //        break;
            //}
            //                     array of characters 
            //string greatMessage = "Good Morning ya joe ";
            //Console.WriteLine(greatMessage[0]);
            //for (int i = 0; i < greatMessage.Length  ; i++)
            //{
            //    Console.WriteLine(greatMessage[i]);
            //}

            //*****
            //*****
            //*****

            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j< 4; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 65, 15, 30, 32 };

            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    Console.WriteLine((arr1[i] % 2 == 0) ? $"{arr1[i]} is even" : $"{arr1[i]} is odd");
            //}

            /*
            int itretaor 
            while(iteraor >10){
            cw(i);
             i++;
            }
             
             */

            //int userValaue;
            ////Console.WriteLine("what is the best place in Muscat ?");
            ////Console.WriteLine("1) AlQuram \n 2) mabila \n 3) Alkhwair");
            ////userValaue = int.Parse(Console.ReadLine());
            //while (userValaue != 0)
            //{
            //    Console.WriteLine("what is the best place in Muscat ?");
            //    Console.WriteLine("1) AlQuram \n 2) mabila \n 3) Alkhwair");
            //    userValaue = int.Parse(Console.ReadLine());
            //    if (userValaue == 1)
            //    {
            //        Console.WriteLine("perfect");
            //    }
            //    else
            //    {
            //        Console.WriteLine("tryagain");
            //    }

            //}
            //int userValaue;
            //do
            //{
            //    Console.WriteLine("what is the best place in Muscat ?");
            //    Console.WriteLine("1) AlQuram \n 2) mabila \n 3) Alkhwair");
            //    userValaue = int.Parse(Console.ReadLine());
            //    if (userValaue == 1)
            //    {
            //        Console.WriteLine("perfect");
            //    }
            //    else
            //    {
            //        Console.WriteLine("tryagain");
            //    }

            //} while(userValaue != 0);





            /*
                do{
            
            
                  }while(condtion)
             
             
             */

            // fib numbers 
            //int fib1 = 0 , fib2 = 1 , temp = 0 ;
            //Console.WriteLine(fib1);
            //Console.WriteLine(fib2);
            ////0,1,1
            //for (int i = 0; i < 10; i++)
            //{

            //    Console.WriteLine(fib1+fib2);
            //    temp= fib1  ;
            //    fib1 = fib2;

            //    fib2 = temp + fib2;

            //}

            //string str = "CodeAcademy";

            //foreach (char item in str)
            //{
            //    Console.WriteLine(item);
            //}
            //debugger
            //for (int i = 0; i < 10; i++)
            //{
            //    if(!(i%2 == 0))
            //    {
            //        //continue;// skip
            //        break;
            //    }
            //    Console.WriteLine(i);
            //} 
            #endregion



            #region TypeCasting
            ////TypeCasting 
            ////implicit Casting ==> من الاصغر للاكبر 
            //int x = 1000;
            //long y = x; // implicit Casting --real number 
            //            //------------------------------
            //            //explicit
            //long xx = 1000000;
            //int yy = (int)xx; //may lead to Dataloss 
            ////-------------------
            //double pi = 3.14;
            //int pii = (int)pi; //3
            //double piii = (double)pii;//3.0 
            #endregion


            #region Grading System
            //boxing and unboxing 
            //from string to int 
            ////string value = "555a";
            //Console.WriteLine("please enter your number that you want to check : ");
            //dynamic value = (int.TryParse(Console.ReadLine(), out int val)) ? val : "invalid input";
            // int x = int.Parse(value);
            //int y = Convert.ToInt32(value);

            //most used and safiest way 
            //var || dynamic
            // dynamic z = (int.TryParse(value, out int val)) ? val : "invalid input"; //true | false


            // //Console.WriteLine(x.GetType());
            //// Console.WriteLine(y.GetType());
            // Console.WriteLine(z.GetType());
            // Console.WriteLine(z);

            #endregion

            // // datastore 
            // int NumberOfStudents;
            // int[] StudentGrade;//decleration 
            //// int userInput;
            // Console.WriteLine("Welcome to Grading System : ");
            // Console.WriteLine("Please enter Number Of Students : ");
            // NumberOfStudents = int.Parse(Console.ReadLine());
            // StudentGrade = new int[NumberOfStudents];
            // for (int i = 0; i < NumberOfStudents; i++)
            // {
            //     Console.WriteLine($"please enter student {i+1} grade :");
            //     StudentGrade[i] = int.Parse(Console.ReadLine());

            // }
            // for (int i = 0; i < StudentGrade.Length; i++)
            // {
            //     if (StudentGrade[i] >=90 && StudentGrade[i]<=100)
            //     {
            //         Console.WriteLine("A");
            //     } else if (StudentGrade[i] >= 80 && StudentGrade[i] <= 89)
            //     {
            //         Console.WriteLine("B");
            //     }else if (StudentGrade[i] >= 70 && StudentGrade[i] <= 79)
            //     {
            //         Console.WriteLine("C");
            //     }else if (StudentGrade[i] >= 60 && StudentGrade[i] <= 69)
            //     {
            //         Console.WriteLine("D");
            //     }else if (StudentGrade[i] >=0 && StudentGrade[i]<=59)
            //     {
            //         Console.WriteLine("F");
            //     }
            //     else
            //     {
            //         Console.WriteLine("invalid grade");
            //     }


            //    int[] arr = { 1, 2, 3, 4, 5 };
            //  int[] temp = new int[arr.Length];
            //  Array.Copy(arr, temp , arr.Length);
            ////Array.Reverse(arr); // 5,4,3,2,1

            ////[1,2,3,4,5]
            ////Console.WriteLine(temp.Length);
            //int it = 0;
            //for (int i = temp.Length - 1 ; i >= 0; i--)
            //{
            //    arr[it] = temp[i];
            //    Console.WriteLine(arr[it]);
            //    it++;
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //    //Console.WriteLine(arr[i]);
            //}

            //intialization and deceleration 

            const double pi = 3.14;

            

        }
        }

    }












