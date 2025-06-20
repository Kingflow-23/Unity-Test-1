using UnityEngine;

public class ChangePlaneColor : MonoBehaviour
{
    private Renderer planeRenderer;

    void Start()
    {
        // Assign the Renderer component to the class variable
        planeRenderer = GetComponent<Renderer>();
    }

    public void ChangeColor()
    {
        // Ensure the object has a Renderer before changing the color
        if (planeRenderer != null)
        {
            planeRenderer.material.color = new Color(Random.value, Random.value, Random.value);
        }
    }
}
