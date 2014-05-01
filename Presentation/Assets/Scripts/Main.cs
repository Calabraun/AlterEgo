using UnityEngine;
using System.Collections;
using GameEngine;

public class Main : MonoBehaviour {

	// Use this for initialization
	void Start () {

        StateController stateController = new StateController();
        stateController.InitializeGameState();

        Debug.Log("The game state is: " + stateController.GetGameState().ToString());

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
