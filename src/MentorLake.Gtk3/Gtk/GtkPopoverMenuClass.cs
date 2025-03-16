namespace MentorLake.Gtk;

public class GtkPopoverMenuClassHandle : BaseSafeHandle
{
}


public static class GtkPopoverMenuClassExtensions
{

	public static GtkPopoverMenuClass Dereference(this GtkPopoverMenuClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkPopoverMenuClass>(x.DangerousGetHandle());
}
internal class GtkPopoverMenuClassExterns
{
}

public struct GtkPopoverMenuClass
{
	public GtkPopoverClass parent_class;
}
