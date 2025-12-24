using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject gameObject;
    private Vector3 spawnPosition = new Vector3(25, 0, 0);

    private PlayerController playerControllerScript;
    private float startDelay = 2;
    private float repeatRate = 2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void SpawnObstacle()
    {
        if (playerControllerScript.gameOver == false)
        {
            Instantiate(gameObject, spawnPosition, gameObject.transform.rotation);
        }
    }
}