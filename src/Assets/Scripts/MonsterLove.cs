using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterLove : MonoBehaviour
{
    public int loveLevel = 0;
    public int loveLevelMax = 3;
    public float elapsedLove = 0f;
    public float loveTiming = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (elapsedLove >= loveTiming)
        {
            elapsedLove = 0f;
            AddLoveLevel();
        }
    }

    public void AddLoveLevel() {
        loveLevel++;

        if (loveLevel >= loveLevelMax) {
            Destroy(gameObject);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Econtrei o Amor.");

            elapsedLove += Time.deltaTime;
        }
    }
}
