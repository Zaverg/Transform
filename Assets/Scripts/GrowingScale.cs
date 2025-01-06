using UnityEngine;

public class GrowingScale : MonoBehaviour
{
    [SerializeField] private float _speedGrowing;
    [SerializeField] private Vector3 _targetScale;
    private Vector3 _startScale;

    private void Start()
    {
        _startScale = transform.localScale;
    }

    private void Update()
    {
        transform.localScale += new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z) * _speedGrowing * Time.deltaTime;

        if (transform.localScale.x >= _targetScale.x)
            _speedGrowing = -1;
        else if (transform.localScale.x <= _startScale.x)
            _speedGrowing = 1;
    }   
}
