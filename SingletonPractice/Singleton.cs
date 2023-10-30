public sealed class Singleton
{
    private static Singleton Instance = null;
    private static int Counter = 0;
    
    private Singleton()
    {
        Counter++;
        System.Console.WriteLine(Counter.ToString());
    }

    public Singleton GetInstance()
    {
        if (Instance == null)
            Instance = new Singleton();


        return Instance;
    }
}