using System;

using UnityEngine;

namespace Game {
	public class ManagerAsMonoBehaviour : MonoBehaviour, ISomeManager {

		public string input;
		#region ISomeManager implementation
		public void DoManagement(string data) {
			Debug.Log("Manager implemented as MonoBehaviour " + data);
			input = data;
		}
		#endregion

		public string getInput() {
			return input;
		}
	}
}
