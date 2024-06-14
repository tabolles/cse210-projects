using System;

public class Fraction{
    private int _top;
    private int _bottom;


    //These are called different signatures
    public Fraction(){
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber){
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom){
        _top = top;
        _bottom = bottom;
    }

    public int getTop(){
        return _top;
    }

    public int setTop(int top){
        _top = top;
        return _top;
    }   

    public int getBottom(){
        return _bottom;
    }

    public int setBottom(int bottom){
        _bottom = bottom;
        return _bottom;
    }

    public string getFractionString(){
        return _top + "/" + _bottom;
    }

    public double getDecimalValue(){
        return (double)_top / _bottom;
    }

}