using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Show_Bookshelf_Item : MonoBehaviour
{
    // 裝大物件的母物件
    public GameObject[] books;

    // 大物件、小物件
    public GameObject item, little_item;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        // 可以搭配 for 迴圈來判斷
        // foreach (GameObject book in books){
            
        // }

        // 偵測是否位於正確位置(與 Move_On_Click 連動)
        if (books[1].GetComponent<Move_On_Click>().correct_spot) {
            // 隱藏該物件，並顯示後方物品
            // books[1].SetActive(false);
            item.SetActive(true);
            little_item.SetActive(true);
        }
        
    }
}
