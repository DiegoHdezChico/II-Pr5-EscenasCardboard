using UnityEngine;
using UnityEngine.Rendering;

public class DesplazaObjeto : MonoBehaviour
{
    public AtraeRecolectables notificador;
    private GameObject objetivo;

    private bool noticacionRecibida;
    private float velocidad;

    private void Desplazar()
    {
        noticacionRecibida = true;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        objetivo = GameObject.FindGameObjectWithTag("Recolector");
        notificador.AlertaPuntero += Desplazar;
        velocidad = 10;
        noticacionRecibida = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (noticacionRecibida)
        {
            Vector3 distancia = (objetivo.transform.position - transform.position).normalized;
            transform.Translate(distancia * Time.deltaTime * velocidad, Space.World);
        }
    }
}
