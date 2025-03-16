namespace MentorLake.GLib;

public class GPatternSpecHandle : BaseSafeHandle
{
	public static MentorLake.GLib.GPatternSpecHandle New(string pattern)
	{
		return GPatternSpecExterns.g_pattern_spec_new(pattern);
	}

}


public static class GPatternSpecExtensions
{
	public static MentorLake.GLib.GPatternSpecHandle Copy(this MentorLake.GLib.GPatternSpecHandle pspec)
	{
		return GPatternSpecExterns.g_pattern_spec_copy(pspec);
	}

	public static bool Equal(this MentorLake.GLib.GPatternSpecHandle pspec1, MentorLake.GLib.GPatternSpecHandle pspec2)
	{
		return GPatternSpecExterns.g_pattern_spec_equal(pspec1, pspec2);
	}

	public static void Free(this MentorLake.GLib.GPatternSpecHandle pspec)
	{
		GPatternSpecExterns.g_pattern_spec_free(pspec);
	}

	public static bool Match(this MentorLake.GLib.GPatternSpecHandle pspec, UIntPtr string_length, string @string, string string_reversed)
	{
		return GPatternSpecExterns.g_pattern_spec_match(pspec, string_length, @string, string_reversed);
	}

	public static bool MatchString(this MentorLake.GLib.GPatternSpecHandle pspec, string @string)
	{
		return GPatternSpecExterns.g_pattern_spec_match_string(pspec, @string);
	}


	public static GPatternSpec Dereference(this GPatternSpecHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GPatternSpec>(x.DangerousGetHandle());
}
internal class GPatternSpecExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GPatternSpecHandle g_pattern_spec_new(string pattern);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GPatternSpecHandle g_pattern_spec_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPatternSpecHandle>))] MentorLake.GLib.GPatternSpecHandle pspec);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_pattern_spec_equal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPatternSpecHandle>))] MentorLake.GLib.GPatternSpecHandle pspec1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPatternSpecHandle>))] MentorLake.GLib.GPatternSpecHandle pspec2);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_pattern_spec_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPatternSpecHandle>))] MentorLake.GLib.GPatternSpecHandle pspec);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_pattern_spec_match([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPatternSpecHandle>))] MentorLake.GLib.GPatternSpecHandle pspec, UIntPtr string_length, string @string, string string_reversed);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_pattern_spec_match_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPatternSpecHandle>))] MentorLake.GLib.GPatternSpecHandle pspec, string @string);

}

public struct GPatternSpec
{
}
