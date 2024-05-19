package crc64bc515f04e1aa01ba;


public class Class1
	extends androidx.appcompat.app.AppCompatActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("ALMENDRA_MOBAPP2_ILS.Class1, ALMENDRA_MOBAPP2_ILS", Class1.class, __md_methods);
	}


	public Class1 ()
	{
		super ();
		if (getClass () == Class1.class) {
			mono.android.TypeManager.Activate ("ALMENDRA_MOBAPP2_ILS.Class1, ALMENDRA_MOBAPP2_ILS", "", this, new java.lang.Object[] {  });
		}
	}


	public Class1 (int p0)
	{
		super (p0);
		if (getClass () == Class1.class) {
			mono.android.TypeManager.Activate ("ALMENDRA_MOBAPP2_ILS.Class1, ALMENDRA_MOBAPP2_ILS", "System.Int32, mscorlib", this, new java.lang.Object[] { p0 });
		}
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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
