using UnityEngine;

public class DebugColorTime : MonoBehaviour
{
    private void Update()
    {
        var color = ColorTime.GetColor(Time.time);
        var rgb = ColorUtility.ToHtmlStringRGB(color);
        Debug.Log($"<color=#{rgb}>#{rgb}</color>");
    }
}
