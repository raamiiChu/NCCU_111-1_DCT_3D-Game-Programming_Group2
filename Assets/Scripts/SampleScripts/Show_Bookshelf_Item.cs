using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Show_Bookshelf_Item : MonoBehaviour
{

    public GameObject[] books;

    public GameObject item, little_item;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        
        // foreach (GameObject book in books){
            
        // }

        if (books[1].GetComponent<Move_On_Click>().correct_spot) {
            // books[1].SetActive(false);
            item.SetActive(true);
            little_item.SetActive(true);
        }
        
    }
}
