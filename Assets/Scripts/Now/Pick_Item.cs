using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pick_Item : MonoBehaviour
{
    public GameObject item_box;

    private bool is_trigger = false;

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
        if (is_trigger){
            return;
        }
        // 只能觸發一次
        else{
        // RectTransform 屬性(不是預設的 Transform)
        RectTransform rect_transform = gameObject.GetComponent<RectTransform>();

        // 將遊戲物件的 Transform 屬性拖曳到 UI 元素的 "Source Transform" 欄位中
        rect_transform.SetParent(item_box.transform, false);

        rect_transform.localScale *= 100;

        // 設立錨點
        rect_transform.anchorMin = new Vector2(0, 0.167f);
        rect_transform.anchorMax = new Vector2(0.838f, 1);

        is_trigger = true;
        }

    }
}
