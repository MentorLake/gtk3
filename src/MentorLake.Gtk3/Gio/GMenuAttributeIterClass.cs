namespace MentorLake.Gio;


public class GMenuAttributeIterClassHandle : BaseSafeHandle
{
}


public static class GMenuAttributeIterClassExtensions
{

	public static GMenuAttributeIterClass Dereference(this GMenuAttributeIterClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GMenuAttributeIterClass>(x.DangerousGetHandle());
}
internal class GMenuAttributeIterClassExterns
{
}


public struct GMenuAttributeIterClass
{
	
public GObjectClass parent_class;
	
public IntPtr get_next;
}
