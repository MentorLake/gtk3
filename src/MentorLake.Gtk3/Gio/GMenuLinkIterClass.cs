namespace MentorLake.Gio;


public class GMenuLinkIterClassHandle : BaseSafeHandle
{
}


public static class GMenuLinkIterClassExtensions
{

	public static GMenuLinkIterClass Dereference(this GMenuLinkIterClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GMenuLinkIterClass>(x.DangerousGetHandle());
}
internal class GMenuLinkIterClassExterns
{
}


public struct GMenuLinkIterClass
{
	
public GObjectClass parent_class;
	
public IntPtr get_next;
}
