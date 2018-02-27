using System;

using UnityEngine;

using strange.extensions.mediation.impl;

namespace Game {
	public class StatusMediator : Mediator {

		[Inject]
		public StatusView view {get; set;}

		[Inject]
		public ShowTextSignal showText {get; set;}

		public override void OnRegister() {
			showText.AddListener(onStatusTextReceived);
		}

		public void onStatusTextReceived(string status) {
			view.setStatus(status);
		}
	}
}