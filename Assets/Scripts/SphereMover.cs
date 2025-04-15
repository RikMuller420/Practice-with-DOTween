using DG.Tweening;
using UnityEngine;

public class SphereMover : MonoBehaviour
{
    [SerializeField] private Vector3 _moveOffset = new Vector3(0, 3f, 0);
    [SerializeField] private float _duration = 3f;

    private void Start()
    {
        transform.DOMove(transform.position + _moveOffset, _duration)
            .SetLoops(-1, LoopType.Yoyo);
    }
}
