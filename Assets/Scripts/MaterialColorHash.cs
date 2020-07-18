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
        var rgba = ColorHash.ComputeHashFromString(str);
        var r = (rgba >> 24 & 0xFF) / 256f;
        var g = (rgba >> 16 & 0xFF) / 256f;
        var b = (rgba >>  8 & 0xFF) / 256f;
        var hashColor = new Color(r, g, b);
        _renderer.material.SetColor(_colorProperty, hashColor);
    }
}
