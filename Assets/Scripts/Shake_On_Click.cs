using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake_On_Click : MonoBehaviour
{
    // 用於儲存晃動的原始位置
    private Vector3 original_position;

    // 晃動的幅度
    public float shake_amount = 2f;

    public bool correct_spot = false;

    // Start is called before the first frame update
    void Start()
    {
        // 初始化時儲存物件的原始位置
        original_position = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        // 執行晃動動畫
        StartCoroutine(Do_Shake());
        GameManager.count += 1;
    }

    IEnumerator Do_Shake()
    {
        // 重複晃動多次
        for (int i = 0; i < 10; i++)
        {
            // 隨機生成晃動的目標位置
            Vector3 target_position = original_position + Random.insideUnitSphere * shake_amount;

            // 將物件移動到目標位置
            transform.position = Vector3.Lerp(transform.position, target_position, Time.deltaTime * 5f);

            // 等待一段時間再進行下一次晃動
            yield return new WaitForSeconds(0.05f);
        }

        // 晃動完成後將物件移動回原始位置
        gameObject.transform.position = original_position;
        
        correct_spot = true;
    }
}
