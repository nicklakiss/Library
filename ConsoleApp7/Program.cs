class Book
{
    private string author;
    private string title;
    private string publisher;
    private int year;
    private int pages;

    public Book(string author, string title, string publisher, int year, int pages)
    {
        this.author = author;
        this.title = title;
        this.publisher = publisher;
        this.year = year;
        this.pages = pages;
    }

    public string Author { get { return author; } }
    public string Title { get { return title; } }
    public string Publisher { get { return publisher; } }
    public int Year { get { return year; } }
    public int Pages { get { return pages; } }
}

class Program
{
    static void Main(string[] args)
    {
        Book[] books = new Book[]
        {
            new Book("Author1", "Title1", "Publisher1", 2000, 400),
            new Book("Author2", "Title2", "Publisher2", 2010, 300),
            new Book("Author3", "Title3", "Publisher1", 2015, 500),
            new Book("Author2", "Title4", "Publisher3", 2012, 450),
            new Book("Author4", "Title5", "Publisher4", 2005, 350),
            new Book("Author1", "Title6", "Publisher2", 2008, 250)
        };

        // список книг заданного автора
        string searchAuthor = "Author2";
        Console.WriteLine($"Books by {searchAuthor}:");
        foreach (Book book in books)
        {
            if (book.Author == searchAuthor)
            {
                Console.WriteLine($"{book.Title} ({book.Year})");
            }
        }
        Console.WriteLine();

        // список книг, выпущенных заданным издательством
        string searchPublisher = "Publisher2";
        Console.WriteLine($"Books published by {searchPublisher}:");
        foreach (Book book in books)
        {
            if (book.Publisher == searchPublisher)
            {
                Console.WriteLine($"{book.Title} ({book.Year})");
            }
        }
        Console.WriteLine();

        // список книг, выпущенных после заданного года
        int searchYear = 2010;
        Console.WriteLine($"Books published after {searchYear}:");
        foreach (Book book in books)
        {
            if (book.Year > searchYear)
            {
                Console.WriteLine($"{book.Title} ({book.Author})");
            }
        }
    }
}