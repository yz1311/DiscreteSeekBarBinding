using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Adw.Library.Widgets.Discreteseekbar.Internal.Compat {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal.compat']/class[@name='SeekBarCompat']"
	[global::Android.Runtime.Register ("org/adw/library/widgets/discreteseekbar/internal/compat/SeekBarCompat", DoNotGenerateAcw=true)]
	public partial class SeekBarCompat : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/adw/library/widgets/discreteseekbar/internal/compat/SeekBarCompat", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SeekBarCompat); }
		}

		protected SeekBarCompat (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal.compat']/class[@name='SeekBarCompat']/constructor[@name='SeekBarCompat' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SeekBarCompat ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (SeekBarCompat)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_getRipple_Landroid_content_res_ColorStateList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal.compat']/class[@name='SeekBarCompat']/method[@name='getRipple' and count(parameter)=1 and parameter[1][@type='android.content.res.ColorStateList']]"
		[Register ("getRipple", "(Landroid/content/res/ColorStateList;)Landroid/graphics/drawable/Drawable;", "")]
		public static unsafe global::Android.Graphics.Drawables.Drawable GetRipple (global::Android.Content.Res.ColorStateList p0)
		{
			if (id_getRipple_Landroid_content_res_ColorStateList_ == IntPtr.Zero)
				id_getRipple_Landroid_content_res_ColorStateList_ = JNIEnv.GetStaticMethodID (class_ref, "getRipple", "(Landroid/content/res/ColorStateList;)Landroid/graphics/drawable/Drawable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Android.Graphics.Drawables.Drawable __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getRipple_Landroid_content_res_ColorStateList_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isHardwareAccelerated_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal.compat']/class[@name='SeekBarCompat']/method[@name='isHardwareAccelerated' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("isHardwareAccelerated", "(Landroid/view/View;)Z", "")]
		public static unsafe bool IsHardwareAccelerated (global::Android.Views.View p0)
		{
			if (id_isHardwareAccelerated_Landroid_view_View_ == IntPtr.Zero)
				id_isHardwareAccelerated_Landroid_view_View_ = JNIEnv.GetStaticMethodID (class_ref, "isHardwareAccelerated", "(Landroid/view/View;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isHardwareAccelerated_Landroid_view_View_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isInScrollingContainer_Landroid_view_ViewParent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal.compat']/class[@name='SeekBarCompat']/method[@name='isInScrollingContainer' and count(parameter)=1 and parameter[1][@type='android.view.ViewParent']]"
		[Register ("isInScrollingContainer", "(Landroid/view/ViewParent;)Z", "")]
		public static unsafe bool IsInScrollingContainer (global::Android.Views.IViewParent p0)
		{
			if (id_isInScrollingContainer_Landroid_view_ViewParent_ == IntPtr.Zero)
				id_isInScrollingContainer_Landroid_view_ViewParent_ = JNIEnv.GetStaticMethodID (class_ref, "isInScrollingContainer", "(Landroid/view/ViewParent;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isInScrollingContainer_Landroid_view_ViewParent_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_setBackground_Landroid_view_View_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal.compat']/class[@name='SeekBarCompat']/method[@name='setBackground' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.graphics.drawable.Drawable']]"
		[Register ("setBackground", "(Landroid/view/View;Landroid/graphics/drawable/Drawable;)V", "")]
		public static unsafe void SetBackground (global::Android.Views.View p0, global::Android.Graphics.Drawables.Drawable p1)
		{
			if (id_setBackground_Landroid_view_View_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_setBackground_Landroid_view_View_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetStaticMethodID (class_ref, "setBackground", "(Landroid/view/View;Landroid/graphics/drawable/Drawable;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setBackground_Landroid_view_View_Landroid_graphics_drawable_Drawable_, __args);
			} finally {
			}
		}

		static IntPtr id_setHotspotBounds_Landroid_graphics_drawable_Drawable_IIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal.compat']/class[@name='SeekBarCompat']/method[@name='setHotspotBounds' and count(parameter)=5 and parameter[1][@type='android.graphics.drawable.Drawable'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("setHotspotBounds", "(Landroid/graphics/drawable/Drawable;IIII)V", "")]
		public static unsafe void SetHotspotBounds (global::Android.Graphics.Drawables.Drawable p0, int p1, int p2, int p3, int p4)
		{
			if (id_setHotspotBounds_Landroid_graphics_drawable_Drawable_IIII == IntPtr.Zero)
				id_setHotspotBounds_Landroid_graphics_drawable_Drawable_IIII = JNIEnv.GetStaticMethodID (class_ref, "setHotspotBounds", "(Landroid/graphics/drawable/Drawable;IIII)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setHotspotBounds_Landroid_graphics_drawable_Drawable_IIII, __args);
			} finally {
			}
		}

		static IntPtr id_setOutlineProvider_Landroid_view_View_Lorg_adw_library_widgets_discreteseekbar_internal_drawable_MarkerDrawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal.compat']/class[@name='SeekBarCompat']/method[@name='setOutlineProvider' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='org.adw.library.widgets.discreteseekbar.internal.drawable.MarkerDrawable']]"
		[Register ("setOutlineProvider", "(Landroid/view/View;Lorg/adw/library/widgets/discreteseekbar/internal/drawable/MarkerDrawable;)V", "")]
		public static unsafe void SetOutlineProvider (global::Android.Views.View p0, global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.MarkerDrawable p1)
		{
			if (id_setOutlineProvider_Landroid_view_View_Lorg_adw_library_widgets_discreteseekbar_internal_drawable_MarkerDrawable_ == IntPtr.Zero)
				id_setOutlineProvider_Landroid_view_View_Lorg_adw_library_widgets_discreteseekbar_internal_drawable_MarkerDrawable_ = JNIEnv.GetStaticMethodID (class_ref, "setOutlineProvider", "(Landroid/view/View;Lorg/adw/library/widgets/discreteseekbar/internal/drawable/MarkerDrawable;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setOutlineProvider_Landroid_view_View_Lorg_adw_library_widgets_discreteseekbar_internal_drawable_MarkerDrawable_, __args);
			} finally {
			}
		}

		static IntPtr id_setTextDirection_Landroid_widget_TextView_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal.compat']/class[@name='SeekBarCompat']/method[@name='setTextDirection' and count(parameter)=2 and parameter[1][@type='android.widget.TextView'] and parameter[2][@type='int']]"
		[Register ("setTextDirection", "(Landroid/widget/TextView;I)V", "")]
		public static unsafe void SetTextDirection (global::Android.Widget.TextView p0, int p1)
		{
			if (id_setTextDirection_Landroid_widget_TextView_I == IntPtr.Zero)
				id_setTextDirection_Landroid_widget_TextView_I = JNIEnv.GetStaticMethodID (class_ref, "setTextDirection", "(Landroid/widget/TextView;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setTextDirection_Landroid_widget_TextView_I, __args);
			} finally {
			}
		}

	}
}
