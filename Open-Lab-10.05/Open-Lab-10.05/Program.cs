using System;

namespace Open_Lab_10._04
{
    class Program
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book();
            Book LOTR2 = new Book();
            Book LOTR3 = new Book("Titulok", 50);
            Book HOBIT = new Book("Titulok", 50, "Kategoria", "Autor", 2020);

            LOTR.Title("Titulok");
            LOTR.Pages(50);
            LOTR.Category("Kategoria");
            LOTR.Author("Author");
            LOTR.ReleaseDate(2020);
            Console.WriteLine(LOTR.ToString());
            Console.WriteLine(LOTR2.ToString());
            Console.WriteLine(LOTR3.ToString());
            Console.WriteLine(HOBIT.ToString());
        }
    }


    public class Book
    {
        public string title;
        public int pages;
        public string category;
        public string author;
        public int releaseDate;


        public Book()
        {
            title = "-1";
            pages = -1;
            category = "-1";
            author = "-1";
            releaseDate = -1;
        }
        public Book(string title, int pages)
        {
            this.title = title;
            this.pages = pages;
            category = "-1";
            author = "-1";
            releaseDate = -1;
        }
        public Book(string title, int pages, string category, string author, int releaseDate)
        {
            this.title = title;
            this.pages = pages;
            this.category = category;
            this.author = author;
            this.releaseDate = releaseDate;
        }


        public void Title(string NewTitle)
        {
            title = NewTitle;
        }
        public void Pages(int NewPages)
        {
            pages = NewPages;
            if (pages < 0)
            {
                pages = 1;
            }
        }
        public void Category(string NewCategory)
        {
            category = NewCategory;
        }
        public void Author(string NewAuthor)
        {
            author = NewAuthor;
        }
        public void ReleaseDate(int NewReleaseDate)
        {
            releaseDate = NewReleaseDate;
            if (releaseDate < 1450 || releaseDate > 2021)
            {
                releaseDate = -1;
            }
        }



        public override string ToString()
        {
            string output = title + pages + category + author + releaseDate;
            return output;
        }
    }
}