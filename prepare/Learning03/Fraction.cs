using System;

public class Fraction
{
    private int _top = 0;
    private int _bottom = 0;

    public Neutral()
    {
        _top = 1;
        _bottom = 1;
    }

    public TopChange(int fractionTop)
    {
        _top = fractionTop;
        _bottom = 1;
    }

    public BothChange(int bottomNum, int topNum)
    {
        _top = topNum;
        _bottom = bottomNum;
    }

    public int GetInteger()
    {
        return _top;
    }
    public void SetInteger(int integer)
    {
        _top = integer;
    }

    public int GetDenom()
    {
        return _bottom;
    }
    public void SetDenom(int demoninator)
    {
        _bottom = demoninator;
    }
}