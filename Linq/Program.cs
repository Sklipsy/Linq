// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata;
using System;
using System.IO;
using System.Text.Json;
using System.Security.Cryptography.X509Certificates;
using System.Globalization;

namespace Linq { 
public class Concert
{
    public int Id { get; set; }

    public bool ReducedVenue { get; set; }

    public DateTime Date { get; set; }

    public string? Performer { get; set; }

    public int BeginsAt { get; set; }

    public int FullCapacitySales { get; set; }

    static void Main(string[]args)
    {

    string? concertData = File.ReadAllText("C:\\Users\\fpg12\\OneDrive\\Skrivbord\\DotNet\\w41\\Linq\\Linq\\concert_data.json");
        List<Concert>? concerts = JsonSerializer.Deserialize<List<Concert>>(concertData);
            Console.WriteLine(concerts[0].Performer);

            
           // test
            List<string> bla = new List<string>(){"1,2,3,4,5"};
            Console.WriteLine(bla.Count());
            
                //UPPG 1
                var num1 = concerts.Where(x=>x.Date > DateTime.Now).OrderBy(t => t.Date).ToList();
            Console.WriteLine(num1.Count);
            //var concert är variabel. num1 är ((new list)). .Where()
            
            /*
            foreach(var concert in num1)
             {
                 Console.WriteLine(concert);
             }
            Console.ReadLine();
            */


            //UPPG2
            List<Concert> num2 =concerts.Where(x => x.ReducedVenue == true).ToList();
            Console.WriteLine(num2.Count);
            /*
            foreach( var c in num2)
            {
                Console.WriteLine(c);
            }
            */
            

            //UPPG3 krånglig men fick den till att fungera sen.
            List<Concert> num3 = concerts
                .Where(x => x.Date >= DateTime.Parse("2024-01-01") 
                && x.Date <= DateTime.Parse("2024-12-31")).ToList();//&& båda sakerna = sant
           // Console.WriteLine(num3);

            foreach (var c in num3)
            {
                Console.WriteLine(c.Date);
            }
            

            //FÖRSÖKTE MED UPPGIFTERNA NEDAN 4 och 5, KLARADE INTE AV DOM 2 SISTA  HELA VÄGEN.:(
            
            List<Concert> num4 = concerts.Where(x=>x.ReducedVenue).ToList();
            Console.WriteLine(num4.Count);



            //uppg5 datetime .dayoftheweek. eller parantes friday == date
            //Datetime Day of the week
            List<Concert> num5 = concerts.OrderBy(x=>x.FullCapacitySales >6).ToList();
            Console.WriteLine(num5.Count);
                 
        }

    }
}

//största till minsta vice verse.Limit top


//Sort






