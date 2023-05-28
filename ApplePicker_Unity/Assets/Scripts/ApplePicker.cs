using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.VirtualTexturing;

public class ApplePicker : MonoBehaviour
{
    [Header("Set in Inspector")]
    public GameObject basketPrefab;
    public int numBaskets = 3;
    public float basketBottomY = -14f;
    public float basketSpacingY = 2f;
    public List<GameObject> basketList;
    // Start is called before the first frame update
    void Start()
    {
        basketList = new List<GameObject>();
        for (int  i= 0; i < numBaskets; i++)
        {
            var b = Instantiate(basketPrefab);
            Vector3 pos = Vector3.zero;
            pos.y = basketBottomY+(basketSpacingY*i);
            b.transform.position = pos;
            basketList.Add(b);
        }
        
    }
    public void AppleDestroyed()
    { 
     
        GameObject[] tAppleArray = GameObject.FindGameObjectsWithTag("Apple");
        foreach (GameObject tGO in tAppleArray)
        {
            Destroy(tGO);
        }
        int basketIndex = basketList.Count - 1;
        // Get a reference to that Basket GameObject
        GameObject tBasketGO = basketList[basketIndex];
        // Remove the Basket from the List and destroy the GameObject
        basketList.RemoveAt(basketIndex);
        Destroy(tBasketGO);
        if (basketList.Count == 0)
        {
            Application.LoadLevel("SampleScene");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
