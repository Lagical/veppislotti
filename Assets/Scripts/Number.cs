using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Number : MonoBehaviour
{
    [SerializeField] float speed;

    void Start()
    {
        Destroy(gameObject, 1f);
    }
    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }

}
