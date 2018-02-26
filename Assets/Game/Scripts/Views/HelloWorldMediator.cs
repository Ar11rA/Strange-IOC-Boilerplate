using System;

using UnityEngine;

using strange.extensions.mediation.impl;

namespace Game {
	public class HelloWorldMediator : Mediator {

		[Inject]
		public HelloWorldView view {get; set;}

		[Inject]
		public DoManagementSignal doManagement {get; set;}

		public override void OnRegister() {
			view.buttonClicked.AddListener(onClickButton);
		}

		private void onClickButton(string data) {
			doManagement.Dispatch(data);
		}

	}
}