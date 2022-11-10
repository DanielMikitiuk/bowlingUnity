using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    [SerializeField]
    private GameObject _ball;
    [SerializeField]
    private int _speed;
    [SerializeField]
    private int _jump;
    [SerializeField]
    private float _rotate; 
    
    // Start is called before the first frame update
    void Start()
    {
        //_ball.transform.position =new Vector3(0,1.5f,0);
    }

    // Update is called once per frame
    void Update()
    {
         


    }
    

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.position += new Vector3(0,0,_speed) * Time.fixedDeltaTime;
           
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.position  -= new Vector3(0,0,_speed)*Time.fixedDeltaTime;
            
        }
        if(Input.GetKey(KeyCode.A))
        {
             this.transform.position -= new Vector3(_speed,0,0)*Time.fixedDeltaTime;            
            
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.position += new Vector3(_speed,0,0) * Time.fixedDeltaTime;
           
        }
        if(Input.GetKey(KeyCode.Space))
        {
            this.transform.position += new Vector3(0,_speed,0) * Time.fixedDeltaTime;
        }
    }
}
