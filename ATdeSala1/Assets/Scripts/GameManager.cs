using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
   public static GameManager Instance;
   private void Awake(){
       if(Instance == null){
           Instance = this;
       }


       else{
           Destroy(this.gameObject);  
       }
   }


   // Start is called once before the first execution of Update after the MonoBehaviour is created
   void Start()
   {
      CarregarCena("Splash");
   }

   public void CarregarCena(string nomedacena)
   {
       SceneManager.LoadScene(nomedacena);
   }
   
   // Update is called once per frame
   void Update()
   {
           SceneManager.LoadScene("Splash");
       }
   }

