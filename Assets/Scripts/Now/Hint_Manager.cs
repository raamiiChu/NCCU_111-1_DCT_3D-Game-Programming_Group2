using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Hint_Manager : MonoBehaviour
{
    // 所有可調查物件(會去抓該物件底下的程式碼)
    // 視需求新增變數
    public Light_Trigger[] items;

    // 存放調查物件是否符合顯示 UI 的條件
    // {"遊戲物件名稱": 布林值}
    private Dictionary<string, bool> save_hint_show = new Dictionary<string, bool>();

    // 提示UI
    public GameObject hint_space;

    // 提示UI座標
    private Vector3 original_position_hint_space = new Vector3(35f, 650f, 0f);
    private Vector3 active_position_hint_space = new Vector3(35f, 515f, 0f);


    // Start is called before the first frame update
    void Start()
    {
        // 系統建議新增的
        DOTween.SetTweensCapacity(500, 50);

        // 初始化 save_hint_show (裡面的變數皆為 "false")
        // 視需求進行修改
        foreach (Light_Trigger item in items) {
            save_hint_show.Add(item.name, false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // 更新是否能顯示 UI
        // 視需求進行修改
        foreach (Light_Trigger item in items) {
            save_hint_show[item.name] = item.show_hint;
        }

        // 偵測是否有任何物件符合條件
        if (save_hint_show.ContainsValue(true)) {
            // 顯示提示
            hint_space.transform.DOLocalMove(active_position_hint_space, 1f);
            hint_space.transform.DOScaleX(1f, 1f);
        }
        else {
            // 隱藏提示
            hint_space.transform.DOLocalMove(original_position_hint_space, 1f);
            hint_space.transform.DOScaleX(0.2f, 1f);
        }

    }
}
