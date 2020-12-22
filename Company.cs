using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Company : MonoBehaviour
{
    Builder b = new Builder();
    

   
    private void Start()
    {
        IWorker worker = new Adapter(b);
        worker.Work();
        worker.PayMoney(5000);
    }
}
