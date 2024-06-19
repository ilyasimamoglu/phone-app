using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phone_app
{
    internal class serach
    {
        public static void serach1()
        {
            bool sonuc = false;
            Console.WriteLine("Enter The Name You Want To find  ::");
            string hide = Console.ReadLine();
            for (int h = 0; h < 5; h++)
            {
                if(hide == phone_note.fname[h])
                {
                    Console.WriteLine($"We Find It !!!\n" +
                        $"The Full Name is :: {phone_note.fname[h]} {phone_note.lname[h]}\n" +
                        $"The Number is :: {phone_note.number[h]}");
                  sonuc = true;
                } 
                

            }
            if (sonuc == false )
            {
                Console.WriteLine("Not Excit");
            }
        }

    }
}
