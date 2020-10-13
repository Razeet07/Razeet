namespace AccessModifierNamespace
{

internal class AccessModifier
{
    internal int x;
    public int y;
    internal void DoSomething()
    {

    }
    public int CalculateAverage(int[] numbers)
    {
        DoSomething();
        return 0;
    }
}
}
