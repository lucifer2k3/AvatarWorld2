using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Tree : MonoBehaviour
{
    public float health = 8;

    [SerializeField] private GameObject body; // Prefab của cây

    public Transform pivotPoint; // Điểm mà cây sẽ xoay quanh
    public float rotationAngle = 90f; // Góc xoay (có thể điều chỉnh)
    public float rotationSpeed = 100f; // Tốc độ xoay

    private bool isFalling = false;
    private float currentRotation = 0f;
    private Vector3 initialRotation;


    [SerializeField]private Item drop;
    [SerializeField]private int quantity1 = 1;
    [SerializeField] private int quantity2 = 1;

    //get player position
    private Transform playerTransform;
    private void Awake()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        if (playerTransform == null)
        {
            Debug.LogError("Player không được tìm thấy trong scene!");
        }
    }
    public void StartFalling()
    {
        if (pivotPoint == null)
        {
            Debug.LogError("Pivot Point chưa được gán!");
            return;
        }
        isFalling = true;
        initialRotation = body.transform.eulerAngles; // Lưu lại góc ban đầu
        currentRotation = 0f;
    }
    void Update()
    {
        if (isFalling)
        {
            // Tính toán góc xoay trong frame này
            float step = rotationSpeed * Time.deltaTime;

            // Xoay cây quanh pivot point
            body.transform.RotateAround(pivotPoint.position, Vector3.forward, step);

            // Cộng dồn góc xoay hiện tại
            currentRotation += Mathf.Abs(step);

            // Kiểm tra nếu đã xoay đủ góc
            if (currentRotation >= rotationAngle)
            {
                isFalling = false;
                // Đảm bảo góc cuối cùng chính xác là 90 độ
                Vector3 finalRotation = initialRotation;
                finalRotation.z -= rotationAngle; // Giả sử xoay quanh trục Z
                Destroy(body); // Xóa cây sau khi đã rơi
                PlayerInvent.instance.AddItem(drop, quantity1); // Thêm item vào inventory
                //body.transform.eulerAngles = finalRotation;
            }
        }

    }
    void OnMouseDown(){
        if (Vector2.Distance(playerTransform.position,transform.position)<5.5f)
            {
            if (playerTransform.position.x > transform.position.x) 
            {
                PlayerController.instance.axetrigger(true);
            }
            else
            {
                PlayerController.instance.axetrigger(false);
            }
            //PlayerController.instance.axetrigger(true);

            {
                if (health > 0)
                {
                    health--;
                }
            if (health == 2)
                {
                    StartFalling();
                }
                if (health <= 0)
                {
                    PlayerInvent.instance.AddItem(drop, quantity2);
                    Destroy(gameObject);
                    // Thêm item vào inventory
                }
            }
            }
        else
        {
            Debug.Log("Player quá xa cây");
        }
    }
    


}
