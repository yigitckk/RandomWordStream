public class RandomStream : IntStream {

    // RandomStream, in which the next() method returns random numbers. In this case, eos() is always false.

    public RandomStream() : base(0)
    {
        CurrentNumber = 1; 
    }

    Random rnd = new Random();

    public override int next()
    {
        
           CurrentNumber = rnd.Next();
           return CurrentNumber;
        
    }

    public override bool eos()
    {
        return false;
    }

    public override void reset()
    {
        base.reset();
    }
}