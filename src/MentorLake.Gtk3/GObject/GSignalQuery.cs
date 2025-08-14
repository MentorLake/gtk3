namespace MentorLake.GObject;

/// <summary>
/// <para>
/// A structure holding in-depth information for a specific signal.
/// </para>
/// <para>
/// See also: g_signal_query()
/// </para>
/// </summary>

public class GSignalQueryHandle : BaseSafeHandle
{
}


public static class GSignalQueryExtensions
{

	public static GSignalQuery Dereference(this GSignalQueryHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GSignalQuery>(x.DangerousGetHandle());
}
internal class GSignalQueryExterns
{
}

/// <summary>
/// <para>
/// A structure holding in-depth information for a specific signal.
/// </para>
/// <para>
/// See also: g_signal_query()
/// </para>
/// </summary>

public struct GSignalQuery
{
	/// <summary>
/// <para>
/// The signal id of the signal being queried, or 0 if the
///  signal to be queried was unknown.
/// </para>
/// </summary>

public uint signal_id;
	/// <summary>
/// <para>
/// The signal name.
/// </para>
/// </summary>

public string signal_name;
	/// <summary>
/// <para>
/// The interface/instance type that this signal can be emitted for.
/// </para>
/// </summary>

public GType itype;
	/// <summary>
/// <para>
/// The signal flags as passed in to g_signal_new().
/// </para>
/// </summary>

public GSignalFlags signal_flags;
	/// <summary>
/// <para>
/// The return type for user callbacks.
/// </para>
/// </summary>

public GType return_type;
	/// <summary>
/// <para>
/// The number of parameters that user callbacks take.
/// </para>
/// </summary>

public uint n_params;
	/// <summary>
/// <para>
/// The individual parameter types for
///  user callbacks, note that the effective callback signature is:
///  |[<!-- language="C" -->
///  @return_type callback (#gpointer     data1,
///  [param_types param_names,]
///  gpointer     data2);
///  ]|
/// </para>
/// </summary>

[MarshalAs(UnmanagedType.ByValArray)] public GType[] param_types;
}
