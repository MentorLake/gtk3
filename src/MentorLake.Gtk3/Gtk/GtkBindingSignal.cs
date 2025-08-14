namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A GtkBindingSignal stores the necessary information to
/// activate a widget in response to a key press via a signal
/// emission.
/// </para>
/// </summary>

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

/// <summary>
/// <para>
/// A GtkBindingSignal stores the necessary information to
/// activate a widget in response to a key press via a signal
/// emission.
/// </para>
/// </summary>

public struct GtkBindingSignal
{
	/// <summary>
/// <para>
/// implementation detail
/// </para>
/// </summary>

public IntPtr next;
	/// <summary>
/// <para>
/// the action signal to be emitted
/// </para>
/// </summary>

public string signal_name;
	/// <summary>
/// <para>
/// number of arguments specified for the signal
/// </para>
/// </summary>

public uint n_args;
	/// <summary>
/// <para>
/// the arguments specified for the signal
/// </para>
/// </summary>

[MarshalAs(UnmanagedType.ByValArray)] public GtkBindingArg[] args;
}
