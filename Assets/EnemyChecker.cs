using TMPro;
using UnityEngine;

public class EnemyChecker : MonoBehaviour
{
    public GameObject player;

    Transform plTf;

    void Start()
    { 
       plTf = player.GetComponent<Transform>(); 
    }

    void Update()
    {}

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("enemy")) { plTf.position = new Vector3(-95.5f, 5f, 3f);}
    }
}
