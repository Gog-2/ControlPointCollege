using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ExitFromFade : MonoBehaviour
{
    public Image Panel;
    void Start()
    {
        Panel.color = new Color(255, 255, 255, 255);
        StartCoroutine(ExitFadeToBlack());
    }

    private IEnumerator ExitFadeToBlack()
    {
        for (float i = 1; i >= 0; i -= Time.deltaTime)
        {
            Panel.color = new Color(255, 255, 255, i);
            yield return null;
        }
        Panel.color = new Color(255, 255, 255, 0);
    }
}
