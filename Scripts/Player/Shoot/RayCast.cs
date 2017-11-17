using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour {

    public static bool shooting;

    public static string letDie;

    public static int enemyHP = 14;

    GameObject enemyFind;

    // Use this for initialization
    void Start() {

    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Shoot();
        }
    }

    // Update is called once per frame
    public void Shoot() {

        Debug.Log("shooting");

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Ammo.reload == false && Physics.Raycast(ray, out hit, 10000) && hit.collider.tag == "enemy")
        {
            enemyFind = hit.transform.gameObject;
            StartCoroutine(DoQuery(enemyFind));
            enemyHP -= 1;
            if(enemyHP <= 0)
            {
                Destroy(hit.transform.gameObject);
            }
        }
    }

    IEnumerator DoQuery(GameObject ef)
    {
        Debug.Log(ef.transform.position.x);
        WWW request = new WWW("http://21941.hosts.ma-cloud.nl/bewijzenmap/2e_jaar/GPR/FPS/index.php?t_x=" + ef.transform.position.x + "&t_y=" + ef.transform.position.y + "&t_z=" + ef.transform.position.z + "&p_id=17");
        //WWW request = new WWW("http://21941.hosts.ma-cloud.nl/bewijzenmap/2e_jaar/GPR/FPS/index.php?target_x=1&target_y=2&target_z=3&player_id=17");
        yield return request;
    }
}
