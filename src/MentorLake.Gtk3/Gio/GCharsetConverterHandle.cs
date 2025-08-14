namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GCharsetConverter` is an implementation of [iface@Gio.Converter] based on
/// [struct@GLib.IConv].
/// </para>
/// </summary>

public class GCharsetConverterHandle : GObjectHandle, GConverterHandle, GInitableHandle
{
/// <summary>
/// <para>
/// Creates a new #GCharsetConverter.
/// </para>
/// </summary>

/// <param name="to_charset">
/// destination charset
/// </param>
/// <param name="from_charset">
/// source charset
/// </param>
/// <return>
/// a new #GCharsetConverter or %NULL on error.
/// </return>

	public static MentorLake.Gio.GCharsetConverterHandle New(string to_charset, string from_charset)
	{
		var externCallResult = GCharsetConverterHandleExterns.g_charset_converter_new(to_charset, from_charset, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}

public static class GCharsetConverterHandleExtensions
{
/// <summary>
/// <para>
/// Gets the number of fallbacks that @converter has applied so far.
/// </para>
/// </summary>

/// <param name="converter">
/// a #GCharsetConverter
/// </param>
/// <return>
/// the number of fallbacks that @converter has applied
/// </return>

	public static uint GetNumFallbacks(this MentorLake.Gio.GCharsetConverterHandle converter)
	{
		if (converter.IsInvalid) throw new Exception("Invalid handle (GCharsetConverterHandle)");
		return GCharsetConverterHandleExterns.g_charset_converter_get_num_fallbacks(converter);
	}

/// <summary>
/// <para>
/// Gets the #GCharsetConverter:use-fallback property.
/// </para>
/// </summary>

/// <param name="converter">
/// a #GCharsetConverter
/// </param>
/// <return>
/// %TRUE if fallbacks are used by @converter
/// </return>

	public static bool GetUseFallback(this MentorLake.Gio.GCharsetConverterHandle converter)
	{
		if (converter.IsInvalid) throw new Exception("Invalid handle (GCharsetConverterHandle)");
		return GCharsetConverterHandleExterns.g_charset_converter_get_use_fallback(converter);
	}

/// <summary>
/// <para>
/// Sets the #GCharsetConverter:use-fallback property.
/// </para>
/// </summary>

/// <param name="converter">
/// a #GCharsetConverter
/// </param>
/// <param name="use_fallback">
/// %TRUE to use fallbacks
/// </param>

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
