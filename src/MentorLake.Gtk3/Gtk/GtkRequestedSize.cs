namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Represents a request of a screen object in a given orientation. These
/// are primarily used in container implementations when allocating a natural
/// size for children calling. See gtk_distribute_natural_allocation().
/// </para>
/// </summary>

public class GtkRequestedSizeHandle : BaseSafeHandle
{
}


public static class GtkRequestedSizeExtensions
{

	public static GtkRequestedSize Dereference(this GtkRequestedSizeHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkRequestedSize>(x.DangerousGetHandle());
}
internal class GtkRequestedSizeExterns
{
}

/// <summary>
/// <para>
/// Represents a request of a screen object in a given orientation. These
/// are primarily used in container implementations when allocating a natural
/// size for children calling. See gtk_distribute_natural_allocation().
/// </para>
/// </summary>

public struct GtkRequestedSize
{
	/// <summary>
/// <para>
/// A client pointer
/// </para>
/// </summary>

public IntPtr data;
	/// <summary>
/// <para>
/// The minimum size needed for allocation in a given orientation
/// </para>
/// </summary>

public int minimum_size;
	/// <summary>
/// <para>
/// The natural size for allocation in a given orientation
/// </para>
/// </summary>

public int natural_size;
}
