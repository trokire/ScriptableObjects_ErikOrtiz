using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    public static CanvasManager Instance;

    public Text texto1;
    public Text texto2;
    public Text texto3;
    public Text texto4;

    private void Awake() {
        if(Instance == null)
        {
            Instance = this;
        }else
        {
            Destroy(this);
        }
    }

    public void TranslateLanguage(Translation item)
    {
        texto1.text = item.texto1;
        texto2.text = item.texto2;
        texto3.text = item.texto3;
        texto4.text = item.texto4;
    }
}
