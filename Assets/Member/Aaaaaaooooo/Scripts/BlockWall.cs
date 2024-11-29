using UnityEngine;

public class BlockWall : MonoBehaviour
{
    [SerializeField]
    private GameObject blockPrefab;
    [SerializeField]
    private Vector2 blockPosition;
    [SerializeField]
    private float delay;

    [SerializeField]
    private AudioClip lockSE;
    [SerializeField]
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        Invoke(nameof(SpawnBlock), delay);
    }

    private void SpawnBlock()
    {
        if (blockPrefab != null)
        {
            Instantiate(blockPrefab, blockPosition, Quaternion.identity);
        }

        if(lockSE != null)
        {
            audioSource.PlayOneShot(lockSE);
        }
    }
}
