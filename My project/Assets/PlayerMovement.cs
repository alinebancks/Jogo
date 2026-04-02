using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
   
    public float speed = 5f; //velocidad

    public float jumpForce = 5f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    //movimentãção básica
    void Update()
    {
        if (Keyboard.current.wKey.isPressed)
            transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (Keyboard.current.sKey.isPressed)
            transform.Translate(Vector3.back * speed * Time.deltaTime);

        if (Keyboard.current.aKey.isPressed)
            transform.Translate(Vector3.left * speed * Time.deltaTime);

        if (Keyboard.current.dKey.isPressed)
            transform.Translate(Vector3.right * speed * Time.deltaTime);

        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}