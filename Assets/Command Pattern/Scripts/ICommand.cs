using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICommand
{
    // Creation de l'interface 
    void Execute();
    void Undue();
}
