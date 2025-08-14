namespace MentorLake.cairo;

/// <summary>
/// <para>
/// #cairo_device_type_t is used to describe the type of a given
/// device. The devices types are also known as "backends" within cairo.
/// </para>
/// <para>
/// The device type can be queried with cairo_device_get_type()
/// </para>
/// <para>
/// The various #cairo_device_t functions can be used with devices of
/// any type, but some backends also provide type-specific functions
/// that must only be called with a device of the appropriate
/// type. These functions have names that begin with
/// <literal>cairo_<emphasis>type</emphasis>_device</literal> such as
/// cairo_xcb_device_debug_cap_xrender_version().
/// </para>
/// <para>
/// The behavior of calling a type-specific function with a device of
/// the wrong type is undefined.
/// </para>
/// <para>
/// New entries may be added in future versions.
/// </para>
/// </summary>

[Flags]
public enum cairo_device_type_t
{
/// <summary>
/// <para>
/// The device is of type Direct Render Manager, since 1.10
/// </para>
/// </summary>

	CAIRO_DEVICE_TYPE_DRM = 0,
/// <summary>
/// <para>
/// The device is of type OpenGL, since 1.10
/// </para>
/// </summary>

	CAIRO_DEVICE_TYPE_GL = 1,
/// <summary>
/// <para>
/// The device is of type script, since 1.10
/// </para>
/// </summary>

	CAIRO_DEVICE_TYPE_SCRIPT = 2,
/// <summary>
/// <para>
/// The device is of type xcb, since 1.10
/// </para>
/// </summary>

	CAIRO_DEVICE_TYPE_XCB = 3,
/// <summary>
/// <para>
/// The device is of type xlib, since 1.10
/// </para>
/// </summary>

	CAIRO_DEVICE_TYPE_XLIB = 4,
/// <summary>
/// <para>
/// The device is of type XML, since 1.10
/// </para>
/// </summary>

	CAIRO_DEVICE_TYPE_XML = 5,
/// <summary>
/// <para>
/// The device is of type cogl, since 1.12
/// </para>
/// </summary>

	CAIRO_DEVICE_TYPE_COGL = 6,
/// <summary>
/// <para>
/// The device is of type win32, since 1.12
/// </para>
/// </summary>

	CAIRO_DEVICE_TYPE_WIN32 = 7,
/// <summary>
/// <para>
/// The device is invalid, since 1.10
/// </para>
/// </summary>

	CAIRO_DEVICE_TYPE_INVALID = -1
}
