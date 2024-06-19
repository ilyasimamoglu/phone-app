using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phone_app
{
    internal class remove
    {
        public static void remo()
        {
            Console.WriteLine("Enter The FirstName You Want Remove  ");
            string php= Console.ReadLine();
            Console.WriteLine("Enter The LastName You Want Remove  ");
            string php1 = Console.ReadLine();
            bool reos = false; 
            for (int l = 0; l < 5; l++)
            {
                if ((php == phone_note.fname[l]) && (php1 == phone_note.lname[l]))
                {
                    phone_note.fname[l] = "";
                    phone_note.lname[l] = "";
                    phone_note.number[l] = 0;
                    reos = true;
                }

            }
            if(reos == false)
            {
                Console.WriteLine("Not Excit");
            }


        }
    }
}
