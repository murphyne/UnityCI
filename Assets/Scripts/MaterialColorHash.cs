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
        var color = ColorHash.ComputeHashColor(Time.time);
        _renderer.material.SetColor(_colorProperty, color);
    }
}
