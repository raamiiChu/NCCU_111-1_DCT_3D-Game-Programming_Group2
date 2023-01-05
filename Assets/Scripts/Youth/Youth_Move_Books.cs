using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Youth_Move_Books : MonoBehaviour
{
    // 書架相機
    public Camera books_cam;

    // Youth_Books_Manager
    public Youth_Books_Manager books_manager;

    // Start is called before the first frame update
    void Start()
    {
        // 紀錄位置是否正確
        books_manager.spot_correct.Add(gameObject.name, false);
    }

    // Update is called once per frame
    void Update()
    {
        // 如果位置正確就記錄下來
        if (books_manager.book_pos[gameObject.name] == gameObject.transform.localPosition) 
        {
            books_manager.spot_correct[gameObject.name] = true;
        }
    }

    void OnMouseDown()
    {
        // 檢測點擊的是哪個子物件
        Ray ray = books_cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        
        if (Physics.Raycast(ray, out hit))
        {
            // 獲取點擊的子物件的 GameObject 引用
            GameObject clicked_object = hit.transform.gameObject;

            // 紀錄子物件
            books_manager.choose_book.Add(clicked_object);
        }
    }
}
