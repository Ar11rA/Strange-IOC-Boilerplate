using System;
using UnityEngine.UI;
using UnityEngine;

using strange.extensions.mediation.impl;
using strange.extensions.signal.impl;

namespace Game {
	public class StatusView : View {
		public Text statusText;

		public void setStatus(string status) {
			statusText.text = status;
		}
			
	}
}