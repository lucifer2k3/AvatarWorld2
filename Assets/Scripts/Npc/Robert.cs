using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robert : MonoBehaviour
{
    private Transform player;
    public GameObject Shop;
    void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnMouseDown()
    {
        if (Vector2.Distance(player.position, this.transform.position) < 6f)
        {
                Shop.SetActive(true);
        }
    }
}
