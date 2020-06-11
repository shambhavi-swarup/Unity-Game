using UnityEngine;

public class PlayerM : MonoBehaviour
{

    public Rigidbody rb;

    public float forf = 2000f;
    public float sidef = 500f;
    // Start is called before the first frame update
    
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forf * Time.deltaTime);

        if(Input.GetKey("d"))
        {
            rb.AddForce(sidef * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidef * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManag>().EndG();
        }
    }
}
