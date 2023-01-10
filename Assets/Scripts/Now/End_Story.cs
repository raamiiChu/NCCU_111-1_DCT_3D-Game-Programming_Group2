using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End_Story : MonoBehaviour
{
    // 結束UI
    public GameObject letter;
    public GameObject talk1;
    public GameObject talk2;
    public GameObject watch;
    public GameObject player;

    int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        player.GetComponent<FirstPersonController>().enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        // 跳換對白
        if (Input.GetKeyDown(KeyCode.Space)) {
            if (count == 0) {
                letter.SetActive(false);
                talk1.SetActive(true);
            } else if (count == 1){
                talk1.SetActive(false);
                talk2.SetActive(true);
            } else if (count == 2) {
                talk2.SetActive(false);
                watch.SetActive(true);
            }
            count +=1 ;
        }
        
    }
}
