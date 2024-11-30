using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenguinStatus : MonoBehaviour
{
    [SerializeField]
    public int _hp; // _hp‚ÍƒoƒEƒ“ƒX‚Ì‰ñ”
    public bool moveFlag;
    [SerializeField]
    private GameObject _outPen;
    [SerializeField]
    private GameObject _inPen;
    [SerializeField]
    private GameObject _outGate;

    // Start is called before the first frame update
    void Start()
    {
        _outPen.gameObject.SetActive(true);
        _inPen.gameObject.SetActive(false);
        _outGate.gameObject.SetActive(false);
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
        if (other.gameObject.CompareTag("Lock"))
        {
            _hp--;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Pen"))
        {
            _outPen.gameObject.SetActive(false);
            _inPen.gameObject.SetActive(true);
            _outGate.gameObject.SetActive(true);
        }
    }
}
