using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Adw.Library.Widgets.Discreteseekbar.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal']/class[@name='Marker']"
	[global::Android.Runtime.Register ("org/adw/library/widgets/discreteseekbar/internal/Marker", DoNotGenerateAcw=true)]
	public partial class Marker : global::Android.Views.ViewGroup, global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.MarkerDrawable.IMarkerAnimationListener {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/adw/library/widgets/discreteseekbar/internal/Marker", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Marker); }
		}

		protected Marker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ILjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal']/class[@name='Marker']/constructor[@name='Marker' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;ILjava/lang/String;)V", "")]
		public unsafe Marker (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2, string p3)
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
				if (GetType () != typeof (Marker)) {
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

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal']/class[@name='Marker']/constructor[@name='Marker' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe Marker (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (Marker)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal']/class[@name='Marker']/constructor[@name='Marker' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe Marker (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (Marker)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal']/class[@name='Marker']/constructor[@name='Marker' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe Marker (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (Marker)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_getValue;
#pragma warning disable 0169
		static Delegate GetGetValueHandler ()
		{
			if (cb_getValue == null)
				cb_getValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetValue);
			return cb_getValue;
		}

		static IntPtr n_GetValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Marker __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Marker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return CharSequence.ToLocalJniHandle (__this.ValueFormatted);
		}
#pragma warning restore 0169

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
			global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Marker __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Marker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.ICharSequence p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ValueFormatted = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getValue;
		static IntPtr id_setValue_Ljava_lang_CharSequence_;
		public virtual unsafe global::Java.Lang.ICharSequence ValueFormatted {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal']/class[@name='Marker']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()Ljava/lang/CharSequence;", "GetGetValueHandler")]
			get {
				if (id_getValue == IntPtr.Zero)
					id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()Ljava/lang/CharSequence;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (JNIEnv.CallObjectMethod  (Handle, id_getValue), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getValue", "()Ljava/lang/CharSequence;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal']/class[@name='Marker']/method[@name='setValue' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
			[Register ("setValue", "(Ljava/lang/CharSequence;)V", "GetSetValue_Ljava_lang_CharSequence_Handler")]
			set {
				if (id_setValue_Ljava_lang_CharSequence_ == IntPtr.Zero)
					id_setValue_Ljava_lang_CharSequence_ = JNIEnv.GetMethodID (class_ref, "setValue", "(Ljava/lang/CharSequence;)V");
				IntPtr native_value = CharSequence.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setValue_Ljava_lang_CharSequence_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setValue", "(Ljava/lang/CharSequence;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		public string Value {
			get { return ValueFormatted == null ? null : ValueFormatted.ToString (); }
			set {
				global::Java.Lang.String jls = value == null ? null : new global::Java.Lang.String (value);
				ValueFormatted = jls;
				if (jls != null) jls.Dispose ();
			}
		}

		static Delegate cb_animateClose;
#pragma warning disable 0169
		static Delegate GetAnimateCloseHandler ()
		{
			if (cb_animateClose == null)
				cb_animateClose = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AnimateClose);
			return cb_animateClose;
		}

		static void n_AnimateClose (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Marker __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Marker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AnimateClose ();
		}
#pragma warning restore 0169

		static IntPtr id_animateClose;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal']/class[@name='Marker']/method[@name='animateClose' and count(parameter)=0]"
		[Register ("animateClose", "()V", "GetAnimateCloseHandler")]
		public virtual unsafe void AnimateClose ()
		{
			if (id_animateClose == IntPtr.Zero)
				id_animateClose = JNIEnv.GetMethodID (class_ref, "animateClose", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_animateClose);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "animateClose", "()V"));
			} finally {
			}
		}

		static Delegate cb_animateOpen;
#pragma warning disable 0169
		static Delegate GetAnimateOpenHandler ()
		{
			if (cb_animateOpen == null)
				cb_animateOpen = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AnimateOpen);
			return cb_animateOpen;
		}

		static void n_AnimateOpen (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Marker __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Marker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AnimateOpen ();
		}
#pragma warning restore 0169

		static IntPtr id_animateOpen;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal']/class[@name='Marker']/method[@name='animateOpen' and count(parameter)=0]"
		[Register ("animateOpen", "()V", "GetAnimateOpenHandler")]
		public virtual unsafe void AnimateOpen ()
		{
			if (id_animateOpen == IntPtr.Zero)
				id_animateOpen = JNIEnv.GetMethodID (class_ref, "animateOpen", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_animateOpen);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "animateOpen", "()V"));
			} finally {
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
			global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Marker __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Marker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnClosingComplete ();
		}
#pragma warning restore 0169

		static IntPtr id_onClosingComplete;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal']/class[@name='Marker']/method[@name='onClosingComplete' and count(parameter)=0]"
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

		static Delegate cb_onLayout_ZIIII;
#pragma warning disable 0169
		static Delegate GetOnLayout_ZIIIIHandler ()
		{
			if (cb_onLayout_ZIIII == null)
				cb_onLayout_ZIIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, int, int, int, int>) n_OnLayout_ZIIII);
			return cb_onLayout_ZIIII;
		}

		static void n_OnLayout_ZIIII (IntPtr jnienv, IntPtr native__this, bool p0, int p1, int p2, int p3, int p4)
		{
			global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Marker __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Marker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnLayout (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_onLayout_ZIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal']/class[@name='Marker']/method[@name='onLayout' and count(parameter)=5 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("onLayout", "(ZIIII)V", "GetOnLayout_ZIIIIHandler")]
		protected override unsafe void OnLayout (bool p0, int p1, int p2, int p3, int p4)
		{
			if (id_onLayout_ZIIII == IntPtr.Zero)
				id_onLayout_ZIIII = JNIEnv.GetMethodID (class_ref, "onLayout", "(ZIIII)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onLayout_ZIIII, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onLayout", "(ZIIII)V"), __args);
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
			global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Marker __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Marker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnOpeningComplete ();
		}
#pragma warning restore 0169

		static IntPtr id_onOpeningComplete;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal']/class[@name='Marker']/method[@name='onOpeningComplete' and count(parameter)=0]"
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

		static Delegate cb_resetSizes_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetResetSizes_Ljava_lang_String_Handler ()
		{
			if (cb_resetSizes_Ljava_lang_String_ == null)
				cb_resetSizes_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ResetSizes_Ljava_lang_String_);
			return cb_resetSizes_Ljava_lang_String_;
		}

		static void n_ResetSizes_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Marker __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Marker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ResetSizes (p0);
		}
#pragma warning restore 0169

		static IntPtr id_resetSizes_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal']/class[@name='Marker']/method[@name='resetSizes' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("resetSizes", "(Ljava/lang/String;)V", "GetResetSizes_Ljava_lang_String_Handler")]
		public virtual unsafe void ResetSizes (string p0)
		{
			if (id_resetSizes_Ljava_lang_String_ == IntPtr.Zero)
				id_resetSizes_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "resetSizes", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_resetSizes_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "resetSizes", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
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
			global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Marker __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.Internal.Marker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetColors (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setColors_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar.internal']/class[@name='Marker']/method[@name='setColors' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
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

	}
}
