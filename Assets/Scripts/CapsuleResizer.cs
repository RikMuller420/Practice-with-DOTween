using DG.Tweening;
using UnityEngine;

public class CapsuleResizer : MonoBehaviour
{
    [SerializeField] private float _duration = 3f;
    [SerializeField] private float _resizeScale = 1.5f;

    private void Start()
    {
        transform.DOScale(Vector3.one * _resizeScale, _duration)
            .SetLoops(-1, LoopType.Yoyo);
    }
}
