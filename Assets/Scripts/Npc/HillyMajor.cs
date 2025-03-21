using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HillyMajor : MonoBehaviour
{
    private Transform player;
    public GameObject Quest_Hilly_UI;
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
            Quest_Hilly_UI.SetActive(true);
        }
    }
}
