using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Subject : MonoBehaviour
{
	public Transform _tr;
	public CubeActor _cube;
	delegate void MoveHandler();

	MoveHandler _moveHandler;
	void Start()
	{
		_tr = gameObject.transform;

		_cube = new CubeActor();
		_moveHandler += new MoveHandler(_cube.OnNotify);

		StartCoroutine(UpdateGoingUp());
	}

	IEnumerator UpdateGoingUp()
	{
		while(true)
		{
			_tr.position = new Vector3(_tr.position.x, _tr.position.y+0.05f, _tr.position.z);

			if(_tr.position.y > 3f)
			{
				_moveHandler();// tant que le cube en Y n'a pas une position en Y en 3 on le bouge
				yield break;
			}
			yield return null;
		}
	}
}
