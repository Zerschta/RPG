using NUnit.Framework;
using UnityEngine;

public class inventory : MonoBehaviour
{
    public GameObject[] slots;
    public GameObject PlayerInventory;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlaceInvInUI();
    }

    void PlaceInvInUI()
    {
        for (int j = 0; j < PlayerInventory.transform.childCount; j++)
        {
            GameObject CurrentItem = PlayerInventory.transform.GetChild(j).gameObject;

            for (int i = 0; i < slots.Length; i++)
            {
                GameObject CurrentSlot = slots[i];

                if (CurrentSlot.GetComponent<SlotEmpty>().IsEmpty && i < PlayerInventory.transform.childCount)
                {
                    CurrentSlot.GetComponent<SlotEmpty>().IsEmpty = false;

                    // CurrentItem in CurrentSlot laden
                    Debug.Log("Currentslot : " + CurrentSlot + "CurrentItem : " + CurrentItem );

                    break;
                }
            }
        }
        
    }
}
