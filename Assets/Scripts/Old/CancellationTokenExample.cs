using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading; 
using System.Threading.Tasks;

public class CancellationTokenExample : MonoBehaviour
{
    CancellationTokenSource cancellationTokenSource;
    Task<int> task;
    // Start is called before the first frame update
    void Start()
    {
        cancellationTokenSource = new CancellationTokenSource();
        CancellationToken cancellationToken = cancellationTokenSource.Token;
        task = Task.Factory.StartNew(TaskMethod, cancellationToken); 
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.C))
        {
            cancellationTokenSource.Cancel();
            if(task != null)
            {
                Debug.Log("Count : " + task.Result); 
            }
        }
    }

    private int TaskMethod()
    {
        int count = 0;
        for(int i = 0; i < 10; i++)
        {
            if(cancellationTokenSource.Token.IsCancellationRequested)
            {
                break;
            }
            count += 1;
            Thread.Sleep(1000);
        }
        return count;
    }
}
