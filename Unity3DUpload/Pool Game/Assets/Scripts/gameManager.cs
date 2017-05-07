using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour {
    
    private GameObject[] getbCount;
    private GameObject[] getrCount;
    private GameObject[] getBlkCount;
    public GameObject bedestroyedatend1;
    public GameObject bedestroyedatend2;
    public static int turns;
    public string currentPlayer;
    public string lastPlayer;
    public Text ballcount;
    public Text Player;
    public Text endtext;
    
    public string player1 = "Player 1";
    public string player2 = "Player 2";
    public Color player1colour = Color.blue;
    public Color player2colour = Color.grey;
    public bool teamChosen;
    // Use this for initialization
    void Start () {
        currentPlayer = player1;
    }

    
    // Update is called once per frame
    void Update () {
        teamChosen = false;
        Player.text = "Current Player: " + currentPlayer;
        getbCount = GameObject.FindGameObjectsWithTag("BlueBall");
        int bcount = getbCount.Length;
        getrCount = GameObject.FindGameObjectsWithTag("RedBall");
        int rcount = getrCount.Length;
        


        ballcount.text = "Blueballs left: " + bcount + " Redballs left: " + rcount;


        checkTeams(rcount,bcount);
        endgame(rcount, bcount);
        
        if (Input.GetButtonDown("Fire1"))
        {
            turns--;
            changeTurns();
        }
    }

    
    public void SwitchPlayer()
    {
        lastPlayer = currentPlayer;
        if (currentPlayer == player1)
        {
            
            currentPlayer = player2;
            Player.text = "Current Player: " + currentPlayer;
            Player.color = player2colour;


        }
        else if (currentPlayer == player2)
        {
            
            currentPlayer = player1;
            Player.text = "Current Player: " + currentPlayer;
            Player.color = player1colour;
        }

    }

    public void changeTurns()
    {
        if(turns <=0)
        {
            SwitchPlayer();
            turns++;
        }
        else
        {
            
        }
        
    }
    public void checkTeams(int rCount, int bCount)
    {
        
        if (teamChosen == false)
        {
            if(bCount < rCount && currentPlayer == player1)
            {
                player1colour = Color.blue;
                player2colour = Color.red;
                teamChosen = true;
            }
            else if(bCount > rCount && currentPlayer == player1)
            {
                player2colour = Color.blue;
                player1colour = Color.red;
                teamChosen = true;
            }
            else if (bCount == rCount)
            {
                player2colour = Color.grey;
                player1colour = Color.grey;
                teamChosen = false;
            }
            
        }
    }

    

    void endgame(int rCount, int bCount)
    {
        getBlkCount = GameObject.FindGameObjectsWithTag("BlackBall");
        int blkcount = getBlkCount.Length;
        if (bCount == 0 && blkcount == 0)
        {

            Destroy(bedestroyedatend1);
            Destroy(bedestroyedatend2);
            endtext.text = "Winner is " + lastPlayer;
        }
        else if(rCount == 0 && blkcount == 0)
        {

            Destroy(bedestroyedatend1);
            Destroy(bedestroyedatend2);
            endtext.text = "Winner is " + lastPlayer;
        }
        else if(bCount == 0 && rCount == 0 && blkcount == 0)
        {

            Destroy(bedestroyedatend1);
            Destroy(bedestroyedatend2);
            endtext.text = "Winner is " + lastPlayer + " for potting the black ball!";
        }
        else if(bCount > 0 && blkcount == 0)
        {

            Destroy(bedestroyedatend1);
            Destroy(bedestroyedatend2);
            endtext.text = "Winner is " + currentPlayer + " because " + lastPlayer + " potted the black before potting all their own balls";
        }
        else if(rCount > 0 && blkcount == 0)
        {
            Destroy(bedestroyedatend1);
            Destroy(bedestroyedatend2);
            endtext.text = "Winner is " + currentPlayer + " because " + lastPlayer + " potted the black before potting all their own balls";
        }
    }
}
