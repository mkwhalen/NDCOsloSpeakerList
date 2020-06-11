package crc641b10f851390d7646;


public class SpeakerDetails
	extends crc64a5a37c43dff01024.Page
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("NDCOsloSpeakerList.Shared.SpeakerDetails, NDCOsloSpeakerList.Droid", SpeakerDetails.class, __md_methods);
	}


	public SpeakerDetails (android.content.Context p0)
	{
		super (p0);
		if (getClass () == SpeakerDetails.class)
			mono.android.TypeManager.Activate ("NDCOsloSpeakerList.Shared.SpeakerDetails, NDCOsloSpeakerList.Droid", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
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
