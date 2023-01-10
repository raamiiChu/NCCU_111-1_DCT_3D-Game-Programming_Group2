using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Children_Switch_Scene : MonoBehaviour
{
    public GameObject video_image;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (video_image.activeSelf){
            Invoke("Switch_Scene", 5f);
        }
    }

    void Switch_Scene() {
        SceneManager.LoadScene(1);
    }
}
