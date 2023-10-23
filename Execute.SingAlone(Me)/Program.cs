using System;
using System.Collections.Generic;
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
            //Intro();
            string mp3FilePath = "executeMe.mp3";
            var audioFile = new AudioFileReader(mp3FilePath);
            var songTask = Task.Run(() =>
            {
                using (var outputDevice = new WaveOutEvent())
                {

                    outputDevice.Init(audioFile);
                    outputDevice.Play();
                    while (outputDevice.PlaybackState == PlaybackState.Playing)
                    {
                        Thread.Sleep(1);
                    }
                }
            });
            var countdownTask = Task.Run(() =>
            {
                world.worldExecuteMe();
            });

            Task.WaitAll(songTask, countdownTask);


        }
     
    }
}
