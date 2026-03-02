using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 7, -10);

    // LateUpdate is called once per frame after Update
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
