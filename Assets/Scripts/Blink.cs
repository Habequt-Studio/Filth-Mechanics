using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Blink : MonoBehaviour
{
    public static float delay = 0;
    Image img;

    private void Start()
    {
        img = GetComponent<Image>();
        StartCoroutine(fade());
    }

    IEnumerator fade()
    {
        yield return new WaitForSeconds(delay);
        delay = 0;
        Color col = Color.black;
        while(col.a > 0)
        {
            col.a -= 0.02f;
            img.color = col;
            yield return new WaitForSecondsRealtime(0.05f);
        }
        Destroy(gameObject);
    }

}
