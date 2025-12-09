using UnityEngine;
using System.Collections;

public class SwitchMaterialTextures : MonoBehaviour
{
    //Array to hold textures to be shown in sequence
    public Texture[] NewTextures;
    //Index of the current texture to show
    private int TextureIndex = 0;
    private IEnumerator coroutine;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Define the coroutine - including time delay
        coroutine = WaitAndSwitchImage(5.0f);
        //Start coroutine
        StartCoroutine(coroutine);
    }
    public void UpdateMaterialTexture(){
        //Get reference to renderer
        Renderer renderer = GetComponent<Renderer>();
        if( renderer != null && NewTextures != null){
            TextureIndex ++;
            if(TextureIndex >= NewTextures.Length){
                TextureIndex = 0;
            }
            renderer.material.mainTexture = NewTextures[TextureIndex];
        }
    }
    // Create a timed function call
    public IEnumerator WaitAndSwitchImage(float waitTime){
        while (true){
            yield return new WaitForSeconds(waitTime);
            UpdateMaterialTexture();
        }
    }
}
