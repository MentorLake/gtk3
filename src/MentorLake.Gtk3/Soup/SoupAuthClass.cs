namespace MentorLake.Soup;


public class SoupAuthClassHandle : BaseSafeHandle
{
}


public static class SoupAuthClassExtensions
{

	public static SoupAuthClass Dereference(this SoupAuthClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<SoupAuthClass>(x.DangerousGetHandle());
}
internal class SoupAuthClassExterns
{
}


public struct SoupAuthClass
{
	
public GObjectClass parent_class;
	
public string scheme_name;
	
public uint strength;
	
public IntPtr update;
	
public IntPtr get_protection_space;
	
public IntPtr authenticate;
	
public IntPtr is_authenticated;
	
public IntPtr get_authorization;
	
public IntPtr is_ready;
	
public IntPtr can_authenticate;
	
public IntPtr padding;
}
