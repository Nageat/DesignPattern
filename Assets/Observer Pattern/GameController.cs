using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObserverPattern
{
public class GameController : MonoBehaviour
{
    public GameObject sphereObj;
    public GameObject boxObj;
    Subject subject = new Subject();

    void Start()
    {
        Box box1 = new Box(box1Obj, new JumpLittle());
        subject.AddObserver(box1);
    }

    // Update is called once per frame
    void Update()
    {
        if ((sphereObj.transform.position).magnitude < 0.5f)
        {
            subject.Notify();
        }        
    }
}
}
