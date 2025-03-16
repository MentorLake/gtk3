namespace MentorLake.Vulkan;

public class VkImageTilingHandle : BaseSafeHandle
{
}


public static class VkImageTilingExtensions
{

	public static VkImageTiling Dereference(this VkImageTilingHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImageTiling>(x.DangerousGetHandle());
}
internal class VkImageTilingExterns
{
}

public struct VkImageTiling
{
}
