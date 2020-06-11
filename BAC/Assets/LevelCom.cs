using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCom : MonoBehaviour
{
    public void LoadNL()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1 );
    }
}
