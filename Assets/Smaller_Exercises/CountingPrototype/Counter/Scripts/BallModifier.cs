using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallModifier : MonoBehaviour
{
    public MeshRenderer Renderer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Material material = Renderer.material;
        material.color = new Color(
            Random.Range(0f, 1f),
            Random.Range(0f, 1f),
            Random.Range(0f, 1f)
        );
    }
}
