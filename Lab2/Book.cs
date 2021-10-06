using System;

namespace Lab2
{
    class Book
    {
        public void All()
        {
            Title title = new Title(); // Потрібно для оголошення методу 
            title.Show(title.Name); // Потрібно для оголошення значення всередині методу 
            Author author = new Author();
            author.Show(author.Writer);
            Content content = new Content();
            content.Show(content.Сontents);
        }
    }

    class Title
    {
        public string Name { get; set; }
        public void Show(string name)
        {
            Name = name;
            Console.ForegroundColor = ConsoleColor.Red;// устанавливаем красный цвет шрифта
            name = "Ведьмак: Останнє бажання";
            Console.WriteLine(name);
            /*Console.BackgroundColor = ConsoleColor.White;  устанавливаем белый цвет фона для текста*/
        }
    }

    class Author
    {
        public string Writer { get; set; }

        public void Show(string author)
        {
            Writer = author;
            Console.ForegroundColor = ConsoleColor.Blue;
            author = "Анджей Сапковський";
            Console.WriteLine(author);
        }

    }

    class Content
    {
        public string Сontents { get; set; }

        public void Show(string сontent)
        {
            Сontents = сontent;
            Console.ForegroundColor = ConsoleColor.Green;
            сontent = "«Последнее желание» - первая книга из фэнтезийного цикла «Ведьмак» польского писателя-фантаста Анджея Сапковского. Протагонистом цикла является Геральт из Ривии, ведьмак - охотник за монстрами, представляющих угрозу для жизни людей. В детстве ему, как и другим Ведьмак, с помощью мутации были приданы сверхъестественные боевые качества: дужисть, молниеносную реакцию, ускоренный метаболизм и высокую регенеративную способность. Ремесло Геральта - охота за деньги на опасных чудовищ.";
            Console.WriteLine(сontent);
        }
    }
}
