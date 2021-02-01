using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    public int MaxHP;
    [HideInInspector]
    public int currentHP;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Damage")
        {
            currentHP = currentHP - 1;
            Destroy(other.gameObject);

        }
    }


    // Start is called before the first frame update
    void Start()
    {
        currentHP = MaxHP;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
