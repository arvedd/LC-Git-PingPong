using Mono.Cecil.Cil;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerControl : MonoBehaviour
{
    public InputAction movementControl;
    public float speed = 10.0f;
    private Rigidbody2D rb2d;

    Vector2 moveDirection = Vector2.zero;

    void OnEnable()
    {
        movementControl.Enable();
    }

    void OnDisable()
    {
        movementControl.Disable();
    }

    void Start() {
        
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update() {

        moveDirection = movementControl.ReadValue<Vector2>();
    }

    void FixedUpdate()
    {
        rb2d.linearVelocity = new Vector2(moveDirection.x * speed, moveDirection.y * speed);
    }
}
