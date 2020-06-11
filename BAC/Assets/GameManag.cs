using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManag : MonoBehaviour
{
    bool gameHasEnded = false;

    public GameObject completelU;

    public float restartDelay = 1f;

    public void Comlvel()
    {
        completelU.SetActive(true);
    }
    public void EndG()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
}
