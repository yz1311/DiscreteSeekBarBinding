package md5cbfacf82a8356e8f29765c09a35331cb;


public class SeekBarNumericTransformer
	extends org.adw.library.widgets.discreteseekbar.DiscreteSeekBar.NumericTransformer
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_transform:(I)I:GetTransform_IHandler\n" +
			"";
		mono.android.Runtime.register ("DiscreteSeekBarDemo.SeekBarNumericTransformer, DiscreteSeekBarDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", SeekBarNumericTransformer.class, __md_methods);
	}


	public SeekBarNumericTransformer () throws java.lang.Throwable
	{
		super ();
		if (getClass () == SeekBarNumericTransformer.class)
			mono.android.TypeManager.Activate ("DiscreteSeekBarDemo.SeekBarNumericTransformer, DiscreteSeekBarDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public int transform (int p0)
	{
		return n_transform (p0);
	}

	private native int n_transform (int p0);

	java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
