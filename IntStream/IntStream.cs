public class IntStream {

    public int CurrentNumber = -1;
    int MaxNumber;

    public IntStream(int maxNumber)
    {
        MaxNumber = maxNumber;
    }

    public virtual int next() { 
        CurrentNumber++;
        return CurrentNumber;
    }

    public virtual bool eos() { 
    
        return CurrentNumber >= MaxNumber;
    }

    public virtual void reset() { 
    
        CurrentNumber = -1;

    }

}