using UnityEngine;

public class EndTr : MonoBehaviour
{
    public GameManag gameManager;
    void OnTriggerEnter()
    {
        gameManager.Comlvel();
    }
}
