using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiMenu : MonoBehaviour
{
    public Image Panel;

    public void ChangeScene(int index)
    {
        StartCoroutine(FadeToBlack(index));
    }
    private IEnumerator FadeToBlack(int index) 
    {
    for (float i = 0; i <= 1; i += Time.deltaTime) {
        Panel.color = new Color(255, 255, 255, i);
    yield return null;
    }
    SceneManager.LoadScene(index);
    }
}
