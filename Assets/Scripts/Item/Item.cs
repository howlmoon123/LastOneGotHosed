using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
   
    [SerializeField]
    private int _itemCode;
    [SerializeField]
    private string itemDescription;
    private SpriteRenderer spriteRenderer;

    public int ItemCode { get { return _itemCode; } set { _itemCode = value; } }

    private void Awake()
    {
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }

    private void Start()
    {
        if (ItemCode != 0)
        {
            Init(ItemCode);
        }
    }

    public void Init(int itemCodeParam)
    {
        if (itemCodeParam != 0)
        {
            ItemCode = itemCodeParam;

            ItemDetails itemDetails = InventoryManager.Instance.GetItemDetails(ItemCode);

           spriteRenderer.sprite = itemDetails.itemSprite;

           
        }
    }
}
