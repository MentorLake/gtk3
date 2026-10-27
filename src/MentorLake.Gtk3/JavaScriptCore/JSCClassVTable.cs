namespace MentorLake.JavaScriptCore;

/// <summary>
/// <para>
/// Virtual table for a JSCClass. This can be optionally used when registering a #JSCClass in a #JSCContext
/// to provide a custom implementation for the class. All virtual functions are optional and can be set to
/// %NULL to fallback to the default implementation.
/// </para>
/// </summary>

public class JSCClassVTableHandle : BaseSafeHandle
{
}


public static class JSCClassVTableExtensions
{

	public static JSCClassVTable Dereference(this JSCClassVTableHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<JSCClassVTable>(x.DangerousGetHandle());
}
internal class JSCClassVTableExterns
{
}

/// <summary>
/// <para>
/// Virtual table for a JSCClass. This can be optionally used when registering a #JSCClass in a #JSCContext
/// to provide a custom implementation for the class. All virtual functions are optional and can be set to
/// %NULL to fallback to the default implementation.
/// </para>
/// </summary>

public struct JSCClassVTable
{
	/// <summary>
/// <para>
/// a #JSCClassGetPropertyFunction for getting a property.
/// </para>
/// </summary>

public JSCClassGetPropertyFunction get_property;
	/// <summary>
/// <para>
/// a #JSCClassSetPropertyFunction for setting a property.
/// </para>
/// </summary>

public JSCClassSetPropertyFunction set_property;
	/// <summary>
/// <para>
/// a #JSCClassHasPropertyFunction for querying a property.
/// </para>
/// </summary>

public JSCClassHasPropertyFunction has_property;
	/// <summary>
/// <para>
/// a #JSCClassDeletePropertyFunction for deleting a property.
/// </para>
/// </summary>

public JSCClassDeletePropertyFunction delete_property;
	/// <summary>
/// <para>
/// a #JSCClassEnumeratePropertiesFunction for enumerating properties.
/// </para>
/// </summary>

public JSCClassEnumeratePropertiesFunction enumerate_properties;
	
public IntPtr _jsc_reserved0;
	
public IntPtr _jsc_reserved1;
	
public IntPtr _jsc_reserved2;
	
public IntPtr _jsc_reserved3;
}
