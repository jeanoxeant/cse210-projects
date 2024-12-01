using System;


class Program
{
  static void Main(string[] args)
  {
    Journal journal = new Journal();
    bool isRunning = true;

    while (isRunning)
    {
      Console.WriteLine("\nMenu:");
      Console.WriteLine("1. Write a new entry");
      Console.WriteLine("2. Display the journal");
      Console.WriteLine("3. Save the journal to a file");
      Console.WriteLine("4. Load the journal from a file");
      Console.WriteLine("5. Exit");

      Console.Write("Please select an option from the menu above: ");
      string choice = Console.ReadLine();

      switch (choice)
      {
        case "1":
          string prompt = PromptGenerator.GetRandomPrompt();
          Console.WriteLine($"Prompt: {prompt}");
          Console.Write("Please enter your response: ");
          string response = Console.ReadLine();
          journal.AddEntry(prompt, response);
          break;


        case "2":
          if (journal.EntriesCount() == 0)
          {
              Console.WriteLine("Your journal is empty. Please add some entries before continuing.");
          }
          else
          {
              journal.DisplayEntries();
          }
          break;


        case "3":
          Console.Write("Please write the file name: ");
          string saveFileName = Console.ReadLine();
          journal.SaveToFile(saveFileName);
          Console.WriteLine("Your journal has been saved successfully.");
          break;

        case "4":
          Console.Write("Please write the file name: ");
          string loadFileName = Console.ReadLine();
          journal.LoadFromFile(loadFileName);
          Console.WriteLine("Your journal has been loaded successfully.");
          break;

        case "5":
          isRunning = false;
          break;

        default:
          Console.WriteLine("Invalid choice. Please select a number between 1 to 5.");
          break;
      }
    }
  }
}    