namespace MentorLake.Vulkan;


public class VkImageSubresourceLayersHandle : BaseSafeHandle
{
}


public static class VkImageSubresourceLayersExtensions
{

	public static VkImageSubresourceLayers Dereference(this VkImageSubresourceLayersHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImageSubresourceLayers>(x.DangerousGetHandle());
}
internal class VkImageSubresourceLayersExterns
{
}


public struct VkImageSubresourceLayers
{
}
