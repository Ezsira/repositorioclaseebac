using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    int x;
    // Start is called before the first frame update
    void Start()
    {
        x = 0;
        print("Algo Paso");
        
        Debug.LogWarning("Algo Salio Medianamente Mal");
        Debug.LogError("Algo Salio Mu Mal");
    }

    // Update is called once per frame
    void Update()
    {
        // x = x + 1;
        // Debug.Log(x);

        Debug.Log("Hola desde Update");
    }
    private void FixedUpdate()
    {
        Debug.LogWarning("Hola desde fixed Update cada 50 frames");
    }
    private void LateUpdate()
    {
        Debug.Log("Hola desde late update"); 
    }

    private void OnEnable()
    {
        Debug.LogWarning("El objeto ha sido habilitado");
    }

    private void OnDisable()
    {
        Debug.LogWarning("el objeto ha sido inhabilitado");
    }
}
