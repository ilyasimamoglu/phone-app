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
    internal class Program
    {
        static void Main(string[] args)
        {
            bool playagain = true;
            while (playagain)
            {
                Console.WriteLine("Pls Choose Something ");
                Console.WriteLine();
                Console.WriteLine("For Adding   Data Enter 1 ::");
                Console.WriteLine("For Updating Data Enter 2 ::");
                Console.WriteLine("For Serching Data Enter 3 ::  ");
                Console.WriteLine("For Listing  Data Enter 4 :: ");
                Console.WriteLine("For Removing Data Enter 5 ::");
                int x = Convert.ToInt32(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        {
                            phone_note.takename();

                            break;
                        }
                    case 2:
                        {
                            phone_app.updating.update();

                            break;
                        }
                        case 3:
                        {
                            phone_app.serach.serach1();

                            break;

                        }
                        case 4:
                        {
                            phone_app.liste.list();
                            break;
                        }
                        case 5:
                        {
                            phone_app.remove.remo();
                            break;
                        }
                    default:

                        break;


                        




                }

            }

            Console.ReadLine();
        }
    }
}
