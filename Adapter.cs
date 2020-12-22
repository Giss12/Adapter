using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Adapter : IWorker
{
    Builder _builder;
    public void PayMoney(int v) 
    {
        _builder.GetSalary(new Salary(v));
    }

    public void Work()
    {
        _builder.Build();
    }
    public Adapter(Builder c)
    {
        _builder = c;
    }
}