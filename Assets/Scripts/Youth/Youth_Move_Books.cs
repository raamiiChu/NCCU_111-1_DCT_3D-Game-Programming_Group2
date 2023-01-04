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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        // 檢測點擊的是哪個子物件
        Ray ray = books_cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        
        if (Physics.Raycast(ray, out hit))
        {
            // 獲取點擊的子物件的 GameObject 引用
            GameObject clickedObject = hit.transform.gameObject;

            // 紀錄子物件
            books_manager.choose_book.Add(clickedObject);
        }
    }
}
