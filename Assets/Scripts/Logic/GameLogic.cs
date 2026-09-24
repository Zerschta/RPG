using UnityEngine;

public class GameLogic : MonoBehaviour
{
    [SerializeField] private GameObject inventoryUI; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ActiveInventory();
    }

    void ActiveInventory()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            inventoryUI.SetActive(!inventoryUI.activeSelf);
        }
    }
}
