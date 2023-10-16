using UnityEngine.Windows.Speech;

public static class DictationAPI
{
    private static DictationRecognizer dictationRecognizer;

    public static Recognize OnRecognize;
    public delegate void Recognize(string str);

    public static void Init()
    {
        dictationRecognizer = new DictationRecognizer();
        dictationRecognizer.DictationResult += RecognizeWord;
    }

    private static void RecognizeWord(string text, ConfidenceLevel confidence)
    {
        OnRecognize?.Invoke(text);
    }

    public static void StartRecognizer() { dictationRecognizer.Start(); }
    public static void StopRecognizer() { dictationRecognizer.Stop(); }

    public static void Terminate()
    {
        if (dictationRecognizer == null)
            return;

        dictationRecognizer.DictationResult -= RecognizeWord;
        dictationRecognizer.Dispose();
    }
}
