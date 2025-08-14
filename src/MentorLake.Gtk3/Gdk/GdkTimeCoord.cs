namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// A #GdkTimeCoord stores a single event in a motion history.
/// </para>
/// </summary>

public class GdkTimeCoordHandle : BaseSafeHandle
{
}


public static class GdkTimeCoordExtensions
{

	public static GdkTimeCoord Dereference(this GdkTimeCoordHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkTimeCoord>(x.DangerousGetHandle());
}
internal class GdkTimeCoordExterns
{
}

/// <summary>
/// <para>
/// A #GdkTimeCoord stores a single event in a motion history.
/// </para>
/// </summary>

public struct GdkTimeCoord
{
	/// <summary>
/// <para>
/// The timestamp for this event.
/// </para>
/// </summary>

public uint time;
	/// <summary>
/// <para>
/// the values of the device’s axes.
/// </para>
/// </summary>

[MarshalAs(UnmanagedType.ByValArray)] public double[] axes;
}
