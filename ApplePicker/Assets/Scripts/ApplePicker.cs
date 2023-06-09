using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;

public class ApplePicker : MonoBehaviour
{
    [Header("Set in Inpsector")]
    public GameObject basketPrefab;
    public int numBaskets = 3;
    public float basketBottomY = -14f;
    public float basketSpacingY = 2f;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numBaskets; i++)
        {
            var b = Instantiate(basketPrefab);
            Vector3 pos = Vector3.zero;
            pos.y=basketBottomY+(basketSpacingY*i);
            b.transform.position = pos;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
