using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Move_On_Click : MonoBehaviour
{
    public GameObject little_book_move;

    public bool correct_spot = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        gameObject.transform.DOLocalMove(new Vector3(-2f, 0f, 0f), 1);  
        little_book_move.transform.DOLocalMove(new Vector3(-1f, 0.387f, 0f), 1);
        
        correct_spot = true;
    }
}
