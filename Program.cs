namespace Prog120_S24_Assignment_Classes
{
    internal class Program
    {
        static Book[] books = new Book[10];
        static int bookCount = 0;
        static void Main(string[] args)
        {
            // Name: Vicky Le
            // Assignment: Classes
            // Date: 5/31/24

            Menu();

        } // Main
        public class Book
        {
            // Fields
            public string Title;
            public string Author;
            public int Year;

            // Constructor
            public Book(string title, string author, int year)
            {
                Title = title;
                Author = author;
                Year = year;
            }

            // Display Book Information
            public void Display()
            {
                Console.WriteLine($"Title: {Title}, Author: {Author}, Year: {Year}");
            }
        } // Book

        public static void AddNewBook()
        {
            if (bookCount >= 10)
            {
                Console.WriteLine("No more books can be added.");
                return;
            }
            Console.Write("Enter the title: ");
            string title = Console.ReadLine();
            Console.Write("Enter the author: ");
            string author = Console.ReadLine();
            Console.Write("Enter the year of publication: ");
            int year;

            while (!int.TryParse(Console.ReadLine(), out year) || year <= 0)
            {
                Console.Write("Please enter a valid year: ");
            }

            books[bookCount] = new Book(title, author, year);
            bookCount++;
            Console.WriteLine("Book added successfully.");
        } // AddNewBook()

        public static void DisplayAllBooks()
        {
            if (bookCount == 0)
            {
                Console.WriteLine("No books to display.");
                return;
            }

            for (int i = 0; i < bookCount; i++)
            {
                books[i].Display();
            }
        } // DisplayAllBooks()

        public static void UpdateBook()
        {
            Console.Write("Enter the title of the book to update: ");
            string title = Console.ReadLine();
            int index = -1;

            for (int i = 0; i < bookCount; i++)
            {
                if (books[i].Title.ToLower() == title.ToLower())
                {
                    index = i;
                    break;
                }
            }

            if (index == -1)
            {
                Console.WriteLine("Book not found.");
                return;
            }

            Console.Write("Enter the new title: ");
            string newTitle = Console.ReadLine();
            Console.Write("Enter the new author: ");
            string newAuthor = Console.ReadLine();
            Console.Write("Enter the new year of publication: ");
            int newYear;

            while (!int.TryParse(Console.ReadLine(), out newYear) || newYear <= 0)
            {
                Console.Write("Please enter a valid year: ");
            }

            books[index].Title = newTitle;
            books[index].Author = newAuthor;
            books[index].Year = newYear;
            Console.WriteLine("Book information updated successfully.");
        } // UpdateBook()

        public static void Menu()
        {
            while (true)
            {
                Console.WriteLine("Book Manager");
                Console.WriteLine("1. Add a new book");
                Console.WriteLine("2. Display all books");
                Console.WriteLine("3. Update a book's information");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    AddNewBook();
                }
                else if (choice == "2")
                {
                    DisplayAllBooks();
                }
                else if (choice == "3")
                {
                    UpdateBook();
                }
                else if (choice == "4")
                {
                    Console.WriteLine("Exiting...");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            }
        } // Menu
    } // Class
} // Namespace
