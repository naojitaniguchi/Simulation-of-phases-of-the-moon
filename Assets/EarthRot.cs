using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EarthRot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void rotBySlider(Slider slider)
    {
        gameObject.transform.rotation = Quaternion.AngleAxis(slider.value * -360.0f, Vector3.up);
    }
}
