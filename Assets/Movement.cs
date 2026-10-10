using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject player;

    Rigidbody player_rb;

    float jumpDuration = 1;
    static float playerSpeed = 7;

    static float speedBooster = 0.0f;

    Vector3 up = new Vector3(0.0f, 270.0f, 0.0f);
    Vector3 forward = new Vector3(0.0f, 0.0f, playerSpeed + speedBooster);
    Vector3 back = new Vector3(0.0f, 0.0f, -playerSpeed + speedBooster);
    Vector3 right = new Vector3(playerSpeed + speedBooster, 0.0f, 0.0f);
    Vector3 left = new Vector3(-playerSpeed + speedBooster, 0.0f, 0.0f);

    void Start()
    {
        // i like cola <3
    }

    void Update()
    {
        
    }

    void FixedUpdate()
    {
        player_rb = player.GetComponent<Rigidbody>();

        if (Input.GetKey(KeyCode.W)) { player_rb.AddForce(forward, ForceMode.Impulse); }
        if (Input.GetKey(KeyCode.D)) { player_rb.AddForce(right, ForceMode.Impulse); }
        if (Input.GetKey(KeyCode.A)) { player_rb.AddForce(left, ForceMode.Impulse); }
        if (Input.GetKey(KeyCode.S)) { player_rb.AddForce(back, ForceMode.Impulse); }

        if (Input.GetKey(KeyCode.Space) && jumpDuration <= 0) { player_rb.AddForce(up, ForceMode.Impulse); jumpDuration = 3; }
        else { jumpDuration -= Time.deltaTime; }

    }
}
