using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class ControladorJugador : MonoBehaviour
{
    private Rigidbody rb;
    private float velocidad = 2f;
    private Control control;
    public Transform transformCamara;

    void Awake()
    {
        control = new Control();
    }

    void OnEnable()
    {
        control.Enable();
    }

    void OnDisable()
    {
        control.Disable();        
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 movimiento2D = control.Jugador.Mover.ReadValue<Vector2>();
        Vector3 verticalCamara = transformCamara.forward;
        verticalCamara.y = 0;
        Vector3 horizontalCamara = transformCamara.right;
        horizontalCamara.y = 0;
        Vector3 movimiento3D = horizontalCamara.normalized * movimiento2D.x + verticalCamara.normalized * movimiento2D.y;
        rb.MovePosition(rb.position + movimiento3D * Time.fixedDeltaTime * velocidad);
    }
}
