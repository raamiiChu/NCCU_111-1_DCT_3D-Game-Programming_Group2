using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadInput : MonoBehaviour
{
    private string input;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReadStringInput(string word) {
        input = word;
        if (input == "FREE55") {
            Debug.Log("YESSS");
        } else {
            Debug.Log("NOOO:(");
        }
    }
}
