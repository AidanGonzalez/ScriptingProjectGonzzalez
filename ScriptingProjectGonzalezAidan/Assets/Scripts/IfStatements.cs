using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    float coffeTemprature = 85.0f;
    float hotLimitTemprature = 70.0f;
    float coldLimitTemprature = 40.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TempratureTest();
        coffeTemprature -= Time.deltaTime * 5f;
        
    }
    void TempratureTest()
    {
        if (coffeTemprature)
    }
}
