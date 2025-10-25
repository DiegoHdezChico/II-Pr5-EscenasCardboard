using UnityEngine;

public class MirarJugador : MonoBehaviour
{
    private Transform transformJugador;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transformJugador = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        transform.LookAt(transformJugador);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
