﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ObjectHitMainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    RaycastHit hit;
    Ray ray;

    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            //Debug.Log(" you clicked on " + hit.collider.gameObject.name);

            if (hit.collider.gameObject.name == "Zombie_01")
            {
                SceneManager.LoadScene(1);
            }
            if (hit.collider.gameObject.name == "Donald_Trump")
            {
                SceneManager.LoadScene(2);
            }
        }
    }
}
