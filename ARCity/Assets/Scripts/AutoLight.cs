using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoLight : MonoBehaviour {
    public float LightValue=1;
    public bool IsPositive;
    public float SpeedVar = 1;
    public Vector2 LightLimit = new Vector2(0, 3);
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (IsPositive)
        {
            if (LightValue < LightLimit.y)
            {
                LightValue += Time.deltaTime * SpeedVar;
            }
            else
            {
                IsPositive = false;
                SpeedVar = Random.Range(0.5f, 3);
            }
        }
        else
        {
            if (LightValue > LightLimit.x)
            {
                LightValue -= Time.deltaTime * SpeedVar;
            }
            else
            {
                IsPositive = true;
                SpeedVar = Random.Range(0.5f, 3);
            }
        }
        gameObject.GetComponent<Light>().intensity = LightValue;
	}

}
