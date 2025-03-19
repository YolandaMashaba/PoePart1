Cybersecurity Awareness Bot - README

Description:
------------
The Cybersecurity Awareness Bot is a console-based chatbot designed to educate users about cybersecurity topics such as password safety, phishing, and safe browsing. The bot provides predefined responses to user queries and features an ASCII art logo and a voice greeting.

Files:
------
1. responses.txt:
   - Contains the bot's predefined responses.
   - Format: Each line is a key-value pair (e.g., "how are you: I'm just a bot, but I'm here to help you, {0}!").

2. logo.txt:
   - Contains the ASCII art logo displayed at the start of the program.

3. greeting.wav:
   - Contains the voice greeting played when the chatbot starts.
   - Must be a WAV file.

Setup Instructions:
-------------------
1. Ensure all required files (responses.txt, logo.txt, greeting.wav) are placed in the same directory as the executable or specify the correct paths in the code.
2. Compile and run the program.

Usage:
------
- When the program starts, the ASCII art logo and voice greeting will be displayed.
- The bot will ask for your name and then prompt you to ask questions.
- Type your questions, and the bot will respond based on the predefined responses.
- Type "exit" to end the program.

Example Interaction:
-------------------
Welcome to the Cybersecurity Awareness Bot!
You can ask me about cybersecurity topics like password safety, phishing, and safe browsing.

What's your name? Riley
Hello, Riley! How can I assist you today?

Riley: How are you?
Bot: I'm just a bot, but I'm here to help you, Alice! How can I assist you today?

Riley: Tell me about password safety.
Bot: Creating a strong password is crucial, Alice. Use a mix of letters, numbers, and special characters. Avoid using common words or personal information.

Riley: exit
Goodbye! Stay safe online.

