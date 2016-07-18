using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class test : MonoBehaviour {
    public Text testtext;
    

	// Use this for initialization
	void Start () {
        testtext.text = LayerMask.GetMask("platforms").ToString();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
