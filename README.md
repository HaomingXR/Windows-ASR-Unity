# Windows ASR for Unity
The `System.Speech.Recognition` from `.NET` is **not** usable in Unity. Even if you do put the `.dll` into the project,
it will simply throw errors about `Platform Not Supported` when you try to run. 

Instead, Unity provides an alternative: [`UnityEngine.Windows.Speech`](https://docs.unity3d.com/ScriptReference/Windows.Speech.DictationRecognizer.html). 
To use it, you will first need to turn the feature on by going to `Settings` -> `Privacy & security` -> `Speech` on Windows.
It also requires an active Internet connection.

# TL;DR
Use [Vosk](https://github.com/HaomingXR/Vosk-ASR-for-Unity) instead 💀