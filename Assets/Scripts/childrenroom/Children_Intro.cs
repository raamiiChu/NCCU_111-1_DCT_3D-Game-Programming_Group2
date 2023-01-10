using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Children_Intro: MonoBehaviour
{
    // 初始對話 UI
    public GameObject intro;

   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 按下 space 切換攝影機，並開始此關卡
        if (Input.GetKeyDown(KeyCode.Space)) {
            intro.SetActive(false);
            gameObject.GetComponent<ChildrenGameManager >().enabled = true;
        }
    }
}
