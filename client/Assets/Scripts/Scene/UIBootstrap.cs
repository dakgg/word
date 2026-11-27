using Dakgg.UI;
using UnityEngine;

public static class UIBootstrap
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
    private static void Initialize()
    {
        if (Object.FindFirstObjectByType<ViewManager>() != null)
        {
            return;
        }

        new GameObject("ViewManager").AddComponent<ViewManager>();
    }
}
