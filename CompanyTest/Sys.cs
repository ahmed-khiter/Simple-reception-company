using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyTest
{
    class Sys
    {
        public List<Employees> WorkersList = new List<Employees>();
        public Action ChooseBetween()
        {
            do
            {
                Console.Clear();
                string[] Arr = { "1 - Add A Worker.", "2 - Print List .","3 - to close application" };
                Console.WriteLine(Arr[0]);
                Console.WriteLine(Arr[1]);
                Console.WriteLine(Arr[2]);

                int Choose = int.Parse(Console.ReadLine());

                switch (Choose)
                {
                    case 1:
                        {
                            AddWorker();

                            break;
                        }

                    case 2:
                        {
                            Console.Clear();
                            foreach (Employees W in WorkersList)
                            {
                                Console.WriteLine(W.Print());
                                Console.WriteLine("----------------------");
                            }
                            Console.ReadKey();

                            break;
                        }
                    case 3:
                        {
                            Environment.Exit(0);
                            break;
                        }
                }
            }
            while (true);

        }

        #region function system
        public  void AddWorker()
        {
            Employees W = new Employees();
         start:
            try
            {
                //enter Id
                Console.Write("\nEnter ID : ");
                W.numberId = long.Parse(Console.ReadLine());

                //enter frist name and last name
                Console.Write("\nEnter Name : ");
                W.name = Console.ReadLine();

                Console.Write("\nEnter Last Name : ");
                W.lastName = Console.ReadLine();
                Console.Write("\nEnter Age : ");
                W.age = byte.Parse(Console.ReadLine());
                if(W.age<18 || W.age > 61)
                {
                    Console.WriteLine("your age must be between 18 and 61 years old !!\nwe will try enter data again");
                    goto start;
                }
            }
            catch (Exception)
            {
                Console.Clear();
                Console.Write("\nyou entered wrong data we will try again !!");
                goto start;
            }

            //enter hour wage
            Console.Write("\nEnter Hour Wage : ");
            W.wageHour = float.Parse(Console.ReadLine());

            //enter total hours
            Console.Write("\nEnter Total Hours : ");
            W.totalHours = byte.Parse(Console.ReadLine());

            WorkersList.Add(W);
        }
        #endregion

    }
}
