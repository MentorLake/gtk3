namespace MentorLake.Gtk;

public class GtkIMContextClassHandle : BaseSafeHandle
{
}


public static class GtkIMContextClassExtensions
{

	public static GtkIMContextClass Dereference(this GtkIMContextClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkIMContextClass>(x.DangerousGetHandle());
}
internal class GtkIMContextClassExterns
{
}

public struct GtkIMContextClass
{
	public IntPtr preedit_start;
	public IntPtr preedit_end;
	public IntPtr preedit_changed;
	public IntPtr commit;
	public IntPtr retrieve_surrounding;
	public IntPtr delete_surrounding;
	public IntPtr set_client_window;
	public IntPtr get_preedit_string;
	public IntPtr filter_keypress;
	public IntPtr focus_in;
	public IntPtr focus_out;
	public IntPtr reset;
	public IntPtr set_cursor_location;
	public IntPtr set_use_preedit;
	public IntPtr set_surrounding;
	public IntPtr get_surrounding;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
	public IntPtr _gtk_reserved5;
	public IntPtr _gtk_reserved6;
}
