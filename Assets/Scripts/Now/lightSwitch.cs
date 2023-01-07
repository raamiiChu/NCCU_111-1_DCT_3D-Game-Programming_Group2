using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightSwitch : MonoBehaviour
{   
    public Material monster;
    public Material redWall;
    public GameObject wall;
    public GameObject real1;
    public GameObject real2;
    public GameObject real3;
    public GameObject real4;
    public GameObject real5;
    public GameObject talk3;
    private Material wallMaterial;
    private GameObject[] redObjects;
    private GameObject[] walls;
    private float timer = 0;
    
    // Start is called before the first frame update

    void Start()
    {
         redObjects = GameObject.FindGameObjectsWithTag("Red");
         walls = GameObject.FindGameObjectsWithTag("Wall");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnMouseDown()
    {
        // 更換牆壁的材質
        wall.GetComponent<MeshRenderer>().material = monster;
        for (int j = 0; j < walls.Length; j++) {
            walls[j].GetComponent<MeshRenderer>().material = redWall;
        }

        // 將初始紅色物件關閉
        for (int i = 0; i < redObjects.Length; i++) {
            redObjects[i].SetActive(false);
        }
        // 將提示物件開啟，因為tag只能用在active物件上，所以用暴力解法
        real1.SetActive(true);
        real2.SetActive(true);
        real3.SetActive(true);
        real4.SetActive(true);
        real5.SetActive(true);
        talk3.SetActive(true);
        Invoke("destroyTalk", 5.0f);
       
    }

     private void destroyTalk() {
         talk3.SetActive(false);
     }
   
}