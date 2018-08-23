using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameplayManager : MonoBehaviour {

    public static GameplayManager GM;
    
    private SFXManager sfxMan;

    private RoundStars roundStars1;
    private RoundStars roundStars2;

    public GameObject pot1;
    public GameObject pot2;

    public Sprite dirty00;
    public Sprite dirty01;
    public Sprite dirty02;
    public Sprite dirty03;
    public Sprite dirty04;
    public Sprite dirty05;
    public Sprite dirty06;
    public Sprite otherDirty00;
    public Sprite otherDirty01;
    public Sprite otherDirty02;
    public Sprite otherDirty03;
    public Sprite otherDirty04;
    public Sprite otherDirty05;
    public Sprite otherDirty06;

    public Meatball meatball;

    public Goal leftGoal; // ADD
    public Goal rightGoal; // ADD

    public Text p1ScoreText; // ADD
    public Text p2ScoreText; // ADD
    private string p1ScoreString;
    private string p2ScoreString;

    private int p1Score;
    private int p2Score;

    public ServeTimer serveTimer; // ADD

    public int scoreCap;
    public int p1RoundScore;
    public int p2RoundScore;
    public string p1RoundPoints;
    public string p2RoundPoints;
    public Text p1RoundText; // ADD
    public Text p2RoundText; // ADD
    public int roundCap;

    public GameObject blueBG;
    public GameObject redBG;
    public GameObject victoryRed;
    public GameObject defeatRed;
    public GameObject victoryBlue;
    public GameObject defeatBlue;
    public GameObject endgameBG;

    public bool gameOn;

    public float[] serveHorizontal = new float[2] { -10, 10 };
    public float whichDirection;
    public int serveTo;

    public KeyCode p1Left { get; set; }
    public KeyCode p1Right { get; set; }
    public KeyCode p1SwingL { get; set; }
    public KeyCode p1SwingR { get; set; }
    public KeyCode p2Left { get; set; }
    public KeyCode p2Right { get; set; }
    public KeyCode p2SwingL { get; set; }
    public KeyCode p2SwingR { get; set; }

    private void Awake()
    {
        if (GM == null)
        {
            DontDestroyOnLoad(gameObject);
            GM = this;
        }
        else if (GM != this)
        {
            Destroy(gameObject);
        }

        p1Left = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("p1LeftKey", "A"));
        p1Right = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("p1RightKey", "D"));
        p1SwingL = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("p1SwingLKey", "V"));
        p1SwingR = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("p1SwingRKey", "B"));
        p2Left = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("p2LeftKey", "LeftArrow"));
        p2Right = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("p2RightKey", "RightArrow"));
        p2SwingL = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("p2SwingLKey", "Comma"));
        p2SwingR = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("p2SwingRKey", "Period"));
    }

    // Use this for initialization
    void Start () {
        int startDirection;
        gameOn = true;
        Instantiate(meatball);
        sfxMan = FindObjectOfType<SFXManager>();
        roundStars1 = GameObject.Find("P1StarCount").GetComponent<RoundStars>();
        roundStars2 = GameObject.Find("P2StarCount").GetComponent<RoundStars>();
        startDirection = Random.Range(0, 2);
        whichDirection = serveHorizontal[startDirection];
        if (startDirection == 0)
        {
            serveTo = 1;
        }
        else if (startDirection <= 1)
        {
            serveTo = 2;
        }
        pot1 = GameObject.Find("Pot 1");
        pot2 = GameObject.Find("Pot 2");
        leftGoal = GameObject.Find("Goal Left").GetComponent<Goal>();
        rightGoal = GameObject.Find("Goal Right").GetComponent<Goal>();
        serveTimer = GameObject.Find("Text").GetComponent<ServeTimer>();

        endgameBG = GameObject.Find("Win/Loss");
        blueBG = GameObject.Find("Background Blue");
        redBG = GameObject.Find("Background Red");
        victoryRed = GameObject.Find("Victory Red");
        defeatRed = GameObject.Find("Defeat Red");
        victoryBlue = GameObject.Find("Victory Blue");
        defeatBlue = GameObject.Find("Defeat Blue");

        endgameBG.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        if (gameOn)
        {
            p1Score = rightGoal.score;
            p2Score = leftGoal.score;

            p1ScoreString = p1Score.ToString();
            p2ScoreString = p2Score.ToString();

            //p1ScoreText.text = p1ScoreString;
            //p2ScoreText.text = p2ScoreString;

            if (p1RoundScore == roundCap || p2RoundScore == roundCap)
            {
                EndGame();
                gameOn = false;
            }
        }
    }

    public void InstTimer()
    {
        if (gameOn)
        {
            serveTimer.StartCountdown();
        }
    }

    public void CheckScore()
    {
        if (p1Score >= scoreCap || p2Score >= scoreCap)
        {
            sfxMan.roundVictory.Play();
            if (p1Score > p2Score)
            {
                p1RoundScore += 1;
            }
            else if (p1Score < p2Score)
            {
                p2RoundScore += 1;
            }
            roundStars1.Invoke("UpdateStars", 0f);
            roundStars2.Invoke("UpdateStars", 0f);
            Invoke("RoundRestart", 2f);
        }
        if (p2Score == 1)
        {
            pot1.GetComponent<SpriteRenderer>().sprite = dirty01;
        }
        if (p2Score == 2)
        {
            pot1.GetComponent<SpriteRenderer>().sprite = dirty02;
        }
        if (p2Score == 3)
        {
            pot1.GetComponent<SpriteRenderer>().sprite = dirty03;
        }
        if (p2Score == 4)
        {
            pot1.GetComponent<SpriteRenderer>().sprite = dirty04;
        }
        if (p2Score == 5)
        {
            pot1.GetComponent<SpriteRenderer>().sprite = dirty05;
        }
        if (p2Score == 6)
        {
            pot1.GetComponent<SpriteRenderer>().sprite = dirty06;
        }
        if (p1Score == 1)
        {
            pot2.GetComponent<SpriteRenderer>().sprite = otherDirty01;
        }
        if (p1Score == 2)
        {
            pot2.GetComponent<SpriteRenderer>().sprite = otherDirty02;
        }
        if (p1Score == 3)
        {
            pot2.GetComponent<SpriteRenderer>().sprite = otherDirty03;
        }
        if (p1Score == 4)
        {
            pot2.GetComponent<SpriteRenderer>().sprite = otherDirty04;
        }
        if (p1Score == 5)
        {
            pot2.GetComponent<SpriteRenderer>().sprite = otherDirty05;
        }
        if (p1Score == 6)
        {
            pot2.GetComponent<SpriteRenderer>().sprite = otherDirty06;
        }
    }

    public void RoundRestart()
    {
<<<<<<< HEAD
=======
        if (p1Score > p2Score)
        {
            p1RoundScore += 1;
            p1RoundPoints = p1RoundScore.ToString();
            p1RoundText.text = p1RoundPoints;
        }
        else if (p1Score < p2Score)
        {
            p2RoundScore += 1;
            p2RoundPoints = p2RoundScore.ToString();
            p2RoundText.text = p2RoundPoints;
        }
>>>>>>> mattTest
        rightGoal.score = 0;
        leftGoal.score = 0;
        pot1.GetComponent<SpriteRenderer>().sprite = dirty00;
        pot2.GetComponent<SpriteRenderer>().sprite = otherDirty00;
    }

    public void EndGame()
    {
        endgameBG.SetActive(true);
        if (p1RoundScore > p2RoundScore)
        {
            blueBG.SetActive(false);
            redBG.SetActive(true);
            victoryBlue.SetActive(false);
            victoryRed.SetActive(true);
            defeatBlue.SetActive(false);
            defeatRed.SetActive(true);
        }
        if (p2RoundScore > p1RoundScore)
        {
            blueBG.SetActive(true);
            redBG.SetActive(false);
            victoryBlue.SetActive(true);
            victoryRed.SetActive(false);
            defeatBlue.SetActive(true);
            defeatRed.SetActive(false);
        }
    }
}
