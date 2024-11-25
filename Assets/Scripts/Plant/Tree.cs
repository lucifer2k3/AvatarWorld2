using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Tree : MonoBehaviour
{
    private BoxCollider2D thistree;
    private Transform body;
    private Vector3 mousePos;
    public float health = 4;
    public Vector2 targetPosition = new Vector2(3f, -2.8f);
    public float fallSpeed = 5;
    private SpriteRenderer spriteRendererBody;
    private SpriteRenderer spriteRendererRoot;
    void Start()
    {
        thistree = GetComponent<BoxCollider2D>();
        body = transform.Find("Body").GetComponent<Transform>();
        spriteRendererBody = transform.Find("Body").GetComponent<SpriteRenderer>();
        spriteRendererBody.sortingOrder = (int)transform.position.y;
        spriteRendererRoot = transform.Find("Root").GetComponent<SpriteRenderer>();
        spriteRendererRoot.sortingOrder = (int)transform.position.y;
    }

    
    void Update()
    {   
        
            
    }
    void OnMouseDown(){
        health--;
        if (health <= 0)
            {
                StartCoroutine(FallDown());
                //body.transform.position = Vector2.Lerp(body.transform.position,targetPosition,1f);
            }

    }   
    private IEnumerator FallDown()
    {
        Quaternion startRotation = body.transform.rotation;
        Quaternion endRotation = Quaternion.Euler(0, 0, -90); 
        float time = 0;
        while (time <= 0.9f)
        {
            time += Time.deltaTime;
            
            body.transform.RotateAround(transform.position,Vector3.forward,-1.18f);
            yield return null;
        }

        
    }

}
