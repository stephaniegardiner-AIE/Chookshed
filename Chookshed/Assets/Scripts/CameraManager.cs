using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Camera mainCamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            RaycastHit hitScrap;
            RaycastHit hitDust;
            RaycastHit hitPerch;
            RaycastHit hitNest;
            RaycastHit hitFeeder;
                
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);

            int scrapLayer = LayerMask.GetMask("ScrapBowl");
            int dustLayer = LayerMask.GetMask("DustTire");
            int perchLayer = LayerMask.GetMask("Perch");
            int nestLayer = LayerMask.GetMask("NestingBox");
            int feederLayer = LayerMask.GetMask("Feeder");

            if (Physics.Raycast(ray, out hitScrap, 20, scrapLayer))
            {
                Debug.Log("ScrapBowlHit!");
            }
            if (Physics.Raycast(ray, out hitDust, 20, dustLayer))
            {
                Debug.Log("DustTireHit!");
            }
            if (Physics.Raycast(ray, out hitPerch, 20, perchLayer))
            {
                Debug.Log("PerchHit!");
            }
            if (Physics.Raycast(ray, out hitNest, 20, nestLayer))
            {
                Debug.Log("NestHit!");
            }
            if (Physics.Raycast(ray, out hitFeeder, 20, feederLayer))
            {
                Debug.Log("FeederHit!");
            }

        }
    }
}
