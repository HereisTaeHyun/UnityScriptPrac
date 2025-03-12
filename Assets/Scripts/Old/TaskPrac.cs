using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks; 
using System; 

public class TaskPrac : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Task.Factory.StartNew(() => Debug.Log("Task"));

        Task task2 = new Task(new Action(DebugLog));
        task2.Start();

        Task task3 = new Task(delegate {DebugLog();});
        task3.Start();

        Task task4 = new Task(() => DebugLog());
        task4.Start();

        Task task5 = new Task(() => {DebugLog();});
        task5.Start();

        task2.Wait(); // Task가 끝날 때까지 대기  
        task3.Wait(); // Task가 끝날 때까지 대기 
        task4.Wait(); // Task가 끝날 때까지 대기 
        task5.Wait(); // Task가 끝날 때까지 대기 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void DebugLog() 
    { 
        Debug.Log("Task"); 
    } 
}
