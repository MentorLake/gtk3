namespace MentorLake.Atk;

public interface AtkStreamableContentHandle
{
}

internal class AtkStreamableContentHandleImpl : BaseSafeHandle, AtkStreamableContentHandle
{
}

public static class AtkStreamableContentHandleExtensions
{
	public static string GetMimeType(this MentorLake.Atk.AtkStreamableContentHandle streamable, int i)
	{
		return AtkStreamableContentHandleExterns.atk_streamable_content_get_mime_type(streamable, i);
	}

	public static int GetNMimeTypes(this MentorLake.Atk.AtkStreamableContentHandle streamable)
	{
		return AtkStreamableContentHandleExterns.atk_streamable_content_get_n_mime_types(streamable);
	}

	public static MentorLake.GLib.GIOChannelHandle GetStream(this MentorLake.Atk.AtkStreamableContentHandle streamable, string mime_type)
	{
		return AtkStreamableContentHandleExterns.atk_streamable_content_get_stream(streamable, mime_type);
	}

	public static string GetUri(this MentorLake.Atk.AtkStreamableContentHandle streamable, string mime_type)
	{
		return AtkStreamableContentHandleExterns.atk_streamable_content_get_uri(streamable, mime_type);
	}

}

internal class AtkStreamableContentHandleExterns
{
	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_streamable_content_get_mime_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkStreamableContentHandleImpl>))] MentorLake.Atk.AtkStreamableContentHandle streamable, int i);

	[DllImport(AtkLibrary.Name)]
	internal static extern int atk_streamable_content_get_n_mime_types([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkStreamableContentHandleImpl>))] MentorLake.Atk.AtkStreamableContentHandle streamable);

	[DllImport(AtkLibrary.Name)]
	internal static extern MentorLake.GLib.GIOChannelHandle atk_streamable_content_get_stream([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkStreamableContentHandleImpl>))] MentorLake.Atk.AtkStreamableContentHandle streamable, string mime_type);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_streamable_content_get_uri([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkStreamableContentHandleImpl>))] MentorLake.Atk.AtkStreamableContentHandle streamable, string mime_type);

}
