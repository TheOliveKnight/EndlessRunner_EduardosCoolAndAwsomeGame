using UnityEngine;
using UnityEngine.UIElements;


public class UIManager : MonoBehaviour
{
   public static UIManager Instance { get; private set; }
   [SerializeField] private UIDocument uiDocument;
  
   // UI Element Fields
   private Label _scoreLabel;
   private Label _timeLabel;
   private RadioButtonGroup _timerRadio;
   private Button _startButton;


   // UI Fields
   private int score;
   private int timeRemaining = 60;


   // Start is called once before the first execution of Update after the MonoBehaviour is created
   void Start()
   {
      
   }


   void Update()
   {


   }
}