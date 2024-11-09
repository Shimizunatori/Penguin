using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenguinMove : MonoBehaviour
{
    [SerializeField]
    private float speed;
    private Rigidbody2D Rb2D;
    private Vector2 mouseStartPos;
    private Vector2 mouseEndPos;
    private Vector2 startDirection;

    //ó\ë™ê¸
    [SerializeField]
    private float maxLine;
    [SerializeField]
    private LineRenderer lineRen;
    [SerializeField]
    private LayerMask wall;

    public bool goFlag;

    // Start is called before the first frame update
    void Start()
    {
        Rb2D = GetComponent<Rigidbody2D>();
        goFlag = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (goFlag == true)
        {
            //lineRen.enabled = true;
            if (Input.GetMouseButtonDown(0))
            {
                mouseStartPos = Input.mousePosition;
            }
            if (Input.GetMouseButtonUp(0))
            {
                mouseEndPos = Input.mousePosition;
                startDirection = -1 * (mouseEndPos - mouseStartPos).normalized;
                Rb2D.AddForce(startDirection * speed);
            }
        }
    }
}
