using UnityEngine;

public class RoatateEnd : MonoBehaviour
{
    [SerializeField] GameObject gameOverUI;

    private void Start()
    {
        gameOverUI.SetActive(false);
    }

    public void DoRestart()
    {
        Time.timeScale = 1f;
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }

    public void DoExit()
    {
        Application.Quit();
    }

    void Update()
    {
        if (transform.rotation.eulerAngles.z >= 90f && transform.rotation.eulerAngles.z < 271f)
        {
            Time.timeScale = 0f;
            gameOverUI.SetActive(true);
        }
        else
        {
            Time.timeScale = 1f;
            gameOverUI.SetActive(false);
        }
    }
}