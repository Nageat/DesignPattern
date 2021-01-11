using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum WeaponType{
    Missile,
    Bullet
}
public class ShipController : MonoBehaviour
{
    public string current;

    public WeaponType weaponType; 
    
    
    private IWeapon iWeapon;
    
    private void HandleWeaponType(){
     
        Component c = gameObject.GetComponent<IWeapon>() as Component;
        if(c!=null){
            Destroy(c);
        }
        
        switch(weaponType){
        
            case WeaponType.Missile:
                iWeapon = gameObject.AddComponent<Missile> ();
                current = "Missile";
                break;
                
            case WeaponType.Bullet:
                iWeapon = gameObject.AddComponent<Bullet> ();
                current = "Bullet";
                break;
                
            default:
                iWeapon = gameObject.AddComponent<Bullet> ();
                break;
        }
        
    }
      public void Fire(){    
        iWeapon.Shoot();
        Debug.Log("Fire !");
    }
        void Update () {
    
        if (Input.GetKeyDown("space")){
            Fire();
        }
        
        if(Input.GetKeyDown("a")){
            HandleWeaponType();
            Debug.Log("Votre arme est :"+current );        
        }    
        
    }

}

