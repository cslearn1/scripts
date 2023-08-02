using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{
    public Vector2 targetPosition;
    public float moveStep;
    public bool trap;
    public float speedF;
    public float scalefF;
    public int catchCount;

    private void Start()
    {
        if(trap == false)
        {
            Player.sqs.Add(this);
        }

        targetPosition = GetRandomPoint();
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, moveStep * Time.deltaTime);

        if((Vector2)transform.position == targetPosition)
        {
            targetPosition = GetRandomPoint();
        }
    }
    Vector2 GetRandomPoint()
    {
        Vector2 randomVector = new Vector2();

        randomVector.x = Random.Range(-7, 7);
        randomVector.y = Random.Range(-4, 4);

        return randomVector;
    }

    void OnMouseDown()
    {
        if(trap)
        {
            Player.defeat();
        }
        else
        {
            Catch();
        }
    }

    void Catch()
    {
        Player.score++;
        catchCount--;

        if(catchCount == 0)
        {
            Player.sqs.Remove(this);
            Destroy(gameObject);
        }
        else
        {
            moveStep += speedF;
            transform.localScale = (Vector2)transform.localScale - new Vector2(scalefF, scalefF);
            transform.position = GetRandomPoint();
        }
    }
}