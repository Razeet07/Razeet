  
class AccessModifier//internal or public
{
    int x;//internal or public
    int y;//internal or public
    private void DoSomething()//internal 
    {

    }
    public int CalculateAverage(int[] numbers)
    {
        DoSomething();
        //calculate average
        return 0;
    }
}