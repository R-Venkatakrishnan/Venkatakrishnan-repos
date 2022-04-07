using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace ConsoleApp2
{
    
    class task
    {
        class BOOKS
        {

            public int BOOKID { get; set; }
            public string TITLENAME { get; set; }
            public int PRICE { get; set; }

            public String AUTHORNAME { get; set; }
        }

        public static void Main()
        {

            IList<BOOKS> BDATA = new List<BOOKS>()
{
new BOOKS(){ BOOKID = 1 , TITLENAME="AGATHA CHRISTIE",AUTHORNAME="AGATHA CHRISTIE",PRICE=200},
new BOOKS(){ BOOKID = 2 , TITLENAME="DA VINCI CODE",AUTHORNAME= "BOLT",PRICE=150},
new BOOKS(){ BOOKID = 3 , TITLENAME="THE MONK WHO SOLD HIS FERRARI ", AUTHORNAME=" ROBIN SHARMA",PRICE=300}};

            //1st program//
            // var Ageqry = from BOK in BDATA
            // select BOK;
            // Console.WriteLine("THE BOOKS");
            // foreach (var v in Ageqry)
            //   Console.WriteLine(v.BOOKID + " " + v.TITLENAME);
            //2nd program//
            //  var Ageqry = from AN in BDATA
            //  where AN.AUTHORNAME.Contains("ALSUDIS")
            // select AN;
            // foreach (var auth in Ageqry)
            //   Console.WriteLine(auth.TITLENAME);

            //  Console.WriteLine("The author name");
            //  foreach (var v in Ageqry)
            //    Console.WriteLine(v.BOOKID + " " + v.TITLENAME);

            //3rd program//
            //  var Ageqry = from pric in BDATA
            //             orderby pric.PRICE
            //           select pric;

            //         Console.WriteLine("THE PRICE LIST");
            // foreach (var v in Ageqry)
            //   Console.WriteLine(v.PRICE + " " + v.TITLENAME);

            //4th program   

            Console.WriteLine("Books by Author");
            var BQry = from stud in BDATA
                   orderby stud.AUTHORNAME
                    select stud;
            foreach (var names in BQry)
              Console.WriteLine(names.AUTHORNAME + " " + names.TITLENAME);


        }

    }

}
   
