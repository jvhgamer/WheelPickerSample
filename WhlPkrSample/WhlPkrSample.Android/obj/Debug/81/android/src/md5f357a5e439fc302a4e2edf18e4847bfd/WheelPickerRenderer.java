package md5f357a5e439fc302a4e2edf18e4847bfd;


public class WheelPickerRenderer
	extends vapolia.WheelPicker
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Vapolia.WheelPickerForms.Droid.WheelPickerRenderer, Vapolia.WheelPickerForms.Droid", WheelPickerRenderer.class, __md_methods);
	}


	public WheelPickerRenderer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == WheelPickerRenderer.class)
			mono.android.TypeManager.Activate ("Vapolia.WheelPickerForms.Droid.WheelPickerRenderer, Vapolia.WheelPickerForms.Droid", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public WheelPickerRenderer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == WheelPickerRenderer.class)
			mono.android.TypeManager.Activate ("Vapolia.WheelPickerForms.Droid.WheelPickerRenderer, Vapolia.WheelPickerForms.Droid", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public WheelPickerRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == WheelPickerRenderer.class)
			mono.android.TypeManager.Activate ("Vapolia.WheelPickerForms.Droid.WheelPickerRenderer, Vapolia.WheelPickerForms.Droid", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public WheelPickerRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2, int p3)
	{
		super (p0, p1, p2, p3);
		if (getClass () == WheelPickerRenderer.class)
			mono.android.TypeManager.Activate ("Vapolia.WheelPickerForms.Droid.WheelPickerRenderer, Vapolia.WheelPickerForms.Droid", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2, p3 });
	}

	private java.util.ArrayList refList;
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
