namespace MentorLake.Vulkan;

public class VkCommandBufferSubmitInfoHandle : BaseSafeHandle
{
}


public static class VkCommandBufferSubmitInfoExtensions
{

	public static VkCommandBufferSubmitInfo Dereference(this VkCommandBufferSubmitInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCommandBufferSubmitInfo>(x.DangerousGetHandle());
}
internal class VkCommandBufferSubmitInfoExterns
{
}

public struct VkCommandBufferSubmitInfo
{
}
