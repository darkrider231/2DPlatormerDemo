using UnityEngine;
using UnityEngine.SceneManagement;

public class YouWin : MonoBehaviour
{
    public Scene activeScene;
   public void RestartLevel()
    {
        activeScene = SceneManager.GetActiveScene();
    }

    public void ExitLevel()
    {
        Debug.Log("GAME EXITED!!");
    }
}
