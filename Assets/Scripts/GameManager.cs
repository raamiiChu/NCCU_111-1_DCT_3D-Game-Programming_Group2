using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;
using UnityEngine.UI;
// test git push
//test

public class GameManager : MonoBehaviour
{
    // 玩家
    public GameObject player;

    // 玩家重生點
    private Vector3 spwan_point;

    // 移動速度
    public float moveSpeed = 5f;

    // 玩家位置
    Vector3 pos_player;

    // 玩家物理屬性
    Rigidbody player_rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        // 紀錄玩家重生點
        spwan_point = player.transform.position;

        // 紀錄玩家物理特性
        player_rigidbody = player.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // 紀錄玩家位置
        pos_player = player.transform.position;

        // 檢查是否掉到地圖外
        if (player.transform.position.y < -5f ){
            Teleport_To_Spwan_Point();
        }

        // 檢查玩家位置是否處於凍結狀態
        if (player_rigidbody.constraints == RigidbodyConstraints.None) {
            // 基礎移動(之後會改)
            if (Input.GetKey(KeyCode.W)) {
                player.transform.Translate(0f, 0f, moveSpeed*Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.A)) {
                player.transform.Translate(-1 * moveSpeed*Time.deltaTime, 0, 0);
            }
            if (Input.GetKey(KeyCode.S)) {
                player.transform.Translate(0f, 0, -1 * moveSpeed*Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.D)) {
                player.transform.Translate(moveSpeed*Time.deltaTime, 0, 0);
            }
        }
    }

    // 按鈕事件(onClick)
    public void Close_investigation_UI () {
        // 按下按鈕後記錄當前的按鈕
        GameObject cur_button = EventSystem.current.currentSelectedGameObject;

        // 依據該按鈕找到它的母物件並將其關閉
        cur_button.transform.parent.gameObject.SetActive(false);

        // 關閉 button 點擊功能(避免玩家重複觸發)
        cur_button.GetComponent<Button>().interactable = false;

        // 解除鎖定玩家位置
        player_rigidbody.constraints = RigidbodyConstraints.None;
    }

    // 避免破圖導致玩家墜落
    void Teleport_To_Spwan_Point() {
        // 鎖住玩家位置
        player_rigidbody.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ;
        
        // 傳送回重生點
        player.transform.position = spwan_point;
        
        // 解除鎖定玩家位置
        player_rigidbody.constraints = RigidbodyConstraints.None;
    }

}
