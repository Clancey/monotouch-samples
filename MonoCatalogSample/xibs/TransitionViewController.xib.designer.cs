﻿// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------



// Base type probably should be MonoTouch.UIKit.UIViewController or subclass
[MonoTouch.Foundation.Register("TransitionViewController")]
public partial class TransitionViewController {
	
	#pragma warning disable 0169
	[MonoTouch.Foundation.Export("curlAction:")]
	partial void curlAction (MonoTouch.UIKit.UIBarButtonItem sender);

	[MonoTouch.Foundation.Export("flipAction:")]
	partial void flipAction (MonoTouch.UIKit.UIBarButtonItem sender);

	[MonoTouch.Foundation.Connect("view")]
	private MonoTouch.UIKit.UIView view {
		get {
			return ((MonoTouch.UIKit.UIView)(this.GetNativeField("view")));
		}
		set {
			this.SetNativeField("view", value);
		}
	}
}
