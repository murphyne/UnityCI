using UnityEngine;

public class MaterialColorHash : MonoBehaviour
{
    private readonly int _colorProperty = Shader.PropertyToID("_Color");
    private Renderer _renderer;

    private void Start()
    {
        _renderer = GetComponent<Renderer>();
    }

    private void Update()
    {
        var str = $"{Time.time}";
        var color = ColorHash.ComputeHashColor(str);
        _renderer.material.SetColor(_colorProperty, color);
    }
}
