using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Begin_Story : MonoBehaviour
{
    // 開場獨白 UI
    public GameObject intro;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player.GetComponent<FirstPersonController>().enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        // 按下 space 開始此關卡
        if (Input.GetKeyDown(KeyCode.Space)) {
            intro.SetActive(false); 
            gameObject.GetComponent<Now_GameManager> ().enabled = true;
            player.GetComponent<FirstPersonController>().enabled = true;
        }
        
    }
}
