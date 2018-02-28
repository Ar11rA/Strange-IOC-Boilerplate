using System;
using System.Collections;
using UnityEngine;
using strange.extensions.context.api;
using strange.extensions.dispatcher.eventdispatcher.api;

namespace Game
{
	public class WebService : IWebService
	{
		[Inject(ContextKeys.CONTEXT_VIEW)]
		public GameObject contextView{get;set;}

		//The interface demands this signal
		[Inject]
		public WebServiceRequestSignal webServiceSignal{get;set;}

		private string url;

		public WebService ()
		{
		}

		public void Request(string url)
		{
			this.url = url;
			Debug.Log ("Inside service Request");
			MonoBehaviour root = contextView.GetComponent<HelloWorldBootstrap>();
			root.StartCoroutine(waitASecond());
		}

		private IEnumerator waitASecond()
		{
			yield return new WaitForSeconds(1f);
			Debug.Log ("Waiting for a second");
			webServiceSignal.Dispatch(url);
		}
	}
}
