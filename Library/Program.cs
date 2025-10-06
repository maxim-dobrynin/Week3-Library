class Book
{
    string Title;
    string Author;
    string ISBN;

    void DisplayInfo()
    {
        Console.WriteLine($"Book title: {Title}");
        Console.WriteLine($"Book Author: {Author}");
        Console.WriteLine($"Book ISBN: {ISBN}");
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        // New instance (object) of Book class
        Book book = new Book();

        // Information for book
        book.Title = "C# for beginners";
        book.Author = "Bill Gates";
        book.ISBN = "12345678";

        // This is another book object
        Book book1 = new Book();
        book1.Title = "C# methods and Classes";
        book1.Author = "Microsoft";
        book1.ISBN = "55667778";

        // Output first book information
        Console.WriteLine($"Book title: {book.Title}");
        Console.WriteLine($"Book Author: {book.Author}");
        Console.WriteLine($"Book ISBN: {book.ISBN}");

        // Output second book information
        book.DisplayInfo();
        book1.DisplayInfo();
    }
}