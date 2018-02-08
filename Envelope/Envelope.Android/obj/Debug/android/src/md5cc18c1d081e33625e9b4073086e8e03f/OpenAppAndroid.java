package md5cc18c1d081e33625e9b4073086e8e03f;


public class OpenAppAndroid
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Envelope.Interfaces.Droid.OpenAppAndroid, Envelope.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", OpenAppAndroid.class, __md_methods);
	}


	public OpenAppAndroid ()
	{
		super ();
		if (getClass () == OpenAppAndroid.class)
			mono.android.TypeManager.Activate ("Envelope.Interfaces.Droid.OpenAppAndroid, Envelope.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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
