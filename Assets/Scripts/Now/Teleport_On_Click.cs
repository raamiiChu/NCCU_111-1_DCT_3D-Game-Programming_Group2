using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport_On_Click : MonoBehaviour
{
    // 小物件
    public GameObject little_book_teleport;

    // 是否在正確位置
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
        // 大、小物件往瞬間移動
        gameObject.transform.localPosition = new Vector3(2f, 0f, 0f);
        little_book_teleport.transform.localPosition = new Vector3(1f, 0.387f, 0f);
        
        // 是否在正確位置(可與 Show_Bookshelf_Item 連動)
        correct_spot = true;
    }
}
