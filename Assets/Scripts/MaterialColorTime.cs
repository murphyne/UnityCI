using UnityEngine;

public class MaterialColorTime : MonoBehaviour
{
    private readonly int _colorProperty = Shader.PropertyToID("_Color");

    private Renderer _renderer;
    private ColorTime _colorProvider;

    private void Start()
    {
        _renderer = GetComponent<Renderer>();
        _colorProvider = new ColorTime(4f);
    }

    private void Update()
    {
        var color = _colorProvider.GetColor(Time.time);
        _renderer.material.SetColor(_colorProperty, color);
    }
}
