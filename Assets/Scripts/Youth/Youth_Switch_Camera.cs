using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Youth_Switch_Camera : MonoBehaviour
{
    public GameObject player_cam;

    public GameObject other_cam;

    public Youth_Light_Trigger youth_light_trigger;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (youth_light_trigger.is_investigating == true) {
            player_cam.SetActive(false);
            other_cam.SetActive(true);
        }
        else {
            player_cam.SetActive(true);
            other_cam.SetActive(false);
        }
    }
}
