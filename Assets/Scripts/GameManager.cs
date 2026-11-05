using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float speed;
    public bool startGame { get; set; }
    public bool gameOver { get; set; }
    public static GameManager Instance { get; private set; }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
}
