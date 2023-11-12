using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPlayer : MonoBehaviour
{
    public GameObject player;
    public float speed;
    public bool stopMove = false;

    // Start is called before the first frame update
    void Start()
    {
        if (player == null) {
            Debug.LogError("É preciso setar Jogador");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!stopMove)
        {
            Vector3 sense =  player.transform.position - transform.position;

            transform.Translate(sense.normalized * Time.deltaTime * speed);
        }
    }
}
