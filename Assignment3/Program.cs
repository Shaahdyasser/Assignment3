namespace Assignment3
{
    #region Question 1
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        string title = "clean code";

    //        string upperTitle = title.ToUpper();

    //        Console.WriteLine(title);
    //        Console.WriteLine(upperTitle);
    //    }
    //}

    #endregion

    #region Question 2
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        string str1 = "Clean Code";
    //        string str2 = "Clean Code";

    //        bool result = ReferenceEquals(str1, str2);

    //        Console.WriteLine(result);
    //    }
    //}
    #endregion

    #region Question 3
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        StringBuilder sb = new StringBuilder();

    //        sb.Append("Book List");

    //        sb.Append(" - Updated");

    //        Console.WriteLine(sb);
    //    }
    //}
    #endregion

    #region Question 4
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        StringBuilder sb = new StringBuilder();

    //        sb.Append("Book List");
    //        sb.Append(" - Updated");

    //        sb.Replace("Book List", "Library");

    //        Console.WriteLine(sb);
    //    }
    //}
    #endregion

    #region Question 5
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        string title = "Clean Code";
    //        int pages = 464;

    //        string result = "Book: " + title + ", Pages: " + pages;

    //        Console.WriteLine(result);
    //    }
    //}
    #endregion

    #region Question 6
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        string title = "Clean Code";
    //        int pages = 464;

    //        string result = $"Book: {title}, Pages: {pages}";

    //        Console.WriteLine(result);
    //    }
    //}
    #endregion

    #region Question 7
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        string title = "Clean Code";
    //        int pages = 464;

    //        string result = string.Format("Book: {0}, Pages: {1}", title, pages);

    //        Console.WriteLine(result);
    //    }
    //}
    #endregion

    #region Question 8
    //class Q8
    //{
    //    static void Main()
    //    {
    //        int pages = 464;
    //        if (pages > 300)
    //        {
    //            Console.WriteLine("Long Book");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Short Book");
    //        }
    //    }
    //}
    #endregion

    #region Question 9
    //class Q9
    //{
    //    static void Main()
    //    {
    //        int pages = 464;
    //        bool isAvailable = true;

    //        if (pages > 300 && isAvailable == true)
    //        {
    //            Console.WriteLine("You can borrow this book");
    //        }
    //    }
    //}
    #endregion

    #region Question 10
    //class Q10
    //{
    //    static void Main()
    //    {
    //        string title = "Refactoring";
    //        switch (title)
    //        {
    //            case "Clean Code":
    //                Console.WriteLine("Great choice!");
    //                break;

    //            case "Refactoring":
    //                Console.WriteLine("Nice pick!");
    //                break;

    //            default:
    //                Console.WriteLine("Never heard of it");
    //                break;
    //        }
    //    }
    //}
    #endregion

    #region Question 11
    //class Program
    //{
    //    static void Main()
    //    {
    //        int pages = 464;
    //        string sizeLabel = pages > 300 ? "Long Book" : "Short Book";
    //        Console.WriteLine(sizeLabel);
    //    }
    //}
    #endregion

    #region Question 12
    //class Question12
    //{
    //    static void Main()
    //    {
    //        string[] books = {
    //        "Clean Code",
    //        "The Pragmatic Programmer",
    //        "Refactoring"
    //    };
    //        for (int i = 0; i < books.Length; i++)
    //        {
    //            Console.WriteLine((i + 1) + ". " + books[i]);
    //        }
    //    }
    //}
    #endregion

    #region Question 13
    //class Question13
    //{
    //    static void Main()
    //    {
    //        string[] books = {
    //        "Clean Code",
    //        "The Pragmatic Programmer",
    //        "Refactoring"
    //    };
    //        int i = 0;
    //        while (i < books.Length)
    //        {
    //            Console.WriteLine(books[i]);

    //            i++;
    //        }
    //    }
    //}
    #endregion

    #region Question 14
    //class Question14
    //{
    //    static void Main()
    //    {
    //        int i = 0;
    //        do
    //        {
    //            Console.WriteLine("Checking book...");

    //            i++;
    //        }
    //        while (i < 3);
    //    }
    //}
    #endregion

    #region Question 15
    //class Question15
    //{
    //    static void Main()
    //    {
    //        string[] books = {
    //        "Clean Code",
    //        "The Pragmatic Programmer",
    //        "Refactoring"
    //    };

    //        foreach (string book in books)
    //        {
    //            Console.WriteLine(book);
    //        }
    //    }
    //}
    #endregion

    #region Question 16

    //class Question16
    //{
    //    static void Main()
    //    {
    //        string[] books = {
    //         "Clean Code",
    //         "The Pragmatic Programmer",
    //         "Refactoring"
    //     };

    //        foreach (string book in books)
    //        {
    //            if (book == "Refactoring")
    //            {
    //                break;
    //            }

    //            Console.WriteLine(book);
    //        }
    //    }
    //}
    #endregion

    #region Question 17
    //class Question17
    //{
    //    static void Main()
    //    {
    //        string[] books = {
    //           "Clean Code",
    //           "The Pragmatic Programmer",
    //           "Refactoring"
    //       };
    //        foreach (string book in books)
    //        {
    //            if (book == "The Pragmatic Programmer")
    //            {
    //                continue;
    //            }

    //            Console.WriteLine(book);
    //        }
    //    }
    //}
    #endregion

    #region Question 18
    //class Question18
    //{
    //    static void PrintFirstBook(string[] books)
    //    {
    //        if (books.Length == 0)
    //        {
    //            return;
    //        }
    //        Console.WriteLine(books[0]);
    //    }

    //    static void Main()
    //    {
    //        string[] books = {
    //        "Clean Code",
    //        "The Pragmatic Programmer",
    //        "Refactoring"
    //    };

    //        PrintFirstBook(books);
    //    }
    //}
    #endregion
}
