using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back : MonoBehaviour {
    private float size1;
    [SerializeField]
    GameObject back;

    Vector3 lastpos;

	// Use this for initialization
	void Start () {
        size1 = back.transform.localScale.x;
        lastpos = back.transform.position;
        for(int x=0;x<50 ;x++ )
        {
            SpawnX();
            SpawnZ();
            
        }
		
	}

    // Update is called once per frame
    private void SpawnX()
    {
        GameObject _back = Instantiate(back) as GameObject;
        _back.transform.position = lastpos + new Vector3(size1, 0f, 0f);
        lastpos = _back.transform.position;
    }

    private void SpawnZ()
    {
        GameObject _back = Instantiate(back) as GameObject;
        _back.transform.position = lastpos + new Vector3(size1, 0f, 0f);
        lastpos = _back.transform.position;
    }
}
