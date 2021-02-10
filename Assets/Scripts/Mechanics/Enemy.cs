using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{
    

    public AudioSource damaged;
    private Vector3 startPosition;
    private Quaternion startRotation;
    private double timeBtwShots;
    public double startTimeBtwShots;

    public GameObject projectile;
    public Transform player;

    public Transform enemy;

    public Transform EnemySpawnPoint;
    

    public int maxHP;
    private int currHP;

    public EnemyHealthBar enemyhealthBar;
    public WeaponDrop weaponDrop;



    // Start is called before the first frame update
    void Awake()
    {
        damaged = GetComponent<AudioSource>();
        currHP = maxHP;
        enemyhealthBar.EnemySetMaxHP(maxHP);
        enemy = GameObject.FindGameObjectWithTag ("Enemy").transform;
        player = GameObject.FindGameObjectWithTag("Player").transform;

        startPosition = EnemySpawnPoint.position;
        startRotation = EnemySpawnPoint.rotation;
        
    }

    

    // Update is called once per frame
    void Update()
    {
        
        if(timeBtwShots <=0){

            Instantiate(projectile, transform.position, Quaternion.identity);
            timeBtwShots = startTimeBtwShots;

        }else{
            timeBtwShots -= Time.deltaTime;
        }
        if (currHP <= 0)
        {
            Score.scoreValue += 1;
            if(Score.scoreValue > HighScore.scoreValue){
                HighScore.scoreValue +=1;
            }
            if(Score.scoreValue <= 10){
            startTimeBtwShots = startTimeBtwShots * 0.9;
            maxHP = maxHP + 3;
            }else{
            startTimeBtwShots = startTimeBtwShots * 0.99;
            maxHP = maxHP + 3;   
            }
            KillAndReset();
            
        } 
    }
    public void takeDamage (int damage)
    {

        currHP -= damage;
        Debug.Log("hoopeeta " + currHP);
        GetComponent<AudioSource> ().Play ();
        enemyhealthBar.EnemySetHealth(currHP);
    }
    public void resetHp ()
    {
        currHP = maxHP;
    }

/*public void enemyRespawn ()
        {
                         Destroy (enemy);
 
             enemy clone;
             clone = Instantiate (respawn, respawnpoint.transform.position, respawnpoint.transform.rotation) as Rigidbody;

        }*/

         public void KillAndReset() {

         weaponDrop.drop();
         currHP = maxHP;
         enemy.transform.position = startPosition;
         enemy.transform.rotation = startRotation;
         enemyhealthBar.EnemySetMaxHP(maxHP);
         enemyhealthBar.EnemySetHealth(maxHP);
    }

 }

