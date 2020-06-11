using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Transform play;
    public Text scoreT;
    // Update is called once per frame
    void Update()
    {
        scoreT.text = play.position.z.ToString("0");
    }
}
