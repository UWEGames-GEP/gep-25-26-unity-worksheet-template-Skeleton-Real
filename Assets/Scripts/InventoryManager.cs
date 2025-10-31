using UnityEngine;
using System.Collections.Generic;

public class InventoryManager : MonoBehaviour
{
    public List<string> items = new List<string> ();

    public GameManagerScript gameScript;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameScript = FindAnyObjectByType<GameManagerScript> ();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameScript.gameState == GameManagerScript.state.GAMEPLAY)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
                AddItem("silly");
            if (Input.GetKeyDown(KeyCode.Alpha2))
                RemoveItem("silly");
        }
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        CollectableScript collisionItem = hit.gameObject.GetComponent<CollectableScript>();
        if (collisionItem != null) 
        {
            AddItem(collisionItem.itemName);
            Destroy(collisionItem.gameObject);
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
