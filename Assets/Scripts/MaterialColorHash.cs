using UnityEngine;

public class MaterialColorHash : MonoBehaviour
{
    [SerializeField] private string message = "Hello World";

    private readonly int _colorProperty = Shader.PropertyToID("_Color");
    private Renderer _renderer;

    private void Start()
    {
        _renderer = GetComponent<Renderer>();
    }

    private void Update()
    {
        var str = message + Time.time;
        var color = ComputeHashColor(str);
        _renderer.material.SetColor(_colorProperty, color);
    }

    private static Color ComputeHashColor(string message)
    {
        var rgba = ColorHash.ComputeHashFromString(message);
        var r = (rgba >> 24 & 0xFF) / 256f;
        var g = (rgba >> 16 & 0xFF) / 256f;
        var b = (rgba >>  8 & 0xFF) / 256f;
        var hashColor = new Color(r, g, b);
        return hashColor;
    }
}
