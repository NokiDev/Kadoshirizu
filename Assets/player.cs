using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {
    public int lifePoint;
    private int nbDots;

    // Use this for initialization
    void Start () {
        this.lifePoint = 5000;
        this.nbDots = 0;
        
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void Dots(){
        nbDots++;
        if(nbDots == 3){
            Damage(1000);
        }
    }

    void Damage(int damage){
        this.lifePoint -= damage;
    }


}
