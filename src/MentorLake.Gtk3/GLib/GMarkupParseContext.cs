namespace MentorLake.GLib;

public class GMarkupParseContextHandle : BaseSafeHandle
{
	public static MentorLake.GLib.GMarkupParseContextHandle New(MentorLake.GLib.GMarkupParserHandle parser, MentorLake.GLib.GMarkupParseFlags flags, IntPtr user_data, MentorLake.GLib.GDestroyNotify user_data_dnotify)
	{
		return GMarkupParseContextExterns.g_markup_parse_context_new(parser, flags, user_data, user_data_dnotify);
	}

}


public static class GMarkupParseContextExtensions
{
	public static bool EndParse(this MentorLake.GLib.GMarkupParseContextHandle context)
	{
		var externCallResult = GMarkupParseContextExterns.g_markup_parse_context_end_parse(context, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static void Free(this MentorLake.GLib.GMarkupParseContextHandle context)
	{
		GMarkupParseContextExterns.g_markup_parse_context_free(context);
	}

	public static string GetElement(this MentorLake.GLib.GMarkupParseContextHandle context)
	{
		return GMarkupParseContextExterns.g_markup_parse_context_get_element(context);
	}

	public static MentorLake.GLib.GSListHandle GetElementStack(this MentorLake.GLib.GMarkupParseContextHandle context)
	{
		return GMarkupParseContextExterns.g_markup_parse_context_get_element_stack(context);
	}

	public static void GetPosition(this MentorLake.GLib.GMarkupParseContextHandle context, out int line_number, out int char_number)
	{
		GMarkupParseContextExterns.g_markup_parse_context_get_position(context, out line_number, out char_number);
	}

	public static IntPtr GetUserData(this MentorLake.GLib.GMarkupParseContextHandle context)
	{
		return GMarkupParseContextExterns.g_markup_parse_context_get_user_data(context);
	}

	public static bool Parse(this MentorLake.GLib.GMarkupParseContextHandle context, string text, UIntPtr text_len)
	{
		var externCallResult = GMarkupParseContextExterns.g_markup_parse_context_parse(context, text, text_len, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static IntPtr Pop(this MentorLake.GLib.GMarkupParseContextHandle context)
	{
		return GMarkupParseContextExterns.g_markup_parse_context_pop(context);
	}

	public static void Push(this MentorLake.GLib.GMarkupParseContextHandle context, MentorLake.GLib.GMarkupParserHandle parser, IntPtr user_data)
	{
		GMarkupParseContextExterns.g_markup_parse_context_push(context, parser, user_data);
	}

	public static MentorLake.GLib.GMarkupParseContextHandle Ref(this MentorLake.GLib.GMarkupParseContextHandle context)
	{
		return GMarkupParseContextExterns.g_markup_parse_context_ref(context);
	}

	public static void Unref(this MentorLake.GLib.GMarkupParseContextHandle context)
	{
		GMarkupParseContextExterns.g_markup_parse_context_unref(context);
	}


	public static GMarkupParseContext Dereference(this GMarkupParseContextHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GMarkupParseContext>(x.DangerousGetHandle());
}
internal class GMarkupParseContextExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GMarkupParseContextHandle g_markup_parse_context_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMarkupParserHandle>))] MentorLake.GLib.GMarkupParserHandle parser, MentorLake.GLib.GMarkupParseFlags flags, IntPtr user_data, MentorLake.GLib.GDestroyNotify user_data_dnotify);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_markup_parse_context_end_parse([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMarkupParseContextHandle>))] MentorLake.GLib.GMarkupParseContextHandle context, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_markup_parse_context_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMarkupParseContextHandle>))] MentorLake.GLib.GMarkupParseContextHandle context);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_markup_parse_context_get_element([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMarkupParseContextHandle>))] MentorLake.GLib.GMarkupParseContextHandle context);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GSListHandle g_markup_parse_context_get_element_stack([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMarkupParseContextHandle>))] MentorLake.GLib.GMarkupParseContextHandle context);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_markup_parse_context_get_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMarkupParseContextHandle>))] MentorLake.GLib.GMarkupParseContextHandle context, out int line_number, out int char_number);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_markup_parse_context_get_user_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMarkupParseContextHandle>))] MentorLake.GLib.GMarkupParseContextHandle context);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_markup_parse_context_parse([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMarkupParseContextHandle>))] MentorLake.GLib.GMarkupParseContextHandle context, string text, UIntPtr text_len, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_markup_parse_context_pop([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMarkupParseContextHandle>))] MentorLake.GLib.GMarkupParseContextHandle context);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_markup_parse_context_push([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMarkupParseContextHandle>))] MentorLake.GLib.GMarkupParseContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMarkupParserHandle>))] MentorLake.GLib.GMarkupParserHandle parser, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GMarkupParseContextHandle g_markup_parse_context_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMarkupParseContextHandle>))] MentorLake.GLib.GMarkupParseContextHandle context);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_markup_parse_context_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMarkupParseContextHandle>))] MentorLake.GLib.GMarkupParseContextHandle context);

}

public struct GMarkupParseContext
{
}
