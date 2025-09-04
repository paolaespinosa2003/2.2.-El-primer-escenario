using UnityEngine;
using UnityEngine.UI;

public class Botones : MonoBehaviour
{
    public Button boton1;
    public Button boton2;
    public Button boton3;

    void Start()
    {
        boton1.onClick.AddListener(() => Debug.Log("Botón 1 presionado"));
        boton2.onClick.AddListener(() => Debug.Log("Botón 2 presionado"));
        boton3.onClick.AddListener(() => Debug.Log("Botón 3 presionado"));
    }
}
