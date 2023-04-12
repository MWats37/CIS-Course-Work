using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program4
{
    class LibraryBook
    {
        private bool _isCheckedOut;
        private string _bookTitle; //backing variables for the book title
        private string _bookAuthor; //backing variables for the book author
        private string _bookPublisher; //backing variables for the book publisher
        private int _yearOfPublication; //backing variables for the year of publication
        private string _iSBN; //backing variables for the ISBN

        //Constructor for the Library book class
        //precondition: all data entered are strings except for the year of publication
        //postcondition: books with those properties created
        public LibraryBook( string bookTitle, string bookAuthor, string bookPublisher, int yearOfPublication, string iSBN)
        {
            BookTitle = bookTitle;
            BookAuthor = bookAuthor;
            BookPublisher = bookPublisher;
            YearOfPublication = yearOfPublication;
            ISBN = iSBN;
        }

        //parameterless contructor
        public LibraryBook()
        {
        }

        public string BookTitle
        {
            //precondtion: None
            //postcondition: book title returned
            get
            {
                return _bookTitle;
            }
            //precondtion: value is entered
            //postcondition: book title is set to entered value
            set
            {
                _bookTitle = value;
            }
        }

        
        public string BookAuthor
        {
            //precondtion: None
            //postcondition: book author returned
            get
            {
                return _bookAuthor;
            }
            //precondtion: value is entered
            //postcondition: book author is set to entered value
            set
            {
                _bookAuthor = value;
            }
        }
        
        public string BookPublisher
        {
            //precondtion: None
            //postcondition: book publisher returned
            get
            {
                return _bookPublisher;
            }
            //precondtion: value is entered
            //postcondition: book publisher is set to entered value
            set
            {
                _bookPublisher = value;
            }
        }

        
        public int YearOfPublication
        {
            //precondtion: none
            //postcondition: year of publication returned
            get
            {
                return _yearOfPublication;
            }
            //precondtion: entered value is non negative
            //postcondition: year of publication is set to specified value
            set
            {
                if(value >= 0)
                {
                    _yearOfPublication = value;
                }
                else
                {
                    _yearOfPublication = 2019;
                }
            }
        }

        
        public string ISBN
        {
            //precondtion: none
            //postcondition: ISBN is returned
            get
            {
                return _iSBN;
            }
            //precondtion: entered value
            //postcondition: iSBN is set to entered vlaue
            set
            {
                _iSBN = value;
            }
        }

        //method to change the checkout status of the book to show that it has been checked out
        public void CheckedOut()
        {
            _isCheckedOut = true;
        }

        //method to change the checkout status to reflect that the book has been returned
        
        public void ReturnToShelf()
        {
            _isCheckedOut = false;
        }

        //is checked out method to return the check out status of the book

        public bool IsCheckedOut()
        {
            return _isCheckedOut;
        }

        //ToString method for book properties, overrides default tostring property
        //Precondition: none
        //Postcondition: a string for the book is returned
        public override string ToString()
        {
            //book title, author, publisher, pubyear, isbn checkout
            string nl = Environment.NewLine; // new line function
            return $"Book - Title: {BookTitle}; Author: {BookAuthor}; Publisher: {BookPublisher}; Publication Year: {YearOfPublication}; ISBN: {ISBN}; Check Out Status: {IsCheckedOut()}; {nl}";
        }
    }
}
