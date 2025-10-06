using Library;

class Program
{
    static void Main(string[] args)
    {
        // Create new instance (object) of Book class
        Book book = new Book("C# for beginners", "Bill Gates", "1234567");

        book.DisplayInfo();
    }
}