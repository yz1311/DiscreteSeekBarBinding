using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Adw.Library.Widgets.Discreteseekbar.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal']/class[@name='PopupIndicator']"
	[global::Android.Runtime.Register ("org/adw/library/widgets/discreteseekbar/internal/PopupIndicator", DoNotGenerateAcw=true)]
	public partial class PopupIndicator : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal']/class[@name='PopupIndicator.Floater']"
		[global::Android.Runtime.Register ("org/adw/library/widgets/discreteseekbar/internal/PopupIndicator$Floater", DoNotGenerateAcw=true)]
		public partial class Floater : global::Android.Widget.FrameLayout, global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.MarkerDrawable.IMarkerAnimationListener {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/adw/library/widgets/discreteseekbar/internal/PopupIndicator$Floater", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Floater); }
			}

			protected Floater (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorg_adw_library_widgets_discreteseekbar_internal_PopupIndicator_Landroid_content_Context_Landroid_util_AttributeSet_ILjava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal']/class[@name='PopupIndicator.Floater']/constructor[@name='PopupIndicator.Floater' and count(parameter)=5 and parameter[1][@type='org.adw.library.widgets.discreteseekbar.internal.PopupIndicator'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='android.util.AttributeSet'] and parameter[4][@type='int'] and parameter[5][@type='java.lang.String']]"
			[Register (".ctor", "(Lorg/adw/library/widgets/discreteseekbar/internal/PopupIndicator;Landroid/content/Context;Landroid/util/AttributeSet;ILjava/lang/String;)V", "")]
			public unsafe Floater (global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.PopupIndicator __self, global::Android.Content.Context p1, global::Android.Util.IAttributeSet p2, int p3, string p4)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p4 = JNIEnv.NewString (p4);
				try {
					JValue* __args = stackalloc JValue [5];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (p3);
					__args [4] = new JValue (native_p4);
					if (GetType () != typeof (Floater)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/content/Context;Landroid/util/AttributeSet;ILjava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/content/Context;Landroid/util/AttributeSet;ILjava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_Lorg_adw_library_widgets_discreteseekbar_internal_PopupIndicator_Landroid_content_Context_Landroid_util_AttributeSet_ILjava_lang_String_ == IntPtr.Zero)
						id_ctor_Lorg_adw_library_widgets_discreteseekbar_internal_PopupIndicator_Landroid_content_Context_Landroid_util_AttributeSet_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/adw/library/widgets/discreteseekbar/internal/PopupIndicator;Landroid/content/Context;Landroid/util/AttributeSet;ILjava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_adw_library_widgets_discreteseekbar_internal_PopupIndicator_Landroid_content_Context_Landroid_util_AttributeSet_ILjava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_adw_library_widgets_discreteseekbar_internal_PopupIndicator_Landroid_content_Context_Landroid_util_AttributeSet_ILjava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p4);
				}
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
				global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.PopupIndicator.Floater __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.PopupIndicator.Floater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnClosingComplete ();
			}
#pragma warning restore 0169

			static IntPtr id_onClosingComplete;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal']/class[@name='PopupIndicator.Floater']/method[@name='onClosingComplete' and count(parameter)=0]"
			[Register ("onClosingComplete", "()V", "GetOnClosingCompleteHandler")]
			public virtual unsafe void OnClosingComplete ()
			{
				if (id_onClosingComplete == IntPtr.Zero)
					id_onClosingComplete = JNIEnv.GetMethodID (class_ref, "onClosingComplete", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onClosingComplete);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onClosingComplete", "()V"));
				} finally {
				}
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
				global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.PopupIndicator.Floater __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.PopupIndicator.Floater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnOpeningComplete ();
			}
#pragma warning restore 0169

			static IntPtr id_onOpeningComplete;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal']/class[@name='PopupIndicator.Floater']/method[@name='onOpeningComplete' and count(parameter)=0]"
			[Register ("onOpeningComplete", "()V", "GetOnOpeningCompleteHandler")]
			public virtual unsafe void OnOpeningComplete ()
			{
				if (id_onOpeningComplete == IntPtr.Zero)
					id_onOpeningComplete = JNIEnv.GetMethodID (class_ref, "onOpeningComplete", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onOpeningComplete);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onOpeningComplete", "()V"));
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
				global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.PopupIndicator.Floater __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.PopupIndicator.Floater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.SetColors (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_setColors_II;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal']/class[@name='PopupIndicator.Floater']/method[@name='setColors' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
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

			static Delegate cb_setFloatOffset_I;
#pragma warning disable 0169
			static Delegate GetSetFloatOffset_IHandler ()
			{
				if (cb_setFloatOffset_I == null)
					cb_setFloatOffset_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetFloatOffset_I);
				return cb_setFloatOffset_I;
			}

			static void n_SetFloatOffset_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.PopupIndicator.Floater __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.PopupIndicator.Floater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.SetFloatOffset (p0);
			}
#pragma warning restore 0169

			static IntPtr id_setFloatOffset_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal']/class[@name='PopupIndicator.Floater']/method[@name='setFloatOffset' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setFloatOffset", "(I)V", "GetSetFloatOffset_IHandler")]
			public virtual unsafe void SetFloatOffset (int p0)
			{
				if (id_setFloatOffset_I == IntPtr.Zero)
					id_setFloatOffset_I = JNIEnv.GetMethodID (class_ref, "setFloatOffset", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setFloatOffset_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFloatOffset", "(I)V"), __args);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/adw/library/widgets/discreteseekbar/internal/PopupIndicator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PopupIndicator); }
		}

		protected PopupIndicator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ILjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal']/class[@name='PopupIndicator']/constructor[@name='PopupIndicator' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;ILjava/lang/String;)V", "")]
		public unsafe PopupIndicator (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2, string p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				if (GetType () != typeof (PopupIndicator)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;ILjava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;ILjava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ILjava_lang_String_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;ILjava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ILjava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_isShowing;
#pragma warning disable 0169
		static Delegate GetIsShowingHandler ()
		{
			if (cb_isShowing == null)
				cb_isShowing = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsShowing);
			return cb_isShowing;
		}

		static bool n_IsShowing (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.PopupIndicator __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.PopupIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsShowing;
		}
#pragma warning restore 0169

		static IntPtr id_isShowing;
		public virtual unsafe bool IsShowing {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal']/class[@name='PopupIndicator']/method[@name='isShowing' and count(parameter)=0]"
			[Register ("isShowing", "()Z", "GetIsShowingHandler")]
			get {
				if (id_isShowing == IntPtr.Zero)
					id_isShowing = JNIEnv.GetMethodID (class_ref, "isShowing", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isShowing);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isShowing", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_dismiss;
#pragma warning disable 0169
		static Delegate GetDismissHandler ()
		{
			if (cb_dismiss == null)
				cb_dismiss = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Dismiss);
			return cb_dismiss;
		}

		static void n_Dismiss (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.PopupIndicator __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.PopupIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dismiss ();
		}
#pragma warning restore 0169

		static IntPtr id_dismiss;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal']/class[@name='PopupIndicator']/method[@name='dismiss' and count(parameter)=0]"
		[Register ("dismiss", "()V", "GetDismissHandler")]
		public virtual unsafe void Dismiss ()
		{
			if (id_dismiss == IntPtr.Zero)
				id_dismiss = JNIEnv.GetMethodID (class_ref, "dismiss", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_dismiss);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dismiss", "()V"));
			} finally {
			}
		}

		static Delegate cb_dismissComplete;
#pragma warning disable 0169
		static Delegate GetDismissCompleteHandler ()
		{
			if (cb_dismissComplete == null)
				cb_dismissComplete = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DismissComplete);
			return cb_dismissComplete;
		}

		static void n_DismissComplete (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.PopupIndicator __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.PopupIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DismissComplete ();
		}
#pragma warning restore 0169

		static IntPtr id_dismissComplete;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal']/class[@name='PopupIndicator']/method[@name='dismissComplete' and count(parameter)=0]"
		[Register ("dismissComplete", "()V", "GetDismissCompleteHandler")]
		public virtual unsafe void DismissComplete ()
		{
			if (id_dismissComplete == IntPtr.Zero)
				id_dismissComplete = JNIEnv.GetMethodID (class_ref, "dismissComplete", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_dismissComplete);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dismissComplete", "()V"));
			} finally {
			}
		}

		static Delegate cb_move_I;
#pragma warning disable 0169
		static Delegate GetMove_IHandler ()
		{
			if (cb_move_I == null)
				cb_move_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Move_I);
			return cb_move_I;
		}

		static void n_Move_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.PopupIndicator __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.PopupIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Move (p0);
		}
#pragma warning restore 0169

		static IntPtr id_move_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal']/class[@name='PopupIndicator']/method[@name='move' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("move", "(I)V", "GetMove_IHandler")]
		public virtual unsafe void Move (int p0)
		{
			if (id_move_I == IntPtr.Zero)
				id_move_I = JNIEnv.GetMethodID (class_ref, "move", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_move_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "move", "(I)V"), __args);
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
			global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.PopupIndicator __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.PopupIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetColors (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setColors_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal']/class[@name='PopupIndicator']/method[@name='setColors' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
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

		static Delegate cb_setListener_Lorg_adw_library_widgets_discreteseekbar_internal_drawable_MarkerDrawable_MarkerAnimationListener_;
#pragma warning disable 0169
		static Delegate GetSetListener_Lorg_adw_library_widgets_discreteseekbar_internal_drawable_MarkerDrawable_MarkerAnimationListener_Handler ()
		{
			if (cb_setListener_Lorg_adw_library_widgets_discreteseekbar_internal_drawable_MarkerDrawable_MarkerAnimationListener_ == null)
				cb_setListener_Lorg_adw_library_widgets_discreteseekbar_internal_drawable_MarkerDrawable_MarkerAnimationListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetListener_Lorg_adw_library_widgets_discreteseekbar_internal_drawable_MarkerDrawable_MarkerAnimationListener_);
			return cb_setListener_Lorg_adw_library_widgets_discreteseekbar_internal_drawable_MarkerDrawable_MarkerAnimationListener_;
		}

		static void n_SetListener_Lorg_adw_library_widgets_discreteseekbar_internal_drawable_MarkerDrawable_MarkerAnimationListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.PopupIndicator __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.PopupIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.MarkerDrawable.IMarkerAnimationListener p0 = (global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.MarkerDrawable.IMarkerAnimationListener)global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.MarkerDrawable.IMarkerAnimationListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setListener_Lorg_adw_library_widgets_discreteseekbar_internal_drawable_MarkerDrawable_MarkerAnimationListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal']/class[@name='PopupIndicator']/method[@name='setListener' and count(parameter)=1 and parameter[1][@type='org.adw.library.widgets.discreteseekbar.internal.drawable.MarkerDrawable.MarkerAnimationListener']]"
		[Register ("setListener", "(Lorg/adw/library/widgets/discreteseekbar/internal/drawable/MarkerDrawable$MarkerAnimationListener;)V", "GetSetListener_Lorg_adw_library_widgets_discreteseekbar_internal_drawable_MarkerDrawable_MarkerAnimationListener_Handler")]
		public virtual unsafe void SetListener (global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.MarkerDrawable.IMarkerAnimationListener p0)
		{
			if (id_setListener_Lorg_adw_library_widgets_discreteseekbar_internal_drawable_MarkerDrawable_MarkerAnimationListener_ == IntPtr.Zero)
				id_setListener_Lorg_adw_library_widgets_discreteseekbar_internal_drawable_MarkerDrawable_MarkerAnimationListener_ = JNIEnv.GetMethodID (class_ref, "setListener", "(Lorg/adw/library/widgets/discreteseekbar/internal/drawable/MarkerDrawable$MarkerAnimationListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setListener_Lorg_adw_library_widgets_discreteseekbar_internal_drawable_MarkerDrawable_MarkerAnimationListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setListener", "(Lorg/adw/library/widgets/discreteseekbar/internal/drawable/MarkerDrawable$MarkerAnimationListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setValue_Ljava_lang_CharSequence_;
#pragma warning disable 0169
		static Delegate GetSetValue_Ljava_lang_CharSequence_Handler ()
		{
			if (cb_setValue_Ljava_lang_CharSequence_ == null)
				cb_setValue_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetValue_Ljava_lang_CharSequence_);
			return cb_setValue_Ljava_lang_CharSequence_;
		}

		static void n_SetValue_Ljava_lang_CharSequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.PopupIndicator __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.PopupIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.ICharSequence p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetValue (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setValue_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal']/class[@name='PopupIndicator']/method[@name='setValue' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
		[Register ("setValue", "(Ljava/lang/CharSequence;)V", "GetSetValue_Ljava_lang_CharSequence_Handler")]
		public virtual unsafe void SetValue (global::Java.Lang.ICharSequence p0)
		{
			if (id_setValue_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_setValue_Ljava_lang_CharSequence_ = JNIEnv.GetMethodID (class_ref, "setValue", "(Ljava/lang/CharSequence;)V");
			IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setValue_Ljava_lang_CharSequence_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setValue", "(Ljava/lang/CharSequence;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		public void SetValue (string p0)
		{
			global::Java.Lang.String jls_p0 = p0 == null ? null : new global::Java.Lang.String (p0);
			SetValue (jls_p0);
			if (jls_p0 != null) jls_p0.Dispose ();
		}

		static Delegate cb_showIndicator_Landroid_view_View_Landroid_graphics_Rect_;
#pragma warning disable 0169
		static Delegate GetShowIndicator_Landroid_view_View_Landroid_graphics_Rect_Handler ()
		{
			if (cb_showIndicator_Landroid_view_View_Landroid_graphics_Rect_ == null)
				cb_showIndicator_Landroid_view_View_Landroid_graphics_Rect_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ShowIndicator_Landroid_view_View_Landroid_graphics_Rect_);
			return cb_showIndicator_Landroid_view_View_Landroid_graphics_Rect_;
		}

		static void n_ShowIndicator_Landroid_view_View_Landroid_graphics_Rect_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.PopupIndicator __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.PopupIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Rect p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ShowIndicator (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_showIndicator_Landroid_view_View_Landroid_graphics_Rect_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal']/class[@name='PopupIndicator']/method[@name='showIndicator' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.graphics.Rect']]"
		[Register ("showIndicator", "(Landroid/view/View;Landroid/graphics/Rect;)V", "GetShowIndicator_Landroid_view_View_Landroid_graphics_Rect_Handler")]
		public virtual unsafe void ShowIndicator (global::Android.Views.View p0, global::Android.Graphics.Rect p1)
		{
			if (id_showIndicator_Landroid_view_View_Landroid_graphics_Rect_ == IntPtr.Zero)
				id_showIndicator_Landroid_view_View_Landroid_graphics_Rect_ = JNIEnv.GetMethodID (class_ref, "showIndicator", "(Landroid/view/View;Landroid/graphics/Rect;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_showIndicator_Landroid_view_View_Landroid_graphics_Rect_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showIndicator", "(Landroid/view/View;Landroid/graphics/Rect;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_updateSizes_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateSizes_Ljava_lang_String_Handler ()
		{
			if (cb_updateSizes_Ljava_lang_String_ == null)
				cb_updateSizes_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UpdateSizes_Ljava_lang_String_);
			return cb_updateSizes_Ljava_lang_String_;
		}

		static void n_UpdateSizes_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.PopupIndicator __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.PopupIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateSizes (p0);
		}
#pragma warning restore 0169

		static IntPtr id_updateSizes_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal']/class[@name='PopupIndicator']/method[@name='updateSizes' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("updateSizes", "(Ljava/lang/String;)V", "GetUpdateSizes_Ljava_lang_String_Handler")]
		public virtual unsafe void UpdateSizes (string p0)
		{
			if (id_updateSizes_Ljava_lang_String_ == IntPtr.Zero)
				id_updateSizes_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "updateSizes", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_updateSizes_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateSizes", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

#region "Event implementation for Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.MarkerDrawable.IMarkerAnimationListener"

		global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.MarkerDrawable.IMarkerAnimationListenerImplementor __CreateIMarkerAnimationListenerImplementor ()
		{
			return new global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.MarkerDrawable.IMarkerAnimationListenerImplementor (this);
		}
#endregion
	}
}
