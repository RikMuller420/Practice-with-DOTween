using DG.Tweening;
using UnityEngine;

public class CubeRotator : MonoBehaviour
{
    [SerializeField] private Vector3 _rotateAngle = new Vector3(0, 90, 180);
    [SerializeField] private float _duration = 3f;

    private void Start()
    {
        Quaternion rotation = Quaternion.Euler(_rotateAngle);

        transform.DORotateQuaternion(rotation, _duration)
            .SetLoops(-1, LoopType.Yoyo);
    }
}
