using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemDrop : MonoBehaviour
{
      public InventoryManager inventoryManager;
      public Item Item;
      public bool attachedToMouse = true;
      public float zDist;
    
        public Transform canvas; 
        public GameObject spawnObj;
        private GameObject followObj;
      public void Update()
      {
        
        //   if (Input.GetKeyDown(KeyCode.Space))
        //   {
        //       attachedToMouse = false;
        //   }
        Vector2 mousePos = Input.mousePosition;
        Camera cam = Camera.main;
        int layerMask = 1 << LayerMask.NameToLayer("ToyBox");

          if (followObj != null && attachedToMouse)
          {
              //Vector3 point = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, (transform.position.y - Camera.main.transform.position.y) , (transform.position.z - Camera.main.transform.position.z))); 
          Vector3 point = cam.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, cam.nearClipPlane + zDist));
          Ray ray = cam.ScreenPointToRay(Input.mousePosition);
          //Ray ray = cam.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));
          RaycastHit hit;
          if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask))
          {
            if(hit.transform.name == "Box"){
              Debug.Log("BOX Did Hit🔥");
              Destroy(followObj);
  
            }
            
          }
          else
          {
            //Debug.Log("Did not Hit");
            
          }
        //    print("I'm looking at " + hit.transform.name);
        //else
        //  print("I'm looking at nothing!");
              
              //Vector3 pos = new Vector3(mousePos.x, mousePos.y, Camera.main.nearClipPlane);
            //   point.z = transform.position.z;
            //   point.y = transform.position.y;
              followObj.transform.position = point;
          }
      }

      public void OnMouseDown()
    {
        // inventoryManager.nowImage.sprite = null;
        // gameObject.SetActive(true);
        // Update();
        //gameObject.transform.parent = canvas;
        followObj = Instantiate(spawnObj);
        attachedToMouse = true;
        
    }
 }