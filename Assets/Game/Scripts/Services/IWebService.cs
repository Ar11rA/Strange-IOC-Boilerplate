using System;
using strange.extensions.dispatcher.eventdispatcher.api;

namespace Game
{
	public interface IWebService
	{
		void Request(string url);
		//Instead of an EventDispatcher, we put the actual Signals into the Interface
		WebServiceRequestSignal webServiceSignal{get;}
	}
}