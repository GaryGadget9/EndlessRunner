using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteFlipper : MonoBehaviour
{
    //this isn't used anymore

    private SpriteRenderer mrBandit;
    // Start is called before the first frame update
    void Awake()
    {
        mrBandit = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        mrBandit.flipX = true;
    }
}
