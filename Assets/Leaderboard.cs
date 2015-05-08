using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Leaderboard : MonoBehaviour {

	public void SortByPoints() {

		List<Entry> list = new List<Entry> (GetComponentsInChildren<Entry> ());

		list.Sort ((anything, anythingElse) => { return anything.ComparePoints(anythingElse); });

		for (int rank = 0; rank < list.Count; ++rank) {

			list[rank].SendMessage ("SetRank", rank + 1);
		}
	}

	public void SortByName() {
		
		List<Entry> list = new List<Entry> (GetComponentsInChildren<Entry> ());
		
		list.Sort ((anything, anythingElse) => { return anything.CompareName(anythingElse); });
		
		for (int alphaPosition = 0; alphaPosition < list.Count; ++alphaPosition) {
			
			list[alphaPosition].SendMessage ("SetAlphaPosition", alphaPosition + 1);
		}
	}

}
