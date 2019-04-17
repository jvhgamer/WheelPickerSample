package md5230e6832f624e9aa9a1b8db9c9a87898;


public class ValueChangeListener
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.super_rabbit.wheel_picker.OnValueChangeListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onValueChange:(Lcom/super_rabbit/wheel_picker/WheelPicker;Ljava/lang/String;Ljava/lang/String;)V:GetOnValueChange_Lcom_super_rabbit_wheel_picker_WheelPicker_Ljava_lang_String_Ljava_lang_String_Handler:SuperRabbit.Lib.IOnValueChangeListenerInvoker, NumberPicker\n" +
			"";
		mono.android.Runtime.register ("SuperRabbit.Lib.ValueChangeListener, NumberPicker", ValueChangeListener.class, __md_methods);
	}


	public ValueChangeListener ()
	{
		super ();
		if (getClass () == ValueChangeListener.class)
			mono.android.TypeManager.Activate ("SuperRabbit.Lib.ValueChangeListener, NumberPicker", "", this, new java.lang.Object[] {  });
	}


	public void onValueChange (com.super_rabbit.wheel_picker.WheelPicker p0, java.lang.String p1, java.lang.String p2)
	{
		n_onValueChange (p0, p1, p2);
	}

	private native void n_onValueChange (com.super_rabbit.wheel_picker.WheelPicker p0, java.lang.String p1, java.lang.String p2);

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
