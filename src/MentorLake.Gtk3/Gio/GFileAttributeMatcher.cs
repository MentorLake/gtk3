namespace MentorLake.Gio;

public class GFileAttributeMatcherHandle : BaseSafeHandle
{
	public static MentorLake.Gio.GFileAttributeMatcherHandle New(string attributes)
	{
		return GFileAttributeMatcherExterns.g_file_attribute_matcher_new(attributes);
	}

}


public static class GFileAttributeMatcherExtensions
{
	public static bool EnumerateNamespace(this MentorLake.Gio.GFileAttributeMatcherHandle matcher, string ns)
	{
		if (matcher.IsInvalid) throw new Exception("Invalid handle (GFileAttributeMatcher)");
		return GFileAttributeMatcherExterns.g_file_attribute_matcher_enumerate_namespace(matcher, ns);
	}

	public static string EnumerateNext(this MentorLake.Gio.GFileAttributeMatcherHandle matcher)
	{
		if (matcher.IsInvalid) throw new Exception("Invalid handle (GFileAttributeMatcher)");
		return GFileAttributeMatcherExterns.g_file_attribute_matcher_enumerate_next(matcher);
	}

	public static bool Matches(this MentorLake.Gio.GFileAttributeMatcherHandle matcher, string attribute)
	{
		if (matcher.IsInvalid) throw new Exception("Invalid handle (GFileAttributeMatcher)");
		return GFileAttributeMatcherExterns.g_file_attribute_matcher_matches(matcher, attribute);
	}

	public static bool MatchesOnly(this MentorLake.Gio.GFileAttributeMatcherHandle matcher, string attribute)
	{
		if (matcher.IsInvalid) throw new Exception("Invalid handle (GFileAttributeMatcher)");
		return GFileAttributeMatcherExterns.g_file_attribute_matcher_matches_only(matcher, attribute);
	}

	public static MentorLake.Gio.GFileAttributeMatcherHandle Ref(this MentorLake.Gio.GFileAttributeMatcherHandle matcher)
	{
		if (matcher.IsInvalid) throw new Exception("Invalid handle (GFileAttributeMatcher)");
		return GFileAttributeMatcherExterns.g_file_attribute_matcher_ref(matcher);
	}

	public static MentorLake.Gio.GFileAttributeMatcherHandle Subtract(this MentorLake.Gio.GFileAttributeMatcherHandle matcher, MentorLake.Gio.GFileAttributeMatcherHandle subtract)
	{
		if (matcher.IsInvalid) throw new Exception("Invalid handle (GFileAttributeMatcher)");
		return GFileAttributeMatcherExterns.g_file_attribute_matcher_subtract(matcher, subtract);
	}

	public static string ToString(this MentorLake.Gio.GFileAttributeMatcherHandle matcher)
	{
		if (matcher.IsInvalid) throw new Exception("Invalid handle (GFileAttributeMatcher)");
		return GFileAttributeMatcherExterns.g_file_attribute_matcher_to_string(matcher);
	}

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

public struct GFileAttributeMatcher
{
}
