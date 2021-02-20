using UnityEngine;
//spawner kood
public class NewBehaviourScript2 : MonoBehaviour {

    public GameObject templateZombie;
    public GameObject templateCoin;

    float time = 0;
    int threshold = 5;

    GameObject lastCoinGameObject = null;

    void Update() {
        time += Time.deltaTime;
        if (time > threshold) {
            GameObject newZombieGameObject = Instantiate(templateZombie);
            newZombieGameObject.transform.position = transform.position;

            if (lastCoinGameObject == null) { 
                lastCoinGameObject = Instantiate(templateCoin);

                int randomX = Random.Range(-4, 4);
                int randomZ = Random.Range(-4, 4);

                lastCoinGameObject.transform.position = new Vector3(randomX, transform.position.y, randomZ);
        }
            time = 0;
        }

        
    
    }

}
