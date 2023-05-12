using System;
 public class Menu
    {
        public string menu1 = "1. Write";
        public string menu2 = "2. Display";
        public string menu3 = "3. Load";
        public string menu4 = "4. Save";
        public string menu5 = "5. Quit";
        public void DisplayMenu()
        {
            Console.WriteLine($"{menu1}\n{menu2}\n{menu3}\n{menu4}\n{menu5}");
        }
    }