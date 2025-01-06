using UnityEngine;

public class SizeChanger : MonoBehaviour
{
    [SerializeField] private float _speedGrowing;

    private void Update()
    {
        transform.localScale += new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z) * _speedGrowing * Time.deltaTime;
    }   
}
