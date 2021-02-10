using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthBar : MonoBehaviour
{
    public Slider enemyslider;
    

    public void EnemySetMaxHP(int health){
            enemyslider.maxValue = health;
            enemyslider.value = health;

            return;

    }
    public void EnemySetHealth(int health){

            enemyslider.value = health;
    }

}
