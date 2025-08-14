namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Determines if a string matches a file attribute.
/// </para>
/// </summary>

public class GFileAttributeMatcherHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Creates a new file attribute matcher, which matches attributes
/// against a given string. #GFileAttributeMatchers are reference
/// counted structures, and are created with a reference count of 1. If
/// the number of references falls to 0, the #GFileAttributeMatcher is
/// automatically destroyed.
/// </para>
/// <para>
/// The @attributes string should be formatted with specific keys separated
/// from namespaces with a double colon. Several "namespace::key" strings may be
/// concatenated with a single comma (e.g. "standard::type,standard::is-hidden").
/// The wildcard "*" may be used to match all keys and namespaces, or
/// "namespace::*" will match all keys in a given namespace.
/// </para>
/// <para>
/// ## Examples of file attribute matcher strings and results
/// </para>
/// <para>
/// - `"*"`: matches all attributes.
/// - `"standard::is-hidden"`: matches only the key is-hidden in the
///   standard namespace.
/// - `"standard::type,unix::*"`: matches the type key in the standard
///   namespace and all keys in the unix namespace.
/// </para>
/// </summary>

/// <param name="attributes">
/// an attribute string to match.
/// </param>
/// <return>
/// a #GFileAttributeMatcher
/// </return>

	public static MentorLake.Gio.GFileAttributeMatcherHandle New(string attributes)
	{
		return GFileAttributeMatcherExterns.g_file_attribute_matcher_new(attributes);
	}

}


public static class GFileAttributeMatcherExtensions
{
/// <summary>
/// <para>
/// Checks if the matcher will match all of the keys in a given namespace.
/// This will always return %TRUE if a wildcard character is in use (e.g. if
/// matcher was created with "standard::*" and @ns is "standard", or if matcher was created
/// using "*" and namespace is anything.)
/// </para>
/// <para>
/// TODO: this is awkwardly worded.
/// </para>
/// </summary>

/// <param name="matcher">
/// a #GFileAttributeMatcher.
/// </param>
/// <param name="ns">
/// a string containing a file attribute namespace.
/// </param>
/// <return>
/// %TRUE if the matcher matches all of the entries
/// in the given @ns, %FALSE otherwise.
/// </return>

	public static bool EnumerateNamespace(this MentorLake.Gio.GFileAttributeMatcherHandle matcher, string ns)
	{
		if (matcher.IsInvalid) throw new Exception("Invalid handle (GFileAttributeMatcher)");
		return GFileAttributeMatcherExterns.g_file_attribute_matcher_enumerate_namespace(matcher, ns);
	}

/// <summary>
/// <para>
/// Gets the next matched attribute from a #GFileAttributeMatcher.
/// </para>
/// </summary>

/// <param name="matcher">
/// a #GFileAttributeMatcher.
/// </param>
/// <return>
/// a string containing the next attribute or, %NULL if
/// no more attribute exist.
/// </return>

	public static string EnumerateNext(this MentorLake.Gio.GFileAttributeMatcherHandle matcher)
	{
		if (matcher.IsInvalid) throw new Exception("Invalid handle (GFileAttributeMatcher)");
		return GFileAttributeMatcherExterns.g_file_attribute_matcher_enumerate_next(matcher);
	}

/// <summary>
/// <para>
/// Checks if an attribute will be matched by an attribute matcher. If
/// the matcher was created with the "*" matching string, this function
/// will always return %TRUE.
/// </para>
/// </summary>

/// <param name="matcher">
/// a #GFileAttributeMatcher.
/// </param>
/// <param name="attribute">
/// a file attribute key.
/// </param>
/// <return>
/// %TRUE if @attribute matches @matcher. %FALSE otherwise.
/// </return>

	public static bool Matches(this MentorLake.Gio.GFileAttributeMatcherHandle matcher, string attribute)
	{
		if (matcher.IsInvalid) throw new Exception("Invalid handle (GFileAttributeMatcher)");
		return GFileAttributeMatcherExterns.g_file_attribute_matcher_matches(matcher, attribute);
	}

/// <summary>
/// <para>
/// Checks if an attribute matcher only matches a given attribute. Always
/// returns %FALSE if "*" was used when creating the matcher.
/// </para>
/// </summary>

/// <param name="matcher">
/// a #GFileAttributeMatcher.
/// </param>
/// <param name="attribute">
/// a file attribute key.
/// </param>
/// <return>
/// %TRUE if the matcher only matches @attribute. %FALSE otherwise.
/// </return>

	public static bool MatchesOnly(this MentorLake.Gio.GFileAttributeMatcherHandle matcher, string attribute)
	{
		if (matcher.IsInvalid) throw new Exception("Invalid handle (GFileAttributeMatcher)");
		return GFileAttributeMatcherExterns.g_file_attribute_matcher_matches_only(matcher, attribute);
	}

/// <summary>
/// <para>
/// References a file attribute matcher.
/// </para>
/// </summary>

/// <param name="matcher">
/// a #GFileAttributeMatcher.
/// </param>
/// <return>
/// a #GFileAttributeMatcher.
/// </return>

	public static MentorLake.Gio.GFileAttributeMatcherHandle Ref(this MentorLake.Gio.GFileAttributeMatcherHandle matcher)
	{
		if (matcher.IsInvalid) throw new Exception("Invalid handle (GFileAttributeMatcher)");
		return GFileAttributeMatcherExterns.g_file_attribute_matcher_ref(matcher);
	}

/// <summary>
/// <para>
/// Subtracts all attributes of @subtract from @matcher and returns
/// a matcher that supports those attributes.
/// </para>
/// <para>
/// Note that currently it is not possible to remove a single
/// attribute when the @matcher matches the whole namespace - or remove
/// a namespace or attribute when the matcher matches everything. This
/// is a limitation of the current implementation, but may be fixed
/// in the future.
/// </para>
/// </summary>

/// <param name="matcher">
/// Matcher to subtract from
/// </param>
/// <param name="subtract">
/// The matcher to subtract
/// </param>
/// <return>
/// A file attribute matcher matching all attributes of
///     @matcher that are not matched by @subtract
/// </return>

	public static MentorLake.Gio.GFileAttributeMatcherHandle Subtract(this MentorLake.Gio.GFileAttributeMatcherHandle matcher, MentorLake.Gio.GFileAttributeMatcherHandle subtract)
	{
		if (matcher.IsInvalid) throw new Exception("Invalid handle (GFileAttributeMatcher)");
		return GFileAttributeMatcherExterns.g_file_attribute_matcher_subtract(matcher, subtract);
	}

/// <summary>
/// <para>
/// Prints what the matcher is matching against. The format will be
/// equal to the format passed to g_file_attribute_matcher_new().
/// The output however, might not be identical, as the matcher may
/// decide to use a different order or omit needless parts.
/// </para>
/// </summary>

/// <param name="matcher">
/// a #GFileAttributeMatcher.
/// </param>
/// <return>
/// a string describing the attributes the matcher matches
///   against or %NULL if @matcher was %NULL.
/// </return>

	public static string ToString(this MentorLake.Gio.GFileAttributeMatcherHandle matcher)
	{
		if (matcher.IsInvalid) throw new Exception("Invalid handle (GFileAttributeMatcher)");
		return GFileAttributeMatcherExterns.g_file_attribute_matcher_to_string(matcher);
	}

/// <summary>
/// <para>
/// Unreferences @matcher. If the reference count falls below 1,
/// the @matcher is automatically freed.
/// </para>
/// </summary>

/// <param name="matcher">
/// a #GFileAttributeMatcher.
/// </param>

	public static void Unref(this MentorLake.Gio.GFileAttributeMatcherHandle matcher)
	{
		if (matcher.IsInvalid) throw new Exception("Invalid handle (GFileAttributeMatcher)");
		GFileAttributeMatcherExterns.g_file_attribute_matcher_unref(matcher);
	}


	public static GFileAttributeMatcher Dereference(this GFileAttributeMatcherHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GFileAttributeMatcher>(x.DangerousGetHandle());
}
internal class GFileAttributeMatcherExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileAttributeMatcherHandle>))]
	internal static extern MentorLake.Gio.GFileAttributeMatcherHandle g_file_attribute_matcher_new(string attributes);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_attribute_matcher_enumerate_namespace([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileAttributeMatcherHandle>))] MentorLake.Gio.GFileAttributeMatcherHandle matcher, string ns);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_file_attribute_matcher_enumerate_next([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileAttributeMatcherHandle>))] MentorLake.Gio.GFileAttributeMatcherHandle matcher);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_attribute_matcher_matches([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileAttributeMatcherHandle>))] MentorLake.Gio.GFileAttributeMatcherHandle matcher, string attribute);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_file_attribute_matcher_matches_only([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileAttributeMatcherHandle>))] MentorLake.Gio.GFileAttributeMatcherHandle matcher, string attribute);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileAttributeMatcherHandle>))]
	internal static extern MentorLake.Gio.GFileAttributeMatcherHandle g_file_attribute_matcher_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileAttributeMatcherHandle>))] MentorLake.Gio.GFileAttributeMatcherHandle matcher);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileAttributeMatcherHandle>))]
	internal static extern MentorLake.Gio.GFileAttributeMatcherHandle g_file_attribute_matcher_subtract([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileAttributeMatcherHandle>))] MentorLake.Gio.GFileAttributeMatcherHandle matcher, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileAttributeMatcherHandle>))] MentorLake.Gio.GFileAttributeMatcherHandle subtract);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_file_attribute_matcher_to_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileAttributeMatcherHandle>))] MentorLake.Gio.GFileAttributeMatcherHandle matcher);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_file_attribute_matcher_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileAttributeMatcherHandle>))] MentorLake.Gio.GFileAttributeMatcherHandle matcher);

}

/// <summary>
/// <para>
/// Determines if a string matches a file attribute.
/// </para>
/// </summary>

public struct GFileAttributeMatcher
{
}
