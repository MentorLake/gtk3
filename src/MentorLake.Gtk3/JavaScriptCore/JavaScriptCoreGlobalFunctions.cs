namespace MentorLake.JavaScriptCore;

public class JavaScriptCoreGlobalFunctions
{
/// <summary>
/// <para>
/// Returns the major version number of the JavaScriptCore library.
/// (e.g. in JavaScriptCore version 1.8.3 this is 1.)
/// </para>
/// <para>
/// This function is in the library, so it represents the JavaScriptCore library
/// your code is running against. Contrast with the #JSC_MAJOR_VERSION
/// macro, which represents the major version of the JavaScriptCore headers you
/// have included when compiling your code.
/// </para>
/// </summary>

/// <return>
/// the major version number of the JavaScriptCore library
/// </return>

	public static uint GetMajorVersion()
	{
		return JavaScriptCoreGlobalFunctionsExterns.jsc_get_major_version();
	}

/// <summary>
/// <para>
/// Returns the micro version number of the JavaScriptCore library.
/// (e.g. in JavaScriptCore version 1.8.3 this is 3.)
/// </para>
/// <para>
/// This function is in the library, so it represents the JavaScriptCore library
/// your code is running against. Contrast with the #JSC_MICRO_VERSION
/// macro, which represents the micro version of the JavaScriptCore headers you
/// have included when compiling your code.
/// </para>
/// </summary>

/// <return>
/// the micro version number of the JavaScriptCore library
/// </return>

	public static uint GetMicroVersion()
	{
		return JavaScriptCoreGlobalFunctionsExterns.jsc_get_micro_version();
	}

/// <summary>
/// <para>
/// Returns the minor version number of the JavaScriptCore library.
/// (e.g. in JavaScriptCore version 1.8.3 this is 8.)
/// </para>
/// <para>
/// This function is in the library, so it represents the JavaScriptCore library
/// your code is running against. Contrast with the #JSC_MINOR_VERSION
/// macro, which represents the minor version of the JavaScriptCore headers you
/// have included when compiling your code.
/// </para>
/// </summary>

/// <return>
/// the minor version number of the JavaScriptCore library
/// </return>

	public static uint GetMinorVersion()
	{
		return JavaScriptCoreGlobalFunctionsExterns.jsc_get_minor_version();
	}

/// <summary>
/// <para>
/// Iterates all available options calling @function for each one. Iteration can
/// stop early if @function returns %FALSE.
/// </para>
/// </summary>

/// <param name="function">
/// a #JSCOptionsFunc callback
/// </param>
/// <param name="user_data">
/// callback user data
/// </param>

	public static void OptionsForeach(MentorLake.JavaScriptCore.JSCOptionsFunc function, IntPtr user_data)
	{
		JavaScriptCoreGlobalFunctionsExterns.jsc_options_foreach(function, user_data);
	}

/// <summary>
/// <para>
/// Get @option as a #gboolean value.
/// </para>
/// </summary>

/// <param name="option">
/// the option identifier
/// </param>
/// <param name="value">
/// return location for the option value
/// </param>
/// <return>
/// %TRUE if @value has been set or %FALSE if the option doesn&apos;t exist
/// </return>

	public static bool OptionsGetBoolean(string option, out bool value)
	{
		return JavaScriptCoreGlobalFunctionsExterns.jsc_options_get_boolean(option, out value);
	}

/// <summary>
/// <para>
/// Get @option as a #gdouble value.
/// </para>
/// </summary>

/// <param name="option">
/// the option identifier
/// </param>
/// <param name="value">
/// return location for the option value
/// </param>
/// <return>
/// %TRUE if @value has been set or %FALSE if the option doesn&apos;t exist
/// </return>

	public static bool OptionsGetDouble(string option, out double value)
	{
		return JavaScriptCoreGlobalFunctionsExterns.jsc_options_get_double(option, out value);
	}

/// <summary>
/// <para>
/// Get @option as a #gint value.
/// </para>
/// </summary>

/// <param name="option">
/// the option identifier
/// </param>
/// <param name="value">
/// return location for the option value
/// </param>
/// <return>
/// %TRUE if @value has been set or %FALSE if the option doesn&apos;t exist
/// </return>

	public static bool OptionsGetInt(string option, out int value)
	{
		return JavaScriptCoreGlobalFunctionsExterns.jsc_options_get_int(option, out value);
	}

/// <summary>
/// <para>
/// Create a #GOptionGroup to handle JSCOptions as command line arguments.
/// The options will be exposed as command line arguments with the form
/// &amp;lt;emphasis&amp;gt;--jsc-&amp;lt;option&amp;gt;=&amp;lt;value&amp;gt;&amp;lt;/emphasis&amp;gt;.
/// Each entry in the returned #GOptionGroup is configured to apply the
/// corresponding option during command line parsing. Applications only need to
/// pass the returned group to g_option_context_add_group(), and the rest will
/// be taken care for automatically.
/// </para>
/// </summary>

/// <return>
/// a #GOptionGroup for the JSCOptions
/// </return>

	public static MentorLake.GLib.GOptionGroupHandle OptionsGetOptionGroup()
	{
		return JavaScriptCoreGlobalFunctionsExterns.jsc_options_get_option_group();
	}

/// <summary>
/// <para>
/// Get @option as a range string. The string must be in the
/// format &amp;lt;emphasis&amp;gt;[!]&amp;lt;low&amp;gt;[:&amp;lt;high&amp;gt;]&amp;lt;/emphasis&amp;gt; where low and high are #guint values.
/// Values between low and high (both included) will be considered in
/// the range, unless &amp;lt;emphasis&amp;gt;!&amp;lt;/emphasis&amp;gt; is used to invert the range.
/// </para>
/// </summary>

/// <param name="option">
/// the option identifier
/// </param>
/// <param name="value">
/// return location for the option value
/// </param>
/// <return>
/// %TRUE if @value has been set or %FALSE if the option doesn&apos;t exist
/// </return>

	public static bool OptionsGetRangeString(string option, out string value)
	{
		return JavaScriptCoreGlobalFunctionsExterns.jsc_options_get_range_string(option, out value);
	}

/// <summary>
/// <para>
/// Get @option as a #gsize value.
/// </para>
/// </summary>

/// <param name="option">
/// the option identifier
/// </param>
/// <param name="value">
/// return location for the option value
/// </param>
/// <return>
/// %TRUE if @value has been set or %FALSE if the option doesn&apos;t exist
/// </return>

	public static bool OptionsGetSize(string option, out UIntPtr value)
	{
		return JavaScriptCoreGlobalFunctionsExterns.jsc_options_get_size(option, out value);
	}

/// <summary>
/// <para>
/// Get @option as a string.
/// </para>
/// </summary>

/// <param name="option">
/// the option identifier
/// </param>
/// <param name="value">
/// return location for the option value
/// </param>
/// <return>
/// %TRUE if @value has been set or %FALSE if the option doesn&apos;t exist
/// </return>

	public static bool OptionsGetString(string option, out string value)
	{
		return JavaScriptCoreGlobalFunctionsExterns.jsc_options_get_string(option, out value);
	}

/// <summary>
/// <para>
/// Get @option as a #guint value.
/// </para>
/// </summary>

/// <param name="option">
/// the option identifier
/// </param>
/// <param name="value">
/// return location for the option value
/// </param>
/// <return>
/// %TRUE if @value has been set or %FALSE if the option doesn&apos;t exist
/// </return>

	public static bool OptionsGetUint(string option, out uint value)
	{
		return JavaScriptCoreGlobalFunctionsExterns.jsc_options_get_uint(option, out value);
	}

/// <summary>
/// <para>
/// Set @option as a #gboolean value.
/// </para>
/// </summary>

/// <param name="option">
/// the option identifier
/// </param>
/// <param name="value">
/// the value to set
/// </param>
/// <return>
/// %TRUE if option was correctly set or %FALSE otherwise.
/// </return>

	public static bool OptionsSetBoolean(string option, bool value)
	{
		return JavaScriptCoreGlobalFunctionsExterns.jsc_options_set_boolean(option, value);
	}

/// <summary>
/// <para>
/// Set @option as a #gdouble value.
/// </para>
/// </summary>

/// <param name="option">
/// the option identifier
/// </param>
/// <param name="value">
/// the value to set
/// </param>
/// <return>
/// %TRUE if option was correctly set or %FALSE otherwise.
/// </return>

	public static bool OptionsSetDouble(string option, double value)
	{
		return JavaScriptCoreGlobalFunctionsExterns.jsc_options_set_double(option, value);
	}

/// <summary>
/// <para>
/// Set @option as a #gint value.
/// </para>
/// </summary>

/// <param name="option">
/// the option identifier
/// </param>
/// <param name="value">
/// the value to set
/// </param>
/// <return>
/// %TRUE if option was correctly set or %FALSE otherwise.
/// </return>

	public static bool OptionsSetInt(string option, int value)
	{
		return JavaScriptCoreGlobalFunctionsExterns.jsc_options_set_int(option, value);
	}

/// <summary>
/// <para>
/// Set @option as a range string. The string must be in the
/// format &amp;lt;emphasis&amp;gt;[!]&amp;lt;low&amp;gt;[:&amp;lt;high&amp;gt;]&amp;lt;/emphasis&amp;gt; where low and high are #guint values.
/// Values between low and high (both included) will be considered in
/// the range, unless &amp;lt;emphasis&amp;gt;!&amp;lt;/emphasis&amp;gt; is used to invert the range.
/// </para>
/// </summary>

/// <param name="option">
/// the option identifier
/// </param>
/// <param name="value">
/// the value to set
/// </param>
/// <return>
/// %TRUE if option was correctly set or %FALSE otherwise.
/// </return>

	public static bool OptionsSetRangeString(string option, string value)
	{
		return JavaScriptCoreGlobalFunctionsExterns.jsc_options_set_range_string(option, value);
	}

/// <summary>
/// <para>
/// Set @option as a #gsize value.
/// </para>
/// </summary>

/// <param name="option">
/// the option identifier
/// </param>
/// <param name="value">
/// the value to set
/// </param>
/// <return>
/// %TRUE if option was correctly set or %FALSE otherwise.
/// </return>

	public static bool OptionsSetSize(string option, UIntPtr value)
	{
		return JavaScriptCoreGlobalFunctionsExterns.jsc_options_set_size(option, value);
	}

/// <summary>
/// <para>
/// Set @option as a string.
/// </para>
/// </summary>

/// <param name="option">
/// the option identifier
/// </param>
/// <param name="value">
/// the value to set
/// </param>
/// <return>
/// %TRUE if option was correctly set or %FALSE otherwise.
/// </return>

	public static bool OptionsSetString(string option, string value)
	{
		return JavaScriptCoreGlobalFunctionsExterns.jsc_options_set_string(option, value);
	}

/// <summary>
/// <para>
/// Set @option as a #guint value.
/// </para>
/// </summary>

/// <param name="option">
/// the option identifier
/// </param>
/// <param name="value">
/// the value to set
/// </param>
/// <return>
/// %TRUE if option was correctly set or %FALSE otherwise.
/// </return>

	public static bool OptionsSetUint(string option, uint value)
	{
		return JavaScriptCoreGlobalFunctionsExterns.jsc_options_set_uint(option, value);
	}

}

internal class JavaScriptCoreGlobalFunctionsExterns
{
	[DllImport(JavaScriptCoreLibrary.Name)]
	internal static extern uint jsc_get_major_version();

	[DllImport(JavaScriptCoreLibrary.Name)]
	internal static extern uint jsc_get_micro_version();

	[DllImport(JavaScriptCoreLibrary.Name)]
	internal static extern uint jsc_get_minor_version();

	[DllImport(JavaScriptCoreLibrary.Name)]
	internal static extern void jsc_options_foreach(MentorLake.JavaScriptCore.JSCOptionsFunc function, IntPtr user_data);

	[DllImport(JavaScriptCoreLibrary.Name)]
	internal static extern bool jsc_options_get_boolean(string option, out bool value);

	[DllImport(JavaScriptCoreLibrary.Name)]
	internal static extern bool jsc_options_get_double(string option, out double value);

	[DllImport(JavaScriptCoreLibrary.Name)]
	internal static extern bool jsc_options_get_int(string option, out int value);

	[DllImport(JavaScriptCoreLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionGroupHandle>))]
	internal static extern MentorLake.GLib.GOptionGroupHandle jsc_options_get_option_group();

	[DllImport(JavaScriptCoreLibrary.Name)]
	internal static extern bool jsc_options_get_range_string(string option, out string value);

	[DllImport(JavaScriptCoreLibrary.Name)]
	internal static extern bool jsc_options_get_size(string option, out UIntPtr value);

	[DllImport(JavaScriptCoreLibrary.Name)]
	internal static extern bool jsc_options_get_string(string option, out string value);

	[DllImport(JavaScriptCoreLibrary.Name)]
	internal static extern bool jsc_options_get_uint(string option, out uint value);

	[DllImport(JavaScriptCoreLibrary.Name)]
	internal static extern bool jsc_options_set_boolean(string option, bool value);

	[DllImport(JavaScriptCoreLibrary.Name)]
	internal static extern bool jsc_options_set_double(string option, double value);

	[DllImport(JavaScriptCoreLibrary.Name)]
	internal static extern bool jsc_options_set_int(string option, int value);

	[DllImport(JavaScriptCoreLibrary.Name)]
	internal static extern bool jsc_options_set_range_string(string option, string value);

	[DllImport(JavaScriptCoreLibrary.Name)]
	internal static extern bool jsc_options_set_size(string option, UIntPtr value);

	[DllImport(JavaScriptCoreLibrary.Name)]
	internal static extern bool jsc_options_set_string(string option, string value);

	[DllImport(JavaScriptCoreLibrary.Name)]
	internal static extern bool jsc_options_set_uint(string option, uint value);

}
