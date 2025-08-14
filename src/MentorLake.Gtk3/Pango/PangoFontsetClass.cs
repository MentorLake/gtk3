namespace MentorLake.Pango;

/// <summary>
/// <para>
/// The `PangoFontsetClass` structure holds the virtual functions for
/// a particular `PangoFontset` implementation.
/// </para>
/// </summary>

public class PangoFontsetClassHandle : BaseSafeHandle
{
}


public static class PangoFontsetClassExtensions
{

	public static PangoFontsetClass Dereference(this PangoFontsetClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoFontsetClass>(x.DangerousGetHandle());
}
internal class PangoFontsetClassExterns
{
}

/// <summary>
/// <para>
/// The `PangoFontsetClass` structure holds the virtual functions for
/// a particular `PangoFontset` implementation.
/// </para>
/// </summary>

public struct PangoFontsetClass
{
	/// <summary>
/// <para>
/// parent `GObjectClass`
/// </para>
/// </summary>

public GObjectClass parent_class;
	/// <summary>
/// <para>
/// a function to get the font in the fontset that contains the
///   best glyph for the given Unicode character; see [method@Pango.Fontset.get_font]
/// </para>
/// </summary>

public IntPtr get_font;
	/// <summary>
/// <para>
/// a function to get overall metric information for the fonts
///   in the fontset; see [method@Pango.Fontset.get_metrics]
/// </para>
/// </summary>

public IntPtr get_metrics;
	/// <summary>
/// <para>
/// a function to get the language of the fontset.
/// </para>
/// </summary>

public IntPtr get_language;
	/// <summary>
/// <para>
/// a function to loop over the fonts in the fontset. See
///   [method@Pango.Fontset.foreach]
/// </para>
/// </summary>

public IntPtr @foreach;
	
public IntPtr _pango_reserved1;
	
public IntPtr _pango_reserved2;
	
public IntPtr _pango_reserved3;
	
public IntPtr _pango_reserved4;
}
