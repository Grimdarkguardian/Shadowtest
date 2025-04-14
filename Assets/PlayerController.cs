using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // Stats
    public int health;
    public float speed;
    public Vector2 direc;

    // Input
    public InputSystem_Actions actions;
    public InputAction move;

    // Components
    Rigidbody2D rb;

    void Awake()
    {
        actions = new InputSystem_Actions();
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        move = actions.Player.Move;
        move.Enable();
        move.performed += i => direc = move.ReadValue<Vector2>();
        move.canceled += i => direc = Vector2.zero;
    }

    private void OnDisable()
    {
        move.Disable();
    }

    void FixedUpdate()
    {
        rb.linearVelocity = direc * speed;
    }
}
