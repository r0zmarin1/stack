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
        MyStack<Student> MyStack1 = new MyStack<Student>();
        for (int i = 0; i < 5; i++)
        {
            Student student = new Student();
            student.FirstName = Console.ReadLine();
            student.LastName = Console.ReadLine();
            MyStack1.Push(student);
        }


        MyStack<Student> MyStack2 = new MyStack<Student>();

        do
        {
            var student = MyStack1.Pop();
            if (student == null)
                return;
            else
            {
                int mark = 0;
                student.Mark = Console.Read();
                student.Mark = mark;
                MyStack2.Push(student);
            }
        }
        while (true);
    }
}