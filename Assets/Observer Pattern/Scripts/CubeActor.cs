using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CubeActor
{
	GameObject _cube;

	public void OnNotify()
	{
		_cube = GameObject.Find("Cube") as GameObject;//Find l'objet cube quand il est "notifié" 
		DoMove();
	}

	void DoMove()
	{
		_cube.transform.position = new Vector3(3f, 3f, 3f);//Le déplacer
	}
}
