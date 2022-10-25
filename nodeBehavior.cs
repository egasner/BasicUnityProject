using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Author: Ethan Gasner
public class nodeBehavior : MonoBehaviour
{
    public GameManager manager;
    public GameObject x;
    public GameObject circle;
    public GameObject Spawnpoint;
    bool hasShape;
    public int gridNumber;
    GameObject instance;
    int numberOfGamesPlayed;

    // Start is called before the first frame update
    void Start()
    {
        numberOfGamesPlayed = 0;
        hasShape = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(numberOfGamesPlayed < manager.getNumGamesPlayed()){
            hasShape = false;
            numberOfGamesPlayed++;
        }
    }

    //Spawns ticTacToe piece based on current play, 
    //switches player, 
    //and Marks a flag that prevents another piece from being spawned on the Node
    void OnMouseDown(){
        if(manager.currentPlayer == 1 && hasShape == false && manager.doneFlag == false){
            instance = Instantiate(x, Spawnpoint.transform);
            manager.currentPlayer++;
            hasShape = true;;
            manager.gameGrid[gridNumber-1] = instance;
        }else if(manager.currentPlayer == 2 && hasShape == false && manager.doneFlag == false)
        {
            instance = Instantiate(circle, Spawnpoint.transform);
            manager.currentPlayer--;
            hasShape = true;;
            manager.gameGrid[gridNumber-1] = instance;
        }
        
    }
}
