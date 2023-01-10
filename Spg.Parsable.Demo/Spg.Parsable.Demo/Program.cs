using Spg.Parsable.Demo;

internal class Program
{
    private static void Main(string[] args)
    {
        int i = int.Parse("1234");
        Console.WriteLine(i);

        int j = 0;
        if (int.TryParse("1234", out j))
        {
            Console.Error.WriteLine(j);
        }

        Console.WriteLine("Vor wordscount");
        int wordsCount = "Hello World! Lorem Ipsum whatever".CountWords();
        Console.WriteLine(wordsCount);


        Person p = "Martin,Schrutek,13.05.1977".Parse<Person>();

        Console.WriteLine(p.ToString());

        //string[] stringArray = "Martin,Schrutek,13.05.1977".Split(',');

        //Console.WriteLine($"String-Array: {foreach(string s in stringArray => return s;)}");
        //Console.WriteLine(stringArray.ToString());
        
    }

    public void StringsOnConsole(string[] stringArray)
    {
        if(stringArray is not null)
        {
            foreach (string s in stringArray)
            {
                Console.WriteLine(s);
            }
        }
        else
        {
            Console.WriteLine("StringArray was null!");
        }
    }
}