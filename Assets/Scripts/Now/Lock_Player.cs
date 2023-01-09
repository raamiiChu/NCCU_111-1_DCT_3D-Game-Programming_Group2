using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock_Player : MonoBehaviour
{
     public GameObject player;
     // 玩家物理特性
    Rigidbody player_rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        // 紀錄玩家物理特性
        player_rigidbody = player.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // 鎖住玩家位置
        player_rigidbody.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ;
        player.GetComponent<FirstPersonController>().playerCanMove = false;
        player.GetComponent<FirstPersonController>().cameraCanMove = false;
        player.GetComponent<FirstPersonController>().lockCursor = false;
    }
}
