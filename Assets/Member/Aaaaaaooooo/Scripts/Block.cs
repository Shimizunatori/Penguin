using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Block : MonoBehaviour
{
    [SerializeField]
    private string Tag;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(Tag))
        {
            FadeManager.Instance.FadeToScene("GameOver");
        }
    }
}
