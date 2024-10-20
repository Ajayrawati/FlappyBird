using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paralex : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    public float animationSpeed = 1f;  // Fixed variable name for clarity

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        // Check if the material has a texture assigned
        if (meshRenderer.material && meshRenderer.material.mainTexture)
        {
            // Apply parallax effect by updating the texture offset
            meshRenderer.material.mainTextureOffset += new Vector2(animationSpeed * Time.deltaTime, 0);
        }
    }
}
