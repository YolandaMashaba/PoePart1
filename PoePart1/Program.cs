using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoePart1
{
    class Program
    {
        static void Main(string[] args)
        {
            new CyberChat() { };
            new VoiceGreeting() { };
            new ResponseSystem() { };
            new AsciiArt() { };

            /*Fix the errors above
             * Create README file
             * Complete the main class
             * regenerate the ascii art on the generator and add it to your resources on logo.txt
             * change the recording to a wav file and save it as greeting.wav
             */

            //Define file paths
            string responseFilePath = "C:\\Users\\ntsal\\source\\repos\\poe_part1\\resources\\responses.txt";//Path to the responses file
            string audioFilePath = "C:\\Users\\ntsal\\source\\repos\\poe_part1\\resources\\greeting.wav";//Path to the audio recording

            //Instantiate the chatbot 
            CyberChat chat = new CyberChat(responseFilePath, audioFilePath);

            //Run the chat
            chat.Run();
        }
    }
}
