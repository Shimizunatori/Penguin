using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boost : MonoBehaviour
{
    [SerializeField]
    private float Boostzone;
    [SerializeField]
    private string Tag;

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
        if(collision.CompareTag(Tag))
        {
            Rigidbody2D rigidbody2D = collision.GetComponent<Rigidbody2D>();
            if(rigidbody2D != null)
            {
                Vector2 direction = rigidbody2D.velocity.normalized;
                rigidbody2D.velocity += direction * Boostzone;
            }
        }
    }
}
