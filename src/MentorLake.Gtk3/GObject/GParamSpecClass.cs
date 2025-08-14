namespace MentorLake.GObject;

/// <summary>
/// <para>
/// The class structure for the GParamSpec type.
/// Normally, GParamSpec classes are filled by
/// g_param_type_register_static().
/// </para>
/// </summary>

public class GParamSpecClassHandle : BaseSafeHandle
{
}


public static class GParamSpecClassExtensions
{

	public static GParamSpecClass Dereference(this GParamSpecClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GParamSpecClass>(x.DangerousGetHandle());
}
internal class GParamSpecClassExterns
{
}

/// <summary>
/// <para>
/// The class structure for the GParamSpec type.
/// Normally, GParamSpec classes are filled by
/// g_param_type_register_static().
/// </para>
/// </summary>

public struct GParamSpecClass
{
	/// <summary>
/// <para>
/// the parent class
/// </para>
/// </summary>

public GTypeClass g_type_class;
	/// <summary>
/// <para>
/// the #GValue type for this parameter
/// </para>
/// </summary>

public GType value_type;
	/// <summary>
/// <para>
/// The instance finalization function (optional), should chain
///  up to the finalize method of the parent class.
/// </para>
/// </summary>

public IntPtr finalize;
	/// <summary>
/// <para>
/// Resets a @value to the default value for this type
///  (recommended, the default is g_value_reset()), see
///  g_param_value_set_default().
/// </para>
/// </summary>

public IntPtr value_set_default;
	/// <summary>
/// <para>
/// Ensures that the contents of @value comply with the
///  specifications set out by this type (optional), see
///  g_param_value_validate().
/// </para>
/// </summary>

public IntPtr value_validate;
	/// <summary>
/// <para>
/// Compares @value1 with @value2 according to this type
///  (recommended, the default is memcmp()), see g_param_values_cmp().
/// </para>
/// </summary>

public IntPtr values_cmp;
	/// <summary>
/// <para>
/// Checks if contents of @value comply with the specifications
///   set out by this type, without modifying the value. This vfunc is optional.
///   If it isn't set, GObject will use @value_validate. Since 2.74
/// </para>
/// </summary>

public IntPtr value_is_valid;
}
