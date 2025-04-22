using UnityEngine;


public class Image : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    { 
        Destroy(this.gameObject, 2f);
        GameManager.Instance.CarregarCena("MainMenu");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
