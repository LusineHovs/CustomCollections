#README.md

[Fibonacci Sequence](https://en.wikipedia.org/wiki/Fibonacci_number) are the sequence of numbers, which have the following view:
**1,1,2,3,5,8,13,21,...**

The method which calculates Fibonacci numbers, used *yield return* and the return type of the method is *IEnumerable<int>*.
```C#
public static IEnumerable<int> GetFibonacciNumber()
{
    int previous = 0;
    int current = 1;

    yield return current;

    for (int i = 0; i < 45; i++)
    {
        int next = previous + current;
        previous = current;
        current = next;
        yield return next;
    }
}
``
