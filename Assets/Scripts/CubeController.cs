using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {

    public float fallDownSpeed;
    public float fallDownStep;

    IEnumerator FallDown()
    {
        while (true) {
            Vector3 currentPosition = transform.position;
            Vector3 step = new Vector3 (0.0f, -1 * 1 * fallDownStep, 0.0f);
            transform.position = currentPosition + step;
            yield return new WaitForSeconds (fallDownSpeed);
            Debug.Log ("yield");
        }
    }

	// Use this for initialization
	void Start () {
        StartCoroutine (FallDown());
	}
	
	// Update is called once per frame
	void Update () {
    }
}
