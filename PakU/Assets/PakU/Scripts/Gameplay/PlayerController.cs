using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Caracteristicas e Variaveis
    float velocidade = 55.5f;
    float ForcaPulo = 25.5f;

    // Funcoes
    void Mover()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * velocidade * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * velocidade * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * velocidade * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * velocidade * Time.deltaTime);
        }
    }
    // End

    private void Start()
    {
       
    }

    private void Update()
    {
        Mover();
    }
}
