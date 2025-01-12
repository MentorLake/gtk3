namespace MentorLake.Gtk3.Gdk3;

public class GdkWindowAttrHandle : BaseSafeHandle
{
}


public static class GdkWindowAttrHandleExtensions
{
}
internal class GdkWindowAttrExterns
{
}

public struct GdkWindowAttr
{
	public string title;
	public int event_mask;
	public int x;
	public int y;
	public int width;
	public int height;
	public GdkWindowWindowClass wclass;
	public GdkVisualHandle visual;
	public GdkWindowType window_type;
	public GdkCursorHandle cursor;
	public string wmclass_name;
	public string wmclass_class;
	public bool override_redirect;
	public GdkWindowTypeHint type_hint;
}
