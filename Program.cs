namespace DilSeçim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dil seçimi yapınız.\n1 - TÜRKÇE(1) \n2 - ENGLISH(2)");
            byte dilSecimi = byte.Parse(Console.ReadLine());

            string secilenDil = string.Empty;

            switch (dilSecimi)
            {
                case 1:
                    secilenDil = "TÜRKÇE";
                    break;
                case 2:
                    secilenDil = "ENGLISH";
                    break;
                default:
                    secilenDil = "Geçersiz seçim!";
                    break;
            }

            Console.WriteLine($"Seçilen dil: {secilenDil}");

            string sekilSecimi = string.Empty;
            double alan = 0, cevre = 0;

            if (dilSecimi == 1)
            {
                Console.WriteLine("Bir şekil seçiniz: Kare, Üçgen veya Daire.");
            }
            else if (dilSecimi == 2)
            {
                Console.WriteLine("Select a shape: Square, Triangle or Circle.");
            }

            string sekil = Console.ReadLine().ToLower();

            Console.WriteLine("Alan mı yoksa çevre mi hesaplamak istersiniz? (Alan/Çevre)");
            string hesaplamaSecimi = Console.ReadLine().ToLower();

            switch (sekil)
            {
                case "kare":
                case "square":
                    if (dilSecimi == 1)
                    {
                        Console.WriteLine("Kenar uzunluğunu giriniz:");
                    }
                    else if (dilSecimi == 2)
                    {
                        Console.WriteLine("Enter the side length:");
                    }
                    double kenar = double.Parse(Console.ReadLine());

                    if (hesaplamaSecimi == "alan")
                    {
                        alan = kenar * kenar;
                        Console.WriteLine($"Alan: {alan}");
                    }
                    else if (hesaplamaSecimi == "çevre" || hesaplamaSecimi == "perimeter")
                    {
                        cevre = 4 * kenar;
                        Console.WriteLine($"Çevre: {cevre}");
                    }
                    else
                    {
                        if (dilSecimi == 1)
                        {
                            Console.WriteLine("Geçersiz seçim.");
                        }
                        else if (dilSecimi == 2)
                        {
                            Console.WriteLine("Invalid selection.");
                        }
                    }
                    break;

                case "üçgen":
                case "triangle":
                    if (dilSecimi == 1)
                    {
                        Console.WriteLine("Taban uzunluğunu giriniz:");
                    }
                    else if (dilSecimi == 2)
                    {
                        Console.WriteLine("Enter the base length:");
                    }
                    double tabanUzunlugu = double.Parse(Console.ReadLine());
                    if (dilSecimi == 1)
                    {
                        Console.WriteLine("Yüksekliği giriniz:");
                    }
                    else if (dilSecimi == 2)
                    {
                        Console.WriteLine("Enter the height:");
                    }
                    double yukseklik = double.Parse(Console.ReadLine());

                    if (hesaplamaSecimi == "alan")
                    {
                        alan = (tabanUzunlugu * yukseklik) / 2;
                        Console.WriteLine($"Alan: {alan}");
                    }
                    else if (hesaplamaSecimi == "çevre" || hesaplamaSecimi == "perimeter")
                    {
                        Console.WriteLine("Üçgenin çevresi için kenar uzunluklarını giriniz:");
                        double a = double.Parse(Console.ReadLine());
                        double b = double.Parse(Console.ReadLine());
                        double c = double.Parse(Console.ReadLine());
                        cevre = a + b + c;
                        Console.WriteLine($"Çevre: {cevre}");
                    }
                    else
                    {
                        if (dilSecimi == 1)
                        {
                            Console.WriteLine("Geçersiz seçim.");
                        }
                        else if (dilSecimi == 2)
                        {
                            Console.WriteLine("Invalid selection.");
                        }
                    }
                    break;

                case "daire":
                case "circle":
                    if (dilSecimi == 1)
                    {
                        Console.WriteLine("Yarıçapı giriniz:");
                    }
                    else if (dilSecimi == 2)
                    {
                        Console.WriteLine("Enter the radius:");
                    }
                    double yaricap = double.Parse(Console.ReadLine());

                    if (hesaplamaSecimi == "alan")
                    {
                        alan = Math.PI * yaricap * yaricap;
                        Console.WriteLine($"Alan: {alan}");
                    }
                    else if (hesaplamaSecimi == "çevre" || hesaplamaSecimi == "perimeter")
                    {
                        cevre = 2 * Math.PI * yaricap;
                        Console.WriteLine($"Çevre: {cevre}");
                    }
                    else
                    {
                        if (dilSecimi == 1)
                        {
                            Console.WriteLine("Geçersiz seçim.");
                        }
                        else if (dilSecimi == 2)
                        {
                            Console.WriteLine("Invalid selection.");
                        }
                    }
                    break;

                default:
                    if (dilSecimi == 1)
                    {
                        Console.WriteLine("Geçersiz şekil.");
                    }
                    else if (dilSecimi == 2)
                    {
                        Console.WriteLine("Invalid shape.");
                    }
                    break;
            }
            }
    }
}
