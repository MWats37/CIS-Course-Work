/*
 * Grading ID: K7987
 * Program 4
 * Due: 12/01/2021 (extension until 12/03/2021)
 * CIS 199 - 01
 * The purpose of this lab is to use classes and properties in order to change and display different data about library books, including title, author, publisher, publication year, ISBN, and check out status
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program4
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiating the 5 library book objects
            LibraryBook book1 = new LibraryBook("To Kill a Mockingbird", "Harper Lee", "J. B. Lippincott & Co.", 1960, "9780060");
            LibraryBook book2 = new LibraryBook("1984", "George Orwell", "Secker & Warburg", 1949, "9780451");
            LibraryBook book3 = new LibraryBook("Fahrenheit 451", "Ray Bradbury", "Simon & Schuster", 1953, "9780564");
            LibraryBook book4 = new LibraryBook("The Catcher in the Rye", "J. D. Salinger", "Little, Brown", 1951, "9790451");
            LibraryBook book5 = new LibraryBook("The Way of Kings", "Brandon Sanderson", "Tor Books", 2010, "9740256");

            //array for storying the objects
            LibraryBook[] books = new LibraryBook[] { book1, book2, book3, book4, book5 };

            //print out all books' original data
            ListAllBooks(books);

            //change the book information
            book1.ISBN = "9845345"; // changing ISBN
            book2.BookPublisher = "James Cameron"; //Changing the publisher
            book3.CheckedOut(); //changing status to checked out
            book4.ISBN = "9873214"; //changing the ISBN
            book5.CheckedOut(); //changing status to checked out

            //print out all new book data
            ListAllBooks(books);

            //calling the method ReturnToShelf to show that the books have been returned
            book3.ReturnToShelf();
            book5.ReturnToShelf();

            //print out all the books data 
            ListAllBooks(books);

        }
        //method to print out all books' data to console
        private static void ListAllBooks(LibraryBook[] books)
        {
            foreach(LibraryBook book in books)
            {
                Console.WriteLine(book);
            }
        }
    }
}
