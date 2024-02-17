using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour 
{
    private bool alive;//True --> (character is alive) , False --> (character is dead)

    private int currentHealth;

    private readonly int HEALTH_OF_CHARACTER = 10; 

    private ArrayList eggs = new ArrayList();

    


    // Start is called before the first frame update
    void Start()
    {
        this.alive = true;
        this.currentHealth = this.HEALTH_OF_CHARACTER;

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    /*
        Checks the aliveness (alive) of the character:
        if alive = false (dead) --> ( invoke the method killCharacter() ) return true;
        or 
        if alive = true (alive) --> return false;
    */
    public bool isDead(){
        if(this.alive == false){//False means character is dead;
            return true;// If true, then our character is dead

        }
        else{
            return false;//Then, our character is alive;

        }

    }

    /*
        Kills the character;
        So, aliveness (alive) is set to 
    */
    public void killCharacter(){
        this.alive = false;

    }

    /*
        Character takes a hit according to specified damage;
        isDead method should be invoked after whenever
    */
    public void takeHit(int damage){
        this.currentHealth -= damage;

    }

    /*
        This method checks if character is on egg.
    */
    public void putEgg(Egg egg){
        if( (this.transform.position) == (egg.transform.position) ){
            chooseCharacter();

        }

    }

    private void chooseCharacter(){
        /*
            Implement some way of switching character png's;
        */


    }

    //------------------------------------------------------
    //  Getters
    //------------------------------------------------------

    /*
        This method returns the alive of the character;
        alive --> (true) , dead --> (false)
    */
    public bool getAliveness(){
        return this.alive;

    }

    /*
        This method returns the currentHealth of the character;
    */
    public int getCurrentHealth(){
        return this.currentHealth;

    }

    //------------------------------------------------------
    //  Setters
    //------------------------------------------------------

    public void setCurrentHealth(int currentHealth){
        if(currentHealth >= 0 && currentHealth <= this.HEALTH_OF_CHARACTER){
            this.currentHealth = currentHealth;

        }
        else if(currentHealth < 0){
            this.currentHealth = 0;

        }
        else{//currentHealth is given bigger than HEALTH_OF_CHARACTER
            this.currentHealth = this.HEALTH_OF_CHARACTER;

        }

    }
    

}