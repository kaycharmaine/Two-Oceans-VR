using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingFish : MonoBehaviour
{
    public bool patrol;

     [SerializeField] float speed=5f;
    [SerializeField] int startPoint;
    [SerializeField] Transform[] points;

    int i;
    bool revers;

    // Start is called before the first frame update
    void Start()
    {
        transform.position=points[startPoint].position;
        i=startPoint;
    }
    // Update is called once per frame
     void Update()
    {

        Vector3 relativePos = points[i].position - transform.position;

        // the second argument, upwards, defaults to Vector3.up
        Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);
        transform.rotation = rotation;

          if(Vector3.Distance(transform.position,points[i].position)<0.01f){
          // canMove=false;
          

            if(i==points.Length-1){
                revers=true;
                i--;
                return;
            }else if(i==0){
                revers=false;
                i++;
                return;
            }

            if(revers){
                i--;
            }else{
                i++;
            }
        }


        if(patrol){
            transform.position=Vector3.MoveTowards(transform.position,points[i].position,speed*Time.deltaTime);
       }
    }
}
