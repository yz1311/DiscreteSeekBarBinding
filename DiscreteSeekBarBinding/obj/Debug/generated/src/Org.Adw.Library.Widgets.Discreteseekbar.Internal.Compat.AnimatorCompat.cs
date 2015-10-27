using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Adw.Library.Widgets.Discreteseekbar.Internal.Compat {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal.compat']/class[@name='AnimatorCompat']"
	[global::Android.Runtime.Register ("org/adw/library/widgets/discreteseekbar/internal/compat/AnimatorCompat", DoNotGenerateAcw=true)]
	public abstract partial class AnimatorCompat : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal.compat']/interface[@name='AnimatorCompat.AnimationFrameUpdateListener']"
		[Register ("org/adw/library/widgets/discreteseekbar/internal/compat/AnimatorCompat$AnimationFrameUpdateListener", "", "Org.Adw.Library.Widgets.Discreteseekbar.Internal.Compat.AnimatorCompat/IAnimationFrameUpdateListenerInvoker")]
		public partial interface IAnimationFrameUpdateListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal.compat']/interface[@name='AnimatorCompat.AnimationFrameUpdateListener']/method[@name='onAnimationFrame' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("onAnimationFrame", "(F)V", "GetOnAnimationFrame_FHandler:Org.Adw.Library.Widgets.Discreteseekbar.Internal.Compat.AnimatorCompat/IAnimationFrameUpdateListenerInvoker, DiscreteSeekBarBinding")]
			void OnAnimationFrame (float p0);

		}

		[global::Android.Runtime.Register ("org/adw/library/widgets/discreteseekbar/internal/compat/AnimatorCompat$AnimationFrameUpdateListener", DoNotGenerateAcw=true)]
		internal class IAnimationFrameUpdateListenerInvoker : global::Java.Lang.Object, IAnimationFrameUpdateListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("org/adw/library/widgets/discreteseekbar/internal/compat/AnimatorCompat$AnimationFrameUpdateListener");
			IntPtr class_ref;

			public static IAnimationFrameUpdateListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IAnimationFrameUpdateListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "org.adw.library.widgets.discreteseekbar.internal.compat.AnimatorCompat.AnimationFrameUpdateListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IAnimationFrameUpdateListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IAnimationFrameUpdateListenerInvoker); }
			}

			static Delegate cb_onAnimationFrame_F;
#pragma warning disable 0169
			static Delegate GetOnAnimationFrame_FHandler ()
			{
				if (cb_onAnimationFrame_F == null)
					cb_onAnimationFrame_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_OnAnimationFrame_F);
				return cb_onAnimationFrame_F;
			}

			static void n_OnAnimationFrame_F (IntPtr jnienv, IntPtr native__this, float p0)
			{
				global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Compat.AnimatorCompat.IAnimationFrameUpdateListener __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Compat.AnimatorCompat.IAnimationFrameUpdateListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnAnimationFrame (p0);
			}
#pragma warning restore 0169

			IntPtr id_onAnimationFrame_F;
			public unsafe void OnAnimationFrame (float p0)
			{
				if (id_onAnimationFrame_F == IntPtr.Zero)
					id_onAnimationFrame_F = JNIEnv.GetMethodID (class_ref, "onAnimationFrame", "(F)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_onAnimationFrame_F, __args);
			}

		}

		public partial class AnimationFrameUpdateEventArgs : global::System.EventArgs {

			public AnimationFrameUpdateEventArgs (float p0)
			{
				this.p0 = p0;
			}

			float p0;
			public float P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/org/adw/library/widgets/discreteseekbar/internal/compat/AnimatorCompat_AnimationFrameUpdateListenerImplementor")]
		internal sealed partial class IAnimationFrameUpdateListenerImplementor : global::Java.Lang.Object, IAnimationFrameUpdateListener {

			object sender;

			public IAnimationFrameUpdateListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/org/adw/library/widgets/discreteseekbar/internal/compat/AnimatorCompat_AnimationFrameUpdateListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<AnimationFrameUpdateEventArgs> Handler;
#pragma warning restore 0649

			public void OnAnimationFrame (float p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new AnimationFrameUpdateEventArgs (p0));
			}

			internal static bool __IsEmpty (IAnimationFrameUpdateListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal.compat']/class[@name='AnimatorCompat.AnimatorCompatBase']"
		[global::Android.Runtime.Register ("org/adw/library/widgets/discreteseekbar/internal/compat/AnimatorCompat$AnimatorCompatBase", DoNotGenerateAcw=true)]
		public partial class AnimatorCompatBase : global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Compat.AnimatorCompat {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/adw/library/widgets/discreteseekbar/internal/compat/AnimatorCompat$AnimatorCompatBase", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (AnimatorCompatBase); }
			}

			protected AnimatorCompatBase (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_FFLorg_adw_library_widgets_discreteseekbar_internal_compat_AnimatorCompat_AnimationFrameUpdateListener_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal.compat']/class[@name='AnimatorCompat.AnimatorCompatBase']/constructor[@name='AnimatorCompat.AnimatorCompatBase' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='org.adw.library.widgets.discreteseekbar.internal.compat.AnimatorCompat.AnimationFrameUpdateListener']]"
			[Register (".ctor", "(FFLorg/adw/library/widgets/discreteseekbar/internal/compat/AnimatorCompat$AnimationFrameUpdateListener;)V", "")]
			public unsafe AnimatorCompatBase (float p0, float p1, global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Compat.AnimatorCompat.IAnimationFrameUpdateListener p2)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					if (GetType () != typeof (AnimatorCompatBase)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(FFLorg/adw/library/widgets/discreteseekbar/internal/compat/AnimatorCompat$AnimationFrameUpdateListener;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(FFLorg/adw/library/widgets/discreteseekbar/internal/compat/AnimatorCompat$AnimationFrameUpdateListener;)V", __args);
						return;
					}

					if (id_ctor_FFLorg_adw_library_widgets_discreteseekbar_internal_compat_AnimatorCompat_AnimationFrameUpdateListener_ == IntPtr.Zero)
						id_ctor_FFLorg_adw_library_widgets_discreteseekbar_internal_compat_AnimatorCompat_AnimationFrameUpdateListener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(FFLorg/adw/library/widgets/discreteseekbar/internal/compat/AnimatorCompat$AnimationFrameUpdateListener;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_FFLorg_adw_library_widgets_discreteseekbar_internal_compat_AnimatorCompat_AnimationFrameUpdateListener_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_FFLorg_adw_library_widgets_discreteseekbar_internal_compat_AnimatorCompat_AnimationFrameUpdateListener_, __args);
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
				global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Compat.AnimatorCompat.AnimatorCompatBase __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Compat.AnimatorCompat.AnimatorCompatBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsRunning;
			}
#pragma warning restore 0169

			static IntPtr id_isRunning;
			public override unsafe bool IsRunning {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal.compat']/class[@name='AnimatorCompat.AnimatorCompatBase']/method[@name='isRunning' and count(parameter)=0]"
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

			static Delegate cb_cancel;
#pragma warning disable 0169
			static Delegate GetCancelHandler ()
			{
				if (cb_cancel == null)
					cb_cancel = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Cancel);
				return cb_cancel;
			}

			static void n_Cancel (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Compat.AnimatorCompat.AnimatorCompatBase __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Compat.AnimatorCompat.AnimatorCompatBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Cancel ();
			}
#pragma warning restore 0169

			static IntPtr id_cancel;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal.compat']/class[@name='AnimatorCompat.AnimatorCompatBase']/method[@name='cancel' and count(parameter)=0]"
			[Register ("cancel", "()V", "GetCancelHandler")]
			public override unsafe void Cancel ()
			{
				if (id_cancel == IntPtr.Zero)
					id_cancel = JNIEnv.GetMethodID (class_ref, "cancel", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_cancel);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cancel", "()V"));
				} finally {
				}
			}

			static Delegate cb_setDuration_I;
#pragma warning disable 0169
			static Delegate GetSetDuration_IHandler ()
			{
				if (cb_setDuration_I == null)
					cb_setDuration_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDuration_I);
				return cb_setDuration_I;
			}

			static void n_SetDuration_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Compat.AnimatorCompat.AnimatorCompatBase __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Compat.AnimatorCompat.AnimatorCompatBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.SetDuration (p0);
			}
#pragma warning restore 0169

			static IntPtr id_setDuration_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal.compat']/class[@name='AnimatorCompat.AnimatorCompatBase']/method[@name='setDuration' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDuration", "(I)V", "GetSetDuration_IHandler")]
			public override unsafe void SetDuration (int p0)
			{
				if (id_setDuration_I == IntPtr.Zero)
					id_setDuration_I = JNIEnv.GetMethodID (class_ref, "setDuration", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setDuration_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDuration", "(I)V"), __args);
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
				global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Compat.AnimatorCompat.AnimatorCompatBase __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Compat.AnimatorCompat.AnimatorCompatBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Start ();
			}
#pragma warning restore 0169

			static IntPtr id_start;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal.compat']/class[@name='AnimatorCompat.AnimatorCompatBase']/method[@name='start' and count(parameter)=0]"
			[Register ("start", "()V", "GetStartHandler")]
			public override unsafe void Start ()
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

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/adw/library/widgets/discreteseekbar/internal/compat/AnimatorCompat", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AnimatorCompat); }
		}

		protected AnimatorCompat (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Compat.AnimatorCompat __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Compat.AnimatorCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRunning;
		}
#pragma warning restore 0169

		public abstract bool IsRunning {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal.compat']/class[@name='AnimatorCompat']/method[@name='isRunning' and count(parameter)=0]"
			[Register ("isRunning", "()Z", "GetIsRunningHandler")] get;
		}

		static Delegate cb_cancel;
#pragma warning disable 0169
		static Delegate GetCancelHandler ()
		{
			if (cb_cancel == null)
				cb_cancel = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Cancel);
			return cb_cancel;
		}

		static void n_Cancel (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Compat.AnimatorCompat __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Compat.AnimatorCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cancel ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal.compat']/class[@name='AnimatorCompat']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "GetCancelHandler")]
		public abstract void Cancel ();

		static IntPtr id_create_FFLorg_adw_library_widgets_discreteseekbar_internal_compat_AnimatorCompat_AnimationFrameUpdateListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal.compat']/class[@name='AnimatorCompat']/method[@name='create' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='org.adw.library.widgets.discreteseekbar.internal.compat.AnimatorCompat.AnimationFrameUpdateListener']]"
		[Register ("create", "(FFLorg/adw/library/widgets/discreteseekbar/internal/compat/AnimatorCompat$AnimationFrameUpdateListener;)Lorg/adw/library/widgets/discreteseekbar/internal/compat/AnimatorCompat;", "")]
		public static unsafe global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Compat.AnimatorCompat Create (float p0, float p1, global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Compat.AnimatorCompat.IAnimationFrameUpdateListener p2)
		{
			if (id_create_FFLorg_adw_library_widgets_discreteseekbar_internal_compat_AnimatorCompat_AnimationFrameUpdateListener_ == IntPtr.Zero)
				id_create_FFLorg_adw_library_widgets_discreteseekbar_internal_compat_AnimatorCompat_AnimationFrameUpdateListener_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(FFLorg/adw/library/widgets/discreteseekbar/internal/compat/AnimatorCompat$AnimationFrameUpdateListener;)Lorg/adw/library/widgets/discreteseekbar/internal/compat/AnimatorCompat;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Compat.AnimatorCompat __ret = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Compat.AnimatorCompat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_FFLorg_adw_library_widgets_discreteseekbar_internal_compat_AnimatorCompat_AnimationFrameUpdateListener_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setDuration_I;
#pragma warning disable 0169
		static Delegate GetSetDuration_IHandler ()
		{
			if (cb_setDuration_I == null)
				cb_setDuration_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDuration_I);
			return cb_setDuration_I;
		}

		static void n_SetDuration_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Compat.AnimatorCompat __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Compat.AnimatorCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDuration (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal.compat']/class[@name='AnimatorCompat']/method[@name='setDuration' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setDuration", "(I)V", "GetSetDuration_IHandler")]
		public abstract void SetDuration (int p0);

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
			global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Compat.AnimatorCompat __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Compat.AnimatorCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal.compat']/class[@name='AnimatorCompat']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler")]
		public abstract void Start ();

	}

	[global::Android.Runtime.Register ("org/adw/library/widgets/discreteseekbar/internal/compat/AnimatorCompat", DoNotGenerateAcw=true)]
	internal partial class AnimatorCompatInvoker : AnimatorCompat {

		public AnimatorCompatInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AnimatorCompatInvoker); }
		}

		static IntPtr id_isRunning;
		public override unsafe bool IsRunning {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal.compat']/class[@name='AnimatorCompat']/method[@name='isRunning' and count(parameter)=0]"
			[Register ("isRunning", "()Z", "GetIsRunningHandler")]
			get {
				if (id_isRunning == IntPtr.Zero)
					id_isRunning = JNIEnv.GetMethodID (class_ref, "isRunning", "()Z");
				try {
					return JNIEnv.CallBooleanMethod  (Handle, id_isRunning);
				} finally {
				}
			}
		}

		static IntPtr id_cancel;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal.compat']/class[@name='AnimatorCompat']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "GetCancelHandler")]
		public override unsafe void Cancel ()
		{
			if (id_cancel == IntPtr.Zero)
				id_cancel = JNIEnv.GetMethodID (class_ref, "cancel", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_cancel);
			} finally {
			}
		}

		static IntPtr id_setDuration_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal.compat']/class[@name='AnimatorCompat']/method[@name='setDuration' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setDuration", "(I)V", "GetSetDuration_IHandler")]
		public override unsafe void SetDuration (int p0)
		{
			if (id_setDuration_I == IntPtr.Zero)
				id_setDuration_I = JNIEnv.GetMethodID (class_ref, "setDuration", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_setDuration_I, __args);
			} finally {
			}
		}

		static IntPtr id_start;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal.compat']/class[@name='AnimatorCompat']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler")]
		public override unsafe void Start ()
		{
			if (id_start == IntPtr.Zero)
				id_start = JNIEnv.GetMethodID (class_ref, "start", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_start);
			} finally {
			}
		}

	}

}
