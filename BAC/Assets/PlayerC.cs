using UnityEngine;

public class PlayerC : MonoBehaviour
{
   
    public PlayerM mov;
     void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obs")
        {
            mov.enabled = false;
            FindObjectOfType<GameManag>().EndG();
        }
    }
}
