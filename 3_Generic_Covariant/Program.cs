public class Program
{
    public static void Main()
    {
        // Stack<Bear> bears = new Stack<Bear>();
        // Stack<Animal> animals = bears; // Compile-time error
        // ZooCleaner.Wash1(bears); // Compile-time error

        Stack<Bear> bears = new Stack<Bear>();
        IPoppable<Animal> animals = bears;
        ZooCleaner.Wash2(bears);

    }
}

public class Animal { }
public class Bear : Animal { }
public class Camel : Animal { }

public class Stack<T> : IPoppable<T>
{
    int position;
    T[] data = new T[100];
    public void Push(T obj) => data[position++] = obj;
    public T Pop() => data[--position];
}

public static class ZooCleaner
{
    public static void Wash1(Stack<Animal> animals) => Console.WriteLine("Wash1");

    public static void Wash2(IPoppable<Animal> animals) => Console.WriteLine("Wash2");
}

public interface IPoppable<out T> { T Pop(); }   //The out modifier flags the type parameter as covariant

