using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TryCatch : MonoBehaviour
{
    GameObject go;
    // Start is called before the first frame update
    void Start()
    {
        // go = new GameObject();
        try
        {
            Debug.Log(go.name);
        }
        catch (NullReferenceException ex)
        {
            Debug.LogWarning($"Null 예외 있음 : {ex}");
        }
        catch (Exception ex)
        {
            Debug.LogWarning($"예외 있음 : {ex}");
        }
        finally
        {
            Debug.Log("얘는 finally라서 꼭 켜짐");
        }
        Debug.Log("얘는 catch 없이 에러나면 안 켜짐");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
