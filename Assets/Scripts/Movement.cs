using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject player;
    Rigidbody player_rb;
    float jumpDuration = 0;
    static float playerSpeed = 8, speedBooster = 0.0f;

    Vector3 up = new Vector3(0.0f, 285.0f, 0.0f), forward = new Vector3(0.0f, 0.0f, playerSpeed + speedBooster), back = new Vector3(0.0f, 0.0f, -playerSpeed + speedBooster), right = new Vector3(playerSpeed + speedBooster, 0.0f, 0.0f), left = new Vector3(-playerSpeed + speedBooster, 0.0f, 0.0f);

    void Start()
    {
        player_rb = player.GetComponent<Rigidbody>();
    }

    void Update()
    {}

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W)) { player_rb.AddForce(forward, ForceMode.Impulse); }
        if (Input.GetKey(KeyCode.D)) { player_rb.AddForce(right, ForceMode.Impulse); }
        if (Input.GetKey(KeyCode.A)) { player_rb.AddForce(left, ForceMode.Impulse); }
        if (Input.GetKey(KeyCode.S)) { player_rb.AddForce(back, ForceMode.Impulse); }

        if (Input.GetKey(KeyCode.Space) && jumpDuration <= 0) { player_rb.AddForce(up, ForceMode.Impulse); jumpDuration = 2f; }
        else { jumpDuration -= Time.deltaTime; }
    }
}
