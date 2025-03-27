using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoePart1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new VoiceGreeting() { };
            new AsciiArt() { };
            new ResponseSystem() { };

            //Define file paths
           string audioFilePath = "C:\\Users\\ntsal\\source\\repos\\PoePart1\\resources\\greeting.wav";//Path to the audio recording
           string responseFilePath = "C:\\Users\\ntsal\\source\\repos\\PoePart1\\resources\\responses.txt";//Path to the responses file
        }
    }
}
