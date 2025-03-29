namespace MentorLake.Atk;

public interface AtkHypertextHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class AtkHypertextHandleImpl : BaseSafeHandle, AtkHypertextHandle
{
}

public static class AtkHypertextHandleExtensions
{
	public static MentorLake.Atk.AtkHyperlinkHandle GetLink(this MentorLake.Atk.AtkHypertextHandle hypertext, int link_index)
	{
		if (hypertext.IsInvalid || hypertext.IsClosed) throw new Exception("Invalid or closed handle (AtkHypertextHandle)");
		return AtkHypertextHandleExterns.atk_hypertext_get_link(hypertext, link_index);
	}

	public static int GetLinkIndex(this MentorLake.Atk.AtkHypertextHandle hypertext, int char_index)
	{
		if (hypertext.IsInvalid || hypertext.IsClosed) throw new Exception("Invalid or closed handle (AtkHypertextHandle)");
		return AtkHypertextHandleExterns.atk_hypertext_get_link_index(hypertext, char_index);
	}

	public static int GetNLinks(this MentorLake.Atk.AtkHypertextHandle hypertext)
	{
		if (hypertext.IsInvalid || hypertext.IsClosed) throw new Exception("Invalid or closed handle (AtkHypertextHandle)");
		return AtkHypertextHandleExterns.atk_hypertext_get_n_links(hypertext);
	}

}

internal class AtkHypertextHandleExterns
{
	[DllImport(AtkLibrary.Name)]
	internal static extern MentorLake.Atk.AtkHyperlinkHandle atk_hypertext_get_link([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkHypertextHandleImpl>))] MentorLake.Atk.AtkHypertextHandle hypertext, int link_index);

	[DllImport(AtkLibrary.Name)]
	internal static extern int atk_hypertext_get_link_index([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkHypertextHandleImpl>))] MentorLake.Atk.AtkHypertextHandle hypertext, int char_index);

	[DllImport(AtkLibrary.Name)]
	internal static extern int atk_hypertext_get_n_links([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkHypertextHandleImpl>))] MentorLake.Atk.AtkHypertextHandle hypertext);

}
