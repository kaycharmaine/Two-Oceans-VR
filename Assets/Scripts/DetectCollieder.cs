using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {


private Animator animate; 
void Start(){
    animate=GetComponent<Animator>();
    animate.enabled=false;
}
private void OnTriggerEnter(Collider other) { 
    if(other.gameObject.tag=="Player") {
      animate.enabled=true;
    }
} 

private void OnTriggerExit(Collider other) { 
    if(other.gameObject.tag=="Player") {
      animate.enabled=false;
    }
}

}