namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A #GtkTargetPair is used to represent the same
/// information as a table of #GtkTargetEntry, but in
/// an efficient form.
/// </para>
/// </summary>

public class GtkTargetPairHandle : BaseSafeHandle
{
}


public static class GtkTargetPairExtensions
{

	public static GtkTargetPair Dereference(this GtkTargetPairHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkTargetPair>(x.DangerousGetHandle());
}
internal class GtkTargetPairExterns
{
}

/// <summary>
/// <para>
/// A #GtkTargetPair is used to represent the same
/// information as a table of #GtkTargetEntry, but in
/// an efficient form.
/// </para>
/// </summary>

public struct GtkTargetPair
{
	/// <summary>
/// <para>
/// #GdkAtom representation of the target type
/// </para>
/// </summary>

public GdkAtom target;
	/// <summary>
/// <para>
/// #GtkTargetFlags for DND
/// </para>
/// </summary>

public uint flags;
	/// <summary>
/// <para>
/// an application-assigned integer ID which will
///     get passed as a parameter to e.g the #GtkWidget::selection-get
///     signal. It allows the application to identify the target
///     type without extensive string compares.
/// </para>
/// </summary>

public uint info;
}
