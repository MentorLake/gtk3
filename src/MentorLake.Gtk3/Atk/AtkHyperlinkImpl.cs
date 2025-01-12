namespace MentorLake.Gtk3.Atk;

public interface AtkHyperlinkImplHandle
{
}

internal class AtkHyperlinkImplHandleImpl : BaseSafeHandle, AtkHyperlinkImplHandle
{
}

public static class AtkHyperlinkImplHandleExtensions
{
	public static AtkHyperlinkHandle GetHyperlink(this AtkHyperlinkImplHandle impl)
	{
		return AtkHyperlinkImplExterns.atk_hyperlink_impl_get_hyperlink(impl);
	}

}

internal class AtkHyperlinkImplExterns
{
	[DllImport(Libraries.Atk)]
	internal static extern AtkHyperlinkHandle atk_hyperlink_impl_get_hyperlink(AtkHyperlinkImplHandle impl);

}
