using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hint : MonoBehaviour
{
    public GameObject hintImage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //偵測滑鼠是否停留在物件上，物件須為 collider 且 trigger 要開啟！
    void OnMouseEnter()
    {
        hintImage.SetActive(true);
        Debug.Log("Mouse Over Object");
    }

    void OnMouseExit()
    {
        hintImage.SetActive(false);
    }
}