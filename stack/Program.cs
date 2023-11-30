using stack;

public class StackItem<T>
{
    public StackItem<T> Previous { get; set; }
    public T Value { get; set; } 
}

public class MyStack<T>
{
    private StackItem<T> obj;

    public void Push(T value)
    {
        var newItem = new StackItem<T> { Value = value, Previous = obj };
        obj = newItem;
    }
    public T Pop()
    {
        if (obj == null)
        {
            return default(T);
        }
        var value = obj.Value;
        obj = obj.Previous;
        return value;
    }
    public T Peek()
    {
        if (obj == null)
        {
            return default(T);
        }
        return obj.Value;
    }

    public int Count
    {
        get
        {
            int count = 0;
            var current = obj;
            while (current != null) 
            {
                count++;
                current = current.Previous;
            }
            return count;
        }
    }

    public void Clear()
    {
        object obj = null;
    }
}

class Program
{
    public static void Main()
    {
        QStack<Student> Queue = new QStack<Student>();
        for (int i = 0; i < 5; i++)
        {
            Student student = new Student();
            Console.WriteLine("введите имя");
            student.FirstName = Console.ReadLine();
            Console.WriteLine("введите фамилию");
            student.LastName = Console.ReadLine();
            Queue.Enqueue(student);
        }


        QStack<Student> Queue1 = new QStack<Student>();

        do
        {
            var student = Queue.Dequeue();
            if (student == null)
                return;
            else
            {;
                Console.WriteLine("введите оценку");
                student.Mark = int.Parse(Console.ReadLine());
                Queue1.Enqueue(student);
                Console.WriteLine(student.FirstName);
                Console.WriteLine(student.LastName);
                Console.WriteLine(student.Mark);
            }
        }
        while (true);
    }
}