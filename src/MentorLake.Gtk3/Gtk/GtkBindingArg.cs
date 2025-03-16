namespace MentorLake.Gtk;

public class GtkBindingArgHandle : BaseSafeHandle
{
}


public static class GtkBindingArgExtensions
{

	public static GtkBindingArg Dereference(this GtkBindingArgHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkBindingArg>(x.DangerousGetHandle());
}
internal class GtkBindingArgExterns
{
}

public struct GtkBindingArg
{
	public GType arg_type;
}
