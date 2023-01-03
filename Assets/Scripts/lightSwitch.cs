using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightSwitch : MonoBehaviour
{   
    public GameObject wall;
    private Material wallMaterial;
    // Start is called before the first frame update

    void Start()
    {
         wallMaterial = wall.GetComponent<MeshRenderer>().material;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnMouseDown()
    {
        // 更換牆壁的材質
        wallMaterial.color = Color.red;
    }
}