using UnityEngine;

public class AtraeRecolectables : MonoBehaviour
{
    public delegate void mensaje();
    public event mensaje AlertaPuntero;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnPointerEnter()
    {
        AlertaPuntero();
    }
    public void OnPointerExit()
    {
        
    }
}
