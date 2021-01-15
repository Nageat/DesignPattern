using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    public float _speed = 3.0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            ICommand moveUp = new MoveUpCommand(this.transform, _speed);
            moveUp.Execute();
            CommandManager.Instance.addCommand(moveUp);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            ICommand moveDown = new MoveDownCommand(this.transform, _speed);
            moveDown.Execute();
            CommandManager.Instance.addCommand(moveDown);

        }
    }
}
