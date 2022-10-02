namespace Assignment
{
    public interface Human_interface  {
        string Name { get; set; }
        int Age { get; set; }
        string address { get; set; }
    }
    public class myHuman : Human_interface {
        public string Name { get; set; }
        public int Age { get; set; }
        public string address { get; set; }


    }
    public delegate string Birthday(string str);
    class Event {
        event Birthday Human_birthday;
        public string Human_date(string date)
        {
            return "Birthday: " + date;
        }
    }
    public class collection<T>
    {
        private T[] arr = new T[10];
        public T this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }
    }
    class Testing
    {
        static void Main(string[] args)
        {
            myHuman Human = new myHuman();
            Human.Name = "John";
            Human.Age = 30;
            Human.address = "123 baker street";
            Event Human_event = new Event();
            string result = Human_event.Human_date("10/10/1997");
            var books = new collection<string>();
            books[0] = "Dreamland";
            books[1] = "Fairy Tale";
            books[2] = "The Bullet That Missed";
            Console.WriteLine("Name: " + Human.Name);
            Console.WriteLine("Age: " + Human.Age);
            Console.WriteLine("Address: " + Human.address);
            Console.WriteLine(result);
            Console.WriteLine("Favorite books:");
            Console.WriteLine(books[0]);
            Console.WriteLine(books[1]);
            Console.WriteLine(books[2]);
        }
    }

}
