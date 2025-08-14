namespace MentorLake.Vulkan;


public class VkSubresourceHostMemcpySizeEXTHandle : BaseSafeHandle
{
}


public static class VkSubresourceHostMemcpySizeEXTExtensions
{

	public static VkSubresourceHostMemcpySizeEXT Dereference(this VkSubresourceHostMemcpySizeEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSubresourceHostMemcpySizeEXT>(x.DangerousGetHandle());
}
internal class VkSubresourceHostMemcpySizeEXTExterns
{
}


public struct VkSubresourceHostMemcpySizeEXT
{
}
