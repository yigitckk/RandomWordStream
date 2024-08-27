using System;

class Program { 
    
    static void Main(String[] args)
    {

        Console.WriteLine("IntStream:");
        IntStream intStream = new IntStream(12);
        while (!intStream.eos())
        {
            Console.Write(intStream.next() + " ");
        }
        Console.WriteLine();
        intStream.reset();

        Console.WriteLine("PrimeStream:");
        PrimeStream primeStream = new PrimeStream(40);
        for (int i = 0; i < 12; i++)
        {
            Console.Write(primeStream.next() + " ");
        }
        Console.WriteLine();
        primeStream.reset();

        Console.WriteLine("RandomStream:");
        RandomStream randomStream = new RandomStream();
        for (int i = 0; i < 10; i++)
        {
            Console.Write(randomStream.next() + " ");
        }
        Console.WriteLine();
        randomStream.reset();



        RandomWordStream randomWordStream = new RandomWordStream();
        for (int i = 0;i<10;i++) {

            Console.WriteLine(randomWordStream.next());
        }

        


    }

}