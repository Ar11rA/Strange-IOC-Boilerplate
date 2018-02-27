using System;
using UnityEngine.UI;
using UnityEngine;

using strange.extensions.mediation.impl;
using strange.extensions.signal.impl;

namespace Game {
	public class HelloWorldView : View {

		public Signal<string> buttonClicked = new Signal<string>{};

		public void OnButtonClicked() {
			string data = GameObject.Find("InputData").GetComponent<InputField>().text;
			buttonClicked.Dispatch(data);
		}

	}
}