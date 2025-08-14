namespace MentorLake.GLib;

/// <summary>
/// <para>
/// An opaque data structure that represents a keyed data list.
/// </para>
/// <para>
/// See also: [Keyed data lists](datalist-and-dataset.html).
/// </para>
/// </summary>

public class GDataHandle : BaseSafeHandle
{
}


public static class GDataExtensions
{

	public static GData Dereference(this GDataHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GData>(x.DangerousGetHandle());
}
internal class GDataExterns
{
}

/// <summary>
/// <para>
/// An opaque data structure that represents a keyed data list.
/// </para>
/// <para>
/// See also: [Keyed data lists](datalist-and-dataset.html).
/// </para>
/// </summary>

public struct GData
{
}
