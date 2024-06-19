using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phone_app
{
    internal class updating
    {
        public static void update( )
        {
            Console.WriteLine("Enter FirstName::");
            string n=Console.ReadLine();
            Console.WriteLine("Enter LastName :: ");
            string ln = Console.ReadLine();
            bool result = false;
            for (int j = 0; j < 5; j++)
            {
                if ((n == phone_note.fname[j]) && (ln == phone_note.lname[j]))
                {
                    Console.WriteLine("For Updating The FirstName enter 1 ::" +
                        "\nFor Updating LastName Enter 2 ::" +
                        "\nFor All Enter 3 ::");
                    int x = Convert.ToInt32(Console.ReadLine());
                    result = true;
                    
                    if (x == 1)
                    {
                        Console.Write("Enter The New Name ::");
                        phone_note.fname[j] = Console.ReadLine();
                        Console.WriteLine("The Name is :: "+ phone_note.fname[j]);
                        break;
                    }
                    else if ( x == 3) {
                        Console.WriteLine("Enter The FirstName and LastName ::");
                        phone_note.fname[j] = Console.ReadLine();
                        phone_note.lname[j]= Console.ReadLine();
                        Console.WriteLine($"The Name is :: {phone_note.fname[j]} {phone_note.lname[j]}");
                        break;
                    }
                    else if (x == 2)
                    {
                        Console.WriteLine("Enter The LastName ::");
                        phone_note.lname[j]= Console.ReadLine();
                        Console.WriteLine("The LastName is :: " + phone_note.lname[j]);
                        break;

                    }
                    else if ((x!=1)&& (x!=2)&& (x!=3))
                    {
                        Console.WriteLine("Pls Enter Number Bettwen 1 - 3 ::");
                        break;
                    }
                    


                }
                
                    
                
                
                
            }
           
             if (result == false){

                Console.WriteLine("not exict");
            }
             else
            {

            }
           





        }

    }
}
