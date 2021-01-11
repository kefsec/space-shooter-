using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float _speed = 3.5f;
    

 
   
    //public float horizontalInput; 

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(6.867356f, 0, 0);
        //camera.main = new Vector3(0, 4.8f, -10);
    }

       // Update is called once per frame
    void Update()
    {
        CalculateMovement();
    }


     void CalculateMovement()
  
    {

         float horizontalInput = Input.GetAxis("Horizontal");
         float verticalInput = Input.GetAxis("Vertical");
       
    
      Vector3 direction = new Vector3(horizontalInput,verticalInput,0);
      transform.Translate(direction * _speed * Time.deltaTime);
    
      
     if (transform.position.y >=0)
     {
         transform.position = new Vector3(transform.position.x ,0 ,0);
     }
      else if (transform.position.y <= -4.8f)
     {
        transform.position = new Vector3(transform.position.x, -4.8f, 0);
     }

    

      if (transform.position.x > 17.3f)
     {
       transform.position = new Vector3(-4.73f, transform.position.y, 0); 
     }
      else if (transform.position.x < -4.73)
     {
         transform.position = new Vector3(17.3f, transform.position.y, 0);
     }  

    }



    
}
