using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    public float _speed = 3.0f;//Vitesse joueur 

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            ICommand moveUp = new MoveUpCommand(this.transform, _speed);
            moveUp.Execute();//Execution de la commande "Moveup" 
            CommandManager.Instance.addCommand(moveUp);//Ajout de la commande a la liste 
        }
        else if (Input.GetKey(KeyCode.S))
        {
            ICommand moveDown = new MoveDownCommand(this.transform, _speed);
            moveDown.Execute();//Execution de la commande "Movedown" 
            CommandManager.Instance.addCommand(moveDown);//Ajout de la commande a la liste 

        }
    }
}
