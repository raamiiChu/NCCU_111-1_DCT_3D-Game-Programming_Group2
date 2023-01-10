using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;
    public List<Item> Items = new List<Item>();

    public Transform ItemContent;
    public GameObject InventoryItem;

    public Sprite spriteCircle;
    public Sprite spriteRectangle;
    public Sprite spriteTriangle;

    public Image image01;
    public Image image02;
    public Image image03;
  
    public GameObject spawnCircle;
    public GameObject spawnRectangle;
    public GameObject spawnTriangle;

    public int imageCount;
    public Image nowImage;
    
    // Start is called before the first frame update

    private void Awake()
    {
        Instance = this;
    }

    public void Add(Item item)
    {
        Items.Add(item);

    }

    public void Remove(Item item)
    {
        Items.Remove(item);
    }

   public void ListItems()
   {
    foreach (Transform item in ItemContent)
    {
       Destroy(item.gameObject);
    }
    foreach(var item in Items)
    {
        GameObject obj = Instantiate(InventoryItem, ItemContent);
        var itemIcon= obj.transform.Find("ItemIcon").GetComponent<Image>();

        itemIcon.sprite = item.icon;
    }
   }
    
   void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowSprite(string objectName)
    {
        imageCount++;

        if(imageCount == 1)
        {
            nowImage = image01;
        }
        else if(imageCount == 2)
        {
            nowImage = image02;
        }
        else
        {
            nowImage = image03;
        }

        if(objectName == "rectangle")
        {
            Debug.Log("Pick");
            nowImage.sprite = spriteRectangle;
        }
        else if (objectName == "triangle")
        {
            nowImage.sprite = spriteTriangle;
        }
        else if (objectName == "circle")
        {
            nowImage.sprite = spriteCircle;
        }
    }

    public void SetSpawnModel(string objectName){
        if(objectName == "rectangle")
        {
            Debug.Log("Pick");
            nowImage.transform.parent.GetComponent<ItemDrop>().spawnObj =  spawnRectangle;
           
        }
        else if (objectName == "triangle")
        {
            nowImage.transform.parent.GetComponent<ItemDrop>().spawnObj =  spawnTriangle;
        }
        else if (objectName == "circle")
        {
            nowImage.transform.parent.GetComponent<ItemDrop>().spawnObj = spawnCircle;
        }

        
    }

}
