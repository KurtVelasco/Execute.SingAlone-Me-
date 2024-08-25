using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NAudio.Wave;

namespace Execute.SingAlone_Me_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            readFile("textFiles/user");
            Console.Write(">");
            string pass = Console.ReadLine();
            if (pass != "run world.exec")
            {
                return;
            }
            world.animateText("Song: World.Execute(Me)", "", "white", 10, false);
            world.animateText("Producer: Mili", "", "white", 10, false);
            Thread.Sleep(2000);
            Console.Clear();

            //World.Execute.(Me)
            //by: Mili

            string musicFile = "executeMe.mp3";
            var audioRender = new AudioFileReader(musicFile);
            var songTask = Task.Run(() =>
            {
                using (var outputDevice = new WaveOutEvent())
                {

                    outputDevice.Init(audioRender);
                    outputDevice.Play();
                    while (outputDevice.PlaybackState == PlaybackState.Playing)
                    {
                        Thread.Sleep(1);
                    }
                }
            });
            var WorldExecute = Task.Run(() =>
            {
                world.worldExecuteMe();
            });


            Task.WaitAll(songTask, WorldExecute);


        }
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
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

    }
}
