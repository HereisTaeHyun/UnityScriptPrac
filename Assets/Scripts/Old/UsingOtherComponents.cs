using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingOtherComponents : MonoBehaviour
{
    public GameObject otherGameObject;
    private AnotherScript anotherScript;
    private YetAnotherScript yetAnotherScript;
    private BoxCollider boxCollider;
    void Awake()
    {
        anotherScript = GetComponent<AnotherScript>();
        yetAnotherScript = otherGameObject.GetComponent<YetAnotherScript>();
        boxCollider = otherGameObject.GetComponent<BoxCollider>();
    }
    // Start is called before the first frame update
    void Start()
    {
        boxCollider.size = new Vector3(3, 3, 3);
        Debug.Log($"The Player's score is {anotherScript.playerScore}");
        Debug.Log($"The Player has died {yetAnotherScript.numberOfPlayerDeaths} times");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
