using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + "\n" + player.position.x.ToString("0");
    }
}
