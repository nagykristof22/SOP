using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

class Program
{
    static List<Chat> chats = new List<Chat>();
    static User currentUser;

    static void Main()
    {
        Console.WriteLine("Welcome to the Chat Program!");

        // Bejelentkezés
        Console.Write("Enter your username: ");
        string username = Console.ReadLine();
        currentUser = new User(username);

        // Főmenü
        while (true)
        {
            Console.WriteLine("\nMain Menu:");
            Console.WriteLine("1. Create Chat");
            Console.WriteLine("2. List Chats");
            Console.WriteLine("3. Enter Chat");
            Console.WriteLine("4. Exit");

            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateChat();
                    break;
                case "2":
                    ListChats();
                    break;
                case "3":
                    EnterChat();
                    break;
                case "4":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void CreateChat()
    {
        Console.Write("Enter the chat name: ");
        string chatName = Console.ReadLine();
        Chat newChat = new Chat(chatName);
        chats.Add(newChat);
        Console.WriteLine($"Chat '{chatName}' created!");
    }

    static void ListChats()
    {
        Console.WriteLine("\nAvailable Chats:");
        foreach (var chat in chats)
        {
            Console.WriteLine($"- {chat.Name}");
        }
    }

    static void EnterChat()
    {
        Console.Write("Enter the chat name: ");
        string chatName = Console.ReadLine();
        Chat selectedChat = chats.FirstOrDefault(c => c.Name == chatName);

        if (selectedChat != null)
        {
            selectedChat.Enter(currentUser);
            ChatMenu(selectedChat);
        }
        else
        {
            Console.WriteLine($"Chat '{chatName}' not found.");
        }
    }

    static void ChatMenu(Chat chat)
    {
        while (true)
        {
            Console.WriteLine($"\nChat: {chat.Name}");
            Console.WriteLine("1. Send Message");
            Console.WriteLine("2. List Messages");
            Console.WriteLine("3. Exit Chat");

            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    SendMessage(chat);
                    break;
                case "2":
                    ListMessages(chat);
                    break;
                case "3":
                    chat.Exit(currentUser);
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void SendMessage(Chat chat)
    {
        Console.Write("Enter your message: ");
        string messageText = Console.ReadLine();
        Message newMessage = new Message(currentUser, messageText);
        chat.SendMessage(newMessage);
    }

    static void ListMessages(Chat chat)
    {
        Console.WriteLine($"\nMessages in {chat.Name}:");
        foreach (var message in chat.Messages)
        {
            Console.WriteLine($"- {message.Sender.Username}: {message.Text}");
        }
    }
}

class User
{
    public string Username { get; }
    public User(string username)
    {
        Username = username;
    }
}

class Message
{
    public User Sender { get; }
    public string Text { get; }
    public DateTime Timestamp { get; }

    public Message(User sender, string text)
    {
        Sender = sender;
        Text = text;
        Timestamp = DateTime.Now;
    }
}

class Chat
{
    public string Name { get; }
    public List<User> Participants { get; }
    public List<Message> Messages { get; }

    public Chat(string name)
    {
        Name = name;
        Participants = new List<User>();
        Messages = new List<Message>();
    }

    public void Enter(User user)
    {
        if (!Participants.Contains(user))
        {
            Participants.Add(user);
            Console.WriteLine($"{user.Username} entered the chat '{Name}'.");
        }
        else
        {
            Console.WriteLine($"{user.Username} is already in the chat '{Name}'.");
        }
    }

    public void Exit(User user)
    {
        Participants.Remove(user);
        Console.WriteLine($"{user.Username} exited the chat '{Name}'.");
    }

    public void SendMessage(Message message)
    {
        Messages.Add(message);
        Console.WriteLine($"{message.Sender.Username} sent a message to '{Name}': {message.Text}");
    }
}
