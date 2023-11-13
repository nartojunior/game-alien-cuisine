using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoofs : MonoBehaviour
{
    public float maxHeight = 6f;
    public float minHeight = -6f;
    public float maxWidth = 9f;
    public float minWidth = -9f;

    public float delaySpawn = 3f;
    public float elapsedTimeToSpawn = 0;

    public bool canSpawn = true;
    public int maxCount = 10;
    public int poofsCount = 0;

    public GameObject poofRosa, poofVermelho;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        if (poofRosa == null) Debug.LogError("PoofRosa null reference");
        if (poofVermelho == null) Debug.LogError("PoofRosa null reference");
        if (player == null) Debug.LogError("PoofRosa null reference");
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTimeToSpawn += Time.deltaTime;
        if (elapsedTimeToSpawn >= delaySpawn)
        {
            if (poofsCount < maxCount)
            {
                elapsedTimeToSpawn = 0f;
                Spawn();
            }
        }
    }

    public void Spawn() {
        Vector3 position = Vector3.zero;
        float chanceRosa = Random.value;
        GameObject a;

        if (chanceRosa <= 0.4f) a = GameObject.Instantiate(poofRosa);
        else a = GameObject.Instantiate(poofVermelho);

        var move = a.GetComponent<MoveToPlayer>();
        move.player = player;
        move.stopMove = false;

        poofsCount++;
    }
}
