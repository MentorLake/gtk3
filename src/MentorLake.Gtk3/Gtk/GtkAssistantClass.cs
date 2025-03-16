namespace MentorLake.Gtk;

public class GtkAssistantClassHandle : BaseSafeHandle
{
}


public static class GtkAssistantClassExtensions
{

	public static GtkAssistantClass Dereference(this GtkAssistantClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkAssistantClass>(x.DangerousGetHandle());
}
internal class GtkAssistantClassExterns
{
}

public struct GtkAssistantClass
{
	public GtkWindowClass parent_class;
	public IntPtr prepare;
	public IntPtr apply;
	public IntPtr close;
	public IntPtr cancel;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
	public IntPtr _gtk_reserved5;
}
