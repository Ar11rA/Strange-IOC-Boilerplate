using System;

using UnityEngine;

using strange.extensions.context.api;
using strange.extensions.command.impl;

namespace Game {
	public class DoManagementCommand : Command {

		[Inject]
		public ISomeManager manager {get; set;}

		[Inject]
		public IWebService service{get;set;}

		[Inject]
		public string data { get; set; }

		[Inject]
		public ShowTextSignal showTextSignal { get; set; }


		public override void Execute() {
			Retain ();
			manager.DoManagement(data);
			string input = manager.getInput ();
			showTextSignal.Dispatch (input);
			service.webServiceSignal.AddListener (OnWebRequestComplete);
			service.Request ("https://www.google.com");
		}

		public void OnWebRequestComplete(string url) {
			service.webServiceSignal.RemoveListener (OnWebRequestComplete);
			Debug.Log ("Web Request Complete");
			Release ();
		}
	}
}