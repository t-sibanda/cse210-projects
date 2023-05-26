using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journal
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create a new journal.
            Journal journal = new Journal();

            // Prompt the user for a prompt.
            string prompt = journal.GetPrompt();

            // Get the user's response.
            string response = journal.GetResponse(prompt);

            // Save the entry.
            journal.SaveEntry(prompt, response);

            // Display the journal.
            journal.Display();
        }
    }

    public class Journal
    {
        private List<Entry> entries = new List<Entry>();

        public void SaveEntry(string prompt, string response)
        {
            // Create a new entry.
            Entry entry = new Entry();
            entry.Prompt = prompt;
            entry.Response = response;
            entry.Date = DateTime.Now;

            // Add the entry to the journal.
            entries.Add(entry);
        }

        public void Display()
        {
            // Iterate through all entries in the journal and display them to the screen.
            foreach (Entry entry in entries)
            {
                Console.WriteLine($"Prompt: {entry.Prompt}");
                Console.WriteLine($"Response: {entry.Response}");
                Console.WriteLine($"Date: {entry.Date}");
                Console.WriteLine();
            }
        }

        public string GetPrompt()
        {
            // Get a random prompt from the list of prompts.
            int index = 0;
            Random random = new Random();
            index = random.Next(Prompts.Length);
            string prompt = Prompts[index];

            return prompt;
        }

        public string GetResponse(string prompt)
        {
            // Prompt the user for a response.
            Console.WriteLine($"What is your response to the prompt: {prompt}?");
            string response = Console.ReadLine();

            return response;
        }

        private static readonly string[] Prompts = {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
    }

    public class Entry
    {
        public string Prompt { get; set; }
        public string Response { get; set; }
        public DateTime Date { get; set; }
    }
}