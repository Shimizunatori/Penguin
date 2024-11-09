using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenguinStatus : MonoBehaviour
{
    [SerializeField]
    public int _hp; // _hp‚ÍƒoƒEƒ“ƒX‚Ì‰ñ”
    public bool moveFlag;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (_hp <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            _hp--;
        }
        if (other.gameObject.CompareTag("Enemy"))
        {
            _hp = 0;
        }
        if (other.gameObject.CompareTag("Conf"))
        {
            if (moveFlag == true)
            {
                gameObject.SetActive(false);
            }
            else
            {

            }
        }
    }
}
