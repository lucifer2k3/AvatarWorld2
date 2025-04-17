using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Kitchen : MonoBehaviour
{
    //public Camera mainCamera;
    [SerializeField]private GameObject kitchenUI; // Reference to the kitchen UI GameObject
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    Vector3 mousePos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        //    RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero);
        //    if (hit.collider != null)
        //    {
        //        if (hit.collider.gameObject.CompareTag("Kitchen"))
        //        {
        //            Debug.Log("Kitchen clicked!");
        //            // Add your logic here for when the kitchen is clicked
        //        }
        //    }
        //}
    }
    private void OnMouseDown()
    {
        OpenKitchenUI();
    }
    private void OpenKitchenUI()
    {
        kitchenUI.SetActive(true); // Show the kitchen UI
    }
}
