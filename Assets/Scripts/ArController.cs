using System.Collections.Generic;
using UnityEngine;

public class ArController : MonoBehaviour {	
	public List<GameObject> objects;
	public List<GameObject> groundObjects;

	public void LoadMeal(string mealId) {
		Debug.Log("LoadMeal called in Unity -> " + mealId.ToString());
		for (int i = 0; i < objects.Count; i++) {
			objects[i].SetActive(false);
			groundObjects[i].SetActive(false);
			if (i.ToString() == mealId) {
				objects[i].SetActive(true);
				groundObjects[i].SetActive(true);
			}
		}
	}
}
