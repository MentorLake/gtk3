namespace MentorLake.Gtk;

public class GtkStackSwitcherClassHandle : BaseSafeHandle
{
}


public static class GtkStackSwitcherClassExtensions
{

	public static GtkStackSwitcherClass Dereference(this GtkStackSwitcherClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkStackSwitcherClass>(x.DangerousGetHandle());
}
internal class GtkStackSwitcherClassExterns
{
}

public struct GtkStackSwitcherClass
{
	public GtkBoxClass parent_class;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
