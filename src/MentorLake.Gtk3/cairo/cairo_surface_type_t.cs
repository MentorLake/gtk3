namespace MentorLake.cairo;

/// <summary>
/// <para>
/// #cairo_surface_type_t is used to describe the type of a given
/// surface. The surface types are also known as "backends" or "surface
/// backends" within cairo.
/// </para>
/// <para>
/// The type of a surface is determined by the function used to create
/// it, which will generally be of the form
/// <function>cairo_<emphasis>type</emphasis>_surface_create(<!-- -->)</function>,
/// (though see cairo_surface_create_similar() as well).
/// </para>
/// <para>
/// The surface type can be queried with cairo_surface_get_type()
/// </para>
/// <para>
/// The various #cairo_surface_t functions can be used with surfaces of
/// any type, but some backends also provide type-specific functions
/// that must only be called with a surface of the appropriate
/// type. These functions have names that begin with
/// <literal>cairo_<emphasis>type</emphasis>_surface</literal> such as cairo_image_surface_get_width().
/// </para>
/// <para>
/// The behavior of calling a type-specific function with a surface of
/// the wrong type is undefined.
/// </para>
/// <para>
/// New entries may be added in future versions.
/// </para>
/// </summary>

[Flags]
public enum cairo_surface_type_t
{
/// <summary>
/// <para>
/// The surface is of type image, since 1.2
/// </para>
/// </summary>

	CAIRO_SURFACE_TYPE_IMAGE = 0,
/// <summary>
/// <para>
/// The surface is of type pdf, since 1.2
/// </para>
/// </summary>

	CAIRO_SURFACE_TYPE_PDF = 1,
/// <summary>
/// <para>
/// The surface is of type ps, since 1.2
/// </para>
/// </summary>

	CAIRO_SURFACE_TYPE_PS = 2,
/// <summary>
/// <para>
/// The surface is of type xlib, since 1.2
/// </para>
/// </summary>

	CAIRO_SURFACE_TYPE_XLIB = 3,
/// <summary>
/// <para>
/// The surface is of type xcb, since 1.2
/// </para>
/// </summary>

	CAIRO_SURFACE_TYPE_XCB = 4,
/// <summary>
/// <para>
/// The surface is of type glitz, since 1.2
/// </para>
/// </summary>

	CAIRO_SURFACE_TYPE_GLITZ = 5,
/// <summary>
/// <para>
/// The surface is of type quartz, since 1.2
/// </para>
/// </summary>

	CAIRO_SURFACE_TYPE_QUARTZ = 6,
/// <summary>
/// <para>
/// The surface is of type win32, since 1.2
/// </para>
/// </summary>

	CAIRO_SURFACE_TYPE_WIN32 = 7,
/// <summary>
/// <para>
/// The surface is of type beos, since 1.2
/// </para>
/// </summary>

	CAIRO_SURFACE_TYPE_BEOS = 8,
/// <summary>
/// <para>
/// The surface is of type directfb, since 1.2
/// </para>
/// </summary>

	CAIRO_SURFACE_TYPE_DIRECTFB = 9,
/// <summary>
/// <para>
/// The surface is of type svg, since 1.2
/// </para>
/// </summary>

	CAIRO_SURFACE_TYPE_SVG = 10,
/// <summary>
/// <para>
/// The surface is of type os2, since 1.4
/// </para>
/// </summary>

	CAIRO_SURFACE_TYPE_OS2 = 11,
/// <summary>
/// <para>
/// The surface is a win32 printing surface, since 1.6
/// </para>
/// </summary>

	CAIRO_SURFACE_TYPE_WIN32_PRINTING = 12,
/// <summary>
/// <para>
/// The surface is of type quartz_image, since 1.6
/// </para>
/// </summary>

	CAIRO_SURFACE_TYPE_QUARTZ_IMAGE = 13,
/// <summary>
/// <para>
/// The surface is of type script, since 1.10
/// </para>
/// </summary>

	CAIRO_SURFACE_TYPE_SCRIPT = 14,
/// <summary>
/// <para>
/// The surface is of type Qt, since 1.10
/// </para>
/// </summary>

	CAIRO_SURFACE_TYPE_QT = 15,
/// <summary>
/// <para>
/// The surface is of type recording, since 1.10
/// </para>
/// </summary>

	CAIRO_SURFACE_TYPE_RECORDING = 16,
/// <summary>
/// <para>
/// The surface is a OpenVG surface, since 1.10
/// </para>
/// </summary>

	CAIRO_SURFACE_TYPE_VG = 17,
/// <summary>
/// <para>
/// The surface is of type OpenGL, since 1.10
/// </para>
/// </summary>

	CAIRO_SURFACE_TYPE_GL = 18,
/// <summary>
/// <para>
/// The surface is of type Direct Render Manager, since 1.10
/// </para>
/// </summary>

	CAIRO_SURFACE_TYPE_DRM = 19,
/// <summary>
/// <para>
/// The surface is of type 'tee' (a multiplexing surface), since 1.10
/// </para>
/// </summary>

	CAIRO_SURFACE_TYPE_TEE = 20,
/// <summary>
/// <para>
/// The surface is of type XML (for debugging), since 1.10
/// </para>
/// </summary>

	CAIRO_SURFACE_TYPE_XML = 21,

	CAIRO_SURFACE_TYPE_SKIA = 22,
/// <summary>
/// <para>
/// The surface is a subsurface created with
///   cairo_surface_create_for_rectangle(), since 1.10
/// </para>
/// </summary>

	CAIRO_SURFACE_TYPE_SUBSURFACE = 23,
/// <summary>
/// <para>
/// This surface is of type Cogl, since 1.12
/// </para>
/// </summary>

	CAIRO_SURFACE_TYPE_COGL = 24
}
