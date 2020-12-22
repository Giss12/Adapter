using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Builder 
{
    public void Build()
    {
        Debug.Log("строим дом...");
    }
    public void GetSalary(Salary salary)
    {
        Debug.Log("Получено :" + salary.Money + " Рублей");
    }
}
