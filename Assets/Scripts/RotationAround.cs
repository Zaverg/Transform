using UnityEngine;

public class RotationAround : MonoBehaviour
{
    [SerializeField] private float _speedRotation;

    private void Update()
    {
        transform.Rotate(Vector3.up * _speedRotation * Time.deltaTime);
    }
}
