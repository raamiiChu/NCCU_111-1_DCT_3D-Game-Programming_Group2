using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Youth_Intro : MonoBehaviour
{
    // 初始對話 UI
    public GameObject intro;

    public GameObject leaflet_camera;

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

            leaflet_camera.SetActive(false);

            gameObject.GetComponent<YouthGameManager>().enabled = true;
        }
    }
}
