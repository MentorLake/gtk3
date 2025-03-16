namespace MentorLake.Gtk;

public class GtkVBoxClassHandle : BaseSafeHandle
{
}


public static class GtkVBoxClassExtensions
{

	public static GtkVBoxClass Dereference(this GtkVBoxClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkVBoxClass>(x.DangerousGetHandle());
}
internal class GtkVBoxClassExterns
{
}

public struct GtkVBoxClass
{
	public GtkBoxClass parent_class;
}
