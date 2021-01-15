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
    }
    private List<ICommand> _commandDuffer = new List<ICommand>();

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
        StartCoroutine(RewindRoutine());
    }
    IEnumerator RewindRoutine()
    {
        Debug.Log("Retour vers le passé...");
        foreach(var command in Enumerable.Reverse(_commandDuffer))
        {
            command.Undue();
            yield return new WaitForEndOfFrame();       
        }
        Debug.Log("Bienvenu dans le passé !");

    }
}
