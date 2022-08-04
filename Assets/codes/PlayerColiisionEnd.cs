using UnityEngine;

public class PlayerColiisionEnd : MonoBehaviour
{
    public playermovement Movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "End")
        {
            Movement.enabled = false;
        }
    }
}
