#nullable enable

class Program
{
    static void Main() { }

    public class Bar { }

    public T? Foo<T>() where T : Bar
    //     ^^ CS862A: nullable type parameter must be known to be a value type or non-nullable reference type.

    {
        return null;
    } 
}
