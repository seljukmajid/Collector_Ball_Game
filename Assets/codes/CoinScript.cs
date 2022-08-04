using UnityEngine;

public class CoinScript : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(90 * Time.deltaTime, 0, 0);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            other.GetComponent<PlayerScript>().points++;
            Destroy(gameObject);
        }
    }
}
