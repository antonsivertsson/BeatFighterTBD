using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour {

	public static ObjectPool current;
	public GameObject pooledObject;
	public int pooledAmount = 25;

	List<GameObject> pooledObjects;

	void Awake() {
		current = this;
	}


	// Use this for initialization
	void Start () {
		pooledObjects = new List<GameObject>();
		for(int i = 0; i < pooledAmount; i++) {
			GameObject obj = (GameObject) Instantiate(pooledObject);
			obj.SetActive(false);
			obj.transform.SetParent(GameObject.Find("BeatBar").transform);
			pooledObjects.Add(obj);
		}
		print("Object pool loaded");
	}
	
	// Update is called once per frame

	public GameObject GetPooledObject() {
		for(int i = 0; i < pooledObjects.Count; i++) {
			if(!pooledObjects[i].activeInHierarchy) {
				return pooledObjects[i];
			}
		}
		return null;
	}

	public GameObject getCustomerObjByIndex(int index) {
		GameObject customerObject = pooledObjects[index];
		customerObject.SetActive(true);
		return customerObject;
	}
}