using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour {
    //zombie kood
    public GameObject gameObjectPlayer;

    void Update() {
        Vector3 targetPosition = new Vector3(gameObjectPlayer.transform.position.x, transform.position.y, gameObjectPlayer.transform.position.z);
        transform.LookAt(targetPosition);

        transform.position = Vector3.Lerp(transform.position, gameObjectPlayer.transform.position, Time.deltaTime * 0.5f);
    }
}
