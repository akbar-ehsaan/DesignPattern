using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22.Decorator
{
    public abstract class LibraryItem
    {
        private int numCopies;

        public int NumCopies
        {
            set=>numCopies=value;
            get => numCopies;
        }
        public abstract void Display();
    }
    public  class Book:LibraryItem
    {
        private string title;
        private string author;

        public Book(string title, string author,int numCopies)
        {
            this.title = title;
            this.author = author;
            this.NumCopies=numCopies;
        }
        public override void Display()
        {
            Console.WriteLine("\nBook ------ ");
            Console.WriteLine(" Author: {0}", author);
            Console.WriteLine(" Title: {0}", title);
            Console.WriteLine(" # Copies: {0}", NumCopies);
        }
    }
    public class Video : LibraryItem
    {
        private string director;
        private string title;
        private int playTime;
        // Constructor
        public Video(string director, string title, int numCopies, int playTime)
        {
            this.director = director;
            this.title = title;
            this.NumCopies = numCopies;
            this.playTime = playTime;
        }
        public override void Display()
        {
            Console.WriteLine("\nVideo ----- ");
            Console.WriteLine(" Director: {0}", director);
            Console.WriteLine(" Title: {0}", title);
            Console.WriteLine(" # Copies: {0}", NumCopies);
            Console.WriteLine(" Playtime: {0}\n", playTime);
        }
    }
    //public class Decorator

}
