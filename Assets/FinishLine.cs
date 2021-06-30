using UnityEngine;
using UnityEngine.UI;

public class FinishLine : MonoBehaviour
{
    public GameObject EndScrn;
    public int score;
    public Text scoreUI;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            EndScrn.gameObject.SetActive(true);
            Time.timeScale = 0;
            scoreUI.text = "Final Score: " + "\n" + score;
        }
    }
}
