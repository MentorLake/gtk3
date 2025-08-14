namespace MentorLake.Atk;

/// <summary>
/// <para>
/// Note: @old_value field of #AtkPropertyValues will not contain a
/// valid value. This is a field defined with the purpose of contain
/// the previous value of the property, but is not used anymore.
/// </para>
/// </summary>

public class AtkPropertyValuesHandle : BaseSafeHandle
{
}


public static class AtkPropertyValuesExtensions
{

	public static AtkPropertyValues Dereference(this AtkPropertyValuesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<AtkPropertyValues>(x.DangerousGetHandle());
}
internal class AtkPropertyValuesExterns
{
}

/// <summary>
/// <para>
/// Note: @old_value field of #AtkPropertyValues will not contain a
/// valid value. This is a field defined with the purpose of contain
/// the previous value of the property, but is not used anymore.
/// </para>
/// </summary>

public struct AtkPropertyValues
{
	/// <summary>
/// <para>
/// The name of the ATK property which has changed.
/// </para>
/// </summary>

public string property_name;
	/// <summary>
/// <para>
/// NULL. This field is not used anymore.
/// </para>
/// </summary>

public GValue old_value;
	/// <summary>
/// <para>
/// The new value of the named property.
/// </para>
/// </summary>

public GValue new_value;
}
