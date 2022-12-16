using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 程式碼直接抄這邊的
// https://www.cg.com.tw/UnityCSharp/Content/Mouse.php
public class Mouse_Drag : MonoBehaviour
{
    // 最遠觸發距離
    public float trigger_dist = 5f;
    public GameObject player;
    private Vector3 screenPoint;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        // 場景座標轉成螢幕座標
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        
        // 只能移動 x 軸，剩下的都被鎖定了
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, screenPoint.y, screenPoint.z));
    }
    
    private void OnMouseDrag()
    {
        float dist = (Vector3.Distance(player.transform.position, gameObject.transform.position));

        if (dist < trigger_dist) {
            Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, screenPoint.y, screenPoint.z);
            Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
            transform.position = curPosition;
        }
        
    }
    private void OnMouseUp() {
        
    }
}
