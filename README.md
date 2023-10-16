# Windows ASR for Unity
The `System.Speech.Recognition` from `.NET` is **not** usable inside Unity. 
Even if you include the `.dll` in the project, it will simply throw an error saying **"Platform not Supported"** when you attempt to run the program. 

Instead, Unity provides an alternative: [`UnityEngine.Windows.Speech`](https://docs.unity3d.com/ScriptReference/Windows.Speech.DictationRecognizer.html). 
You still need to first turn on the feature by going to `Settings` -> `Privacy & security` -> `Speech` on Windows.
It also requires an active Internet connection.

# TL;DR
Use [Vosk](https://github.com/HaomingXR/Vosk-ASR-for-Unity) instead 💀
