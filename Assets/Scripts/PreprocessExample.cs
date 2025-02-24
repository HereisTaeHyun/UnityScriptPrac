#if UNITY_ANDROID
#define PRODUCT
#endif

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreprocessExample : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

#if(UNITY_EDITOR || UNITY_STANDALONE_WIN)
#endif

#region PlatformDivide
#if UNITY_STANDALONE_WIN
    #if UNITY_EDITOR
    #endif
#elif UNITY_ANDROID
    #if UNITY_EDITOR
    #endif
#endif
#endregion