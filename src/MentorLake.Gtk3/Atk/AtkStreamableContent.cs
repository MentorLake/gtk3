namespace MentorLake.Gtk3.Atk;

public interface AtkStreamableContentHandle
{
}

internal class AtkStreamableContentHandleImpl : BaseSafeHandle, AtkStreamableContentHandle
{
}

public static class AtkStreamableContentHandleExtensions
{
	public static string GetMimeType(this AtkStreamableContentHandle streamable, int i)
	{
		return AtkStreamableContentExterns.atk_streamable_content_get_mime_type(streamable, i);
	}

	public static int GetNMimeTypes(this AtkStreamableContentHandle streamable)
	{
		return AtkStreamableContentExterns.atk_streamable_content_get_n_mime_types(streamable);
	}

	public static GIOChannelHandle GetStream(this AtkStreamableContentHandle streamable, string mime_type)
	{
		return AtkStreamableContentExterns.atk_streamable_content_get_stream(streamable, mime_type);
	}

	public static string GetUri(this AtkStreamableContentHandle streamable, string mime_type)
	{
		return AtkStreamableContentExterns.atk_streamable_content_get_uri(streamable, mime_type);
	}

}

internal class AtkStreamableContentExterns
{
	[DllImport(Libraries.Atk)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_streamable_content_get_mime_type(AtkStreamableContentHandle streamable, int i);

	[DllImport(Libraries.Atk)]
	internal static extern int atk_streamable_content_get_n_mime_types(AtkStreamableContentHandle streamable);

	[DllImport(Libraries.Atk)]
	internal static extern GIOChannelHandle atk_streamable_content_get_stream(AtkStreamableContentHandle streamable, string mime_type);

	[DllImport(Libraries.Atk)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_streamable_content_get_uri(AtkStreamableContentHandle streamable, string mime_type);

}
