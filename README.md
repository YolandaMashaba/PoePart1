# Cyber Chat: Cybersecurity Awareness Bot 💻🔒

A console-based chatbot designed to educate users about essential cybersecurity topics through interactive conversations. Built with C# .NET.

## Description
Cyber Chat is an interactive console application that raises awareness about critical cybersecurity practices. 
Built with C# .NET, it provides guided conversations on topics like password safety, phishing, and secure browsing. 
The bot greets users with a voice message and dynamically responds to questions using a customizable knowledge base.

## Features: ✨
- **Predefined Security Topics**: Answers questions about password safety, phishing, malware, and more
- **Personalized Interaction**: Addresses users by name using string formatting
- **ASCII Art Logo**: Displays cybersecurity-themed ASCII art on launch
- **Voice Greeting**: Plays WAV audio welcome message using System.Media
- **Easy Configuration**: Simple text-based response system for customization
- **Cross-platform**: Runs on any system with .NET Runtime installed

## Solution Structure 📁
PoePart1.sln
    -Program.cs
    -CyberChat.cs
    -VoiceGreeting.cs
    -ResponseSystem.cs
    -AsciiArt.cs
  resources
    -greeting.wav
    -responses.txt

## Setup Instructions: 📝
1. Ensure all required files (responses.txt, greeting.wav) are placed in the same directory as the executable or specify the correct paths in the code.
2. Compile and run the program.

## Usage:
- When the program starts, the ASCII art logo and voice greeting will be displayed.
- The bot will ask for your name and then prompt you to ask questions.
- Type your questions, and the bot will respond based on the predefined responses.
- Type "exit" to end the program.

## Example Interaction: 🗣💻
Welcome to the Cyber Chat a Cybersecurity Awareness Bot!
You can ask me about cybersecurity topics like password safety, phishing, and safe browsing.

I am Cyber Chat. What should I call you? 
user name
Hello, user name! How can I assist you today?
user name: How are you?
Cyber Chat: I'm just a bot, but I'm here to help you, user name! How can I assist you today?
user name: Tell me about password safety.
Cyber Chat: Creating a strong password is crucial, user name. Use a mix of letters, numbers, and special characters. Avoid using common words or personal information.
user name: exit
Goodbye! Stay safe online.
    
