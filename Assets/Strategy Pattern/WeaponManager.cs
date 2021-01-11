using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
}

public interface IWeapon{
    void Shoot(); 
}

public class Bullet: MonoBehaviour, IWeapon{
    public void Shoot(){
    
        Vector3 initialPosition = new Vector3 (this.transform.position.x, this.transform.position.y +1f,0);
        GameObject bullet =  Instantiate(Resources.Load("Bullet",typeof(GameObject))) as GameObject;    
        bullet.transform.position = initialPosition;
        bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(0f,3f);
    } 
}

public class Missile: MonoBehaviour, IWeapon{
    public void Shoot(){
        
        Vector3 initialPosition = new Vector3 (this.transform.position.x, this.transform.position.y + 1f,0);
        GameObject missile =  Instantiate(Resources.Load("Missile",typeof(GameObject))) as GameObject;    
        missile.transform.position = initialPosition;
        missile.GetComponent<Rigidbody2D>().velocity = new Vector2(0f,3f);
        
    }
}
