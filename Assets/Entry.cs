using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Entry : MonoBehaviour {

	Text textComponent;
	int points;
	int rank;

	// Use this for initialization
	void Start () {
	
		textComponent = GetComponent<Text> ();
		points = Random.Range (0, 100);
	}

	void Update (){

		textComponent.text = string.Format (" - {0}. {1} | {2}", rank, name, points);
	}

	public int ComparePoints(Entry other) {
		
		return other.points.CompareTo(points);
	}

	public int CompareName(Entry other) {
		
		return name.CompareTo(other.name);
	}

	void SetRank(int newRank) {
		
		rank = newRank;
		Transform parent = transform.parent;
		transform.SetParent (null);
		transform.SetParent (parent);
	}

	void SetAlphaPosition(int position) {
		
		Transform parent = transform.parent;
		transform.SetParent (null);
		transform.SetParent (parent);
	}
}
