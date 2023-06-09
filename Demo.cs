using UnityEngine;
using UnityEngine.UI;

public class Demo : MonoBehaviour
{
    [SerializeField]
    private Text resultText;

    void Awake()
    {
        DictationAPI.Init();
        DictationAPI.OnRecognize += OnWordRecognized;
    }

    void Start()
    {
        DictationAPI.StartRecognizer();
    }

    void OnApplicationQuit()
    {
        DictationAPI.Terminate();
    }

    private void OnWordRecognized(string text)
    {
        resultText.text += text + " ";
    }
}