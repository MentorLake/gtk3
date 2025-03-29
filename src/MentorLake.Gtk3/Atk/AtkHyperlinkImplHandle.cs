namespace MentorLake.Atk;

public interface AtkHyperlinkImplHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class AtkHyperlinkImplHandleImpl : BaseSafeHandle, AtkHyperlinkImplHandle
{
}

public static class AtkHyperlinkImplHandleExtensions
{
	public static MentorLake.Atk.AtkHyperlinkHandle GetHyperlink(this MentorLake.Atk.AtkHyperlinkImplHandle impl)
	{
		if (impl.IsInvalid || impl.IsClosed) throw new Exception("Invalid or closed handle (AtkHyperlinkImplHandle)");
		return AtkHyperlinkImplHandleExterns.atk_hyperlink_impl_get_hyperlink(impl);
	}

}

internal class AtkHyperlinkImplHandleExterns
{
	[DllImport(AtkLibrary.Name)]
	internal static extern MentorLake.Atk.AtkHyperlinkHandle atk_hyperlink_impl_get_hyperlink([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkHyperlinkImplHandleImpl>))] MentorLake.Atk.AtkHyperlinkImplHandle impl);

}
