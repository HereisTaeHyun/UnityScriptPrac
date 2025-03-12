using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;

public class AsyncAwaitExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TaskRun(); 
        TaskFromResult(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    async void TaskRun()
    {
        var task = Task.Run(() => TaskRunMethod(3));
        int count = await task;
        Debug.Log($"Count : {task.Result}");
    }

    private int TaskRunMethod(int limit)
    {
        int count = 0;
        for(int i = 0; i < limit; i++)
        {
            count += 1;
            Thread.Sleep(1000);
        }
        return count;
    }

    async void TaskFromResult()
    {
        int sum = await Task.FromResult(Add(1, 2));
        Debug.Log(sum);
    }

    private int Add(int a, int b)
    {
        return a + b;
    }
}
