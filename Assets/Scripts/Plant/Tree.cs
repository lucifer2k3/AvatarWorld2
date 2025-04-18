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
                //body.transform.eulerAngles = finalRotation;
            }
        }

    }
    void OnMouseDown(){

        if (health > 0)
        {
            health--;
        }
        if (health <= 4)
        {
            StartFalling();
        }
    }
    


}
