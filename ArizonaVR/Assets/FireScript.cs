using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.Events;

public class FireScript : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawnPoint;
    public float bulletSpeed = 20;

    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
        grabbable.activated.AddListener(FireBullet);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void FireBullet(ActivateEventArgs arg)
    {
        Instantiate(bullet, spawnPoint.position, Quaternion.identity);
        bullet.GetComponent<Rigidbody>().velocity = new Vector3(bulletSpeed, bulletSpeed, bulletSpeed);
        Destroy(bullet, 3);
    }
}
