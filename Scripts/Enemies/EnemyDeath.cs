using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootClass : MonoBehaviour {

    /*
    
    /// <summary>
    /// The update is not needed.
    /// Create a new class for the input and go to
    /// Edit/Inputsettings/Fire1 and change it to the button you want.
    /// </summary>

    bool red;
    public static GameObject other;

    void Start()
    {    
    }
    public static void Shoot()
    {
        GameObject Dom = GameObject.FindGameObjectWithTag("enemy");
        other = Dom;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Ammo.i <= 5 && GameObject.FindGameObjectWithTag("enemy"))
        {
            Destroy(other);
        }   
    }
    */
} 

/*void Update()
{
    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    RaycastHit hit;
    if (Input.GetMouseButton(0) && Ammo.reload == false)
    {
        if (Physics.Raycast(ray, out hit, 100) && Ammo.i <= 5 && GameObject.FindGameObjectWithTag("enemy"))
        {
            Debug.Log("1");
            Destroy(other);
        }

    }
}*/
