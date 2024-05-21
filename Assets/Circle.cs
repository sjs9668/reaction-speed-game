using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Circle : MonoBehaviour
{
    float speed;
    private void Start()
    {
        speed = Random.Range(2f, 3f);
        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);
        GetComponent<SpriteRenderer>().color = new Color(r, g, b);
    }

    private void Update()
    {
        transform.position += Vector3.up * Time.deltaTime * speed;
    }
    private void OnMouseDown()
    {
        score.Score += 1;
        Destroy(gameObject);
    }
}
