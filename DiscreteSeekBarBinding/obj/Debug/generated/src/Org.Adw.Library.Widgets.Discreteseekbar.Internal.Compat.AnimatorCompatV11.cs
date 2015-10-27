using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Adw.Library.Widgets.Discreteseekbar.Internal.Compat {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal.compat']/class[@name='AnimatorCompatV11']"
	[global::Android.Runtime.Register ("org/adw/library/widgets/discreteseekbar/internal/compat/AnimatorCompatV11", DoNotGenerateAcw=true)]
	public partial class AnimatorCompatV11 : global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Compat.AnimatorCompat {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/adw/library/widgets/discreteseekbar/internal/compat/AnimatorCompatV11", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AnimatorCompatV11); }
		}

		protected AnimatorCompatV11 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_FFLorg_adw_library_widgets_discreteseekbar_internal_compat_AnimatorCompat_AnimationFrameUpdateListener_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal.compat']/class[@name='AnimatorCompatV11']/constructor[@name='AnimatorCompatV11' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='org.adw.library.widgets.discreteseekbar.internal.compat.AnimatorCompat.AnimationFrameUpdateListener']]"
		[Register (".ctor", "(FFLorg/adw/library/widgets/discreteseekbar/internal/compat/AnimatorCompat$AnimationFrameUpdateListener;)V", "")]
		public unsafe AnimatorCompatV11 (float p0, float p1, global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Compat.AnimatorCompat.IAnimationFrameUpdateListener p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (AnimatorCompatV11)) {
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
			global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Compat.AnimatorCompatV11 __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Compat.AnimatorCompatV11> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRunning;
		}
#pragma warning restore 0169

		static IntPtr id_isRunning;
		public override unsafe bool IsRunning {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal.compat']/class[@name='AnimatorCompatV11']/method[@name='isRunning' and count(parameter)=0]"
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
			global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Compat.AnimatorCompatV11 __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Compat.AnimatorCompatV11> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cancel ();
		}
#pragma warning restore 0169

		static IntPtr id_cancel;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal.compat']/class[@name='AnimatorCompatV11']/method[@name='cancel' and count(parameter)=0]"
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
			global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Compat.AnimatorCompatV11 __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Compat.AnimatorCompatV11> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDuration (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDuration_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal.compat']/class[@name='AnimatorCompatV11']/method[@name='setDuration' and count(parameter)=1 and parameter[1][@type='int']]"
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
			global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Compat.AnimatorCompatV11 __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Compat.AnimatorCompatV11> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		static IntPtr id_start;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal.compat']/class[@name='AnimatorCompatV11']/method[@name='start' and count(parameter)=0]"
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
}
