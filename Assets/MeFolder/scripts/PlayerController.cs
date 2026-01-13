using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 15f;
    [SerializeField] float turnSpeed = 200f;
    float horizontalInput;
    float verticalInput;

    void FixedUpdate()
    {
      
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);


    }
}




























/* ימממ
* לולולו
* 11037
* 33550336
* XD
*/
