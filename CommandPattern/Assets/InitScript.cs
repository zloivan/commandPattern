using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.CommandManager;
using UnityEngine;

public class InitScript : MonoBehaviour
{

    private CommandManager _commandManager;

    internal CommandManager CommandManager
    {
        get { return _commandManager; }
    }

    // Use this for initialization
	private void Start () 
	{
	    this._commandManager = new CommandManager();	
	}
	
	
}
