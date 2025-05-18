namespace MentorLake.Gio;

public class GCharsetConverterHandle : GObjectHandle, GConverterHandle, GInitableHandle
{
	public static MentorLake.Gio.GCharsetConverterHandle New(string to_charset, string from_charset)
	{
		var externCallResult = GCharsetConverterHandleExterns.g_charset_converter_new(to_charset, from_charset, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}

public static class GCharsetConverterHandleExtensions
{
	public static uint GetNumFallbacks(this MentorLake.Gio.GCharsetConverterHandle converter)
	{
		if (converter.IsInvalid) throw new Exception("Invalid handle (GCharsetConverterHandle)");
		return GCharsetConverterHandleExterns.g_charset_converter_get_num_fallbacks(converter);
	}

	public static bool GetUseFallback(this MentorLake.Gio.GCharsetConverterHandle converter)
	{
		if (converter.IsInvalid) throw new Exception("Invalid handle (GCharsetConverterHandle)");
		return GCharsetConverterHandleExterns.g_charset_converter_get_use_fallback(converter);
	}

	public static T SetUseFallback<T>(this T converter, bool use_fallback) where T : GCharsetConverterHandle
	{
		if (converter.IsInvalid) throw new Exception("Invalid handle (GCharsetConverterHandle)");
		GCharsetConverterHandleExterns.g_charset_converter_set_use_fallback(converter, use_fallback);
		return converter;
	}

}

internal class GCharsetConverterHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GCharsetConverterHandle>))]
	internal static extern MentorLake.Gio.GCharsetConverterHandle g_charset_converter_new(string to_charset, string from_charset, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern uint g_charset_converter_get_num_fallbacks([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCharsetConverterHandle>))] MentorLake.Gio.GCharsetConverterHandle converter);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_charset_converter_get_use_fallback([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCharsetConverterHandle>))] MentorLake.Gio.GCharsetConverterHandle converter);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_charset_converter_set_use_fallback([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCharsetConverterHandle>))] MentorLake.Gio.GCharsetConverterHandle converter, bool use_fallback);

}
