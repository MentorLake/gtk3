namespace MentorLake.Gtk;

public class GtkStyleClassHandle : BaseSafeHandle
{
}


public static class GtkStyleClassExtensions
{

	public static GtkStyleClass Dereference(this GtkStyleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkStyleClass>(x.DangerousGetHandle());
}
internal class GtkStyleClassExterns
{
}

public struct GtkStyleClass
{
	public GObjectClass parent_class;
	public IntPtr realize;
	public IntPtr unrealize;
	public IntPtr copy;
	public IntPtr clone;
	public IntPtr init_from_rc;
	public IntPtr set_background;
	public IntPtr render_icon;
	public IntPtr draw_hline;
	public IntPtr draw_vline;
	public IntPtr draw_shadow;
	public IntPtr draw_arrow;
	public IntPtr draw_diamond;
	public IntPtr draw_box;
	public IntPtr draw_flat_box;
	public IntPtr draw_check;
	public IntPtr draw_option;
	public IntPtr draw_tab;
	public IntPtr draw_shadow_gap;
	public IntPtr draw_box_gap;
	public IntPtr draw_extension;
	public IntPtr draw_focus;
	public IntPtr draw_slider;
	public IntPtr draw_handle;
	public IntPtr draw_expander;
	public IntPtr draw_layout;
	public IntPtr draw_resize_grip;
	public IntPtr draw_spinner;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
	public IntPtr _gtk_reserved5;
	public IntPtr _gtk_reserved6;
	public IntPtr _gtk_reserved7;
	public IntPtr _gtk_reserved8;
	public IntPtr _gtk_reserved9;
	public IntPtr _gtk_reserved10;
	public IntPtr _gtk_reserved11;
}
