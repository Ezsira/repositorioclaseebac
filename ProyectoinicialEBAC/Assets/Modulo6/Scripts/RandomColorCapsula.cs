using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColorCapsula : MonoBehaviour
{
    public GameObject PrefabCapsula;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        GameObject tempGameObject = Instantiate<GameObject>(PrefabCapsula);
        Color c = new Color(Random.value, Random.value, Random.value);
        tempGameObject.GetComponent<MeshRenderer>().material.color = c;
    }
}
