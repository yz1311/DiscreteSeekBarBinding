using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal.drawable']/class[@name='MarkerDrawable']"
	[global::Android.Runtime.Register ("org/adw/library/widgets/discreteseekbar/internal/drawable/MarkerDrawable", DoNotGenerateAcw=true)]
	public partial class MarkerDrawable : global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.StateDrawable, global::Android.Graphics.Drawables.IAnimatable {

		// Metadata.xml XPath interface reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal.drawable']/interface[@name='MarkerDrawable.MarkerAnimationListener']"
		[Register ("org/adw/library/widgets/discreteseekbar/internal/drawable/MarkerDrawable$MarkerAnimationListener", "", "Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.MarkerDrawable/IMarkerAnimationListenerInvoker")]
		public partial interface IMarkerAnimationListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal.drawable']/interface[@name='MarkerDrawable.MarkerAnimationListener']/method[@name='onClosingComplete' and count(parameter)=0]"
			[Register ("onClosingComplete", "()V", "GetOnClosingCompleteHandler:Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.MarkerDrawable/IMarkerAnimationListenerInvoker, DiscreteSeekBarBinding")]
			void OnClosingComplete ();

			// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal.drawable']/interface[@name='MarkerDrawable.MarkerAnimationListener']/method[@name='onOpeningComplete' and count(parameter)=0]"
			[Register ("onOpeningComplete", "()V", "GetOnOpeningCompleteHandler:Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.MarkerDrawable/IMarkerAnimationListenerInvoker, DiscreteSeekBarBinding")]
			void OnOpeningComplete ();

		}

		[global::Android.Runtime.Register ("org/adw/library/widgets/discreteseekbar/internal/drawable/MarkerDrawable$MarkerAnimationListener", DoNotGenerateAcw=true)]
		internal class IMarkerAnimationListenerInvoker : global::Java.Lang.Object, IMarkerAnimationListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("org/adw/library/widgets/discreteseekbar/internal/drawable/MarkerDrawable$MarkerAnimationListener");
			IntPtr class_ref;

			public static IMarkerAnimationListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IMarkerAnimationListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "org.adw.library.widgets.discreteseekbar.internal.drawable.MarkerDrawable.MarkerAnimationListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IMarkerAnimationListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IMarkerAnimationListenerInvoker); }
			}

			static Delegate cb_onClosingComplete;
#pragma warning disable 0169
			static Delegate GetOnClosingCompleteHandler ()
			{
				if (cb_onClosingComplete == null)
					cb_onClosingComplete = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnClosingComplete);
				return cb_onClosingComplete;
			}

			static void n_OnClosingComplete (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.MarkerDrawable.IMarkerAnimationListener __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.MarkerDrawable.IMarkerAnimationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnClosingComplete ();
			}
#pragma warning restore 0169

			IntPtr id_onClosingComplete;
			public unsafe void OnClosingComplete ()
			{
				if (id_onClosingComplete == IntPtr.Zero)
					id_onClosingComplete = JNIEnv.GetMethodID (class_ref, "onClosingComplete", "()V");
				JNIEnv.CallVoidMethod (Handle, id_onClosingComplete);
			}

			static Delegate cb_onOpeningComplete;
#pragma warning disable 0169
			static Delegate GetOnOpeningCompleteHandler ()
			{
				if (cb_onOpeningComplete == null)
					cb_onOpeningComplete = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnOpeningComplete);
				return cb_onOpeningComplete;
			}

			static void n_OnOpeningComplete (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.MarkerDrawable.IMarkerAnimationListener __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.MarkerDrawable.IMarkerAnimationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnOpeningComplete ();
			}
#pragma warning restore 0169

			IntPtr id_onOpeningComplete;
			public unsafe void OnOpeningComplete ()
			{
				if (id_onOpeningComplete == IntPtr.Zero)
					id_onOpeningComplete = JNIEnv.GetMethodID (class_ref, "onOpeningComplete", "()V");
				JNIEnv.CallVoidMethod (Handle, id_onOpeningComplete);
			}

		}

		[global::Android.Runtime.Register ("mono/org/adw/library/widgets/discreteseekbar/internal/drawable/MarkerDrawable_MarkerAnimationListenerImplementor")]
		internal sealed partial class IMarkerAnimationListenerImplementor : global::Java.Lang.Object, IMarkerAnimationListener {

			object sender;

			public IMarkerAnimationListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/org/adw/library/widgets/discreteseekbar/internal/drawable/MarkerDrawable_MarkerAnimationListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler OnClosingCompleteHandler;
#pragma warning restore 0649

			public void OnClosingComplete ()
			{
				var __h = OnClosingCompleteHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler OnOpeningCompleteHandler;
#pragma warning restore 0649

			public void OnOpeningComplete ()
			{
				var __h = OnOpeningCompleteHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (IMarkerAnimationListenerImplementor value)
			{
				return value.OnClosingCompleteHandler == null && value.OnOpeningCompleteHandler == null;
			}
		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/adw/library/widgets/discreteseekbar/internal/drawable/MarkerDrawable", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MarkerDrawable); }
		}

		protected MarkerDrawable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_res_ColorStateList_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal.drawable']/class[@name='MarkerDrawable']/constructor[@name='MarkerDrawable' and count(parameter)=2 and parameter[1][@type='android.content.res.ColorStateList'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Landroid/content/res/ColorStateList;I)V", "")]
		public unsafe MarkerDrawable (global::Android.Content.Res.ColorStateList p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (MarkerDrawable)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/res/ColorStateList;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/res/ColorStateList;I)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_res_ColorStateList_I == IntPtr.Zero)
					id_ctor_Landroid_content_res_ColorStateList_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/res/ColorStateList;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_res_ColorStateList_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_res_ColorStateList_I, __args);
			} finally {
			}
		}

		static Delegate cb_isRunning;
#pragma warning disable 0169
		static Delegate GetIsRunningHandler ()
		{
			if (cb_isRunning == null)
				cb_isRunning = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRunning);
			return cb_isRunning;
		}

		static bool n_IsRunning (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.MarkerDrawable __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.MarkerDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRunning;
		}
#pragma warning restore 0169

		static IntPtr id_isRunning;
		public virtual unsafe bool IsRunning {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal.drawable']/class[@name='MarkerDrawable']/method[@name='isRunning' and count(parameter)=0]"
			[Register ("isRunning", "()Z", "GetIsRunningHandler")]
			get {
				if (id_isRunning == IntPtr.Zero)
					id_isRunning = JNIEnv.GetMethodID (class_ref, "isRunning", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isRunning);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isRunning", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getPath;
#pragma warning disable 0169
		static Delegate GetGetPathHandler ()
		{
			if (cb_getPath == null)
				cb_getPath = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPath);
			return cb_getPath;
		}

		static IntPtr n_GetPath (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.MarkerDrawable __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.MarkerDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Path);
		}
#pragma warning restore 0169

		static IntPtr id_getPath;
		public virtual unsafe global::Android.Graphics.Path Path {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal.drawable']/class[@name='MarkerDrawable']/method[@name='getPath' and count(parameter)=0]"
			[Register ("getPath", "()Landroid/graphics/Path;", "GetGetPathHandler")]
			get {
				if (id_getPath == IntPtr.Zero)
					id_getPath = JNIEnv.GetMethodID (class_ref, "getPath", "()Landroid/graphics/Path;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Path> (JNIEnv.CallObjectMethod  (Handle, id_getPath), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Path> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPath", "()Landroid/graphics/Path;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_animateToNormal;
#pragma warning disable 0169
		static Delegate GetAnimateToNormalHandler ()
		{
			if (cb_animateToNormal == null)
				cb_animateToNormal = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AnimateToNormal);
			return cb_animateToNormal;
		}

		static void n_AnimateToNormal (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.MarkerDrawable __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.MarkerDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AnimateToNormal ();
		}
#pragma warning restore 0169

		static IntPtr id_animateToNormal;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal.drawable']/class[@name='MarkerDrawable']/method[@name='animateToNormal' and count(parameter)=0]"
		[Register ("animateToNormal", "()V", "GetAnimateToNormalHandler")]
		public virtual unsafe void AnimateToNormal ()
		{
			if (id_animateToNormal == IntPtr.Zero)
				id_animateToNormal = JNIEnv.GetMethodID (class_ref, "animateToNormal", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_animateToNormal);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "animateToNormal", "()V"));
			} finally {
			}
		}

		static Delegate cb_animateToPressed;
#pragma warning disable 0169
		static Delegate GetAnimateToPressedHandler ()
		{
			if (cb_animateToPressed == null)
				cb_animateToPressed = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AnimateToPressed);
			return cb_animateToPressed;
		}

		static void n_AnimateToPressed (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.MarkerDrawable __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.MarkerDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AnimateToPressed ();
		}
#pragma warning restore 0169

		static IntPtr id_animateToPressed;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal.drawable']/class[@name='MarkerDrawable']/method[@name='animateToPressed' and count(parameter)=0]"
		[Register ("animateToPressed", "()V", "GetAnimateToPressedHandler")]
		public virtual unsafe void AnimateToPressed ()
		{
			if (id_animateToPressed == IntPtr.Zero)
				id_animateToPressed = JNIEnv.GetMethodID (class_ref, "animateToPressed", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_animateToPressed);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "animateToPressed", "()V"));
			} finally {
			}
		}

		static Delegate cb_setColors_II;
#pragma warning disable 0169
		static Delegate GetSetColors_IIHandler ()
		{
			if (cb_setColors_II == null)
				cb_setColors_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_SetColors_II);
			return cb_setColors_II;
		}

		static void n_SetColors_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.MarkerDrawable __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.MarkerDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetColors (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setColors_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal.drawable']/class[@name='MarkerDrawable']/method[@name='setColors' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setColors", "(II)V", "GetSetColors_IIHandler")]
		public virtual unsafe void SetColors (int p0, int p1)
		{
			if (id_setColors_II == IntPtr.Zero)
				id_setColors_II = JNIEnv.GetMethodID (class_ref, "setColors", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setColors_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setColors", "(II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setExternalOffset_I;
#pragma warning disable 0169
		static Delegate GetSetExternalOffset_IHandler ()
		{
			if (cb_setExternalOffset_I == null)
				cb_setExternalOffset_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetExternalOffset_I);
			return cb_setExternalOffset_I;
		}

		static void n_SetExternalOffset_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.MarkerDrawable __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.MarkerDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetExternalOffset (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setExternalOffset_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal.drawable']/class[@name='MarkerDrawable']/method[@name='setExternalOffset' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setExternalOffset", "(I)V", "GetSetExternalOffset_IHandler")]
		public virtual unsafe void SetExternalOffset (int p0)
		{
			if (id_setExternalOffset_I == IntPtr.Zero)
				id_setExternalOffset_I = JNIEnv.GetMethodID (class_ref, "setExternalOffset", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setExternalOffset_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setExternalOffset", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setMarkerListener_Lorg_adw_library_widgets_discreteseekbar_internal_drawable_MarkerDrawable_MarkerAnimationListener_;
#pragma warning disable 0169
		static Delegate GetSetMarkerListener_Lorg_adw_library_widgets_discreteseekbar_internal_drawable_MarkerDrawable_MarkerAnimationListener_Handler ()
		{
			if (cb_setMarkerListener_Lorg_adw_library_widgets_discreteseekbar_internal_drawable_MarkerDrawable_MarkerAnimationListener_ == null)
				cb_setMarkerListener_Lorg_adw_library_widgets_discreteseekbar_internal_drawable_MarkerDrawable_MarkerAnimationListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMarkerListener_Lorg_adw_library_widgets_discreteseekbar_internal_drawable_MarkerDrawable_MarkerAnimationListener_);
			return cb_setMarkerListener_Lorg_adw_library_widgets_discreteseekbar_internal_drawable_MarkerDrawable_MarkerAnimationListener_;
		}

		static void n_SetMarkerListener_Lorg_adw_library_widgets_discreteseekbar_internal_drawable_MarkerDrawable_MarkerAnimationListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.MarkerDrawable __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.MarkerDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.MarkerDrawable.IMarkerAnimationListener p0 = (global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.MarkerDrawable.IMarkerAnimationListener)global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.MarkerDrawable.IMarkerAnimationListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetMarkerListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setMarkerListener_Lorg_adw_library_widgets_discreteseekbar_internal_drawable_MarkerDrawable_MarkerAnimationListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal.drawable']/class[@name='MarkerDrawable']/method[@name='setMarkerListener' and count(parameter)=1 and parameter[1][@type='org.adw.library.widgets.discreteseekbar.internal.drawable.MarkerDrawable.MarkerAnimationListener']]"
		[Register ("setMarkerListener", "(Lorg/adw/library/widgets/discreteseekbar/internal/drawable/MarkerDrawable$MarkerAnimationListener;)V", "GetSetMarkerListener_Lorg_adw_library_widgets_discreteseekbar_internal_drawable_MarkerDrawable_MarkerAnimationListener_Handler")]
		public virtual unsafe void SetMarkerListener (global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.MarkerDrawable.IMarkerAnimationListener p0)
		{
			if (id_setMarkerListener_Lorg_adw_library_widgets_discreteseekbar_internal_drawable_MarkerDrawable_MarkerAnimationListener_ == IntPtr.Zero)
				id_setMarkerListener_Lorg_adw_library_widgets_discreteseekbar_internal_drawable_MarkerDrawable_MarkerAnimationListener_ = JNIEnv.GetMethodID (class_ref, "setMarkerListener", "(Lorg/adw/library/widgets/discreteseekbar/internal/drawable/MarkerDrawable$MarkerAnimationListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setMarkerListener_Lorg_adw_library_widgets_discreteseekbar_internal_drawable_MarkerDrawable_MarkerAnimationListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMarkerListener", "(Lorg/adw/library/widgets/discreteseekbar/internal/drawable/MarkerDrawable$MarkerAnimationListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_start;
#pragma warning disable 0169
		static Delegate GetStartHandler ()
		{
			if (cb_start == null)
				cb_start = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Start);
			return cb_start;
		}

		static void n_Start (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.MarkerDrawable __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.MarkerDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		static IntPtr id_start;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal.drawable']/class[@name='MarkerDrawable']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler")]
		public virtual unsafe void Start ()
		{
			if (id_start == IntPtr.Zero)
				id_start = JNIEnv.GetMethodID (class_ref, "start", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_start);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "start", "()V"));
			} finally {
			}
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.MarkerDrawable __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.MarkerDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		static IntPtr id_stop;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal.drawable']/class[@name='MarkerDrawable']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public virtual unsafe void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_stop);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stop", "()V"));
			} finally {
			}
		}

#region "Event implementation for Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.MarkerDrawable.IMarkerAnimationListener"
		public event EventHandler ClosingComplete {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.MarkerDrawable.IMarkerAnimationListener, global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.MarkerDrawable.IMarkerAnimationListenerImplementor>(
						ref weak_implementor_SetMarkerListener,
						__CreateIMarkerAnimationListenerImplementor,
						SetMarkerListener,
						__h => __h.OnClosingCompleteHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.MarkerDrawable.IMarkerAnimationListener, global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.MarkerDrawable.IMarkerAnimationListenerImplementor>(
						ref weak_implementor_SetMarkerListener,
						global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.MarkerDrawable.IMarkerAnimationListenerImplementor.__IsEmpty,
						__v => SetMarkerListener (null),
						__h => __h.OnClosingCompleteHandler -= value);
			}
		}

		public event EventHandler OpeningComplete {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.MarkerDrawable.IMarkerAnimationListener, global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.MarkerDrawable.IMarkerAnimationListenerImplementor>(
						ref weak_implementor_SetMarkerListener,
						__CreateIMarkerAnimationListenerImplementor,
						SetMarkerListener,
						__h => __h.OnOpeningCompleteHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.MarkerDrawable.IMarkerAnimationListener, global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.MarkerDrawable.IMarkerAnimationListenerImplementor>(
						ref weak_implementor_SetMarkerListener,
						global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.MarkerDrawable.IMarkerAnimationListenerImplementor.__IsEmpty,
						__v => SetMarkerListener (null),
						__h => __h.OnOpeningCompleteHandler -= value);
			}
		}

		WeakReference weak_implementor_SetMarkerListener;

		global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.MarkerDrawable.IMarkerAnimationListenerImplementor __CreateIMarkerAnimationListenerImplementor ()
		{
			return new global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.MarkerDrawable.IMarkerAnimationListenerImplementor (this);
		}
#endregion
	}
}
