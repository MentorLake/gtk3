namespace MentorLake.GObject;

/// <summary>
/// <para>
/// This structure is used to provide the type system with the information
/// required to initialize and destruct (finalize) a parameter's class and
/// instances thereof.
/// </para>
/// <para>
/// The initialized structure is passed to the g_param_type_register_static()
/// The type system will perform a deep copy of this structure, so its memory
/// does not need to be persistent across invocation of
/// g_param_type_register_static().
/// </para>
/// </summary>

public class GParamSpecTypeInfoHandle : BaseSafeHandle
{
}


public static class GParamSpecTypeInfoExtensions
{

	public static GParamSpecTypeInfo Dereference(this GParamSpecTypeInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GParamSpecTypeInfo>(x.DangerousGetHandle());
}
internal class GParamSpecTypeInfoExterns
{
}

/// <summary>
/// <para>
/// This structure is used to provide the type system with the information
/// required to initialize and destruct (finalize) a parameter's class and
/// instances thereof.
/// </para>
/// <para>
/// The initialized structure is passed to the g_param_type_register_static()
/// The type system will perform a deep copy of this structure, so its memory
/// does not need to be persistent across invocation of
/// g_param_type_register_static().
/// </para>
/// </summary>

public struct GParamSpecTypeInfo
{
	/// <summary>
/// <para>
/// Size of the instance (object) structure.
/// </para>
/// </summary>

public ushort instance_size;
	/// <summary>
/// <para>
/// Prior to GLib 2.10, it specified the number of pre-allocated (cached) instances to reserve memory for (0 indicates no caching). Since GLib 2.10, it is ignored, since instances are allocated with the [slice allocator][glib-Memory-Slices] now.
/// </para>
/// </summary>

public ushort n_preallocs;
	/// <summary>
/// <para>
/// Location of the instance initialization function (optional).
/// </para>
/// </summary>

public IntPtr instance_init;
	/// <summary>
/// <para>
/// The #GType of values conforming to this #GParamSpec
/// </para>
/// </summary>

public GType value_type;
	/// <summary>
/// <para>
/// The instance finalization function (optional).
/// </para>
/// </summary>

public IntPtr finalize;
	/// <summary>
/// <para>
/// Resets a @value to the default value for @pspec
///  (recommended, the default is g_value_reset()), see
///  g_param_value_set_default().
/// </para>
/// </summary>

public IntPtr value_set_default;
	/// <summary>
/// <para>
/// Ensures that the contents of @value comply with the
///  specifications set out by @pspec (optional), see
///  g_param_value_validate().
/// </para>
/// </summary>

public IntPtr value_validate;
	/// <summary>
/// <para>
/// Compares @value1 with @value2 according to @pspec
///  (recommended, the default is memcmp()), see g_param_values_cmp().
/// </para>
/// </summary>

public IntPtr values_cmp;
}
