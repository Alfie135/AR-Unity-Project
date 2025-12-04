using UnityEngine;

public class SetSelectedScript : MonoBehaviour
{

    public Material SelectedMaterial;
    private Material originalMaterial;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Get a reference to the original prefab material.
        originalMaterial = gameObject.GetComponent<MeshRenderer>().material;
    }
    public void SetSelected(){
        gameObject.GetComponent<MeshRenderer>().material = SelectedMaterial;
    }

    public void SetUnselected(){
        gameObject.GetComponent<MeshRenderer>().material = originalMaterial;
    }
}
