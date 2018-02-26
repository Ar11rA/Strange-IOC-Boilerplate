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

			// we bind a command to StartSignal since it is invoked by SignalContext (the parent class) during on Launch()
			commandBinder.Bind<StartSignal>().To<HelloWorldStartCommand>().Once();
			commandBinder.Bind<DoManagementSignal>().To<DoManagementCommand>().Pooled(); // THIS IS THE NEW MAPPING!!!

			// bind our view to its mediator
			mediationBinder.Bind<HelloWorldView>().To<HelloWorldMediator>();

			// REMOVED!!!
			//injectionBinder.Bind<ISomeManager>().To<ManagerAsNormalClass>().ToSingleton();

			// bind the manager implemented as a MonoBehaviour
			ManagerAsMonoBehaviour manager = GameObject.Find("Manager").GetComponent<ManagerAsMonoBehaviour>();
			injectionBinder.Bind<ISomeManager>().ToValue(manager);
		}
	}
}