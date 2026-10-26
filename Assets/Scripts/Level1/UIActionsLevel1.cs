using UnityEngine;
using UnityEngine.SceneManagement;

public class UIActionsLevel1 : MonoBehaviour
{
    public GameObject canvas;

    public void OnMenuButtonClicked()
    {
        SceneManager.LoadSceneAsync("MainMenu");
    }

    public void OnQuitButtonClicked()
    {
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            if (canvas.activeInHierarchy)
            {
                canvas.SetActive(false);
            }
            else
            {
                canvas.SetActive(true);
            }
        }
    }
}
