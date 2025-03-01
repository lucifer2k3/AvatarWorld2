using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caroline : MonoBehaviour
{
    private Transform player;
    public GameObject QA_UI;
    void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {
    }
    private void OnMouseDown()
    {
        if (Vector2.Distance(player.position, this.transform.position) < 6f)
        {
            QA_UI.SetActive(true);
        }
    }
}
