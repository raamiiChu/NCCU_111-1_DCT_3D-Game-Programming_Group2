using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Light_Trigger : MonoBehaviour
{
    // 最遠觸發距離
    public float trigger_dist;

    // 玩家
    public GameObject player;

    // 玩家位置
    Vector3 pos_player;

    // 玩家物理特性
    Rigidbody player_rigidbody;

    // 發光物位置
    Vector3 pos_item;

    // 發光物的材質
    Material mat;

    // 發光物的光環
    Component halo;

    // 提示UI
    public GameObject hint_space;

    // 提示UI座標
    private Vector3 original_position_hint_space = new Vector3(35f, 650f, 0f);
    private Vector3 active_position_hint_space = new Vector3(35f, 515f, 0f);


    // 調查 UI 介面
    public GameObject investigation_UI;

    // 是否能調查
    private bool enable_investigate;

    // 玩家相機
    public Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        // 紀錄玩家物理特性
        player_rigidbody = player.GetComponent<Rigidbody>();

        // 紀錄發光物的材質
        mat = gameObject.GetComponent<Renderer>().material;

        // 紀錄發光物位置
        pos_item = gameObject.transform.position;

        // 記錄光環
        halo = gameObject.GetComponent("Halo");
    }

    // Update is called once per frame
    void Update()
    {
        // 紀錄玩家位置
        pos_player = player.transform.position;

        // 計算玩家與發光物的距離
        float dist = (Vector3.Distance(pos_player, pos_item));

        // 紀錄物件在螢幕中的座標
        Vector3 view_pos = cam.WorldToViewportPoint(gameObject.transform.position);

        // 紀錄是否在螢幕指定範圍內
        bool in_screen = (0.3f < view_pos.x && view_pos.x < 0.7f) &&  (0.1f < view_pos.y && view_pos.y < 0.45f);

        // 距離夠近且位於螢幕指定範圍內才發光
        if (dist < trigger_dist && in_screen) {
            // 發光
            mat.EnableKeyword("_EMISSION");
            enable_investigate = true;
            halo.GetType().GetProperty("enabled").SetValue(halo, true);

            // 顯示提示
            hint_space.transform.DOLocalMove(active_position_hint_space, 1f);
            hint_space.transform.DOScaleX(1f, 1f);
        }
        else {
            // 取消發光
            mat.DisableKeyword("_EMISSION");
            enable_investigate = false;
            halo.GetType().GetProperty("enabled").SetValue(halo, false);

            // 隱藏提示
            // hint_space.transform.DOLocalMove(original_position_hint_space, 1f);
            // hint_space.transform.DOScaleX(0.2f, 1f);
        }

        // 檢查是否可調查
        if(enable_investigate) {
            // 調查介面中的 button
            Component button_UI  = investigation_UI.transform.Find("Button");

            // 按下 space 開啟調查介面
            if (!investigation_UI.activeSelf && Input.GetKeyDown(KeyCode.Space)){
                investigation_UI.SetActive(true);

                // 開啟 button 點擊功能
                // investigation_UI.transform.Find("Button").GetComponent<Button>().interactable = true;
                button_UI.GetComponent<Button>().interactable = true;

                // 鎖住玩家位置
                player_rigidbody.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ;
            }

            // 按下 esc 關閉調查介面(調查介面有開啟時才有效)
            else if (investigation_UI.activeSelf && Input.GetKeyDown(KeyCode.Space)) {
                investigation_UI.SetActive(false);

                // 關閉 button 點擊功能(避免玩家重複觸發)
                button_UI.GetComponent<Button>().interactable = false;

                // 解除鎖定玩家位置
                player_rigidbody.constraints = RigidbodyConstraints.None;
            }
        }
    }
}
