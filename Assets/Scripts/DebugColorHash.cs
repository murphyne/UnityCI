using UnityEngine;

public class DebugColorHash : MonoBehaviour
{
    [SerializeField] private string message = "Hello World";

    private void Update()
    {
        var str = message + Time.time;
        var rgba = ColorHash.ComputeHashFromString(str);
        var rgb = rgba >> 8 & 0xffffff;
        Debug.Log($"<color=#{rgb:x6}>{message}</color>");
    }
}
