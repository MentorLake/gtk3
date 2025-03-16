namespace MentorLake.Vulkan;

public class VkImageBlitHandle : BaseSafeHandle
{
}


public static class VkImageBlitExtensions
{

	public static VkImageBlit Dereference(this VkImageBlitHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImageBlit>(x.DangerousGetHandle());
}
internal class VkImageBlitExterns
{
}

public struct VkImageBlit
{
}
