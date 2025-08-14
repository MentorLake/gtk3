namespace MentorLake.Pango;

/// <summary>
/// <para>
/// The `PangoFontMapClass` structure holds the virtual functions for
/// a particular `PangoFontMap` implementation.
/// </para>
/// </summary>

public class PangoFontMapClassHandle : BaseSafeHandle
{
}


public static class PangoFontMapClassExtensions
{

	public static PangoFontMapClass Dereference(this PangoFontMapClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoFontMapClass>(x.DangerousGetHandle());
}
internal class PangoFontMapClassExterns
{
}

/// <summary>
/// <para>
/// The `PangoFontMapClass` structure holds the virtual functions for
/// a particular `PangoFontMap` implementation.
/// </para>
/// </summary>

public struct PangoFontMapClass
{
	/// <summary>
/// <para>
/// parent `GObjectClass`
/// </para>
/// </summary>

public GObjectClass parent_class;
	/// <summary>
/// <para>
/// a function to load a font with a given description. See
/// pango_font_map_load_font().
/// </para>
/// </summary>

public IntPtr load_font;
	/// <summary>
/// <para>
/// A function to list available font families. See
/// pango_font_map_list_families().
/// </para>
/// </summary>

public IntPtr list_families;
	/// <summary>
/// <para>
/// a function to load a fontset with a given given description
/// suitable for a particular language. See pango_font_map_load_fontset().
/// </para>
/// </summary>

public IntPtr load_fontset;
	/// <summary>
/// <para>
/// the type of rendering-system-dependent engines that
/// can handle fonts of this fonts loaded with this fontmap.
/// </para>
/// </summary>

public string shape_engine_type;
	/// <summary>
/// <para>
/// a function to get the serial number of the fontmap.
/// See pango_font_map_get_serial().
/// </para>
/// </summary>

public IntPtr get_serial;
	/// <summary>
/// <para>
/// See pango_font_map_changed()
/// </para>
/// </summary>

public IntPtr changed;
	
public IntPtr get_family;
	
public IntPtr get_face;
}
