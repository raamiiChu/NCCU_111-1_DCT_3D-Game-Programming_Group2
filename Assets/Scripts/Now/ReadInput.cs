using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class ReadInput : MonoBehaviour
{

    private string input;
    public GameObject letter;
    public GameObject WrongHint;
    public GameObject passwordUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
        
    }

    public void ReadStringInput(string word) {

        input = word;
        if (input == "FREE1314" || input == "free1314") {
            Debug.Log("YESSS");
            passwordUI.SetActive(false);
            letter.SetActive(true);
            gameObject.GetComponent<GameManager> ().enabled = false;
            gameObject.GetComponent<End_Story> ().enabled = true;
        } else {
            Debug.Log("NOOO:(");
            passwordUI.SetActive(false);
            WrongHint.SetActive(true);
            Invoke("Close_Result", 2f);
        }

    }

    // 關閉介面
    void Close_Result() {
        WrongHint.SetActive(false);
    }
}
