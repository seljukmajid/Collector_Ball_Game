using UnityEngine;

public class PlayerEnd : MonoBehaviour
{
    public Gamemanager manager;
    void OnTriggerEnter()
    {
        manager.CompleteLevel();
    }
}
