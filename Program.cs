namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Hej! Skriv in ditt namn");
            var name = Console.ReadLine();
                Console.WriteLine($"{Environment.NewLine}Hej, {name}, Har du ätit frukost idag?");
                Console.WriteLine($"{Environment.NewLine}");

                    var breakfast = Console.ReadLine();
                        if(breakfast == "ja" || breakfast == "Ja"){
                            Console.WriteLine($"{Environment.NewLine}Toppen {name}! Det är viktigt med frukost.");
                        }else if(breakfast == "nej" || breakfast == "Nej"){
                            Console.WriteLine($"{Environment.NewLine}Nämen {name}! Då är det nog dags för det nu :D");
                        }else{
                            Console.WriteLine($"{Environment.NewLine}Jag förstår inte om du ätit frukost eller inte... Pröva att skriva ja eller nej för att besvara frågan.");
                            Console.WriteLine($"{Environment.NewLine}");

                    var breakfast2 = Console.ReadLine();
                        if(breakfast2 == "ja" || breakfast2 == "Ja"){
                            Console.WriteLine($"{Environment.NewLine}Toppen {name}! Det är viktigt med frukost.");
                        }else if(breakfast2 == "nej" || breakfast2 == "Nej"){
                            Console.WriteLine($"{Environment.NewLine}Nämen {name}! Då är det nog dags för det nu :D");
                        }else{
                            Console.WriteLine($"{Environment.NewLine}Jag är ledsen men jag förstår fortfarande inte om du ätit frukost eller inte...");
                        }
                        }
                Console.Write($"{Environment.NewLine}Tryck på valfri tangent för att avsluta.");
                Console.ReadKey(true);
                    }
                }
            }