using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class Switch_Camera_Bookshelf : MonoBehaviour
{
    // 玩家
    public GameObject player;
    // 玩家攝影機
    public GameObject player_camera;
    // 書架攝影機
    public GameObject bookshelf_camera;
    // 按鈕
    public GameObject btn;

    // 觸發距離
    public float trigger_dist = 5f;
    // 是否在調查階段
    private bool invastigate_bookshelf = false;

    // 玩家物理屬性
    private Rigidbody player_rigidbody;

    // 按鈕座標
    private Vector3 original_position_btn = new Vector3(35f, 649f, 0f);
    private Vector3 invastigate_position_btn = new Vector3(35f, 444f, 0f);

    // Start is called before the first frame update
    void Start()
    {
        player_rigidbody = player.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float dist = (Vector3.Distance(player.transform.position, gameObject.transform.position));
        
        // 距離小書架足夠近
        if (dist < trigger_dist && Input.GetKeyDown(KeyCode.Space)) {
            Investigate_Bookshelf();
        }
    }

    void Investigate_Bookshelf() {
        // 按下 space 進入調查畫面
        if (!invastigate_bookshelf) {
            // 正在進行調查
            invastigate_bookshelf = true;

            // 切換攝影機
            player_camera.SetActive(false);
            bookshelf_camera.SetActive(true);

            // 可點擊按鈕
            btn.GetComponent<Button>().interactable = true;

            // 移動按鈕
            btn.transform.DOLocalMove(invastigate_position_btn, 1f);

            // 鎖住玩家位置
            player_rigidbody.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ;
        }
        // 按下 space 離開調查畫面
        else if (invastigate_bookshelf) {
            End_Investigation();
        }
    }

    // 離開調查畫面
    // 同時也是 按鈕事件(onClick)
    public void End_Investigation () {
        // 沒有在進行調查
        invastigate_bookshelf = false;
        
        // 切換攝影機
        player_camera.SetActive(true);
        bookshelf_camera.SetActive(false);

        // 不可點擊按鈕(避免玩家重複觸發)
        btn.GetComponent<Button>().interactable = false;

        // 移動按鈕
        btn.transform.DOLocalMove(original_position_btn, 1f);
        
        // 解除鎖定玩家位置
        player_rigidbody.constraints = RigidbodyConstraints.None;
    }
    
}
