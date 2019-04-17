package md5e7cb750ce1ea8f25dd8c5767b7edf33d;


public class MainPage_CustomWheelAdapter
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		android.support.v7.view.ActionMode.Callback,
		com.super_rabbit.wheel_picker.WheelAdapter
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onActionItemClicked:(Landroid/support/v7/view/ActionMode;Landroid/view/MenuItem;)Z:GetOnActionItemClicked_Landroid_support_v7_view_ActionMode_Landroid_view_MenuItem_Handler:Android.Support.V7.View.ActionMode/ICallbackInvoker, Xamarin.Android.Support.v7.AppCompat\n" +
			"n_onCreateActionMode:(Landroid/support/v7/view/ActionMode;Landroid/view/Menu;)Z:GetOnCreateActionMode_Landroid_support_v7_view_ActionMode_Landroid_view_Menu_Handler:Android.Support.V7.View.ActionMode/ICallbackInvoker, Xamarin.Android.Support.v7.AppCompat\n" +
			"n_onDestroyActionMode:(Landroid/support/v7/view/ActionMode;)V:GetOnDestroyActionMode_Landroid_support_v7_view_ActionMode_Handler:Android.Support.V7.View.ActionMode/ICallbackInvoker, Xamarin.Android.Support.v7.AppCompat\n" +
			"n_onPrepareActionMode:(Landroid/support/v7/view/ActionMode;Landroid/view/Menu;)Z:GetOnPrepareActionMode_Landroid_support_v7_view_ActionMode_Landroid_view_Menu_Handler:Android.Support.V7.View.ActionMode/ICallbackInvoker, Xamarin.Android.Support.v7.AppCompat\n" +
			"n_getMaxIndex:()I:GetGetMaxIndexHandler:SuperRabbit.Lib.IWheelAdapterInvoker, NumberPicker\n" +
			"n_getMinIndex:()I:GetGetMinIndexHandler:SuperRabbit.Lib.IWheelAdapterInvoker, NumberPicker\n" +
			"n_getTextWithMaximumLength:()Ljava/lang/String;:GetGetTextWithMaximumLengthHandler:SuperRabbit.Lib.IWheelAdapterInvoker, NumberPicker\n" +
			"n_getPosition:(Ljava/lang/String;)I:GetGetPosition_Ljava_lang_String_Handler:SuperRabbit.Lib.IWheelAdapterInvoker, NumberPicker\n" +
			"n_getValue:(I)Ljava/lang/String;:GetGetValue_IHandler:SuperRabbit.Lib.IWheelAdapterInvoker, NumberPicker\n" +
			"";
		mono.android.Runtime.register ("WhlPkrSample.MainPage+CustomWheelAdapter, WhlPkrSample.Android", MainPage_CustomWheelAdapter.class, __md_methods);
	}


	public MainPage_CustomWheelAdapter ()
	{
		super ();
		if (getClass () == MainPage_CustomWheelAdapter.class)
			mono.android.TypeManager.Activate ("WhlPkrSample.MainPage+CustomWheelAdapter, WhlPkrSample.Android", "", this, new java.lang.Object[] {  });
	}


	public boolean onActionItemClicked (android.support.v7.view.ActionMode p0, android.view.MenuItem p1)
	{
		return n_onActionItemClicked (p0, p1);
	}

	private native boolean n_onActionItemClicked (android.support.v7.view.ActionMode p0, android.view.MenuItem p1);


	public boolean onCreateActionMode (android.support.v7.view.ActionMode p0, android.view.Menu p1)
	{
		return n_onCreateActionMode (p0, p1);
	}

	private native boolean n_onCreateActionMode (android.support.v7.view.ActionMode p0, android.view.Menu p1);


	public void onDestroyActionMode (android.support.v7.view.ActionMode p0)
	{
		n_onDestroyActionMode (p0);
	}

	private native void n_onDestroyActionMode (android.support.v7.view.ActionMode p0);


	public boolean onPrepareActionMode (android.support.v7.view.ActionMode p0, android.view.Menu p1)
	{
		return n_onPrepareActionMode (p0, p1);
	}

	private native boolean n_onPrepareActionMode (android.support.v7.view.ActionMode p0, android.view.Menu p1);


	public int getMaxIndex ()
	{
		return n_getMaxIndex ();
	}

	private native int n_getMaxIndex ();


	public int getMinIndex ()
	{
		return n_getMinIndex ();
	}

	private native int n_getMinIndex ();


	public java.lang.String getTextWithMaximumLength ()
	{
		return n_getTextWithMaximumLength ();
	}

	private native java.lang.String n_getTextWithMaximumLength ();


	public int getPosition (java.lang.String p0)
	{
		return n_getPosition (p0);
	}

	private native int n_getPosition (java.lang.String p0);


	public java.lang.String getValue (int p0)
	{
		return n_getValue (p0);
	}

	private native java.lang.String n_getValue (int p0);

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
