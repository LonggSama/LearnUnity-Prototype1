using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    [SerializeField] float enemySpeed;

    // Update is called once per frame
    void FixedUpdate()
    {
         transform.Translate(Vector3.forward * enemySpeed * Time.deltaTime);
    }

}
