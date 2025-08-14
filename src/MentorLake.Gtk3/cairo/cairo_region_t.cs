namespace MentorLake.cairo;

/// <summary>
/// <para>
/// A #cairo_region_t represents a set of integer-aligned rectangles.
/// </para>
/// <para>
/// It allows set-theoretical operations like cairo_region_union() and
/// cairo_region_intersect() to be performed on them.
/// </para>
/// <para>
/// Memory management of #cairo_region_t is done with
/// cairo_region_reference() and cairo_region_destroy().
/// </para>
/// </summary>

public class cairo_region_tHandle : BaseSafeHandle
{
}


public static class cairo_region_tExtensions
{

	public static cairo_region_t Dereference(this cairo_region_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<cairo_region_t>(x.DangerousGetHandle());
}
internal class cairo_region_tExterns
{
}

/// <summary>
/// <para>
/// A #cairo_region_t represents a set of integer-aligned rectangles.
/// </para>
/// <para>
/// It allows set-theoretical operations like cairo_region_union() and
/// cairo_region_intersect() to be performed on them.
/// </para>
/// <para>
/// Memory management of #cairo_region_t is done with
/// cairo_region_reference() and cairo_region_destroy().
/// </para>
/// </summary>

public struct cairo_region_t
{
}
