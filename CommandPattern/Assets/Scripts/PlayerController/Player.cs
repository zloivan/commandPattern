using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.CommandManager;
using Assets.Scripts.PlayerController;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private float Step=1f;

    private CommandManager _commandManager;
	// Use this for initialization
	void Start ()
	{
	    
	    this._commandManager = Camera.main.GetComponent<InitScript>().CommandManager;
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown(KeyCode.UpArrow)) _commandManager.SetCommand(new MoveUp(this));
	    if (Input.GetKeyDown(KeyCode.DownArrow)) _commandManager.SetCommand(new MoveDown(this));
	    if (Input.GetKeyDown(KeyCode.LeftArrow)) _commandManager.SetCommand(new MoveLeft(this));
	    if (Input.GetKeyDown(KeyCode.RightArrow)) _commandManager.SetCommand(new MoveRight(this));
	}

    public void MoveUp()
    {
        transform.position = new Vector3(transform.position.x+Step,transform.position.y,transform.position.z);
    }

    public void MoveDown()
    {
        transform.position = new Vector3(transform.position.x - Step,transform.position.y,transform.position.z);
    }

    public void MoveRight()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y,transform.position.z - Step);
    }

    public void MoveLeft()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y,transform.position.z + Step);
    }

}
