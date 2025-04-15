using DG.Tweening;
using UnityEngine;

public class CylinderColorChanger : MonoBehaviour
{
    [SerializeField] private float _duration = 3f;
    [SerializeField] private MeshRenderer _renderer;
    [SerializeField] private Color _changeColor = Color.red;

    private void Start()
    {
        _renderer.material.DOColor(_changeColor, _duration)
            .SetLoops(-1, LoopType.Yoyo);
    }
}
