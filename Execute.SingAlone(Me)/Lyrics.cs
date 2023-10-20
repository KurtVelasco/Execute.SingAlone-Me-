using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace Execute.SingAlone_Me_
{
    internal  static class world
    {
        public static void readFile(string fileName)
        {
            string filePath = fileName;
            try
            {
                using (StreamReader reader = new StreamReader(filePath + ".txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                        Thread.Sleep(5);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file could not be found.");
            }
            catch (IOException)
            {
                Console.WriteLine("An error occurred while reading the file.");
            }
        }
        public static void slowType(string text, int delayMilliseconds)
        {
            TimeSpan delay = TimeSpan.FromMilliseconds(delayMilliseconds);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("[Console] ");
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
     
        public static void worldExecuteMe()
        {
            slowType("Switch on the Power Line", 50);
            readFile("textFiles/logoRhine");
            slowType("Remember to Put on -- P R O T E C T I O N", 50);
            Console.WriteLine("encryptEnigma();");
            Console.WriteLine("\u001b[31mAlternative Name: Terra\u001b[0m");
            readFile("textFiles/newWorldSettings");
            simulateLoading(" Encryption Set",20,10);
            slowType("Lay down your pieces and let's begin \u001b[33m objectCreation(); \u001b[0m", 50);
            animateText("Fill in my data.", "[Console]", 5);
            readFile("textFiles/createObject");
            slowType("Parameters. ", 60);
            LayDown();
            slowType("Initialization.", 60);
            simulateLoading(" Generating World",10,10);
            slowType("Setup our new world", 40);
            Console.WriteLine(">>World world = new World(5);\r\n>>world.addThing(me);\r\n<<world.addThing(you);");
            slowType("let's begin the... \n", 30);
            slowType("S I M U L A T I O N ~ \n", 70);
            Console.WriteLine("\u001b[33m>>world.activateSimulation(); \u001b[0m");
            Thread.Sleep(200);
            simulateWorld();
            Thread.Sleep(200);

            slowType("If I'm a set of points.", 50);
            slowType("then I will give you my dimension.", 50);
            Console.WriteLine("\u001b[33mif(me is pointSet)\r\n{\r\nyou.applyAttribute(me.Dimensions());\r\n} \u001b[0m");
            slowType("If I'm a circle.", 70);
            slowType("then I will give you my circumference.", 60);
            Console.WriteLine("\u001b[33mif(me is pointSet)\r\n{\r\nyou.applyAttribute(me.Dimensions());\r\n} \u001b[0m");
            slowType("If I'm a sine wave.", 50);
            slowType("then you can sit on all my tangents", 50);
            Console.WriteLine("\u001b[33mif(me is pointSet)\r\n{\r\nyou.applyAttribute(me.Dimensions());\r\n} \u001b[0m");
            slowType("If I approach infinty", 70);
            slowType("then you can be my limitations", 80);
            Console.WriteLine("\u001b[33mif(me is pointSet)\r\n{\r\nyou.applyAttribute(me.Dimensions());\r\n} \u001b[0m");
            slowType("Switch my Current", 80);
            slowType("to AC to DC", 120);
            Console.WriteLine("\u001b[33mif(me is pointSet)\r\n{\r\nyou.applyAttribute(me.Dimensions());\r\n} \u001b[0m");
            slowType("And then blind my Vision", 70);
            slowType("So dizz, so dizzy", 120);
            Console.WriteLine("\u001b[33mif(me is pointSet)\r\n{\r\nyou.applyAttribute(me.Dimensions());\r\n} \u001b[0m");
            slowType("Oh, we can travel to... ", 80);
            slowType("AB to BC", 120);
            slowType("And we can unite to", 70);
            slowType("soo deeply, so deeply", 80);

            slowType("If I can", 120);
            slowType("If I can", 120);
            slowType("give you all the", 70);
            slowType("S T I M U L A T I O N S", 60);
            slowType("Then I can, then I can be your only S A S T I F A C T I O N", 40);
            slowType("If I can make you happy,", 50);
            slowType("I will run the  \u001b[31mworld.execution();\u001b[0m", 50);
            slowType("Though we are trapped in this STRANGGE, strange simulation", 40);
            slowType("If I'm an eggplant", 90);
            slowType("the I will you my nutrients", 70);
            slowType("If I'm a tomato,", 90);
            slowType("then I will give you antioxidants", 60);
            slowType("If I'm a tabby cat,", 90);
            slowType("then I will purr for your enjoyment", 60);
            slowType("If I'm the only \u001b[31mGOD\u001b[0m,", 70);
            slowType("then you're the proof of my existence", 60);

            slowType("Switch my gender to \u001b[31mF to M\u001b[0m", 80);
            slowType("And then do whatever from \u001b[31mAM to PM\u001b[0m", 80);
            slowType("Oh, switch my role \u001b[31mS to M\u001b[0m", 90);
            slowType("So we can enter the trance, the trance", 80);


            slowType("If I can, if I can, feel your vibrations", 80);
            slowType("Then I can, then I can finally be completion", 60);

            slowType("Though you have left, you have left", 60);
            slowType("You have left, you have left, you have left", 60);
            slowType("You have left me in isolation", 80);


            slowType("If I can, if I can, erase all the pointless fragments", 80);
            slowType("Then maybe, then maybe, you won't leave me so disheartened", 80);

            slowType("Challenging your God, you have made some illegal arguments", 80);


            //If I'm an eggplant, then I will give you my nutrients
            //If I'm a tomato, then I will give you antioxidants
            //If I'm a tabby cat, then I will purr for your enjoyment
            //If I'm the only god, then you're the proof of my existence

            //If I can, If I can, give you all the stimulations
            // Then I can, then I can be your only satisfaction
            //If I can make you happy, I will run the execution
            //Though we are trapped in this strange, strange simulation


        }

        public static void simulateLoading(string message, int delayAmount, int barAmount)
        {
            int totalBars = 10;
            int delay = delayAmount;
            string[] phrases = { "Applying AI", "Adding Stars", "Giving Weather" };
            for (int i = 0; i <= totalBars; i++)
            {
                string progressBar = ">>[" + new string('#', i) + new string('-', totalBars - i) + "]";
                Console.Write("\r{0} {1}%", progressBar, i * 100 / 10);
                Thread.Sleep(delay);
            }
            Console.Write(message +'\n');
        }
        static char[] shuffleWords(string unshuffled)
        {
            string word = unshuffled;
            char[] charArray = word.ToCharArray();
            Random random = new Random();

            for (int i = charArray.Length - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                char temp = charArray[i];
                charArray[i] = charArray[j];
                charArray[j] = temp;
            }
            return charArray;
        }
        static void simulateWorld()
        {
            int totalBars = 69;
            int delay = 200;
            string[] phrases = { "Adding. 'You' and 'Me'.", "Generating the Universe", "Adding Star and Moons..", "Crafting the Narrative." };
            Random random = new Random();         
            Console.WriteLine("████████Generating World████████");
            Console.WriteLine("     *   .                  .              .        .   *          .\r\n  .         .                     .       .           .      .        .\r\n        o                             .                   .\r\n         .              .                  .           .\r\n          0     .\r\n                 .          .                 ,                ,    ,\r\n .          \\          .                         .\r\n      .      \\   ,\r\n   .          o     .                 .                   .            .\r\n     .         \\                 ,             .                .\r\n               #\\##\\#      .                              .        .\r\n             #  #O##\\###                .                        .\r\n   .        #*#  #\\##\\###                       .                     ,\r\n        .   ##*#  #\\##\\##               .                     .\r\n      .      ##*#  #o##\\#         .                             ,       .\r\n          .     *#  #\\#     .                    .             .          ,\r\n                      \\          .                         .\r\n____^/\\___^--____/\\____O______________/\\/\\---/\\___________---______________\r\n   /\\^   ^  ^    ^                  ^^ ^  '\\ ^          ^       ---\r\n         --           -            --  -      -         ---  __       ^\r\n   --  __                      ___--  ^  ^                         --  __");
            Console.WriteLine("Seed ID: 03108891624980232");
            for (int i = 0; i <= totalBars; i++)
            {
                string randomPhrase = phrases[random.Next(phrases.Length)];
                string progressBar =   randomPhrase+" [" + new string('#', i) + new string('-', totalBars - i) + "]";
                double percent = Math.Ceiling(i * 10 / 6.9);
                Console.Write("\r{0} {1}%", progressBar, percent);
                Thread.Sleep(delay);
            }
            Console.WriteLine();
        }
        public static void writeSeperator(int lineLenght)
        {
            for(int i = 0;i <= lineLenght; i++)
            {
                Console.Write("*");
                Thread.Sleep(2);
            }
            Console.WriteLine();
        }
        public static void LayDown()
        {
            List<string> listy = new List<string> { "bVJijcss", "ijcssjzpTjH9no@K-emz", "1+Rza-<cT+G\"sC6IhJci!b ", "8V!g8WFkHzm<", "9no@K-emz", "56.23.15  >>Completed" };
            int count2 = 0;
            foreach (string c in listy)
            {
                string cc = listy[count2 % listy.Count];
                Console.Write(cc + "\r");
                Thread.Sleep(100);
                count2++;
            } 
            
            Console.WriteLine();
        }
        public static void animateText(string word, string actorTalk, int loops)
        {


            for (int a = 0; a < loops ; a++)
            {
               
                string cc = new string(shuffleWords(word));
                Console.Write(actorTalk +" "+cc + "\r");
                Thread.Sleep(50);
            }
            switch (actorTalk)
            {
                case "[Console]":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
            }

            Console.Write(actorTalk + " " + word +"\r");
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
