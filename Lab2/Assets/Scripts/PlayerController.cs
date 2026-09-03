using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(h, 0, v);
        transform.Translate(movement * speed * Time.deltaTime);

        float mouseX = Input.GetAxis("Mouse X");
        transform.Rotate(new Vector3(0,mouseX,0));

    }
}

