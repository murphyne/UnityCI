using UnityEngine;

public class DebugColorTime : MonoBehaviour
{
    private ColorTime _colorProvider;

    private void Start()
    {
        _colorProvider = new ColorTime(4f);
    }

    private void Update()
    {
        var color = _colorProvider.GetColor(Time.time);
        var rgb = ColorUtility.ToHtmlStringRGB(color);
        Debug.Log($"<color=#{rgb}>#{rgb}</color>");
    }
}
