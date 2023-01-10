using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemActive : MonoBehaviour
{
    public GameObject Toy01;
    public GameObject Toy02;
    public GameObject Toy03;
    public GameObject Bag;
    // Start is called before the first frame update


    public void Active_Toy()
    {
        Toy01.SetActive(true);
        Toy02.SetActive(true);
        Toy03.SetActive(true);
        Bag.SetActive(true);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
