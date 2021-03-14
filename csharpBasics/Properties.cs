using System;
class Human
{
    string name;
    int age;
    public byte Age
    {
        get
        {
            return Age;
        }
        set
        {
            if(value >20&&value<30)
            age = value;
        }
    }
    //autoimplemented property
    public string Name {get; set;}
    //random property
    public string address {get;}
}
