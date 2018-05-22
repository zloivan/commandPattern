using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;


class CommandInvoker : MonoBehaviour
{
    public Button UndoButton;
    public Button RedoButton;

    private void Start()
    {
        UndoButton.interactable = false;
        RedoButton.interactable = false;
    }

    private void Update()
    {
        if (GetComponent<InitScript>().CommandManager.ExecuteCommand())
        {
            UndoButton.interactable = true;
            RedoButton.interactable = false;
        }
        GetComponent<InitScript>().CommandManager.ExecuteCommand();
    }

    public void OnUndoBtn()
    {
        UndoButton.interactable = GetComponent<InitScript>().CommandManager.UndoCommand();
        RedoButton.interactable = true;
       
    }
    public void OnRedoBtn()
    {
       RedoButton.interactable= GetComponent<InitScript>().CommandManager.RedoCommand();
        UndoButton.interactable = true;
    }

}

