POE PART1
# Cybersecurity Awareness Bot

## Student Information

**Name:** Bhekithemba David Mkuzo
**Project:** Cybersecurity Awareness Bot
**Programming Language:** C#

---

## 1. Project Description

The Cybersecurity Awareness Bot is a C# console application designed to provide users with basic cybersecurity awareness and advice.

The application allows the user to interact with a chatbot and ask questions about common cybersecurity topics such as password safety, phishing and safe browsing.

The main purpose of the project is to help users understand some basic ways of staying safe when using computers, websites and online services.

---

## 2. How the Application Works

When the application starts, it first plays a voice greeting and displays cybersecurity artwork in the console.

The user is then asked to enter their name. The program uses the name entered by the user to create a personalised greeting.

After the greeting, the user can interact with the chatbot by entering questions or topics related to cybersecurity.

The chatbot continues running through a conversation loop, which allows the user to ask more than one question during the same session.

---

## 3. Main Features

The application includes the following features:

* Voice greeting when the application starts.
* Cybersecurity artwork displayed in the console.
* Personalised greeting using the user's name.
* Conversation loop for multiple questions.
* Responses about password safety.
* Responses about phishing.
* Responses about safe browsing.
* Input validation for the user's name.
* Console colours to improve readability.
* Use of a `ChatBot` class to organise the chatbot functionality.
* Automatic properties for storing information such as the user's name and cybersecurity tip.
* String processing using methods such as `ToLower()` and `Trim()`.
* GitHub repository for storing and tracking the project.
* Meaningful Git commits showing the development process.
* GitHub Actions workflow for automatically building the C# project.

---

## 4. Technologies Used

The following technologies and tools were used to develop the project:

* **C#** – Main programming language.
* **.NET** – Used to build and run the C# application.
* **Visual Studio / Visual Studio Code** – Development environment.
* **Git** – Used for version control.
* **GitHub** – Used to store the project repository.
* **GitHub Actions** – Used to automatically build the project when changes are pushed.

---

## 5. C# Concepts Used

Several C# programming concepts were used in the application.

### Classes

A `ChatBot` class was created to keep the chatbot functionality organised. This makes the code easier to manage and separates the chatbot functionality from the rest of the application.

### Automatic Properties

Automatic properties are used to store information such as the user's name and the cybersecurity tip.

### Loops

A conversation loop allows the user to continue interacting with the chatbot instead of the program ending after one question.

### String Methods

The `ToLower()` method is used to make text lowercase, while `Trim()` removes unnecessary spaces from the beginning and end of the user's input. This makes it easier for the program to process different types of user input.

### Input Validation

Input validation is used to check whether the user has entered valid information. For example, if the user does not enter a name, the program asks them to enter a valid name.

### Console Formatting

Console colours are used to make different parts of the application easier to read and understand.

---

## 6. Cybersecurity Topics Covered

The chatbot provides basic information about several cybersecurity topics.

### Password Safety

The chatbot provides advice about creating and maintaining safer passwords and explains why password security is important.

### Phishing

The chatbot provides basic information about phishing and helps users understand why they should be careful with suspicious messages, emails and links.

### Safe Browsing

The chatbot provides general advice about browsing the internet safely and being careful when visiting unfamiliar websites.

---

## 7. Project Structure

A simplified structure of the project is shown below:

```text
CybersecurityAwarenessBot/
│
├── ChatBot.cs
├── Program.cs
├── CybersecurityAwarenessBot.csproj
│
└── .github/
    └── workflows/
        └── build.yml
```

The exact file names may be different depending on the final project structure.

---

## 8. GitHub and Version Control

The project is stored on GitHub using Git for version control.

Meaningful commits were used throughout the development of the application. These commits show the different stages of development and make it possible to track changes made to the project.

Using GitHub also provides a backup of the project and makes it easier to manage the source code.

**GitHub Repository:**
*Add your GitHub repository link here.*

---

## 9. GitHub Actions

A GitHub Actions workflow was created for the project.

The workflow automatically builds the C# project when changes are pushed to the GitHub repository.

This helps check that the project continues to build successfully after changes are made. It also helps identify build problems earlier during development.

The workflow is stored inside the `.github/workflows` folder of the repository.

---

## 10. Input Validation

Input validation was included to make the application more reliable.

For example, when the program asks the user for their name, it checks whether something has been entered. If the user leaves the name empty, the program asks them to enter a valid name.

The chatbot also uses `Trim()` and `ToLower()` to make user input easier to process.

---

## 11. Example Interaction

A basic interaction with the application can look like this:

```text
========================================
     CYBERSECURITY AWARENESS BOT
========================================

Hello! Welcome to the Cybersecurity Awareness Bot.

Please enter your name:
Bhekithemba

Hello Bhekithemba! How can I help you
with cybersecurity today?

You: What is phishing?

Bot: Phishing is a type of cyber attack where
someone tries to trick you into giving away
personal information or clicking on a harmful link.

You: How can I create a safe password?

Bot: Use a strong and unique password and avoid
using information that is easy for others to guess.

You: exit

Thank you for using the Cybersecurity Awareness Bot.
Stay safe online!
```

*The exact output may differ depending on the final version of the program.*

---

## 12. Future Improvements

The application could be improved in the future by adding more cybersecurity topics and making the chatbot understand a wider range of questions.

Possible improvements include:

* Adding more cybersecurity tips.
* Adding more responses to different questions.
* Adding a graphical user interface.
* Adding more advanced natural-language processing.
* Adding a scoring system or cybersecurity quiz.
* Saving conversation history.
* Adding support for more languages.
* Improving the voice interaction.

---

## 13. Conclusion

The Cybersecurity Awareness Bot was created to provide users with simple cybersecurity information through a C# console application.

The project demonstrates different C# concepts, including classes, automatic properties, loops, string methods and input validation. Git and GitHub were also used to manage the project and track development.

The GitHub Actions workflow provides an additional way of checking that the project continues to build successfully when changes are made.

Overall, the project helped demonstrate how C# programming concepts can be combined to create a simple application that provides useful cybersecurity awareness.

---

## 14. Author

**Bhekithemba David Mkuzo**

C# Cybersecurity Awareness Bot Project
https://github.com/terrismkuzo-web/ConsoleApp1.git
https://youtu.be/2XBD6HKtQaw

# Cyber Awareness Chatbot GUI - PROG6221 POE Part 2

WPF Chatbot that promotes cybersecurity awareness with memory, sentiment, and delegate.

## Features Implemented (Rubric)
- Q1: WPF GUI, voice greeting (greeting.wav), ASCII art image (ascii_logo.png), neat colors
- Q2: Keyword Recognition using Dictionary<string, List<string>> - password, scam, privacy, phishing, malware
- Q3: Random Responses using List<string> + Random class
- Q4: Conversation Flow - handles "another tip", "tell me more", "explain more"
- Q5: Memory & Recall - stores name and favourite topic, personalizes responses
- Q6: Sentiment Detection - worried, frustrated, curious + auto-shares tip (no re-input needed)
- Q7: Error Handling - default response, try-catch for WAV
- Q8: Optimisation - Dictionaries, Lists, Classes, Methods, Delegate

## How to Run
1. Place greeting.wav and ascii_logo.png in /Assets (Build Action: Content, Copy Always)
2. Build and Run

## Delegate Usage
public delegate string ChatbotResponseDelegate(string userInput);
Used in ChatbotEngine.cs - responseHandler = ProcessInput;

## Technologies
C#.NET 8.0 WPF, System.Media.SoundPlayer
 
## 1. Project Overview

The Cybersecurity Awareness Chatbot is a C# application designed to educate users about cybersecurity and help them understand how to stay safe when using computers, mobile devices and the internet.

In Part 1, I developed a console-based chatbot that provided basic cybersecurity information. In Part 2, the project is extended by introducing a graphical user interface (GUI) using Windows Forms (WinForms). The aim is to make the chatbot easier to use and improve the way it interacts with users.

## 2. Project Objectives

The main objectives of this project are to:

- Develop a user-friendly graphical interface.
- Provide information about common cybersecurity threats.
- Recognise keywords in user messages.
- Generate relevant and varied chatbot responses.
- Remember selected information shared during a conversation.
- Detect basic sentiment in user messages.
- Support follow-up questions and maintain conversation flow.
- Apply C# programming concepts such as classes, methods, collections and delegates.
- Handle unexpected input without crashing the application.

## 3. Technologies Used

The following technologies and tools are used in the project:

- **Programming language:** C#
- **Framework:** .NET for Windows Forms
- **User interface:** Windows Forms (WinForms)
- **Development environment:** Visual Studio
- **Version control:** Git and GitHub
- **Voice functionality:** C# speech functionality, where implemented

## 4. Application Features

### 4.1 Graphical User Interface

The application uses a graphical interface to allow users to communicate with the chatbot. The interface is designed to display messages clearly and provide an input area and Send button for submitting questions.

### 4.2 Keyword Recognition

The chatbot checks user messages for keywords related to cybersecurity topics, such as phishing, passwords, malware, scams and online safety. It uses these keywords to identify the topic and provide a relevant response.

### 4.3 Random Responses

The chatbot can use collections of predefined responses to provide different answers to similar questions. This helps make conversations less repetitive.

### 4.4 Memory

The memory feature allows the chatbot to retain selected information shared by the user during the conversation. This information can be used to personalise later responses.

### 4.5 Sentiment Detection

The chatbot checks for basic words or phrases that may indicate a user's mood or feelings. It can adjust its response to provide a more suitable and supportive interaction.

### 4.6 Conversation Flow

The chatbot supports follow-up messages and uses the conversation context where implemented. This helps users continue a discussion without having to repeat the entire question.

### 4.7 Error Handling

The application handles unexpected or unrecognised messages by providing an appropriate response. This helps prevent the chatbot from failing when it receives input it does not understand.

### 4.8 Object-Oriented Programming

The project uses C# programming concepts such as classes and methods to organise the code. Collections and delegates are also used where required to manage information and support application functionality.

## 5. Installation and Setup

To run the project on a Windows computer:

1. Install Visual Studio with the appropriate .NET desktop development workload.
2. Clone or download the project from the GitHub repository.
3. Open the solution file (`.sln`) in Visual Studio.
4. Allow Visual Studio to restore any required dependencies.
5. Build the solution and check for compilation errors.
6. Run the application using the Start button or the `F5` keyboard shortcut.

The application requires a compatible Windows environment and the appropriate .NET runtime or development tools.

## 6. How to Use the Application

1. Launch the Cybersecurity Awareness Chatbot.
2. Read the welcome message displayed on the interface.
3. Type a cybersecurity-related question into the message input area.
4. Click the Send button to submit the message.
5. Read the chatbot's response in the conversation area.
6. Continue the conversation by asking another question or using a supported follow-up message.
7. Close the application when finished.

## 7. Example Questions

Users can try questions such as:

- What is phishing?
- How can I create a strong password?
- How do I recognise an online scam?
- What is malware?
- How can I protect my personal information online?
- What should I do if I receive a suspicious email?

The responses depend on the keywords and conversation features implemented in the application.

## 8. Testing

The application should be tested using different types of input to check that its features work correctly.

| Test | Expected result |
|---|---|
| Enter a cybersecurity question | The chatbot provides a relevant response. |
| Enter an unknown question | The chatbot displays a suitable fallback response. |
| Enter an empty message | The application prevents or handles the empty input. |
| Ask repeated questions | The chatbot responds according to its response logic. |
| Share information for memory | The chatbot retains the supported information during the conversation. |
| Enter messages with different sentiments | The chatbot responds according to its sentiment rules. |
| Use follow-up messages | The chatbot handles supported follow-up requests. |

Testing results should be updated after each test has been performed.

## 9. GitHub Repository and Version Control

GitHub is used to store the project source code and track changes throughout development. Meaningful commits help show the progress made while implementing the Part 2 requirements.

The repository should include the C# source files, project files, README documentation and any other required resources. Releases should be created according to the assignment instructions.

**Repository link:** [Insert your GitHub repository URL here]

## 10. Conclusion

Part 2 extends the original Cybersecurity Awareness Chatbot by introducing a graphical interface and additional interaction features. The project provides an opportunity to apply C# programming concepts to a practical application while helping users learn about cybersecurity.

Developing this application also improves my understanding of graphical user interfaces, object-oriented programming, collections, delegates, user input handling and software testing.

## 11. Author

**Name:** Bhekithemba Mkuzo 
**Module:** Programming 2A  
**Project:** Cybersecurity Awareness Chatbot – Part 2  
**Programming language:** C#
https://youtu.be/xxxxxx or https://www.youtube.com/watch?v=xxxxxx
## Video Presentation
YouTube Unlisted Link: https://youtu.be/YOUR_VIDEO_ID_HERE


