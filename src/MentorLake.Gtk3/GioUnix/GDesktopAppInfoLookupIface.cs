namespace MentorLake.GioUnix;

/// <summary>
/// <para>
/// Interface that is used by backends to associate default
/// handlers with URI schemes.
/// </para>
/// </summary>

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

/// <summary>
/// <para>
/// Interface that is used by backends to associate default
/// handlers with URI schemes.
/// </para>
/// </summary>

public struct GDesktopAppInfoLookupIface
{
	
public GTypeInterface g_iface;
	/// <summary>
/// <para>
/// Virtual method for
///  g_desktop_app_info_lookup_get_default_for_uri_scheme().
/// </para>
/// </summary>

public IntPtr get_default_for_uri_scheme;
}
