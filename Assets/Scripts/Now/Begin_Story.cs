using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Begin_Story : MonoBehaviour
{
    // 開場獨白 UI
    public GameObject intro;

    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        // 按下 space 開始此關卡
        if (Input.GetKeyDown(KeyCode.Space)) {
            intro.SetActive(false); 
            gameObject.GetComponent<GameManager> ().enabled = true;
        }
        
    }
}
