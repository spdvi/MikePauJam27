using UnityEngine;
using UnityEngine.SceneManagement;

public class UIActions : MonoBehaviour
{
    public void OnPlayButtonClicked() {
        //Debug.Log("OnPlayButtonClicked");
        SceneManager.LoadSceneAsync("Level1");
    }
}
