﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DreamCar01Track : MonoBehaviour {

    public GameObject theMarker;
    public GameObject mark01;
    public GameObject mark02;
    public GameObject mark03;
    public GameObject mark04;
    public GameObject mark05;
    public GameObject mark06;
    public GameObject mark07;
    public GameObject mark08;
    public GameObject mark09;
    public GameObject mark10;
    public GameObject mark11;
    public GameObject mark12;
    public GameObject mark13;
    public GameObject mark14;
    public GameObject mark15;
    public GameObject mark16;
    public GameObject mark17;
    public GameObject mark18;
    public GameObject mark19;
    public GameObject mark20;
    public GameObject mark21;

    public int markTracker;

    void Update() {

        if (markTracker == 0)
        {
            theMarker.transform.position = mark01.transform.position;
        }

        if (markTracker == 1)
        {
            theMarker.transform.position = mark02.transform.position;
        }

        if (markTracker == 2)
        {
            theMarker.transform.position = mark03.transform.position;
        }

        if (markTracker == 3)
        {
            theMarker.transform.position = mark04.transform.position;
        }

        if (markTracker == 4)
        {
            theMarker.transform.position = mark05.transform.position;
        }

        if (markTracker == 5)
        {
            theMarker.transform.position = mark06.transform.position;
        }

        if (markTracker == 6)
        {
            theMarker.transform.position = mark07.transform.position;
        }

        if (markTracker == 7)
        {
            theMarker.transform.position = mark08.transform.position;
        }

        if (markTracker == 8)
        {
            theMarker.transform.position = mark09.transform.position;
        }

        if (markTracker == 9)
        {
            theMarker.transform.position = mark10.transform.position;
        }

        if (markTracker == 10)
        {
            theMarker.transform.position = mark11.transform.position;
        }

        if (markTracker == 11)
        {
            theMarker.transform.position = mark12.transform.position;
        }

        if (markTracker == 12)
        {
            theMarker.transform.position = mark13.transform.position;
        }

        if (markTracker == 13)
        {
            theMarker.transform.position = mark14.transform.position;
        }

        if (markTracker == 14)
        {
            theMarker.transform.position = mark15.transform.position;
        }

        if (markTracker == 15)
        {
            theMarker.transform.position = mark16.transform.position;
        }

        if (markTracker == 16)
        {
            theMarker.transform.position = mark17.transform.position;
        }

        if (markTracker == 17)
        {
            theMarker.transform.position = mark18.transform.position;
        }

        if (markTracker == 18)
        {
            theMarker.transform.position = mark19.transform.position;
        }

        if (markTracker == 19)
        {
            theMarker.transform.position = mark20.transform.position;
        }

        if (markTracker == 20)
        {
            theMarker.transform.position = mark21.transform.position;
        }
    }

    IEnumerator OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "dreamCar01")
        {
            this.GetComponent<BoxCollider>().enabled = false;
            markTracker += 1;
            if (markTracker == 21)
            {
                markTracker = 0;
            }
            yield return new WaitForSeconds(1);
            this.GetComponent<BoxCollider>().enabled = true;
        }
    }
}

