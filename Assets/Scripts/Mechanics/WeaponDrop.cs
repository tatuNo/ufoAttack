using System;
using System.Collections;
using System.Collections.Generic;
using Unity.UIWidgets.ui;
using UnityEngine;


public class WeaponDrop : MonoBehaviour
{

	public Transform enemy;
	public Boolean akDrop = false;
	public Boolean m16Drop = false;
	private Boolean boxDropped = false;
	public Boolean juustoDropped = false;
	public Boolean bazookDropped = false;
	public HealthDrop healthdrop;

	public GameObject imageM16;
	public GameObject imageAK;
	public GameObject imageBAZOK;
	public GameObject imageCHEEZ;
	
	
	//public GameObject m16;
	//public GameObject ak47;
	//public GameObject cheeze;
	//public GameObject bazook;

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.CompareTag("Player"))
		{
			gameObject.SetActive(false);
			boxDropped = false;
			weaponDraw();
		}
	}

	public void drop()
	{

		if (boxDropped == false)
		{
			gameObject.transform.position = GameObject.Find("Enemy").transform.position;
			gameObject.transform.rotation = GameObject.Find("Enemy").transform.rotation;
		}
		int numb = UnityEngine.Random.Range(0, 100);
		if (numb < 20) // 20
		{
			gameObject.SetActive(true);
			boxDropped = true;
		}
		if (numb > 90)
		{
			healthdrop.dropHealth();
		}
	}

	public void weaponDraw() {

		int numb2 = 0;
		while (true)
		{
			if (m16Drop == true && akDrop == true && bazookDropped == true && juustoDropped == true)
			{
				break;
			}
	
			numb2 = UnityEngine.Random.Range(0, 100);
			Debug.Log("Number:" + numb2);
			if(numberCheck(numb2) == true)
			{
				break;
			}
		}

		if (numb2 >= 0 && numb2 < 38 && m16Drop == false)
		{
			m16Drop = true;
			imageM16.SetActive(true);
		}
		else if (numb2 >= 38 && numb2 < 75 && akDrop == false)
		{
			akDrop = true;
			imageAK.SetActive(true);
		}
		else if (numb2 >= 75 && numb2 < 92 && bazookDropped == false)
		{
			//Drop bazook
			bazookDropped = true;
			imageBAZOK.SetActive(true);
		}
		else if (numb2 >= 92 && juustoDropped == false)
		{
			// Drop juust
			juustoDropped = true;
			imageCHEEZ.SetActive(true);
		}
	}

	private Boolean numberCheck (int num)
	{
		if(num < 38 && m16Drop == true)
		{
			return false;
		}
		if (num >= 38 && num < 75 && akDrop == true)
		{
			return false;
		}
		if (num >= 75 && num < 92 && bazookDropped == true)
		{
			return false;
		}
		if(num >= 92 && juustoDropped == true)
		{
			return false;
		}
		else
		{
			return true;
		}
	}
}
	


