using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using DG.Tweening;

public class Youth_Books_Manager : MonoBehaviour
{
    // public GameObject[] choose_book = new GameObject[2];

    public List<GameObject> choose_book = new List<GameObject> {};

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        // 選取兩個物件
        if (choose_book.Count == 2) {
            Vector3 pos_0 = choose_book[0].transform.position;
            Vector3 pos_1 = choose_book[1].transform.position;

            // 交換位置
            choose_book[0].transform.position = pos_1;
            choose_book[1].transform.position = pos_0;

            // 重製紀錄器
            choose_book.Clear();
        }
    }
}
