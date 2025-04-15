using DG.Tweening;
using UnityEngine;

public class CubeTransformChanger : MonoBehaviour
{
    [SerializeField] private float _duration = 3f;
    [SerializeField] private Vector3 _moveOffset = new Vector3(0, 3f, 0);
    [SerializeField] private float _resizeScale = 1.5f;
    [SerializeField] private Vector3 _rotateAngle = new Vector3(0, 90, 180);

    private void Start()
    {
        Quaternion rotation = Quaternion.Euler(_rotateAngle);

        Sequence sequence = DOTween.Sequence();
        sequence
            .Join(transform.DOMove(transform.position + _moveOffset, _duration))
            .Join(transform.DORotateQuaternion(rotation, _duration))
            .Join(transform.DOScale(Vector3.one * _resizeScale, _duration))
            .SetLoops(-1, LoopType.Yoyo);
    }
}
