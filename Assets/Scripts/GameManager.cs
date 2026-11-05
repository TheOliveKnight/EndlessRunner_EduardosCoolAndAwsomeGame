using UnityEngine;


public class GameManager : MonoBehaviour
{
   public static GameManager Instance { get; private set; }
   public float BackgroundSpeed = 1f;
   public float FloorgroundSpeed = 2f;
   public bool gameOver;
   public bool startGame {get; set;}
   
   //BackgroundSpeed;

   void Awake()
   {
       if(Instance == null)
       {
           Instance = this;
       }
       else
       {
           Destroy(gameObject);
       }
   }
}
