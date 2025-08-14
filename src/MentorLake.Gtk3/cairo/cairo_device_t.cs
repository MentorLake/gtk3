namespace MentorLake.cairo;

/// <summary>
/// <para>
/// A #cairo_device_t represents the driver interface for drawing
/// operations to a #cairo_surface_t.  There are different subtypes of
/// #cairo_device_t for different drawing backends; for example,
/// cairo_egl_device_create() creates a device that wraps an EGL display and
/// context.
/// </para>
/// <para>
/// The type of a device can be queried with cairo_device_get_type().
/// </para>
/// <para>
/// Memory management of #cairo_device_t is done with
/// cairo_device_reference() and cairo_device_destroy().
/// </para>
/// </summary>

public class cairo_device_tHandle : BaseSafeHandle
{
}


public static class cairo_device_tExtensions
{

	public static cairo_device_t Dereference(this cairo_device_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<cairo_device_t>(x.DangerousGetHandle());
}
internal class cairo_device_tExterns
{
}

/// <summary>
/// <para>
/// A #cairo_device_t represents the driver interface for drawing
/// operations to a #cairo_surface_t.  There are different subtypes of
/// #cairo_device_t for different drawing backends; for example,
/// cairo_egl_device_create() creates a device that wraps an EGL display and
/// context.
/// </para>
/// <para>
/// The type of a device can be queried with cairo_device_get_type().
/// </para>
/// <para>
/// Memory management of #cairo_device_t is done with
/// cairo_device_reference() and cairo_device_destroy().
/// </para>
/// </summary>

public struct cairo_device_t
{
}
