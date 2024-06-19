using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phone_app
{
    internal class liste
    {
        public static void list()
        {
            for(int k = 0; k < 3; k++)
            {
                Console.WriteLine($"{phone_note.fname[k]} {phone_note.lname[k]} {phone_note.number[k]}");
            }
        }

    }
}
