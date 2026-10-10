using TMPro;
using UnityEngine;

public class PlayerStat : MonoBehaviour
{
    public TextMeshProUGUI speeddisplay;
    public TextMeshProUGUI playerdisplay;
    public GameObject player;

    Rigidbody player_rb;

    void Start()
    {
        
    }

    void Update()
    {
        
    }
    void FixedUpdate()
    {
        player_rb = player.GetComponent<Rigidbody>();

        speeddisplay.text = ((int)player_rb.linearVelocity.magnitude).ToString() + " km/h";
    }
}
