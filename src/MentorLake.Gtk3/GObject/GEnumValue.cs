namespace MentorLake.GObject;

/// <summary>
/// <para>
/// A structure which contains a single enum value, its name, and its
/// nickname.
/// </para>
/// </summary>

public class GEnumValueHandle : BaseSafeHandle
{
}


public static class GEnumValueExtensions
{

	public static GEnumValue Dereference(this GEnumValueHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GEnumValue>(x.DangerousGetHandle());
}
internal class GEnumValueExterns
{
}

/// <summary>
/// <para>
/// A structure which contains a single enum value, its name, and its
/// nickname.
/// </para>
/// </summary>

public struct GEnumValue
{
	/// <summary>
/// <para>
/// the enum value
/// </para>
/// </summary>

public int value;
	/// <summary>
/// <para>
/// the name of the value
/// </para>
/// </summary>

public string value_name;
	/// <summary>
/// <para>
/// the nickname of the value
/// </para>
/// </summary>

public string value_nick;
}
