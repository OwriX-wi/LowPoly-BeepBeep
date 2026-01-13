using Unity.VisualScripting;
using UnityEngine;

public class CarsBeep : MonoBehaviour
{
    [SerializeField] float OwnSpeed = 25f;

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * OwnSpeed);
    }
}