using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class Input_Password : MonoBehaviour
{
    public GameObject input_UI, wrong, correct;

    private bool is_typing;

    // Start is called before the first frame update
    void Start()
    {

    }
    

    // Update is called once per frame
    void Update()
    {
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
