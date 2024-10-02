using LMSBL;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Create an author
        Author author = new Author
        {
            AuthorId = 1,
            AuthorName = "J.K. Rowling"
        };

        // Create a publication
        Publication publication = new Publication
        {
            PublicationID = 101,
            Name = "Bloomsbury"
        };

        // Create a book
        Book book = new Book
        {
            Id = 1,
            Title = "Harry Potter and the Philosopher's Stone",
            Price = 19.99m,
            Available = true,
            Author = author,
            NoOfPages = 223
        };

        // Create a magazine
        Magazines magazine = new Magazines
        {
            Id = 2,
            Title = "National Geographic",
            Price = 5.99m,
            Available = true,
            NoOfPages = 100,
            Publication = publication
        };

        // Create an audiobook
        AudioBook audioBook = new AudioBook
        {
            Id = 3,
            Title = "Harry Potter and the Chamber of Secrets",
            Price = 14.99m,
            Available = false,
            Author = author,
            Duration = 8.5
        };

        // Check availability and print details
        Console.WriteLine($"{book.Title} by {book.Author.AuthorName} is {book.CheckAvailability()}");
        Console.WriteLine($"{magazine.Title} published by {magazine.Publication.Name} is {magazine.CheckAvailability()}");
        Console.WriteLine($"{audioBook.Title} by {audioBook.Author.AuthorName} is {audioBook.CheckAvailability()}");
    }
}

