using System;

class Article
{
    private string title;
    private string content;
    private string author;

    // Конструктор за статия
    public Article(string title, string content, string author)
    {
        this.title = title;   // this се използва, за да се отличат член-променливите на класа от аргументите на конструктора
        this.content = content;
        this.author = author;
    }

    // Метод за редакция на съдържанието на статията
    public void Edit(string newContent)
    {
        this.content = newContent;   // this се използва, за да се отличат член-променливите от аргументите на метода
    }

    // Метод за смяна на автора на статията
    public void ChangeAuthor(string newAuthor)
    {
        this.author = newAuthor;
    }

    // Метод за смяна на заглавието на статията
    public void Rename(string newTitle)
    {
        this.title = newTitle;
    }

    // Презаписване на метода ToString за форматиране на статията при извеждане
    public override string ToString()
    {
        // this.title, this.content и this.author се използват, за да се вземат стойностите на член-променливите на статията
        return $"{this.title} - {this.content}: {this.author}";
    }
}

class Program
{
    static void Main()
    {
        // Четене на информация за статията
        string[] articleInfo = Console.ReadLine().Split(", ");
        string title = articleInfo[0];
        string content = articleInfo[1];
        string author = articleInfo[2];

        // Създаване на обект Article
        Article article = new Article(title, content, author);

        // Четене на броя на командите
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            // Четене на команда и аргумент
            string[] commandInfo = Console.ReadLine().Split(": ");
            string command = commandInfo[0];
            string argument = commandInfo[1];

            // Проверка и изпълнение на командата
            if (command == "Edit")
            {
                article.Edit(argument);    // Извиква метода Edit с аргумента за новото съдържание
            }
            else if (command == "ChangeAuthor")
            {
                article.ChangeAuthor(argument);   // Извиква метода ChangeAuthor с аргумента за новия автор
            }
            else if (command == "Rename")
            {
                article.Rename(argument);   // Извиква метода Rename с аргумента за новото заглавие
            }
        }

        // Извеждане на финалното състояние на статията
        Console.WriteLine(article.ToString());   // Извиква метода ToString за форматиране на статията и я извежда
    }
}
