using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Camera cam;

    [Header("Move")]
    [SerializeField] private float moveSpeed;

    [SerializeField] private Transform corner1;
    [SerializeField] private Transform corner2;


    [SerializeField] private float xInput;
    [SerializeField] private float zInput;

    public static CameraController instance;
    void Start()
    {
        moveSpeed = 50;
    }

    // Update is called once per frame
    void Update()
    {
        MoveByKB();
    }
    
    void Awake()
    {
        instance = this;
        cam = Camera.main;
    }
    
    private void MoveByKB()
    {
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");

        Vector3 dir = (transform.forward * zInput) + (transform.right * xInput);

        transform.position += dir * moveSpeed * Time.deltaTime;
    }


}
