using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Point : MonoBehaviour
{
    private GameObject PointText;
    int point = 0;
    // Start is called before the first frame update
    void Start()
    {
        this.PointText = GameObject.Find("PointText");


    }

    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "LargeStarTag")
        {
            point += 100;
        }
        if (other.gameObject.tag == "SmallStarTag")
        {
            point += 150;
        }
        if (other.gameObject.tag == "LargeCloudTag")
        {
            point += 200;
        }
        if (other.gameObject.tag == "SmallCloudTag")
        {
            point += 250;
        }
        this.PointText.GetComponent<Text>().text = point + "point";




    }
}
