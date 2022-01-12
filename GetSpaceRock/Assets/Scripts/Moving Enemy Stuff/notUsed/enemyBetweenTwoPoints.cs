using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBetweenTwoPoints : MonoBehaviour
{

    void Start()
    {
        StartCoroutine(EnemyLeft());
    }

    IEnumerator EnemyLeft()
    {
        transform.position += Vector3.left;
        transform.position += Vector3.left;
        transform.position += Vector3.left;
        transform.position += Vector3.left;
        transform.position += Vector3.left;
        yield return new WaitForSeconds(1);
        StartCoroutine(EnemyRight());
    }

    IEnumerator EnemyRight()
    {
        transform.position += Vector3.right;
        transform.position += Vector3.right;
        transform.position += Vector3.right;
        transform.position += Vector3.right;
        transform.position += Vector3.right;
        yield return new WaitForSeconds(1);
        StartCoroutine(EnemyLeft());
    }
}
