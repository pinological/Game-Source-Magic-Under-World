using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootmagic : MonoBehaviour
{
    public Camera cam;
    public GameObject magicball;
    public Transform shootPoint;
    public float shootspeed = 50f;
    public float arcRange = 0.5f;

    private Vector3 destination;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            FindObjectOfType<triggerAnimationshoot>().shootAni();
            shootMagicball();
        }
        else
        {
            FindObjectOfType<triggerAnimationshoot>().idelAni();
        }
    }
    void shootMagicball()
    {
        Ray ray = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            destination = hit.point;
        }
        else
        {
            destination = ray.GetPoint(1000);
        }
        InstantiateProjectile(shootPoint);
    }
    void InstantiateProjectile(Transform shootpoint)
    {
        var projectObj = Instantiate(magicball, shootpoint.position, Quaternion.identity) as GameObject;
        projectObj.GetComponent<Rigidbody>().velocity = (destination - shootpoint.position).normalized * shootspeed;

        iTween.PunchPosition(projectObj,new Vector3(Random.Range(arcRange,arcRange), Random.Range(arcRange, arcRange),0),Random.Range(0.5f,2));
    }
}
