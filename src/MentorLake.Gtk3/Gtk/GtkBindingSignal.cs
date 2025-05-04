namespace MentorLake.Gtk;

public class GtkBindingSignalHandle : BaseSafeHandle
{
}


public static class GtkBindingSignalExtensions
{

	public static GtkBindingSignal Dereference(this GtkBindingSignalHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkBindingSignal>(x.DangerousGetHandle());
}
internal class GtkBindingSignalExterns
{
}

public struct GtkBindingSignal
{
	public IntPtr next;
	public string signal_name;
	public uint n_args;
	[MarshalAs(UnmanagedType.ByValArray)] public GtkBindingArg[] args;
}
