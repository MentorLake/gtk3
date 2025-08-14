namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A #GtkBindingArg holds the data associated with
/// an argument for a key binding signal emission as
/// stored in #GtkBindingSignal.
/// </para>
/// </summary>

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

/// <summary>
/// <para>
/// A #GtkBindingArg holds the data associated with
/// an argument for a key binding signal emission as
/// stored in #GtkBindingSignal.
/// </para>
/// </summary>

public struct GtkBindingArg
{
	/// <summary>
/// <para>
/// implementation detail
/// </para>
/// </summary>

public GType arg_type;
}
