using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Adw.Library.Widgets.Discreteseekbar {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar']/class[@name='DiscreteSeekBar']"
	[global::Android.Runtime.Register ("org/adw/library/widgets/discreteseekbar/DiscreteSeekBar", DoNotGenerateAcw=true)]
	public partial class DiscreteSeekBar : global::Android.Views.View {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar']/class[@name='DiscreteSeekBar.CustomState']"
		[global::Android.Runtime.Register ("org/adw/library/widgets/discreteseekbar/DiscreteSeekBar$CustomState", DoNotGenerateAcw=true)]
		public partial class CustomState : global::Android.Views.View.BaseSavedState {


			static IntPtr CREATOR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar']/class[@name='DiscreteSeekBar.CustomState']/field[@name='CREATOR']"
			[Register ("CREATOR")]
			public static global::Android.OS.IParcelableCreator Creator {
				get {
					if (CREATOR_jfieldId == IntPtr.Zero)
						CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/adw/library/widgets/discreteseekbar/DiscreteSeekBar$CustomState", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CustomState); }
			}

			protected CustomState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Landroid_os_Parcelable_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar']/class[@name='DiscreteSeekBar.CustomState']/constructor[@name='DiscreteSeekBar.CustomState' and count(parameter)=1 and parameter[1][@type='android.os.Parcelable']]"
			[Register (".ctor", "(Landroid/os/Parcelable;)V", "")]
			public unsafe CustomState (global::Android.OS.IParcelable p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (GetType () != typeof (CustomState)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/os/Parcelable;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/os/Parcelable;)V", __args);
						return;
					}

					if (id_ctor_Landroid_os_Parcelable_ == IntPtr.Zero)
						id_ctor_Landroid_os_Parcelable_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/os/Parcelable;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_os_Parcelable_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_os_Parcelable_, __args);
				} finally {
				}
			}

			static IntPtr id_ctor_Landroid_os_Parcel_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar']/class[@name='DiscreteSeekBar.CustomState']/constructor[@name='DiscreteSeekBar.CustomState' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
			[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
			public unsafe CustomState (global::Android.OS.Parcel p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (GetType () != typeof (CustomState)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/os/Parcel;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/os/Parcel;)V", __args);
						return;
					}

					if (id_ctor_Landroid_os_Parcel_ == IntPtr.Zero)
						id_ctor_Landroid_os_Parcel_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/os/Parcel;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_os_Parcel_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_os_Parcel_, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar']/class[@name='DiscreteSeekBar.DefaultNumericTransformer']"
		[global::Android.Runtime.Register ("org/adw/library/widgets/discreteseekbar/DiscreteSeekBar$DefaultNumericTransformer", DoNotGenerateAcw=true)]
		public partial class DefaultNumericTransformer : global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar.NumericTransformer {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/adw/library/widgets/discreteseekbar/DiscreteSeekBar$DefaultNumericTransformer", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DefaultNumericTransformer); }
			}

			protected DefaultNumericTransformer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_transform_I;
#pragma warning disable 0169
			static Delegate GetTransform_IHandler ()
			{
				if (cb_transform_I == null)
					cb_transform_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_Transform_I);
				return cb_transform_I;
			}

			static int n_Transform_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar.DefaultNumericTransformer __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar.DefaultNumericTransformer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Transform (p0);
			}
#pragma warning restore 0169

			static IntPtr id_transform_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar']/class[@name='DiscreteSeekBar.DefaultNumericTransformer']/method[@name='transform' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("transform", "(I)I", "GetTransform_IHandler")]
			public override unsafe int Transform (int p0)
			{
				if (id_transform_I == IntPtr.Zero)
					id_transform_I = JNIEnv.GetMethodID (class_ref, "transform", "(I)I");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_transform_I, __args);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "transform", "(I)I"), __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar']/class[@name='DiscreteSeekBar.NumericTransformer']"
		[global::Android.Runtime.Register ("org/adw/library/widgets/discreteseekbar/DiscreteSeekBar$NumericTransformer", DoNotGenerateAcw=true)]
		public abstract partial class NumericTransformer : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/adw/library/widgets/discreteseekbar/DiscreteSeekBar$NumericTransformer", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (NumericTransformer); }
			}

			protected NumericTransformer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar']/class[@name='DiscreteSeekBar.NumericTransformer']/constructor[@name='DiscreteSeekBar.NumericTransformer' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe NumericTransformer ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (NumericTransformer)) {
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

			static Delegate cb_transform_I;
#pragma warning disable 0169
			static Delegate GetTransform_IHandler ()
			{
				if (cb_transform_I == null)
					cb_transform_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_Transform_I);
				return cb_transform_I;
			}

			static int n_Transform_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar.NumericTransformer __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar.NumericTransformer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Transform (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar']/class[@name='DiscreteSeekBar.NumericTransformer']/method[@name='transform' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("transform", "(I)I", "GetTransform_IHandler")]
			public abstract int Transform (int p0);

			static Delegate cb_transformToString_I;
#pragma warning disable 0169
			static Delegate GetTransformToString_IHandler ()
			{
				if (cb_transformToString_I == null)
					cb_transformToString_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_TransformToString_I);
				return cb_transformToString_I;
			}

			static IntPtr n_TransformToString_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar.NumericTransformer __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar.NumericTransformer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.TransformToString (p0));
			}
#pragma warning restore 0169

			static IntPtr id_transformToString_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar']/class[@name='DiscreteSeekBar.NumericTransformer']/method[@name='transformToString' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("transformToString", "(I)Ljava/lang/String;", "GetTransformToString_IHandler")]
			public virtual unsafe string TransformToString (int p0)
			{
				if (id_transformToString_I == IntPtr.Zero)
					id_transformToString_I = JNIEnv.GetMethodID (class_ref, "transformToString", "(I)Ljava/lang/String;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_transformToString_I, __args), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "transformToString", "(I)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_useStringTransform;
#pragma warning disable 0169
			static Delegate GetUseStringTransformHandler ()
			{
				if (cb_useStringTransform == null)
					cb_useStringTransform = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_UseStringTransform);
				return cb_useStringTransform;
			}

			static bool n_UseStringTransform (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar.NumericTransformer __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar.NumericTransformer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.UseStringTransform ();
			}
#pragma warning restore 0169

			static IntPtr id_useStringTransform;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar']/class[@name='DiscreteSeekBar.NumericTransformer']/method[@name='useStringTransform' and count(parameter)=0]"
			[Register ("useStringTransform", "()Z", "GetUseStringTransformHandler")]
			public virtual unsafe bool UseStringTransform ()
			{
				if (id_useStringTransform == IntPtr.Zero)
					id_useStringTransform = JNIEnv.GetMethodID (class_ref, "useStringTransform", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_useStringTransform);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "useStringTransform", "()Z"));
				} finally {
				}
			}

		}

		[global::Android.Runtime.Register ("org/adw/library/widgets/discreteseekbar/DiscreteSeekBar$NumericTransformer", DoNotGenerateAcw=true)]
		internal partial class NumericTransformerInvoker : NumericTransformer {

			public NumericTransformerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (NumericTransformerInvoker); }
			}

			static IntPtr id_transform_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar']/class[@name='DiscreteSeekBar.NumericTransformer']/method[@name='transform' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("transform", "(I)I", "GetTransform_IHandler")]
			public override unsafe int Transform (int p0)
			{
				if (id_transform_I == IntPtr.Zero)
					id_transform_I = JNIEnv.GetMethodID (class_ref, "transform", "(I)I");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					return JNIEnv.CallIntMethod  (Handle, id_transform_I, __args);
				} finally {
				}
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar']/interface[@name='DiscreteSeekBar.OnProgressChangeListener']"
		[Register ("org/adw/library/widgets/discreteseekbar/DiscreteSeekBar$OnProgressChangeListener", "", "Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar/IOnProgressChangeListenerInvoker")]
		public partial interface IOnProgressChangeListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar']/interface[@name='DiscreteSeekBar.OnProgressChangeListener']/method[@name='onProgressChanged' and count(parameter)=3 and parameter[1][@type='org.adw.library.widgets.discreteseekbar.DiscreteSeekBar'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
			[Register ("onProgressChanged", "(Lorg/adw/library/widgets/discreteseekbar/DiscreteSeekBar;IZ)V", "GetOnProgressChanged_Lorg_adw_library_widgets_discreteseekbar_DiscreteSeekBar_IZHandler:Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar/IOnProgressChangeListenerInvoker, DiscreteSeekBarBinding")]
			void OnProgressChanged (global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar p0, int p1, bool p2);

			// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar']/interface[@name='DiscreteSeekBar.OnProgressChangeListener']/method[@name='onStartTrackingTouch' and count(parameter)=1 and parameter[1][@type='org.adw.library.widgets.discreteseekbar.DiscreteSeekBar']]"
			[Register ("onStartTrackingTouch", "(Lorg/adw/library/widgets/discreteseekbar/DiscreteSeekBar;)V", "GetOnStartTrackingTouch_Lorg_adw_library_widgets_discreteseekbar_DiscreteSeekBar_Handler:Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar/IOnProgressChangeListenerInvoker, DiscreteSeekBarBinding")]
			void OnStartTrackingTouch (global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar']/interface[@name='DiscreteSeekBar.OnProgressChangeListener']/method[@name='onStopTrackingTouch' and count(parameter)=1 and parameter[1][@type='org.adw.library.widgets.discreteseekbar.DiscreteSeekBar']]"
			[Register ("onStopTrackingTouch", "(Lorg/adw/library/widgets/discreteseekbar/DiscreteSeekBar;)V", "GetOnStopTrackingTouch_Lorg_adw_library_widgets_discreteseekbar_DiscreteSeekBar_Handler:Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar/IOnProgressChangeListenerInvoker, DiscreteSeekBarBinding")]
			void OnStopTrackingTouch (global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar p0);

		}

		[global::Android.Runtime.Register ("org/adw/library/widgets/discreteseekbar/DiscreteSeekBar$OnProgressChangeListener", DoNotGenerateAcw=true)]
		internal class IOnProgressChangeListenerInvoker : global::Java.Lang.Object, IOnProgressChangeListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("org/adw/library/widgets/discreteseekbar/DiscreteSeekBar$OnProgressChangeListener");
			IntPtr class_ref;

			public static IOnProgressChangeListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnProgressChangeListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "org.adw.library.widgets.discreteseekbar.DiscreteSeekBar.OnProgressChangeListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnProgressChangeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnProgressChangeListenerInvoker); }
			}

			static Delegate cb_onProgressChanged_Lorg_adw_library_widgets_discreteseekbar_DiscreteSeekBar_IZ;
#pragma warning disable 0169
			static Delegate GetOnProgressChanged_Lorg_adw_library_widgets_discreteseekbar_DiscreteSeekBar_IZHandler ()
			{
				if (cb_onProgressChanged_Lorg_adw_library_widgets_discreteseekbar_DiscreteSeekBar_IZ == null)
					cb_onProgressChanged_Lorg_adw_library_widgets_discreteseekbar_DiscreteSeekBar_IZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, bool>) n_OnProgressChanged_Lorg_adw_library_widgets_discreteseekbar_DiscreteSeekBar_IZ);
				return cb_onProgressChanged_Lorg_adw_library_widgets_discreteseekbar_DiscreteSeekBar_IZ;
			}

			static void n_OnProgressChanged_Lorg_adw_library_widgets_discreteseekbar_DiscreteSeekBar_IZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, bool p2)
			{
				global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar.IOnProgressChangeListener __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar.IOnProgressChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar p0 = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnProgressChanged (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_onProgressChanged_Lorg_adw_library_widgets_discreteseekbar_DiscreteSeekBar_IZ;
			public unsafe void OnProgressChanged (global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar p0, int p1, bool p2)
			{
				if (id_onProgressChanged_Lorg_adw_library_widgets_discreteseekbar_DiscreteSeekBar_IZ == IntPtr.Zero)
					id_onProgressChanged_Lorg_adw_library_widgets_discreteseekbar_DiscreteSeekBar_IZ = JNIEnv.GetMethodID (class_ref, "onProgressChanged", "(Lorg/adw/library/widgets/discreteseekbar/DiscreteSeekBar;IZ)V");
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (Handle, id_onProgressChanged_Lorg_adw_library_widgets_discreteseekbar_DiscreteSeekBar_IZ, __args);
			}

			static Delegate cb_onStartTrackingTouch_Lorg_adw_library_widgets_discreteseekbar_DiscreteSeekBar_;
#pragma warning disable 0169
			static Delegate GetOnStartTrackingTouch_Lorg_adw_library_widgets_discreteseekbar_DiscreteSeekBar_Handler ()
			{
				if (cb_onStartTrackingTouch_Lorg_adw_library_widgets_discreteseekbar_DiscreteSeekBar_ == null)
					cb_onStartTrackingTouch_Lorg_adw_library_widgets_discreteseekbar_DiscreteSeekBar_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnStartTrackingTouch_Lorg_adw_library_widgets_discreteseekbar_DiscreteSeekBar_);
				return cb_onStartTrackingTouch_Lorg_adw_library_widgets_discreteseekbar_DiscreteSeekBar_;
			}

			static void n_OnStartTrackingTouch_Lorg_adw_library_widgets_discreteseekbar_DiscreteSeekBar_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar.IOnProgressChangeListener __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar.IOnProgressChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar p0 = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnStartTrackingTouch (p0);
			}
#pragma warning restore 0169

			IntPtr id_onStartTrackingTouch_Lorg_adw_library_widgets_discreteseekbar_DiscreteSeekBar_;
			public unsafe void OnStartTrackingTouch (global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar p0)
			{
				if (id_onStartTrackingTouch_Lorg_adw_library_widgets_discreteseekbar_DiscreteSeekBar_ == IntPtr.Zero)
					id_onStartTrackingTouch_Lorg_adw_library_widgets_discreteseekbar_DiscreteSeekBar_ = JNIEnv.GetMethodID (class_ref, "onStartTrackingTouch", "(Lorg/adw/library/widgets/discreteseekbar/DiscreteSeekBar;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_onStartTrackingTouch_Lorg_adw_library_widgets_discreteseekbar_DiscreteSeekBar_, __args);
			}

			static Delegate cb_onStopTrackingTouch_Lorg_adw_library_widgets_discreteseekbar_DiscreteSeekBar_;
#pragma warning disable 0169
			static Delegate GetOnStopTrackingTouch_Lorg_adw_library_widgets_discreteseekbar_DiscreteSeekBar_Handler ()
			{
				if (cb_onStopTrackingTouch_Lorg_adw_library_widgets_discreteseekbar_DiscreteSeekBar_ == null)
					cb_onStopTrackingTouch_Lorg_adw_library_widgets_discreteseekbar_DiscreteSeekBar_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnStopTrackingTouch_Lorg_adw_library_widgets_discreteseekbar_DiscreteSeekBar_);
				return cb_onStopTrackingTouch_Lorg_adw_library_widgets_discreteseekbar_DiscreteSeekBar_;
			}

			static void n_OnStopTrackingTouch_Lorg_adw_library_widgets_discreteseekbar_DiscreteSeekBar_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar.IOnProgressChangeListener __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar.IOnProgressChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar p0 = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnStopTrackingTouch (p0);
			}
#pragma warning restore 0169

			IntPtr id_onStopTrackingTouch_Lorg_adw_library_widgets_discreteseekbar_DiscreteSeekBar_;
			public unsafe void OnStopTrackingTouch (global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar p0)
			{
				if (id_onStopTrackingTouch_Lorg_adw_library_widgets_discreteseekbar_DiscreteSeekBar_ == IntPtr.Zero)
					id_onStopTrackingTouch_Lorg_adw_library_widgets_discreteseekbar_DiscreteSeekBar_ = JNIEnv.GetMethodID (class_ref, "onStopTrackingTouch", "(Lorg/adw/library/widgets/discreteseekbar/DiscreteSeekBar;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_onStopTrackingTouch_Lorg_adw_library_widgets_discreteseekbar_DiscreteSeekBar_, __args);
			}

		}

		public partial class ProgressChangedEventArgs : global::System.EventArgs {

			public ProgressChangedEventArgs (global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar p0, int p1, bool p2)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
			}

			global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar p0;
			public global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar P0 {
				get { return p0; }
			}

			int p1;
			public int P1 {
				get { return p1; }
			}

			bool p2;
			public bool P2 {
				get { return p2; }
			}
		}

		public partial class StartTrackingTouchEventArgs : global::System.EventArgs {

			public StartTrackingTouchEventArgs (global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar p0)
			{
				this.p0 = p0;
			}

			global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar p0;
			public global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar P0 {
				get { return p0; }
			}
		}

		public partial class StopTrackingTouchEventArgs : global::System.EventArgs {

			public StopTrackingTouchEventArgs (global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar p0)
			{
				this.p0 = p0;
			}

			global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar p0;
			public global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/org/adw/library/widgets/discreteseekbar/DiscreteSeekBar_OnProgressChangeListenerImplementor")]
		internal sealed partial class IOnProgressChangeListenerImplementor : global::Java.Lang.Object, IOnProgressChangeListener {

			object sender;

			public IOnProgressChangeListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/org/adw/library/widgets/discreteseekbar/DiscreteSeekBar_OnProgressChangeListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<ProgressChangedEventArgs> OnProgressChangedHandler;
#pragma warning restore 0649

			public void OnProgressChanged (global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar p0, int p1, bool p2)
			{
				var __h = OnProgressChangedHandler;
				if (__h != null)
					__h (sender, new ProgressChangedEventArgs (p0, p1, p2));
			}
#pragma warning disable 0649
			public EventHandler<StartTrackingTouchEventArgs> OnStartTrackingTouchHandler;
#pragma warning restore 0649

			public void OnStartTrackingTouch (global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar p0)
			{
				var __h = OnStartTrackingTouchHandler;
				if (__h != null)
					__h (sender, new StartTrackingTouchEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<StopTrackingTouchEventArgs> OnStopTrackingTouchHandler;
#pragma warning restore 0649

			public void OnStopTrackingTouch (global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar p0)
			{
				var __h = OnStopTrackingTouchHandler;
				if (__h != null)
					__h (sender, new StopTrackingTouchEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnProgressChangeListenerImplementor value)
			{
				return value.OnProgressChangedHandler == null && value.OnStartTrackingTouchHandler == null && value.OnStopTrackingTouchHandler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/adw/library/widgets/discreteseekbar/DiscreteSeekBar", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DiscreteSeekBar); }
		}

		protected DiscreteSeekBar (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar']/class[@name='DiscreteSeekBar']/constructor[@name='DiscreteSeekBar' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe DiscreteSeekBar (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (DiscreteSeekBar)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar']/class[@name='DiscreteSeekBar']/constructor[@name='DiscreteSeekBar' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe DiscreteSeekBar (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (DiscreteSeekBar)) {
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

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar']/class[@name='DiscreteSeekBar']/constructor[@name='DiscreteSeekBar' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe DiscreteSeekBar (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (DiscreteSeekBar)) {
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

		static Delegate cb_isRtl;
#pragma warning disable 0169
		static Delegate GetIsRtlHandler ()
		{
			if (cb_isRtl == null)
				cb_isRtl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRtl);
			return cb_isRtl;
		}

		static bool n_IsRtl (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRtl;
		}
#pragma warning restore 0169

		static IntPtr id_isRtl;
		public virtual unsafe bool IsRtl {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar']/class[@name='DiscreteSeekBar']/method[@name='isRtl' and count(parameter)=0]"
			[Register ("isRtl", "()Z", "GetIsRtlHandler")]
			get {
				if (id_isRtl == IntPtr.Zero)
					id_isRtl = JNIEnv.GetMethodID (class_ref, "isRtl", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isRtl);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isRtl", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getMax;
#pragma warning disable 0169
		static Delegate GetGetMaxHandler ()
		{
			if (cb_getMax == null)
				cb_getMax = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMax);
			return cb_getMax;
		}

		static int n_GetMax (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Max;
		}
#pragma warning restore 0169

		static Delegate cb_setMax_I;
#pragma warning disable 0169
		static Delegate GetSetMax_IHandler ()
		{
			if (cb_setMax_I == null)
				cb_setMax_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMax_I);
			return cb_setMax_I;
		}

		static void n_SetMax_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Max = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMax;
		static IntPtr id_setMax_I;
		public virtual unsafe int Max {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar']/class[@name='DiscreteSeekBar']/method[@name='getMax' and count(parameter)=0]"
			[Register ("getMax", "()I", "GetGetMaxHandler")]
			get {
				if (id_getMax == IntPtr.Zero)
					id_getMax = JNIEnv.GetMethodID (class_ref, "getMax", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getMax);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMax", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar']/class[@name='DiscreteSeekBar']/method[@name='setMax' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMax", "(I)V", "GetSetMax_IHandler")]
			set {
				if (id_setMax_I == IntPtr.Zero)
					id_setMax_I = JNIEnv.GetMethodID (class_ref, "setMax", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setMax_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMax", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMin;
#pragma warning disable 0169
		static Delegate GetGetMinHandler ()
		{
			if (cb_getMin == null)
				cb_getMin = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMin);
			return cb_getMin;
		}

		static int n_GetMin (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Min;
		}
#pragma warning restore 0169

		static Delegate cb_setMin_I;
#pragma warning disable 0169
		static Delegate GetSetMin_IHandler ()
		{
			if (cb_setMin_I == null)
				cb_setMin_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMin_I);
			return cb_setMin_I;
		}

		static void n_SetMin_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Min = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMin;
		static IntPtr id_setMin_I;
		public virtual unsafe int Min {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar']/class[@name='DiscreteSeekBar']/method[@name='getMin' and count(parameter)=0]"
			[Register ("getMin", "()I", "GetGetMinHandler")]
			get {
				if (id_getMin == IntPtr.Zero)
					id_getMin = JNIEnv.GetMethodID (class_ref, "getMin", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getMin);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMin", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar']/class[@name='DiscreteSeekBar']/method[@name='setMin' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMin", "(I)V", "GetSetMin_IHandler")]
			set {
				if (id_setMin_I == IntPtr.Zero)
					id_setMin_I = JNIEnv.GetMethodID (class_ref, "setMin", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setMin_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMin", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getProgress;
#pragma warning disable 0169
		static Delegate GetGetProgressHandler ()
		{
			if (cb_getProgress == null)
				cb_getProgress = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetProgress);
			return cb_getProgress;
		}

		static int n_GetProgress (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Progress;
		}
#pragma warning restore 0169

		static Delegate cb_setProgress_I;
#pragma warning disable 0169
		static Delegate GetSetProgress_IHandler ()
		{
			if (cb_setProgress_I == null)
				cb_setProgress_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetProgress_I);
			return cb_setProgress_I;
		}

		static void n_SetProgress_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Progress = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getProgress;
		static IntPtr id_setProgress_I;
		public virtual unsafe int Progress {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar']/class[@name='DiscreteSeekBar']/method[@name='getProgress' and count(parameter)=0]"
			[Register ("getProgress", "()I", "GetGetProgressHandler")]
			get {
				if (id_getProgress == IntPtr.Zero)
					id_getProgress = JNIEnv.GetMethodID (class_ref, "getProgress", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getProgress);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getProgress", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar']/class[@name='DiscreteSeekBar']/method[@name='setProgress' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setProgress", "(I)V", "GetSetProgress_IHandler")]
			set {
				if (id_setProgress_I == IntPtr.Zero)
					id_setProgress_I = JNIEnv.GetMethodID (class_ref, "setProgress", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setProgress_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setProgress", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getNumericTransformer;
#pragma warning disable 0169
		static Delegate GetGetNumericTransformerHandler ()
		{
			if (cb_getNumericTransformer == null)
				cb_getNumericTransformer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNumericTransformer);
			return cb_getNumericTransformer;
		}

		static IntPtr n_GetNumericTransformer (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetNumericTransformer ());
		}
#pragma warning restore 0169

		static IntPtr id_getNumericTransformer;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar']/class[@name='DiscreteSeekBar']/method[@name='getNumericTransformer' and count(parameter)=0]"
		[Register ("getNumericTransformer", "()Lorg/adw/library/widgets/discreteseekbar/DiscreteSeekBar$NumericTransformer;", "GetGetNumericTransformerHandler")]
		public virtual unsafe global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar.NumericTransformer GetNumericTransformer ()
		{
			if (id_getNumericTransformer == IntPtr.Zero)
				id_getNumericTransformer = JNIEnv.GetMethodID (class_ref, "getNumericTransformer", "()Lorg/adw/library/widgets/discreteseekbar/DiscreteSeekBar$NumericTransformer;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar.NumericTransformer> (JNIEnv.CallObjectMethod  (Handle, id_getNumericTransformer), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar.NumericTransformer> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNumericTransformer", "()Lorg/adw/library/widgets/discreteseekbar/DiscreteSeekBar$NumericTransformer;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_onHideBubble;
#pragma warning disable 0169
		static Delegate GetOnHideBubbleHandler ()
		{
			if (cb_onHideBubble == null)
				cb_onHideBubble = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnHideBubble);
			return cb_onHideBubble;
		}

		static void n_OnHideBubble (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnHideBubble ();
		}
#pragma warning restore 0169

		static IntPtr id_onHideBubble;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar']/class[@name='DiscreteSeekBar']/method[@name='onHideBubble' and count(parameter)=0]"
		[Register ("onHideBubble", "()V", "GetOnHideBubbleHandler")]
		protected virtual unsafe void OnHideBubble ()
		{
			if (id_onHideBubble == IntPtr.Zero)
				id_onHideBubble = JNIEnv.GetMethodID (class_ref, "onHideBubble", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onHideBubble);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onHideBubble", "()V"));
			} finally {
			}
		}

		static Delegate cb_onShowBubble;
#pragma warning disable 0169
		static Delegate GetOnShowBubbleHandler ()
		{
			if (cb_onShowBubble == null)
				cb_onShowBubble = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnShowBubble);
			return cb_onShowBubble;
		}

		static void n_OnShowBubble (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnShowBubble ();
		}
#pragma warning restore 0169

		static IntPtr id_onShowBubble;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar']/class[@name='DiscreteSeekBar']/method[@name='onShowBubble' and count(parameter)=0]"
		[Register ("onShowBubble", "()V", "GetOnShowBubbleHandler")]
		protected virtual unsafe void OnShowBubble ()
		{
			if (id_onShowBubble == IntPtr.Zero)
				id_onShowBubble = JNIEnv.GetMethodID (class_ref, "onShowBubble", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onShowBubble);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onShowBubble", "()V"));
			} finally {
			}
		}

		static Delegate cb_onValueChanged_I;
#pragma warning disable 0169
		static Delegate GetOnValueChanged_IHandler ()
		{
			if (cb_onValueChanged_I == null)
				cb_onValueChanged_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnValueChanged_I);
			return cb_onValueChanged_I;
		}

		static void n_OnValueChanged_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnValueChanged (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onValueChanged_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar']/class[@name='DiscreteSeekBar']/method[@name='onValueChanged' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onValueChanged", "(I)V", "GetOnValueChanged_IHandler")]
		protected virtual unsafe void OnValueChanged (int p0)
		{
			if (id_onValueChanged_I == IntPtr.Zero)
				id_onValueChanged_I = JNIEnv.GetMethodID (class_ref, "onValueChanged", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onValueChanged_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onValueChanged", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setIndicatorFormatter_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetIndicatorFormatter_Ljava_lang_String_Handler ()
		{
			if (cb_setIndicatorFormatter_Ljava_lang_String_ == null)
				cb_setIndicatorFormatter_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIndicatorFormatter_Ljava_lang_String_);
			return cb_setIndicatorFormatter_Ljava_lang_String_;
		}

		static void n_SetIndicatorFormatter_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetIndicatorFormatter (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setIndicatorFormatter_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar']/class[@name='DiscreteSeekBar']/method[@name='setIndicatorFormatter' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setIndicatorFormatter", "(Ljava/lang/String;)V", "GetSetIndicatorFormatter_Ljava_lang_String_Handler")]
		public virtual unsafe void SetIndicatorFormatter (string p0)
		{
			if (id_setIndicatorFormatter_Ljava_lang_String_ == IntPtr.Zero)
				id_setIndicatorFormatter_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setIndicatorFormatter", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setIndicatorFormatter_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIndicatorFormatter", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setIndicatorPopupEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetIndicatorPopupEnabled_ZHandler ()
		{
			if (cb_setIndicatorPopupEnabled_Z == null)
				cb_setIndicatorPopupEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetIndicatorPopupEnabled_Z);
			return cb_setIndicatorPopupEnabled_Z;
		}

		static void n_SetIndicatorPopupEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetIndicatorPopupEnabled (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setIndicatorPopupEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar']/class[@name='DiscreteSeekBar']/method[@name='setIndicatorPopupEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setIndicatorPopupEnabled", "(Z)V", "GetSetIndicatorPopupEnabled_ZHandler")]
		public virtual unsafe void SetIndicatorPopupEnabled (bool p0)
		{
			if (id_setIndicatorPopupEnabled_Z == IntPtr.Zero)
				id_setIndicatorPopupEnabled_Z = JNIEnv.GetMethodID (class_ref, "setIndicatorPopupEnabled", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setIndicatorPopupEnabled_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIndicatorPopupEnabled", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setNumericTransformer_Lorg_adw_library_widgets_discreteseekbar_DiscreteSeekBar_NumericTransformer_;
#pragma warning disable 0169
		static Delegate GetSetNumericTransformer_Lorg_adw_library_widgets_discreteseekbar_DiscreteSeekBar_NumericTransformer_Handler ()
		{
			if (cb_setNumericTransformer_Lorg_adw_library_widgets_discreteseekbar_DiscreteSeekBar_NumericTransformer_ == null)
				cb_setNumericTransformer_Lorg_adw_library_widgets_discreteseekbar_DiscreteSeekBar_NumericTransformer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNumericTransformer_Lorg_adw_library_widgets_discreteseekbar_DiscreteSeekBar_NumericTransformer_);
			return cb_setNumericTransformer_Lorg_adw_library_widgets_discreteseekbar_DiscreteSeekBar_NumericTransformer_;
		}

		static void n_SetNumericTransformer_Lorg_adw_library_widgets_discreteseekbar_DiscreteSeekBar_NumericTransformer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar.NumericTransformer p0 = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar.NumericTransformer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetNumericTransformer (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setNumericTransformer_Lorg_adw_library_widgets_discreteseekbar_DiscreteSeekBar_NumericTransformer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar']/class[@name='DiscreteSeekBar']/method[@name='setNumericTransformer' and count(parameter)=1 and parameter[1][@type='org.adw.library.widgets.discreteseekbar.DiscreteSeekBar.NumericTransformer']]"
		[Register ("setNumericTransformer", "(Lorg/adw/library/widgets/discreteseekbar/DiscreteSeekBar$NumericTransformer;)V", "GetSetNumericTransformer_Lorg_adw_library_widgets_discreteseekbar_DiscreteSeekBar_NumericTransformer_Handler")]
		public virtual unsafe void SetNumericTransformer (global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar.NumericTransformer p0)
		{
			if (id_setNumericTransformer_Lorg_adw_library_widgets_discreteseekbar_DiscreteSeekBar_NumericTransformer_ == IntPtr.Zero)
				id_setNumericTransformer_Lorg_adw_library_widgets_discreteseekbar_DiscreteSeekBar_NumericTransformer_ = JNIEnv.GetMethodID (class_ref, "setNumericTransformer", "(Lorg/adw/library/widgets/discreteseekbar/DiscreteSeekBar$NumericTransformer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setNumericTransformer_Lorg_adw_library_widgets_discreteseekbar_DiscreteSeekBar_NumericTransformer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNumericTransformer", "(Lorg/adw/library/widgets/discreteseekbar/DiscreteSeekBar$NumericTransformer;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnProgressChangeListener_Lorg_adw_library_widgets_discreteseekbar_DiscreteSeekBar_OnProgressChangeListener_;
#pragma warning disable 0169
		static Delegate GetSetOnProgressChangeListener_Lorg_adw_library_widgets_discreteseekbar_DiscreteSeekBar_OnProgressChangeListener_Handler ()
		{
			if (cb_setOnProgressChangeListener_Lorg_adw_library_widgets_discreteseekbar_DiscreteSeekBar_OnProgressChangeListener_ == null)
				cb_setOnProgressChangeListener_Lorg_adw_library_widgets_discreteseekbar_DiscreteSeekBar_OnProgressChangeListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnProgressChangeListener_Lorg_adw_library_widgets_discreteseekbar_DiscreteSeekBar_OnProgressChangeListener_);
			return cb_setOnProgressChangeListener_Lorg_adw_library_widgets_discreteseekbar_DiscreteSeekBar_OnProgressChangeListener_;
		}

		static void n_SetOnProgressChangeListener_Lorg_adw_library_widgets_discreteseekbar_DiscreteSeekBar_OnProgressChangeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar.IOnProgressChangeListener p0 = (global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar.IOnProgressChangeListener)global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar.IOnProgressChangeListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnProgressChangeListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnProgressChangeListener_Lorg_adw_library_widgets_discreteseekbar_DiscreteSeekBar_OnProgressChangeListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar']/class[@name='DiscreteSeekBar']/method[@name='setOnProgressChangeListener' and count(parameter)=1 and parameter[1][@type='org.adw.library.widgets.discreteseekbar.DiscreteSeekBar.OnProgressChangeListener']]"
		[Register ("setOnProgressChangeListener", "(Lorg/adw/library/widgets/discreteseekbar/DiscreteSeekBar$OnProgressChangeListener;)V", "GetSetOnProgressChangeListener_Lorg_adw_library_widgets_discreteseekbar_DiscreteSeekBar_OnProgressChangeListener_Handler")]
		public virtual unsafe void SetOnProgressChangeListener (global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar.IOnProgressChangeListener p0)
		{
			if (id_setOnProgressChangeListener_Lorg_adw_library_widgets_discreteseekbar_DiscreteSeekBar_OnProgressChangeListener_ == IntPtr.Zero)
				id_setOnProgressChangeListener_Lorg_adw_library_widgets_discreteseekbar_DiscreteSeekBar_OnProgressChangeListener_ = JNIEnv.GetMethodID (class_ref, "setOnProgressChangeListener", "(Lorg/adw/library/widgets/discreteseekbar/DiscreteSeekBar$OnProgressChangeListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setOnProgressChangeListener_Lorg_adw_library_widgets_discreteseekbar_DiscreteSeekBar_OnProgressChangeListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnProgressChangeListener", "(Lorg/adw/library/widgets/discreteseekbar/DiscreteSeekBar$OnProgressChangeListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setScrubberColor_Landroid_content_res_ColorStateList_;
#pragma warning disable 0169
		static Delegate GetSetScrubberColor_Landroid_content_res_ColorStateList_Handler ()
		{
			if (cb_setScrubberColor_Landroid_content_res_ColorStateList_ == null)
				cb_setScrubberColor_Landroid_content_res_ColorStateList_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetScrubberColor_Landroid_content_res_ColorStateList_);
			return cb_setScrubberColor_Landroid_content_res_ColorStateList_;
		}

		static void n_SetScrubberColor_Landroid_content_res_ColorStateList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Res.ColorStateList p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Res.ColorStateList> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetScrubberColor (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setScrubberColor_Landroid_content_res_ColorStateList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar']/class[@name='DiscreteSeekBar']/method[@name='setScrubberColor' and count(parameter)=1 and parameter[1][@type='android.content.res.ColorStateList']]"
		[Register ("setScrubberColor", "(Landroid/content/res/ColorStateList;)V", "GetSetScrubberColor_Landroid_content_res_ColorStateList_Handler")]
		public virtual unsafe void SetScrubberColor (global::Android.Content.Res.ColorStateList p0)
		{
			if (id_setScrubberColor_Landroid_content_res_ColorStateList_ == IntPtr.Zero)
				id_setScrubberColor_Landroid_content_res_ColorStateList_ = JNIEnv.GetMethodID (class_ref, "setScrubberColor", "(Landroid/content/res/ColorStateList;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setScrubberColor_Landroid_content_res_ColorStateList_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setScrubberColor", "(Landroid/content/res/ColorStateList;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setScrubberColor_I;
#pragma warning disable 0169
		static Delegate GetSetScrubberColor_IHandler ()
		{
			if (cb_setScrubberColor_I == null)
				cb_setScrubberColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetScrubberColor_I);
			return cb_setScrubberColor_I;
		}

		static void n_SetScrubberColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetScrubberColor (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setScrubberColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar']/class[@name='DiscreteSeekBar']/method[@name='setScrubberColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setScrubberColor", "(I)V", "GetSetScrubberColor_IHandler")]
		public virtual unsafe void SetScrubberColor (int p0)
		{
			if (id_setScrubberColor_I == IntPtr.Zero)
				id_setScrubberColor_I = JNIEnv.GetMethodID (class_ref, "setScrubberColor", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setScrubberColor_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setScrubberColor", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setThumbColor_Landroid_content_res_ColorStateList_I;
#pragma warning disable 0169
		static Delegate GetSetThumbColor_Landroid_content_res_ColorStateList_IHandler ()
		{
			if (cb_setThumbColor_Landroid_content_res_ColorStateList_I == null)
				cb_setThumbColor_Landroid_content_res_ColorStateList_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_SetThumbColor_Landroid_content_res_ColorStateList_I);
			return cb_setThumbColor_Landroid_content_res_ColorStateList_I;
		}

		static void n_SetThumbColor_Landroid_content_res_ColorStateList_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Res.ColorStateList p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Res.ColorStateList> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetThumbColor (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setThumbColor_Landroid_content_res_ColorStateList_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar']/class[@name='DiscreteSeekBar']/method[@name='setThumbColor' and count(parameter)=2 and parameter[1][@type='android.content.res.ColorStateList'] and parameter[2][@type='int']]"
		[Register ("setThumbColor", "(Landroid/content/res/ColorStateList;I)V", "GetSetThumbColor_Landroid_content_res_ColorStateList_IHandler")]
		public virtual unsafe void SetThumbColor (global::Android.Content.Res.ColorStateList p0, int p1)
		{
			if (id_setThumbColor_Landroid_content_res_ColorStateList_I == IntPtr.Zero)
				id_setThumbColor_Landroid_content_res_ColorStateList_I = JNIEnv.GetMethodID (class_ref, "setThumbColor", "(Landroid/content/res/ColorStateList;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setThumbColor_Landroid_content_res_ColorStateList_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setThumbColor", "(Landroid/content/res/ColorStateList;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setThumbColor_II;
#pragma warning disable 0169
		static Delegate GetSetThumbColor_IIHandler ()
		{
			if (cb_setThumbColor_II == null)
				cb_setThumbColor_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_SetThumbColor_II);
			return cb_setThumbColor_II;
		}

		static void n_SetThumbColor_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetThumbColor (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setThumbColor_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar']/class[@name='DiscreteSeekBar']/method[@name='setThumbColor' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setThumbColor", "(II)V", "GetSetThumbColor_IIHandler")]
		public virtual unsafe void SetThumbColor (int p0, int p1)
		{
			if (id_setThumbColor_II == IntPtr.Zero)
				id_setThumbColor_II = JNIEnv.GetMethodID (class_ref, "setThumbColor", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setThumbColor_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setThumbColor", "(II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setTrackColor_Landroid_content_res_ColorStateList_;
#pragma warning disable 0169
		static Delegate GetSetTrackColor_Landroid_content_res_ColorStateList_Handler ()
		{
			if (cb_setTrackColor_Landroid_content_res_ColorStateList_ == null)
				cb_setTrackColor_Landroid_content_res_ColorStateList_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTrackColor_Landroid_content_res_ColorStateList_);
			return cb_setTrackColor_Landroid_content_res_ColorStateList_;
		}

		static void n_SetTrackColor_Landroid_content_res_ColorStateList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Res.ColorStateList p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Res.ColorStateList> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetTrackColor (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setTrackColor_Landroid_content_res_ColorStateList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar']/class[@name='DiscreteSeekBar']/method[@name='setTrackColor' and count(parameter)=1 and parameter[1][@type='android.content.res.ColorStateList']]"
		[Register ("setTrackColor", "(Landroid/content/res/ColorStateList;)V", "GetSetTrackColor_Landroid_content_res_ColorStateList_Handler")]
		public virtual unsafe void SetTrackColor (global::Android.Content.Res.ColorStateList p0)
		{
			if (id_setTrackColor_Landroid_content_res_ColorStateList_ == IntPtr.Zero)
				id_setTrackColor_Landroid_content_res_ColorStateList_ = JNIEnv.GetMethodID (class_ref, "setTrackColor", "(Landroid/content/res/ColorStateList;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setTrackColor_Landroid_content_res_ColorStateList_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTrackColor", "(Landroid/content/res/ColorStateList;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setTrackColor_I;
#pragma warning disable 0169
		static Delegate GetSetTrackColor_IHandler ()
		{
			if (cb_setTrackColor_I == null)
				cb_setTrackColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTrackColor_I);
			return cb_setTrackColor_I;
		}

		static void n_SetTrackColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar __this = global::Java.Lang.Object.GetObject<global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTrackColor (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setTrackColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.adw.library.widgets.discreteseekbar']/class[@name='DiscreteSeekBar']/method[@name='setTrackColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTrackColor", "(I)V", "GetSetTrackColor_IHandler")]
		public virtual unsafe void SetTrackColor (int p0)
		{
			if (id_setTrackColor_I == IntPtr.Zero)
				id_setTrackColor_I = JNIEnv.GetMethodID (class_ref, "setTrackColor", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setTrackColor_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTrackColor", "(I)V"), __args);
			} finally {
			}
		}

#region "Event implementation for Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar.IOnProgressChangeListener"
		public event EventHandler<global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar.ProgressChangedEventArgs> ProgressChanged {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar.IOnProgressChangeListener, global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar.IOnProgressChangeListenerImplementor>(
						ref weak_implementor_SetOnProgressChangeListener,
						__CreateIOnProgressChangeListenerImplementor,
						SetOnProgressChangeListener,
						__h => __h.OnProgressChangedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar.IOnProgressChangeListener, global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar.IOnProgressChangeListenerImplementor>(
						ref weak_implementor_SetOnProgressChangeListener,
						global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar.IOnProgressChangeListenerImplementor.__IsEmpty,
						__v => SetOnProgressChangeListener (null),
						__h => __h.OnProgressChangedHandler -= value);
			}
		}

		public event EventHandler<global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar.StartTrackingTouchEventArgs> StartTrackingTouch {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar.IOnProgressChangeListener, global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar.IOnProgressChangeListenerImplementor>(
						ref weak_implementor_SetOnProgressChangeListener,
						__CreateIOnProgressChangeListenerImplementor,
						SetOnProgressChangeListener,
						__h => __h.OnStartTrackingTouchHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar.IOnProgressChangeListener, global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar.IOnProgressChangeListenerImplementor>(
						ref weak_implementor_SetOnProgressChangeListener,
						global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar.IOnProgressChangeListenerImplementor.__IsEmpty,
						__v => SetOnProgressChangeListener (null),
						__h => __h.OnStartTrackingTouchHandler -= value);
			}
		}

		public event EventHandler<global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar.StopTrackingTouchEventArgs> StopTrackingTouch {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar.IOnProgressChangeListener, global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar.IOnProgressChangeListenerImplementor>(
						ref weak_implementor_SetOnProgressChangeListener,
						__CreateIOnProgressChangeListenerImplementor,
						SetOnProgressChangeListener,
						__h => __h.OnStopTrackingTouchHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar.IOnProgressChangeListener, global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar.IOnProgressChangeListenerImplementor>(
						ref weak_implementor_SetOnProgressChangeListener,
						global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar.IOnProgressChangeListenerImplementor.__IsEmpty,
						__v => SetOnProgressChangeListener (null),
						__h => __h.OnStopTrackingTouchHandler -= value);
			}
		}

		WeakReference weak_implementor_SetOnProgressChangeListener;

		global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar.IOnProgressChangeListenerImplementor __CreateIOnProgressChangeListenerImplementor ()
		{
			return new global::Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar.IOnProgressChangeListenerImplementor (this);
		}
#endregion
	}
}
