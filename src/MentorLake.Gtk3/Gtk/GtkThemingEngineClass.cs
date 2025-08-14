namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Base class for theming engines.
/// </para>
/// </summary>

public class GtkThemingEngineClassHandle : BaseSafeHandle
{
}


public static class GtkThemingEngineClassExtensions
{

	public static GtkThemingEngineClass Dereference(this GtkThemingEngineClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkThemingEngineClass>(x.DangerousGetHandle());
}
internal class GtkThemingEngineClassExterns
{
}

/// <summary>
/// <para>
/// Base class for theming engines.
/// </para>
/// </summary>

public struct GtkThemingEngineClass
{
	/// <summary>
/// <para>
/// The parent class.
/// </para>
/// </summary>

public GObjectClass parent_class;
	/// <summary>
/// <para>
/// Renders a line between two points.
/// </para>
/// </summary>

public IntPtr render_line;
	/// <summary>
/// <para>
/// Renders the background area of a widget region.
/// </para>
/// </summary>

public IntPtr render_background;
	/// <summary>
/// <para>
/// Renders the frame around a widget area.
/// </para>
/// </summary>

public IntPtr render_frame;
	/// <summary>
/// <para>
/// Renders the frame around a widget area with a gap in it.
/// </para>
/// </summary>

public IntPtr render_frame_gap;
	/// <summary>
/// <para>
/// Renders a extension to a box, usually a notebook tab.
/// </para>
/// </summary>

public IntPtr render_extension;
	/// <summary>
/// <para>
/// Renders a checkmark, as in #GtkCheckButton.
/// </para>
/// </summary>

public IntPtr render_check;
	/// <summary>
/// <para>
/// Renders an option, as in #GtkRadioButton.
/// </para>
/// </summary>

public IntPtr render_option;
	/// <summary>
/// <para>
/// Renders an arrow pointing to a certain direction.
/// </para>
/// </summary>

public IntPtr render_arrow;
	/// <summary>
/// <para>
/// Renders an element what will expose/expand part of
///                   the UI, as in #GtkExpander.
/// </para>
/// </summary>

public IntPtr render_expander;
	/// <summary>
/// <para>
/// Renders the focus indicator.
/// </para>
/// </summary>

public IntPtr render_focus;
	/// <summary>
/// <para>
/// Renders a #PangoLayout
/// </para>
/// </summary>

public IntPtr render_layout;
	/// <summary>
/// <para>
/// Renders a slider control, as in #GtkScale.
/// </para>
/// </summary>

public IntPtr render_slider;
	/// <summary>
/// <para>
/// Renders a handle to drag UI elements, as in #GtkPaned.
/// </para>
/// </summary>

public IntPtr render_handle;
	/// <summary>
/// <para>
/// Renders an area displaying activity, such as in #GtkSpinner,
///                   or #GtkProgressBar.
/// </para>
/// </summary>

public IntPtr render_activity;
	/// <summary>
/// <para>
/// Renders an icon as a #GdkPixbuf.
/// </para>
/// </summary>

public IntPtr render_icon_pixbuf;
	/// <summary>
/// <para>
/// Renders an icon given as a #GdkPixbuf.
/// </para>
/// </summary>

public IntPtr render_icon;
	/// <summary>
/// <para>
/// Renders an icon given as a #cairo_surface_t.
/// </para>
/// </summary>

public IntPtr render_icon_surface;
}
