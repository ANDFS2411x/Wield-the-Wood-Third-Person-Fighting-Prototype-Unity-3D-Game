using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public GameObject levelUpUI;
    public string nextLevel = "Gameplay_Level2";
    bool done = false;

    void Update()
    {
        if (done) return;

        if (GameObject.FindGameObjectsWithTag("Enemy").Length == 0)
        {
            done = true;
            levelUpUI.SetActive(true);
            Invoke(nameof(LoadNext), 3f);
        }
    }

    void LoadNext()
    {
        SceneManager.LoadScene(nextLevel);
    }
}
