using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal.drawable']/class[@name='AlmostRippleDrawable']"
	[global::Android.Runtime.Register ("org/adw/library/widgets/discreteseekbar/internal/drawable/AlmostRippleDrawable", DoNotGenerateAcw=true)]
	public partial class AlmostRippleDrawable : global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.StateDrawable, global::Android.Graphics.Drawables.IAnimatable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/adw/library/widgets/discreteseekbar/internal/drawable/AlmostRippleDrawable", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AlmostRippleDrawable); }
		}

		protected AlmostRippleDrawable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_res_ColorStateList_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal.drawable']/class[@name='AlmostRippleDrawable']/constructor[@name='AlmostRippleDrawable' and count(parameter)=1 and parameter[1][@type='android.content.res.ColorStateList']]"
		[Register (".ctor", "(Landroid/content/res/ColorStateList;)V", "")]
		public unsafe AlmostRippleDrawable (global::Android.Content.Res.ColorStateList p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (AlmostRippleDrawable)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/res/ColorStateList;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/res/ColorStateList;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_res_ColorStateList_ == IntPtr.Zero)
					id_ctor_Landroid_content_res_ColorStateList_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/res/ColorStateList;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_res_ColorStateList_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_res_ColorStateList_, __args);
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
			global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.AlmostRippleDrawable __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.AlmostRippleDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRunning;
		}
#pragma warning restore 0169

		static IntPtr id_isRunning;
		public virtual unsafe bool IsRunning {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal.drawable']/class[@name='AlmostRippleDrawable']/method[@name='isRunning' and count(parameter)=0]"
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
			global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.AlmostRippleDrawable __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.AlmostRippleDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AnimateToNormal ();
		}
#pragma warning restore 0169

		static IntPtr id_animateToNormal;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal.drawable']/class[@name='AlmostRippleDrawable']/method[@name='animateToNormal' and count(parameter)=0]"
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
			global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.AlmostRippleDrawable __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.AlmostRippleDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AnimateToPressed ();
		}
#pragma warning restore 0169

		static IntPtr id_animateToPressed;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal.drawable']/class[@name='AlmostRippleDrawable']/method[@name='animateToPressed' and count(parameter)=0]"
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

		static Delegate cb_doDraw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;
#pragma warning disable 0169
		static Delegate GetDoDraw_Landroid_graphics_Canvas_Landroid_graphics_Paint_Handler ()
		{
			if (cb_doDraw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ == null)
				cb_doDraw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_DoDraw_Landroid_graphics_Canvas_Landroid_graphics_Paint_);
			return cb_doDraw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;
		}

		static void n_DoDraw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.AlmostRippleDrawable __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.AlmostRippleDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Paint p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.DoDraw (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_doDraw_Landroid_graphics_Canvas_Landroid_graphics_Paint_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal.drawable']/class[@name='AlmostRippleDrawable']/method[@name='doDraw' and count(parameter)=2 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='android.graphics.Paint']]"
		[Register ("doDraw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V", "GetDoDraw_Landroid_graphics_Canvas_Landroid_graphics_Paint_Handler")]
		public virtual unsafe void DoDraw (global::Android.Graphics.Canvas p0, global::Android.Graphics.Paint p1)
		{
			if (id_doDraw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ == IntPtr.Zero)
				id_doDraw_Landroid_graphics_Canvas_Landroid_graphics_Paint_ = JNIEnv.GetMethodID (class_ref, "doDraw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_doDraw_Landroid_graphics_Canvas_Landroid_graphics_Paint_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "doDraw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V"), __args);
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
			global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.AlmostRippleDrawable __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.AlmostRippleDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		static IntPtr id_start;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal.drawable']/class[@name='AlmostRippleDrawable']/method[@name='start' and count(parameter)=0]"
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
			global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.AlmostRippleDrawable __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.AlmostRippleDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		static IntPtr id_stop;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal.drawable']/class[@name='AlmostRippleDrawable']/method[@name='stop' and count(parameter)=0]"
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

	}
}
