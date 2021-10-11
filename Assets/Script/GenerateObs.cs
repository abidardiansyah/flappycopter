using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObs : MonoBehaviour
{
    private float score,timer;
    public GameObject rocks;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateObstacle",1f,1.5f);
	
    }
    void CreateObstacle()
    {
        Instantiate(rocks);
	
    }

    // Update is called once per frame
    void Update()
    {
	timer+=Time.deltaTime;
	 if (timer > 5.5f && score <=0) {
        score ++;
        timer = 0;
    }else if (timer > 1.5f && score >=1) {
        score ++;
        timer = 0;
    }
    }
    void OnGUI(){
        GUI.color=Color.black;
        GUILayout.Label("Score: "+score.ToString());
    }
        
}
