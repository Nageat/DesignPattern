using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class CommandManager : MonoBehaviour
{
    private static CommandManager _instance;
    public static CommandManager Instance
    {
        get{
            if(_instance == null)
                Debug.Log("Command Manager Vide");
            return _instance;
        }
    }//Gestion des instances 
    private List<ICommand> _commandDuffer = new List<ICommand>();//Liste de commandes 

    private void Awake()
    {
        _instance = this;
    }

    public void addCommand(ICommand command)
    {
        _commandDuffer.Add(command);
    }
    public void Rewind()
    {
        StartCoroutine(RewindRoutine());//Coroutine de Rewind 
    }
    IEnumerator RewindRoutine()
    {
        Debug.Log("Retour vers le passé...");
        foreach(var command in Enumerable.Reverse(_commandDuffer))//Lecture de la listes de commandes mais dans le sens contraire
        {
            command.Undue();//appel de Undue
            yield return new WaitForEndOfFrame();       
        }
        Debug.Log("Bienvenu dans le passé !");

    }
}
