using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour
{
   [SerializeField] private float jumpForce, gravityModifier;
   [SerializeField] private ParticleSystem explosionParticle, dirtParticle;
   [SerializeField] private AudioClip crashSound;
   private Animator playerAnimator;
   private AudioSource playerAudio;
   private Rigidbody playerRb;
   private bool isOnGround;
   private float animationSpeed;
   [SerializeField] private MeshRenderer playerMesh;

   // Start is called once before the first execution of Update after the MonoBehaviour is created
   void Start()
   {
       playerRb = GetComponent<Rigidbody>();
       playerAnimator = GetComponent<Animator>();
       playerAudio = GetComponent<AudioSource>();
       isOnGround = true;
       Physics.gravity *= gravityModifier;
       animationSpeed = playerAnimator.GetFloat("Speed_f");
       playerAnimator.SetFloat("Speed_f", 0);
   }


   void Update()
   {
       if(GameManager.Instance.gameOver)
       {
           playerAnimator.SetFloat("Speed_f", 0);
           dirtParticle.Stop();
       }


       if (GameManager.Instance.startGame)
       {
           StartGame();
       }
   }


   private void StartGame()
   {
       GameManager.Instance.startGame = false;
       playerAnimator.SetFloat("Speed_f", animationSpeed);
       isOnGround = true;
       dirtParticle.Play();
   }


   public void OnJump(InputAction.CallbackContext ctx)
   {
       if (ctx.performed && isOnGround && !GameManager.Instance.gameOver)
       {
           playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
           isOnGround = false;
           playerAnimator.SetBool("IsGroundedBro", false);
           dirtParticle.Stop();
       }
   }


   private void OnCollisionEnter(Collision collision)
   {
       if (collision.gameObject.name == "Ground" && !GameManager.Instance.gameOver)
       {
           playerAnimator.SetBool("IsGroundedBro", true);
           isOnGround = true;
           dirtParticle.Play();
       }


       if (collision.gameObject.CompareTag("Obsticale"))
       {
           dirtParticle.Stop();
           explosionParticle.Play();
           playerAudio.PlayOneShot(crashSound, 1.0f);
           if (playerMesh != null)
           {
               playerMesh.enabled = false;
           }
           Debug.Log("Did everything else except turning off the object");
           UIManager.Instance.GameOver();
           Debug.Log("Did everything else except turning off the object");
        }
   


   }


   private void OnTriggerEnter(Collider other)
   {
       if(other.gameObject.CompareTag("Scoreable"))
       {
           Debug.Log("Received a Score");
           //UIManager.Instance.UpdateScore(5);
       }
   }
}
