using UnityEngine;
using System.Collections;

public class TestMovement : MonoBehaviour {
    Vector3 target;
    float timer;
    int sec;
	// Use this for initialization
	void Start () {
        target = ResetTarget();
        sec = ResetSec();
	}
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (timer>sec)
        {
                target = ResetTarget();
                sec = ResetSec();  
        }
        transform.Translate(target * 10 * Time.deltaTime);//the object movement instruction
    }
    Vector3 ResetTarget()
    {
        return new Vector3(Random.Range(-2,2),0,Random.Range(-2,2));//the moving vector attributes
    }
    int ResetSec()
    {
        timer = 0;
        return Random.Range(1, 3);
    }
    
}
