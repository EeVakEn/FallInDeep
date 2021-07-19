using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Shop : MonoBehaviour
{
    [System.Serializable]
    class ShopItem
    {
        public Sprite Image;
        public int Price;
        public bool IsPurchased = false;
        public bool IsSelected = false;
    }

    [SerializeField] List<ShopItem> ShopItemsList;
    
    GameObject ItemTemplate;
    GameObject g;
    [SerializeField] Transform ShopScrollView;
    private Button buyBtn;
    
    void Start()
    {
        ItemTemplate = ShopScrollView.GetChild(0).gameObject;
        int len = ShopItemsList.Count;
        for (int i = 0; i < len; i++)
        {
            g = Instantiate(ItemTemplate, ShopScrollView);
            g.transform.GetChild(0).GetComponent<Image>().sprite = ShopItemsList[i].Image;
            g.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = ShopItemsList[i].Price.ToString();
            g.transform.GetChild(2).GetComponent<Button>().interactable = !ShopItemsList[i].IsSelected;
            buyBtn =  g.transform.GetChild(3).GetComponent<Button>();
            buyBtn.gameObject.SetActive(!ShopItemsList[i].IsPurchased);
            buyBtn.AddEventListener(i,OnShopItemBtnClicked);
        }
        Destroy(ItemTemplate);
    }

    void OnShopItemBtnClicked(int itemIndex)
    {
        ShopItemsList[itemIndex].IsPurchased = true;
        ShopScrollView.GetChild(itemIndex).GetChild(3).GetComponent<Button>().gameObject.SetActive(false);
    }
}
