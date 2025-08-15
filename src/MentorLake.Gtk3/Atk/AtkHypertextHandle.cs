namespace MentorLake.Atk;

/// <summary>
/// <para>
/// The ATK interface which provides standard mechanism for manipulating hyperlinks.
/// </para>
/// <para>
/// An interface used for objects which implement linking between
/// multiple resource or content locations, or multiple &apos;markers&apos;
/// within a single document.  A Hypertext instance is associated with
/// one or more Hyperlinks, which are associated with particular
/// offsets within the Hypertext&apos;s included content.  While this
/// interface is derived from Text, there is no requirement that
/// Hypertext instances have textual content; they may implement Image
/// as well, and Hyperlinks need not have non-zero text offsets.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// Gets the link in this hypertext document at index
/// @link_index
/// </para>
/// </summary>

/// <param name="hypertext">
/// an #AtkHypertext
/// </param>
/// <param name="link_index">
/// an integer specifying the desired link
/// </param>
/// <return>
/// the link in this hypertext document at
/// index @link_index
/// </return>

	public static MentorLake.Atk.AtkHyperlinkHandle GetLink(this MentorLake.Atk.AtkHypertextHandle hypertext, int link_index)
	{
		if (hypertext.IsInvalid) throw new Exception("Invalid handle (AtkHypertextHandle)");
		return AtkHypertextHandleExterns.atk_hypertext_get_link(hypertext, link_index);
	}

/// <summary>
/// <para>
/// Gets the index into the array of hyperlinks that is associated with
/// the character specified by @char_index.
/// </para>
/// </summary>

/// <param name="hypertext">
/// an #AtkHypertext
/// </param>
/// <param name="char_index">
/// a character index
/// </param>
/// <return>
/// an index into the array of hyperlinks in @hypertext,
/// or -1 if there is no hyperlink associated with this character.
/// </return>

	public static int GetLinkIndex(this MentorLake.Atk.AtkHypertextHandle hypertext, int char_index)
	{
		if (hypertext.IsInvalid) throw new Exception("Invalid handle (AtkHypertextHandle)");
		return AtkHypertextHandleExterns.atk_hypertext_get_link_index(hypertext, char_index);
	}

/// <summary>
/// <para>
/// Gets the number of links within this hypertext document.
/// </para>
/// </summary>

/// <param name="hypertext">
/// an #AtkHypertext
/// </param>
/// <return>
/// the number of links within this hypertext document
/// </return>

	public static int GetNLinks(this MentorLake.Atk.AtkHypertextHandle hypertext)
	{
		if (hypertext.IsInvalid) throw new Exception("Invalid handle (AtkHypertextHandle)");
		return AtkHypertextHandleExterns.atk_hypertext_get_n_links(hypertext);
	}

}

internal class AtkHypertextHandleExterns
{
	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkHyperlinkHandle>))]
	internal static extern MentorLake.Atk.AtkHyperlinkHandle atk_hypertext_get_link([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkHypertextHandleImpl>))] MentorLake.Atk.AtkHypertextHandle hypertext, int link_index);

	[DllImport(AtkLibrary.Name)]
	internal static extern int atk_hypertext_get_link_index([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkHypertextHandleImpl>))] MentorLake.Atk.AtkHypertextHandle hypertext, int char_index);

	[DllImport(AtkLibrary.Name)]
	internal static extern int atk_hypertext_get_n_links([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkHypertextHandleImpl>))] MentorLake.Atk.AtkHypertextHandle hypertext);

}
