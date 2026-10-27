namespace MentorLake.JavaScriptCore;

/// <summary>
/// <para>
/// Flags used when defining properties with jsc_value_object_define_property_data() and
/// jsc_value_object_define_property_accessor().
/// </para>
/// </summary>

[Flags]
public enum JSCValuePropertyFlags : uint
{
/// <summary>
/// <para>
/// the type of the property descriptor may be changed and the
///  property may be deleted from the corresponding object.
/// </para>
/// </summary>

	JSC_VALUE_PROPERTY_CONFIGURABLE = 1,
/// <summary>
/// <para>
/// the property shows up during enumeration of the properties on
///  the corresponding object.
/// </para>
/// </summary>

	JSC_VALUE_PROPERTY_ENUMERABLE = 2,
/// <summary>
/// <para>
/// the value associated with the property may be changed with an
///  assignment operator. This doesn&apos;t have any effect when passed to jsc_value_object_define_property_accessor().
/// </para>
/// </summary>

	JSC_VALUE_PROPERTY_WRITABLE = 4
}
