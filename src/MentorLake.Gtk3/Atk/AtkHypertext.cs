namespace MentorLake.Gtk3.Atk;

public interface AtkHypertextHandle
{
}

internal class AtkHypertextHandleImpl : BaseSafeHandle, AtkHypertextHandle
{
}

public static class AtkHypertextHandleExtensions
{
	public static AtkHyperlinkHandle GetLink(this AtkHypertextHandle hypertext, int link_index)
	{
		return AtkHypertextExterns.atk_hypertext_get_link(hypertext, link_index);
	}

	public static int GetLinkIndex(this AtkHypertextHandle hypertext, int char_index)
	{
		return AtkHypertextExterns.atk_hypertext_get_link_index(hypertext, char_index);
	}

	public static int GetNLinks(this AtkHypertextHandle hypertext)
	{
		return AtkHypertextExterns.atk_hypertext_get_n_links(hypertext);
	}

}

internal class AtkHypertextExterns
{
	[DllImport(Libraries.Atk)]
	internal static extern AtkHyperlinkHandle atk_hypertext_get_link(AtkHypertextHandle hypertext, int link_index);

	[DllImport(Libraries.Atk)]
	internal static extern int atk_hypertext_get_link_index(AtkHypertextHandle hypertext, int char_index);

	[DllImport(Libraries.Atk)]
	internal static extern int atk_hypertext_get_n_links(AtkHypertextHandle hypertext);

}
