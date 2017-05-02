using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBehaviorScript : MonoBehaviour {
    public Transform TeleporterTransform;
	
	void Update () {
        if(Vector3.Distance(TeleporterTransform.position, transform.position) < 1.15)
        {
            SceneManager.LoadScene("Civil_War", LoadSceneMode.Single);
        }
	}
}
