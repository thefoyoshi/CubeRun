using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public GameObject playerBody;
    public Camera playerCamera;

    Transform player_tf, camera_tf;

    void Start() 
    {
        player_tf = playerBody.GetComponent<Transform>();
        camera_tf = playerCamera.GetComponent<Transform>();
    }

    void Update()
    {
        camera_tf.SetPositionAndRotation(new Vector3(player_tf.position.x, player_tf.position.y + 5, player_tf.position.z - 9), Quaternion.Euler(27, 0, 0));
    }
}
