namespace MentorLake.cairo;

/// <summary>
/// <para>
/// A #cairo_t contains the current state of the rendering device,
/// including coordinates of yet to be drawn shapes.
/// </para>
/// <para>
/// Cairo contexts, as #cairo_t objects are named, are central to
/// cairo and all drawing with cairo is always done to a #cairo_t
/// object.
/// </para>
/// <para>
/// Memory management of #cairo_t is done with
/// cairo_reference() and cairo_destroy().
/// </para>
/// </summary>

public class cairo_tHandle : BaseSafeHandle
{
}


public static class cairo_tExtensions
{

	public static cairo_t Dereference(this cairo_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<cairo_t>(x.DangerousGetHandle());
}
internal class cairo_tExterns
{
}

/// <summary>
/// <para>
/// A #cairo_t contains the current state of the rendering device,
/// including coordinates of yet to be drawn shapes.
/// </para>
/// <para>
/// Cairo contexts, as #cairo_t objects are named, are central to
/// cairo and all drawing with cairo is always done to a #cairo_t
/// object.
/// </para>
/// <para>
/// Memory management of #cairo_t is done with
/// cairo_reference() and cairo_destroy().
/// </para>
/// </summary>

public struct cairo_t
{
}
