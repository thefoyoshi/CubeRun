using TMPro;
using UnityEngine;

public class EnemyChecker : MonoBehaviour
{
    public GameObject player;

    Transform plTf;

    float attempts_count = 0;

    void Start()
    {}

    void Update()
    {}

    void OnCollisionEnter(Collision collision)
    {
        plTf = player.GetComponent<Transform>();
        if (collision.gameObject.CompareTag("enemy")) { plTf.position = new Vector3(-95.5f, 5f, 3f); attempts_count += 1; }
    }
}
