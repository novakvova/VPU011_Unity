using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header("Set in Inspector")]
    //Наше яблуко
    public GameObject applePrefab;
    //Швикдість дерева
    public float speed=1;
    //Ліва і права меже по переміщеню дерева
    public float leftAndRightEdge = 10;
    //Імовірність зміни напрямку руху
    public float chanceToChangeDireaction = 0.1f;
    //Частота скидання яблук
    public float secondsBetweenAppleDrops = 1f;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DropApple", 2f);
    }
    void DropApple()
    {
        GameObject apple = Instantiate(applePrefab);
        apple.transform.position = this.transform.position;
        Invoke("DropApple", secondsBetweenAppleDrops);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;
        if(pos.x<-leftAndRightEdge)
        {
            speed = Mathf.Abs(speed);
        }
        else if(pos.x>leftAndRightEdge)
        {
             speed=-Mathf.Abs(speed);
        }

    }
    private void FixedUpdate()
    {
        if(Random.value<chanceToChangeDireaction)
        {
            speed *= -1;
        }
    }
}
