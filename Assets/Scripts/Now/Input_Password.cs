using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class Input_Password : MonoBehaviour
{
    // 輸入密碼、正確、錯誤 介面
    public GameObject input_UI, wrong, correct;

    // 玩家是否正在輸入密碼
    private bool is_typing;

    // Start is called before the first frame update
    void Start()
    {

    }
    

    // Update is called once per frame
    void Update()
    {
        // 按下 Q 開啟輸入欄位，再次按下 Q 會關閉
        if (Input.GetKeyDown(KeyCode.Q)) {
            if (is_typing) {
                is_typing = false;
                input_UI.SetActive(true);
            }
            else {
                is_typing = true;
                input_UI.SetActive(false);
            }   
        }

        // 按下 ESC 關閉 正確、錯誤的介面
        if (Input.GetKeyDown(KeyCode.Escape)) {
            correct.SetActive(false);
            wrong.SetActive(false);
        }
    }

    // 輸入完密碼後執行這段
    public void Type_Password(string your_input) {
        input_UI.SetActive(false);
        
        // 正確
        if (your_input == "1234") {
            correct.SetActive(true);
        }
        // 錯誤
        else {
            wrong.SetActive(true);
        }

        // 2 秒後自動關閉介面
        Invoke("Close_Result", 2f);
    }

    // 關閉介面
    void Close_Result() {
        correct.SetActive(false);
        wrong.SetActive(false);
    }
}
