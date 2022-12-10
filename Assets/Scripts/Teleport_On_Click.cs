using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport_On_Click : MonoBehaviour
{
    public GameObject little_book_teleport;

    public bool correct_spot = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() {
        gameObject.transform.localPosition = new Vector3(2f, 0f, 0f);
        little_book_teleport.transform.localPosition = new Vector3(1f, 0.387f, 0f);
        
        correct_spot = true;
    }
}
