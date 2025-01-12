namespace MentorLake.Gtk3.Gtk3;

public class GtkBindingSignalHandle : BaseSafeHandle
{
}


public static class GtkBindingSignalHandleExtensions
{
}
internal class GtkBindingSignalExterns
{
}

public struct GtkBindingSignal
{
	public GtkBindingSignalHandle next;
	public string signal_name;
	public uint n_args;
	public GtkBindingArgHandle args;
}
