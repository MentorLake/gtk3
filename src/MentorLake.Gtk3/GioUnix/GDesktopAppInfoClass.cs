namespace MentorLake.GioUnix;


public class GDesktopAppInfoClassHandle : BaseSafeHandle
{
}


public static class GDesktopAppInfoClassExtensions
{

	public static GDesktopAppInfoClass Dereference(this GDesktopAppInfoClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDesktopAppInfoClass>(x.DangerousGetHandle());
}
internal class GDesktopAppInfoClassExterns
{
}


public struct GDesktopAppInfoClass
{
	
public GObjectClass parent_class;
}
