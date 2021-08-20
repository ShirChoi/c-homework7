using System;

namespace Problem2 {
    class Program {
        static void Main(string[] args) {
            Book book1 = new Book {
                Title = new Title(info: "Война и мир", color: ConsoleColor.Red),
                Author = new Author(info: "Лев Толстой", color: ConsoleColor.Gray),
                Content = new Content(info: "куча страниц интересного текста", color: ConsoleColor.Blue) 
            };

            book1.Show();

            System.Console.WriteLine("---------------------------------------------");

            Book book2 = new Book {
                Title = new Title(info: "451 градус по Фаренгейту", color: ConsoleColor.Red),
                Author = new Author(info: "Рэй Брэдбери", color: ConsoleColor.Gray),
                Content = new Content(info: "пожарные создают пожары, а не тушат их", color: ConsoleColor.Blue) 
            };

            book2.Show();
        }
    }

    class Book {
        public Title Title { get; set; }
        public Author Author { get; set; }
        public Content Content { get; set; }

        public void Show() {
            Title?.Show();
            Author?.Show();
            Content?.Show();
        }
    }
    class Title {
        protected ConsoleColor _color;
        protected string _info;
        public Title() {}
        public Title(string info, ConsoleColor color) {
            _info = info;
            _color = color;
        }

        public void Show() {
            Console.ForegroundColor = _color;
            Console.WriteLine($"Название: {_info}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    class Author {
        protected ConsoleColor _color;
        protected string _info;
        public Author() {}
        public Author(string info, ConsoleColor color) {
            _info = info;
            _color = color;
        }

        public void Show() {
            Console.ForegroundColor = _color;
            Console.WriteLine($"Автор: {_info}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    class Content {
        protected ConsoleColor _color;
        protected string _info;
        public Content() {}
        public Content(string info, ConsoleColor color) {
            _info = info;
            _color = color;
        }

        public void Show() {
            Console.ForegroundColor = _color;
            Console.WriteLine($"Содержание: {_info}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
