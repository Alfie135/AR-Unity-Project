using UnityEngine;

public class SetSelectedState : MonoBehaviour
{
public Material SelectedMaterial;
private Material originalMaterial;
    void Start()
    {
        originalMaterial = gameObject.GetComponent<MeshRenderer>().material;  
    }
    public void SetSelected()
    {
        gameObject.GetComponent<MeshRenderer>().material = SelectedMaterial;
    }
    public void SetUnSelected()
    {
        gameObject.GetComponent<MeshRenderer>().material = originalMaterial;
    }
}
