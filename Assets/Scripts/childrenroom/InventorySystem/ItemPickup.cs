using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemPickup : MonoBehaviour
{
    public Item Item;
    public InventoryManager inventoryManager;

    void Pickup()
    {        
        
        inventoryManager.ShowSprite(gameObject.name);
        inventoryManager.SetSpawnModel(gameObject.name);
        Destroy(gameObject);

    }

    private void OnMouseDown()
    {
        Pickup();
    }

    void Start()
    {
        inventoryManager.imageCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
