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
