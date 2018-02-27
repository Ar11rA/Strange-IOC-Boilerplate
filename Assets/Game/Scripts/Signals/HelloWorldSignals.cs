using System;

using strange.extensions.signal.impl;

namespace Game {

	public class StartSignal : Signal {}

	public class DoManagementSignal : Signal<string> {} // A new signal!

	public class ShowTextSignal : Signal<string> {} 
}