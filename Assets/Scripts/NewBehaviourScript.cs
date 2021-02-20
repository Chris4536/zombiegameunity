using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    //player kood

    int score = 0;
    float speed = 2f;

   
    void Update() {
 
        if (Input.GetMouseButton (0)) {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
            if (Physics.Raycast (ray, out hit)) {
                Vector3 targetPosition = new Vector3 (hit.point.x, transform.position.y, hit.point.z);
                transform.position = Vector3.Lerp (transform.position, targetPosition, Time.deltaTime * speed);
                transform.LookAt (targetPosition);
            }
        }     
    }

    private void OnTriggerEnter(Collider other) {
        
        if (other.transform.gameObject.CompareTag ("Enemy")) {
            Debug.Log("Game over!");

        } else {
            score++;
            Debug.Log ("Score is " + score);
            Destroy(other.transform.gameObject);
        }
           
        
    
    }
}
