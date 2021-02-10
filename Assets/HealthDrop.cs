using Platformer.Mechanics;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthDrop : MonoBehaviour
{
	public PlayerController playercontroller;
	private Boolean isDropped = false;
	private int healthIncrease = 5;
	public HealthBar healthbar;

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.CompareTag("Player"))
		{
			gameObject.SetActive(false);
			isDropped = false;
			if(healthIncrease + playercontroller.currHP > playercontroller.startHP)
			{
				playercontroller.currHP = playercontroller.startHP;
				healthbar.SetHealth(playercontroller.currHP);
			} else
			{
				playercontroller.currHP += healthIncrease;
				healthbar.SetHealth(playercontroller.currHP);
			}
		}
	}

	public void dropHealth()
	{
		if (isDropped == false)
		{
			gameObject.transform.position = GameObject.Find("Enemy").transform.position;
			gameObject.transform.rotation = GameObject.Find("Enemy").transform.rotation;
			gameObject.SetActive(true);
			isDropped = true;
		}
	}
}
