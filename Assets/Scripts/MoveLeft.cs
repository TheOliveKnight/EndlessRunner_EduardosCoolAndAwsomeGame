using UnityEngine;


public class MoveLeft : MonoBehaviour
{
   [SerializeField] private float currentSpeed;
   private Vector3 startPos;
   [SerializeField] private float repeatWidth;

   void Start()
   {
       startPos = transform.position;
   }


   // Update is called once per frame
   void Update()
   {
       MoveToTheLeft();
       DeleteOutOfScene();
       MoveToStart();
   }


   // Moves the attached GameObject left in the scene
   private void MoveToTheLeft()
   {
       if(!GameManager.Instance.gameOver)
       {
           transform.Translate(Vector3.left * Time.deltaTime * currentSpeed);
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
        if(gameObject.tag != "Obsticale")
        {
       if(gameObject.tag == "Background" && transform.position.x < repeatWidth)
       {
           transform.position = startPos;
       }
        }

       }
   }
