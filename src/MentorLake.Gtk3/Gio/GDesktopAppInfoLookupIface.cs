namespace MentorLake.Gio;

public class GDesktopAppInfoLookupIfaceHandle : BaseSafeHandle
{
}


public static class GDesktopAppInfoLookupIfaceExtensions
{

	public static GDesktopAppInfoLookupIface Dereference(this GDesktopAppInfoLookupIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDesktopAppInfoLookupIface>(x.DangerousGetHandle());
}
internal class GDesktopAppInfoLookupIfaceExterns
{
}

public struct GDesktopAppInfoLookupIface
{
	public GTypeInterface g_iface;
	public IntPtr get_default_for_uri_scheme;
}
