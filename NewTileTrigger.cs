using UnityEngine;
using System.Collections;

public class NewTileTrigger : MonoBehaviour {

    public GameObject newTile;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

    }

    public void OnTriggerEnter(Collider player)
    {
        spawnNewTile();
    }

    private void spawnNewTile()
    {
        Instantiate(newTile, new Vector3(transform.position.x, transform.position.y, transform.position.z + 49), Quaternion.identity);
    }
}
