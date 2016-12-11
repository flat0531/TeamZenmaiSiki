﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class EnemyNameNode : MonoBehaviour {

    // Use this for initialization
    bool isbeforecollection;
    bool isendcollection;
    bool iscollection;
    private string enemyName;
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void setCollection(bool _isbefore,bool _isend)
    {
        isbeforecollection = _isbefore;
        isendcollection = _isend;
    }
    public bool getCollection()
    {
        return iscollection;
    }
    public void setName(string _name)
    {
        enemyName = _name;
        foreach (Transform child in transform)
        {
            if (child.name =="EnemyName")
            {

                child.GetComponent<Text>().text = enemyName;
            }
        }

    }
}