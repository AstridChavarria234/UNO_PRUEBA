package crc642e78f8f485fbceef;


public class CancellationPage
	extends crc64a5a37c43dff01024.Page
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("PARCIAL.Pages.CancellationPage, PARCIAL.Droid", CancellationPage.class, __md_methods);
	}


	public CancellationPage (android.content.Context p0)
	{
		super (p0);
		if (getClass () == CancellationPage.class)
			mono.android.TypeManager.Activate ("PARCIAL.Pages.CancellationPage, PARCIAL.Droid", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
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
