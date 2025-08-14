namespace MentorLake.Vulkan;


public class VkImageViewTypeHandle : BaseSafeHandle
{
}


public static class VkImageViewTypeExtensions
{

	public static VkImageViewType Dereference(this VkImageViewTypeHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImageViewType>(x.DangerousGetHandle());
}
internal class VkImageViewTypeExterns
{
}


public struct VkImageViewType
{
}
