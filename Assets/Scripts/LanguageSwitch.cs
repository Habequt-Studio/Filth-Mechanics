using UnityEngine;
using TMPro;

public class LanguageSwitch : MonoBehaviour
{
    //If you want to select language -> PlayerPrefs.SetInt("Language", <language index>);
    public int language = 0; //0 - English; 1 - Russian
    public string[] text;
    private TextMeshProUGUI textline;

    private void Start()
    {
        language = PlayerPrefs.GetInt("Language", language);
        textline = GetComponent<TextMeshProUGUI>();
        textline.text = "" + text[language];
    }
}
