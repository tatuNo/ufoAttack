﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitching : MonoBehaviour
{
    public int selectedWeapon = 0;
    public WeaponDrop isDropped;

    void Start()
    {
        selectWeapon();
    }

    
    void Update()
    {
        int previousSelectedWeapon = selectedWeapon;

        //if(Input.GetAxis("Mouse ScrollWheel") > 0f)
        //{
        //    if (selectedWeapon >= transform.childCount - 1)
        //        selectedWeapon = 0;
        //    else
        //        selectedWeapon++;
        //}
        //if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        //{
        //    if (selectedWeapon <= 0)
        //        selectedWeapon = transform.childCount - 1;
        //    else
        //        selectedWeapon--;
        //}
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            selectedWeapon = 0;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if(isDropped.m16Drop)
            selectedWeapon = 1;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            if(isDropped.akDrop)
            selectedWeapon = 2;
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            if(isDropped.bazookDropped)
            selectedWeapon = 3;
        }

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            if(isDropped.juustoDropped)
            selectedWeapon = 4;
        }

        if (previousSelectedWeapon != selectedWeapon)
        {
            selectWeapon();
        }
    }

    public void selectWeapon ()
    {
        int i = 0;
        foreach (Transform weapon in transform)
        {
            if (i == selectedWeapon)
                weapon.gameObject.SetActive(true);
            else
                weapon.gameObject.SetActive(false);
            i++;
        }
    }
}
