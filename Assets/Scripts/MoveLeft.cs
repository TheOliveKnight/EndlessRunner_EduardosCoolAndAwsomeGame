using UnityEngine;


public class MoveLeft : MonoBehaviour
{
   private float currentSpeedBG;
   private Vector3 startPosBG;
   private float repeatWidthBG;

   private float currentSpeedFG; 
   private Vector3 startPosFG;
   private float repeatWidthFG;
   void Start()
   {
       startPosBG = transform.position;
       repeatWidthBG = GetComponent<BoxCollider>().size.x / 2;

       startPosFG = transform.position;
       repeatWidthFG = GetComponent<BoxCollider>().size.x / 1;
   }


   // Update is called once per frame
   void Update()
   {
       currentSpeedBG = GameManager.Instance.BackgroundSpeed;
       MoveToTheLeftBG();
       DeleteOutOfScene();
       MoveToStart();

       currentSpeedFG = GameManager.Instance.FloorgroundSpeed;
       MoveToTheLeftFG();
       DeleteOutOfScene();
       MoveToStart();
   }


   // Moves the attached GameObject left in the scene
   private void MoveToTheLeftBG()
   {
       if(!GameManager.Instance.gameOver)
       {
           transform.Translate(Vector3.left * Time.deltaTime * currentSpeedBG);
       }
   }
    private void MoveToTheLeftFG()
   {
       if(!GameManager.Instance.gameOver)
       {
           transform.Translate(Vector3.left * Time.deltaTime * currentSpeedFG);
       }
   }

   // Removes any Obstacle tagged game object if it falls below ground level.
   private void DeleteOutOfScene()
   {
       if (gameObject.tag == "Obsticale" && transform.position.x < -11)
       {
           Destroy(gameObject);
       }
   }


   private void MoveToStart()
   {
       if(gameObject.tag == "Background" && transform.position.x < startPosBG.x - repeatWidthBG)
       {
           transform.position = startPosBG;
       }
       if(gameObject.tag == "FloorGround" && transform.position.x < startPosFG.x - repeatWidthFG)
       {
           transform.position = startPosFG;
       }
   }
}
