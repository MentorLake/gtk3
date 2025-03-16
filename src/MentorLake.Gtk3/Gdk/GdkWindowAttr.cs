namespace MentorLake.Gdk;

public class GdkWindowAttrHandle : BaseSafeHandle
{
}


public static class GdkWindowAttrExtensions
{

	public static GdkWindowAttr Dereference(this GdkWindowAttrHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkWindowAttr>(x.DangerousGetHandle());
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
	public IntPtr visual;
	public GdkWindowType window_type;
	public IntPtr cursor;
	public string wmclass_name;
	public string wmclass_class;
	public bool override_redirect;
	public GdkWindowTypeHint type_hint;
}
