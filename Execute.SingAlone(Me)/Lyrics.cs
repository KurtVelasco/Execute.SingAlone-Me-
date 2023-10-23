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
        public static void slowType(string text, int delayMilliseconds, bool newLine, int spaceNumber, string color)
        {
            TimeSpan delay = TimeSpan.FromMilliseconds(delayMilliseconds);
            Console.ForegroundColor = ConsoleColor.Green;
            switch (color)
            {
                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "blue":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case "yellow":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
            }
            Console.Write("[Console] ");
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
            if (newLine)
            {
                Console.WriteLine("");
                for (int i = 0; i < spaceNumber; i++)
                {
                    Console.WriteLine("");
                }
            }
            Console.ResetColor();
        }
      
        public static void worldExecuteMe()
        {
            slowType("Switch on the Power Line", 50,true,0,"");
            readFile("textFiles/logoRhine");
            slowType("Remember to Put on -- P R O T E C T I O N", 50, true, 2, "");
            Console.WriteLine("\u001b[33m>encryptEnigma();\u001b[0m");
            simulateLoading(" Encryption Set",20,10);
            Console.WriteLine("");
            slowType("Lay down your pieces and let's begin \u001b[33m objectCreation(); \u001b[0m", 50, true, 0, "");
            animateText("[Console] Fill in my data.", "", "green", 5,false);
            readFile("textFiles/createObject");
            slowType("Parameters. ", 70, true, 0, "");
            List<string> listy = new List<string> { "bVJijcss", "ijcssjzpTjH9no@K-emz", "1+Rza-<cT+G\"sC6IhJci!b ", "8V!g8WFkHzm<", "9no@K-emz", "56.23.15  >> Rotors ON " };
            encryptWall(3,listy);
            slowType("Initialization.", 60, true, 0, "");
            readFile("textFiles/getError");
            animateText("world.toggleValidity(false)", "", "yellow", 3, false);
            animateText("world.toggleTelementary(false)", "", "yellow", 3, false);
            simulateLoading(" Applyting World Settings",10,10);
            slowType("Setup our new world", 40, true, 0, "");
            animateText("World world = new World(5);", "", "yellow", 1, false);
            animateText("world.addThing(me);", "", "yellow", 1, false);
            animateText("world.addThing(You);", "", "yellow", 1, false);
            slowType("let's begin...", 30, true, 0, "");
            slowType("T H E  S I M U L A T I O N <3", 45, true, 0, "");
            animateText("world.activateSimulation()", "", "yellow", 5, false);
            simulateWorld();
            Thread.Sleep(200);
            //2nd Chorus
            ////
            readFile("textFiles/newWorldSettings");
            slowType("If I'm a set of points.", 50, true, 0, "");
            slowType("then I will give you my dimensions", 45, false, 0, "");
            animateText("getDimension();", "[Console] then I will give you my", "green", 5, true);
            readFile("textFiles/getDimension");
            slowType("If I'm a circle.", 70, true, 0, "");
            slowType("then I will give you my circumference.", 45, false, 0, "");
            animateText("getCircumference();", "[Console] then I will give you my ", "green", 5, true);
            readFile("textFiles/getCircumference");
            slowType("If I'm a sineWave.", 50, true, 0, "");
            slowType("then you can sit on all my tangents", 50, false, 0, "");
            animateText("getTangents()", "[Console]", "green", 5, false);
            readFile("textFiles/getTangent");
            slowType("If I approach infinty", 70, true, 0, "");
            animateText("[Console] then you can be my limitations", "", "green", 10, true);
            List<string> infinity = new List<string> { " 22145432389", "    32312421424242", "     4124143545433", "       █████████", "         ███████████████", "you.appplyLimitation(me,int.max);" };
            encryptWall(1, infinity);   
            slowType("Switch my Current", 80, true, 0, "");
            List<string> ACDC = new List<string> { "DC ---> AC", "Conve", "Converting...", "Converting.. to AC to DC", "████████████████████████████████████ 98%   ", "               Converted AC to DC               " };
            encryptWall(1, ACDC);           
            slowType("And then blind my Vision", 70, true, 0, "");
            slowType("So dizzy,", 120, true, 0, "");
            animateText("WARNING: Setting me.toggleVision() OFF will ----", "", "yellow", 5, false);
            animateText("WARNING: Setting me.toggleVision() OFF will ----", "", "yellow", 5, false);
            slowType("So dizzy", 120, true, 0, "");
            animateText("world.disableWarnings()","","yellow", 5, false);
            slowType("Oh, we can travel to... ", 80, true, 0, "");
            slowType("AB to BC", 120, true, 0, "");
            animateText("Year: 2332 BC", "[World] Setting Date to: ", "", 5, false);
            List<string> timeTravel = new List<string> { "[World] Setting Locations:████████████ ", "[World]: Setting Locations: BABY████████████ ", "[World]: Setting Locations: BABYLON, Year: 2332 B.C " };
            encryptWall(1, timeTravel);
            slowType("And we can unite to", 70, true, 0, "");
            readFile("textFiles/getDeeply");
            slowType("soo deeply,", 80, true, 0, "");
            animateText("me.addLover('you')", "", "yellow", 3, false);
            slowType("soo deeply", 80, true, 0, "");
            animateText("you.addLover('me')", "", "yellow", 3, false);
            slowType("If I can", 110, true, 0, "");
            slowType("If I can", 110, true, 0, "");
            slowType("give you all the", 60, true, 0, "");
            slowType("S T I M U L A T I O N S", 60, true, 0, "");
            animateText("you.getAffections();", "[World] Applying 'You' ", "", 3, false);
            slowType("Then I can, then I can be your only S A S T I F A C T I O N", 40, true, 0, "");
            animateText("world.removeCharacters('all','nonEssential');", "", "yellow", 3, false);
            animateText("[REDACTED]", "[World] Deleting Character: ", "", 2, false);
            animateText("[REDACTED]", "[World] Deleting Character: ","", 2, false);
            slowType("If I can make you happy,", 50, true, 0, "");
            slowType("I will run the  \u001b[31mworld.execution();\u001b[0m", 50, true, 0, "");
            readFile("textFiles/newWorldSettings");
            slowType("Though we are trapped in this STRANGE, strange simulation", 40, true, 0, "");
            slowType("If I'm an eggplant", 90, true, 0, "");
            readFile("textFiles/getEggplant");
            slowType("the I will you my nutrients", 70, true, 0, "");
            animateText("if(me is Eggplant) => you.addAttribute(me.getAttribute('nutrients'))", "", "", 2, false);
            slowType("If I'm a tomato,", 90, true, 0, "");
            animateText("if(me is Apple) => you.addAttribute(me.getAttribute('antioxidants'))", "", "", 2, false);
            slowType("then I will give you antioxidants", 60, true, 0, "");
            readFile("textFiles/getTomato");
            slowType("If I'm a tabby cat,", 90, true, 0, "");
            animateText("if(me is Cat){ => you.addAttribute(me.getLanguage('meow'))", "", "", 2, false);
            slowType("then I will purr for your enjoyment", 50, true, 0, "");
            readFile("textFiles/getCat");
            slowType("If I'm the only \u001b[31mGOD\u001b[0m,", 55, true, 0, "");
            animateText("[REDACTED] as Owner", "[World] Set player ", "", 2, false);
            animateText("[REDACTED] as Owner", "[World] Set player ", "", 2, false);
            animateText("[REDACTED] as Owner", "[World] Set player ", "", 2, false);
            slowType("then you're the proof of my ", 55, false, 0, "");
            animateText("E X I S T A N C E", "[World] Set player", "red", 3, false);
            slowType("Switch my gender to \u001b[31mF to M\u001b[0m", 80, true, 0, "");
            animateText("Male", "[World] Set player's gender:", "", 3, false);
            slowType("And then do whatever from \u001b[31mAM to PM\u001b[0m", 80, true, 1, "");
            animateText("UTC + 8", "[World] Changing Timezone:", "", 5, false);
            animateText("4:23 P.M 22/10/2023", "[World] Updating Time: ", "", 5, false);
            slowType("Oh, switch my role \u001b[31mS to M\u001b[0m", 90, true, 1, "");
            slowType("((Lovable)me.toggleKink())", 50, true, 0, "yellow");
            slowType("So we can enter the trance, the trance", 80, true, 0, "");
            List<string> trance = new List<string> { "th", "the T","the Tra", "the Tran%&^*(", "      the Trance" };
            encryptWall(2, trance);
            slowType("If I can,", 80, true, 0, "");
            slowType("If I can", 80, true, 0, "");
            slowType("if I can, feel your vibrations", 80, true, 0, "");
            readFile("textFiles/getVibration");
            slowType("then I can finally be completion", 60, true, 0, "1");
            simulateLoading("C O M P L E T I O N", 10, 10);
            Console.WriteLine();
            slowType("Though you have left,", 60, true, 1, "1");
            slowType("Though you have left,", 60, true, 1, "1");
            Console.WriteLine("");
            animateText("THOUGH YOU HAVE LEFT!", "[Console] ", "red", 10, false);
            Console.WriteLine("");
            animateText("THOUGH YOU HAVE LEFT!", "[Console] ", "red", 10, false);
            slowType("You have left me in isolation", 70, true, 0, "");


            slowType("If I can,", 80, true, 0, "1");
            slowType("If I can", 80, true, 0, "1");
            slowType("Erase all the pointless fragments", 80, true, 0, "");
            slowType("Then maybe,", 80, true, 0, "");
            slowType("then maybe, you won't leave me so disheartened", 80, true, 1, "");
            slowType("Challenging your God", 80, true, 1, "");
            slowType("You have made some ILLEGAL ARGUMENTS", 80, true, 0, "red");



        }

        public static void simulateLoading(string message, int delayAmount, int barAmount)
        {
            int totalBars = 10;
            int delay = delayAmount;
            string[] phrases = { "Applying AI", "Adding Stars", "Giving Weather" };
            for (int i = 0; i <= totalBars; i++)
            {
                string progressBar = "[" + new string('#', i) + new string('-', totalBars - i) + "]";
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
            readFile("textFiles/generatingWorld");
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

        public static void encryptWall(int loopAmount, List<string> wordBlock)
        {
            
            int sleepAmount = (int)Math.Ceiling((double)100/loopAmount);
            for (int i = 0; i < loopAmount ; i++) {
                int count2 = 0;
                foreach (string c in wordBlock)
                {
                    string cc = wordBlock[count2];
                    Console.Write(cc + "\r");
                    Thread.Sleep(sleepAmount);
                    count2++;
                }
                Console.WriteLine();
            }
            
        }
        public static void animateText(string animateWord, string actorTalk ,string color, int loops, bool sepColor)
        {
            Console.Write("\r");
            for (int a = 0; a < loops ; a++)
            {          
                string cc = new string(shuffleWords(animateWord));
                Console.Write(actorTalk + "" + cc +"\r");
                Thread.Sleep(50);
            }
            switch (color)
            {
                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "blue":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case "yellow":
                    Console.ForegroundColor = ConsoleColor.Yellow; 
                    break;
                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
            }
            if (sepColor)
            {
                Console.Write("\r" + actorTalk + " " + "\u001b[33m"+ animateWord + "\u001b[0m");
            }
            else
            {
                Console.Write("\r" + actorTalk + " " + animateWord);
            }

            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
