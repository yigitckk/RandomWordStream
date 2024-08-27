using System;

public class RandomWordStream : PrimeStream {

    private Random random = new Random();


    public RandomWordStream() : base(0) {}


    public new string next()
    {

        int wordLength = base.next();
        return GenerateRandomWord(wordLength);

    }

    Random rnd = new Random();

    private string GenerateRandomWord(int length)
    {
        char[] chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".ToArray();
        string output;

        output = "";
        for (int i = 0; i < length; i++)
        {
            output += chars[rnd.Next(0, chars.Length)];
        }

        return output;

    }
    

    public new bool eos() 
    {
        return false; 
    }

    public new void reset() 
    {
        base.reset();
    }

}