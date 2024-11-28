using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportObj : MonoBehaviour
{
    [SerializeField] private Transform teleportTarget;
    [SerializeField] private string targetTag;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag(targetTag))
        {
            collision.transform.position = teleportTarget.position;
        }
    }
}
