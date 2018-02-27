using System;

using UnityEngine;

using strange.extensions.context.impl;

namespace Game {
	public class HelloWorldContext : SignalContext {

		/**
         * Constructor
         */
		public HelloWorldContext(MonoBehaviour contextView) : base(contextView) {
		}

		protected override void mapBindings() {
			base.mapBindings();

			commandBinder.Bind<StartSignal>().To<HelloWorldStartCommand>().Once();
			commandBinder.Bind<DoManagementSignal>().To<DoManagementCommand>().Pooled(); // THIS IS THE NEW MAPPING!!!

			mediationBinder.Bind<HelloWorldView>().To<HelloWorldMediator>();
			mediationBinder.Bind<StatusView>().To<StatusMediator>();


			ManagerAsMonoBehaviour manager = GameObject.Find("Manager").GetComponent<ManagerAsMonoBehaviour>();
			injectionBinder.Bind<ISomeManager>().ToValue(manager);

			injectionBinder.Bind<ShowTextSignal>().ToSingleton();
		}
	}
}