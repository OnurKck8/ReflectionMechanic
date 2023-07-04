using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootLeaser : MonoBehaviour
{
    public Material material;
    LeaserBall leaserBall;
    public Color myColor;

    void Start()
    {
        myColor = Color.green;
    }

    void Update()
    {
        Destroy(GameObject.Find("Laser Beam"));
        leaserBall = new LeaserBall(gameObject.transform.position, gameObject.transform.right, material,myColor);
    }
}
