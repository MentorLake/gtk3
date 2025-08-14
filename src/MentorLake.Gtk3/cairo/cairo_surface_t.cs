namespace MentorLake.cairo;

/// <summary>
/// <para>
/// A #cairo_surface_t represents an image, either as the destination
/// of a drawing operation or as source when drawing onto another
/// surface.  To draw to a #cairo_surface_t, create a cairo context
/// with the surface as the target, using cairo_create().
/// </para>
/// <para>
/// There are different subtypes of #cairo_surface_t for
/// different drawing backends; for example, cairo_image_surface_create()
/// creates a bitmap image in memory.
/// The type of a surface can be queried with cairo_surface_get_type().
/// </para>
/// <para>
/// The initial contents of a surface after creation depend upon the manner
/// of its creation. If cairo creates the surface and backing storage for
/// the user, it will be initially cleared; for example,
/// cairo_image_surface_create() and cairo_surface_create_similar().
/// Alternatively, if the user passes in a reference to some backing storage
/// and asks cairo to wrap that in a #cairo_surface_t, then the contents are
/// not modified; for example, cairo_image_surface_create_for_data() and
/// cairo_xlib_surface_create().
/// </para>
/// <para>
/// Memory management of #cairo_surface_t is done with
/// cairo_surface_reference() and cairo_surface_destroy().
/// </para>
/// </summary>

public class cairo_surface_tHandle : BaseSafeHandle
{
}


public static class cairo_surface_tExtensions
{

	public static cairo_surface_t Dereference(this cairo_surface_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<cairo_surface_t>(x.DangerousGetHandle());
}
internal class cairo_surface_tExterns
{
}

/// <summary>
/// <para>
/// A #cairo_surface_t represents an image, either as the destination
/// of a drawing operation or as source when drawing onto another
/// surface.  To draw to a #cairo_surface_t, create a cairo context
/// with the surface as the target, using cairo_create().
/// </para>
/// <para>
/// There are different subtypes of #cairo_surface_t for
/// different drawing backends; for example, cairo_image_surface_create()
/// creates a bitmap image in memory.
/// The type of a surface can be queried with cairo_surface_get_type().
/// </para>
/// <para>
/// The initial contents of a surface after creation depend upon the manner
/// of its creation. If cairo creates the surface and backing storage for
/// the user, it will be initially cleared; for example,
/// cairo_image_surface_create() and cairo_surface_create_similar().
/// Alternatively, if the user passes in a reference to some backing storage
/// and asks cairo to wrap that in a #cairo_surface_t, then the contents are
/// not modified; for example, cairo_image_surface_create_for_data() and
/// cairo_xlib_surface_create().
/// </para>
/// <para>
/// Memory management of #cairo_surface_t is done with
/// cairo_surface_reference() and cairo_surface_destroy().
/// </para>
/// </summary>

public struct cairo_surface_t
{
}
