using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardforce = 2000f;
    public float sidewayforce = 500f;

    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardforce * Time.deltaTime);
        if (Input.GetKey("d")) //yeh Input.GetKey lagaya he key se control kerna ke liye game ko ek side se
        {
            rb.AddForce(sidewayforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a")) //yeh Input.GetKey lagaya he key se control kerna ke liye game ko dosri side se
        {
            rb.AddForce(-sidewayforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        //  if(rb.position.y< -1f)
        //{
        //  FindObjectOfType<GameManager>().EndGame();
        //}
    }



}
