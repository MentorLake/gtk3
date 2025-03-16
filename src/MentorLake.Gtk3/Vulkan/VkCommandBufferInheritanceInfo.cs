namespace MentorLake.Vulkan;

public class VkCommandBufferInheritanceInfoHandle : BaseSafeHandle
{
}


public static class VkCommandBufferInheritanceInfoExtensions
{

	public static VkCommandBufferInheritanceInfo Dereference(this VkCommandBufferInheritanceInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCommandBufferInheritanceInfo>(x.DangerousGetHandle());
}
internal class VkCommandBufferInheritanceInfoExterns
{
}

public struct VkCommandBufferInheritanceInfo
{
}
