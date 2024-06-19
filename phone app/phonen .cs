using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//bir telefon defteri tanımlancaktır;
//telfon defteri kişileri topluluk halinde içermektedir;
//her  bir kişiye ait isim soyisim ve telfon bilgileri bulunmaktadır;
//telefon defteri kişiler topluluguna ekleme yapabilir;
//topluluk belli bir kritere göre arama gerçekleştirebilir 
//listeme yapabilir 
//güncelleme ve silme işlemlerini yapabilir 
namespace phone_app
{
    internal class phone_note
    {
       public static int i = 0;
        public static string[] fname = new string[5] ;
        public static string[] lname = new string[5] ;
        public static int[] number = new int[5];

       public static void takename()
        {
            
            Console.Write("Enter The FirstName :: ");
            fname[i]=Console.ReadLine();
                
            Console.Write("enter The LastName ::");
            lname[i]= Console.ReadLine();
          
            Console.Write("Enter the number ::");
            number[i]=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The Name is :: {fname[i]} {lname[i]}\nthe number is ::{number[i]}");
            i++;
        }
       

        

    }
}
