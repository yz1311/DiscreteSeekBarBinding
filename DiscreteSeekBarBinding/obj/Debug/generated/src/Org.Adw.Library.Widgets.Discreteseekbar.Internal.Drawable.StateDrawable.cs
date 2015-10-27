using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal.drawable']/class[@name='StateDrawable']"
	[global::Android.Runtime.Register ("org/adw/library/widgets/discreteseekbar/internal/drawable/StateDrawable", DoNotGenerateAcw=true)]
	public abstract partial class StateDrawable : global::Android.Graphics.Drawables.Drawable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/adw/library/widgets/discreteseekbar/internal/drawable/StateDrawable", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StateDrawable); }
		}

		protected StateDrawable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_res_ColorStateList_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal.drawable']/class[@name='StateDrawable']/constructor[@name='StateDrawable' and count(parameter)=1 and parameter[1][@type='android.content.res.ColorStateList']]"
		[Register (".ctor", "(Landroid/content/res/ColorStateList;)V", "")]
		public unsafe StateDrawable (global::Android.Content.Res.ColorStateList p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (StateDrawable)) {
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

		static Delegate cb_getOpacity;
#pragma warning disable 0169
		static Delegate GetGetOpacityHandler ()
		{
			if (cb_getOpacity == null)
				cb_getOpacity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetOpacity);
			return cb_getOpacity;
		}

		static int n_GetOpacity (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.StateDrawable __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.StateDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Opacity;
		}
#pragma warning restore 0169

		static IntPtr id_getOpacity;
		public override unsafe int Opacity {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal.drawable']/class[@name='StateDrawable']/method[@name='getOpacity' and count(parameter)=0]"
			[Register ("getOpacity", "()I", "GetGetOpacityHandler")]
			get {
				if (id_getOpacity == IntPtr.Zero)
					id_getOpacity = JNIEnv.GetMethodID (class_ref, "getOpacity", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getOpacity);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOpacity", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_draw_Landroid_graphics_Canvas_;
#pragma warning disable 0169
		static Delegate GetDraw_Landroid_graphics_Canvas_Handler ()
		{
			if (cb_draw_Landroid_graphics_Canvas_ == null)
				cb_draw_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Draw_Landroid_graphics_Canvas_);
			return cb_draw_Landroid_graphics_Canvas_;
		}

		static void n_Draw_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.StateDrawable __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.StateDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Draw (p0);
		}
#pragma warning restore 0169

		static IntPtr id_draw_Landroid_graphics_Canvas_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal.drawable']/class[@name='StateDrawable']/method[@name='draw' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("draw", "(Landroid/graphics/Canvas;)V", "GetDraw_Landroid_graphics_Canvas_Handler")]
		public override unsafe void Draw (global::Android.Graphics.Canvas p0)
		{
			if (id_draw_Landroid_graphics_Canvas_ == IntPtr.Zero)
				id_draw_Landroid_graphics_Canvas_ = JNIEnv.GetMethodID (class_ref, "draw", "(Landroid/graphics/Canvas;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_draw_Landroid_graphics_Canvas_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "draw", "(Landroid/graphics/Canvas;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setAlpha_I;
#pragma warning disable 0169
		static Delegate GetSetAlpha_IHandler ()
		{
			if (cb_setAlpha_I == null)
				cb_setAlpha_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetAlpha_I);
			return cb_setAlpha_I;
		}

		static void n_SetAlpha_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.StateDrawable __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.StateDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAlpha (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAlpha_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal.drawable']/class[@name='StateDrawable']/method[@name='setAlpha' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setAlpha", "(I)V", "GetSetAlpha_IHandler")]
		public override unsafe void SetAlpha (int p0)
		{
			if (id_setAlpha_I == IntPtr.Zero)
				id_setAlpha_I = JNIEnv.GetMethodID (class_ref, "setAlpha", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setAlpha_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAlpha", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setColorFilter_Landroid_graphics_ColorFilter_;
#pragma warning disable 0169
		static Delegate GetSetColorFilter_Landroid_graphics_ColorFilter_Handler ()
		{
			if (cb_setColorFilter_Landroid_graphics_ColorFilter_ == null)
				cb_setColorFilter_Landroid_graphics_ColorFilter_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetColorFilter_Landroid_graphics_ColorFilter_);
			return cb_setColorFilter_Landroid_graphics_ColorFilter_;
		}

		static void n_SetColorFilter_Landroid_graphics_ColorFilter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.StateDrawable __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.StateDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.ColorFilter p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.ColorFilter> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetColorFilter (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setColorFilter_Landroid_graphics_ColorFilter_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal.drawable']/class[@name='StateDrawable']/method[@name='setColorFilter' and count(parameter)=1 and parameter[1][@type='android.graphics.ColorFilter']]"
		[Register ("setColorFilter", "(Landroid/graphics/ColorFilter;)V", "GetSetColorFilter_Landroid_graphics_ColorFilter_Handler")]
		public override unsafe void SetColorFilter (global::Android.Graphics.ColorFilter p0)
		{
			if (id_setColorFilter_Landroid_graphics_ColorFilter_ == IntPtr.Zero)
				id_setColorFilter_Landroid_graphics_ColorFilter_ = JNIEnv.GetMethodID (class_ref, "setColorFilter", "(Landroid/graphics/ColorFilter;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setColorFilter_Landroid_graphics_ColorFilter_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setColorStateList_Landroid_content_res_ColorStateList_;
#pragma warning disable 0169
		static Delegate GetSetColorStateList_Landroid_content_res_ColorStateList_Handler ()
		{
			if (cb_setColorStateList_Landroid_content_res_ColorStateList_ == null)
				cb_setColorStateList_Landroid_content_res_ColorStateList_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetColorStateList_Landroid_content_res_ColorStateList_);
			return cb_setColorStateList_Landroid_content_res_ColorStateList_;
		}

		static void n_SetColorStateList_Landroid_content_res_ColorStateList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.StateDrawable __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.StateDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Res.ColorStateList p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Res.ColorStateList> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetColorStateList (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setColorStateList_Landroid_content_res_ColorStateList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal.drawable']/class[@name='StateDrawable']/method[@name='setColorStateList' and count(parameter)=1 and parameter[1][@type='android.content.res.ColorStateList']]"
		[Register ("setColorStateList", "(Landroid/content/res/ColorStateList;)V", "GetSetColorStateList_Landroid_content_res_ColorStateList_Handler")]
		public virtual unsafe void SetColorStateList (global::Android.Content.Res.ColorStateList p0)
		{
			if (id_setColorStateList_Landroid_content_res_ColorStateList_ == IntPtr.Zero)
				id_setColorStateList_Landroid_content_res_ColorStateList_ = JNIEnv.GetMethodID (class_ref, "setColorStateList", "(Landroid/content/res/ColorStateList;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setColorStateList_Landroid_content_res_ColorStateList_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setColorStateList", "(Landroid/content/res/ColorStateList;)V"), __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("org/adw/library/widgets/discreteseekbar/internal/drawable/StateDrawable", DoNotGenerateAcw=true)]
	internal partial class StateDrawableInvoker : StateDrawable {

		public StateDrawableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (StateDrawableInvoker); }
		}

	}

}
