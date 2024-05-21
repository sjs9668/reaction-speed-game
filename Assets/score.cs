using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class score : MonoBehaviour
{
    public static int Score;

    // Update is called once per frame
    void Update()
    {
        GetComponent<TMP_Text>().text = "#" + Score;
    }
}
