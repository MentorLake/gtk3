namespace MentorLake.GLib;

/// <summary>
/// <para>
/// A typedef alias for gchar**. This is mostly useful when used together with
/// `g_auto()`.
/// </para>
/// </summary>

public struct GStrv
{
	public string Value;
}

/// <summary>
/// <para>
/// A typedef alias for gchar**. This is mostly useful when used together with
/// `g_auto()`.
/// </para>
/// </summary>

public class GStrvHandle : BaseSafeHandle
{
}

public static class GStrvHandleExtensions
{
	public static GStrv Dereference(this GStrvHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GStrv>(x.DangerousGetHandle());
	public static string DereferenceValue(this GStrvHandle x) => x.Dereference().Value;
}
