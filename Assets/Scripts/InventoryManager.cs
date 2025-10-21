using UnityEngine;
using System.Collections.Generic;

public class InventoryManager : MonoBehaviour
{
    public List<string> items = new List<string> ();

    public GameManagerScript gameManagerScript;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManagerScript.gameState == state.GAMEPLAY)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
                AddItem("silly");
            if (Input.GetKeyDown(KeyCode.Alpha2))
                RemoveItem("silly");
        }
    }

    public void AddItem(string itemName)
    {
        items.Add(itemName);
    }

    public void RemoveItem(string itemName)
    { 
        items.Remove(itemName);
    }
}
