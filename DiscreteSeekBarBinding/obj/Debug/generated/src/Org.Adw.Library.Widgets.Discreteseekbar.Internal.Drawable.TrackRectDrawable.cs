using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal.drawable']/class[@name='TrackRectDrawable']"
	[global::Android.Runtime.Register ("org/adw/library/widgets/discreteseekbar/internal/drawable/TrackRectDrawable", DoNotGenerateAcw=true)]
	public partial class TrackRectDrawable : global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.StateDrawable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/adw/library/widgets/discreteseekbar/internal/drawable/TrackRectDrawable", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TrackRectDrawable); }
		}

		protected TrackRectDrawable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_res_ColorStateList_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal.drawable']/class[@name='TrackRectDrawable']/constructor[@name='TrackRectDrawable' and count(parameter)=1 and parameter[1][@type='android.content.res.ColorStateList']]"
		[Register (".ctor", "(Landroid/content/res/ColorStateList;)V", "")]
		public unsafe TrackRectDrawable (global::Android.Content.Res.ColorStateList p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (TrackRectDrawable)) {
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

	}
}
