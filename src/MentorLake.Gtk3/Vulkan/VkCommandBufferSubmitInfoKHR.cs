namespace MentorLake.Vulkan;

public class VkCommandBufferSubmitInfoKHRHandle : BaseSafeHandle
{
}


public static class VkCommandBufferSubmitInfoKHRExtensions
{

	public static VkCommandBufferSubmitInfoKHR Dereference(this VkCommandBufferSubmitInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCommandBufferSubmitInfoKHR>(x.DangerousGetHandle());
}
internal class VkCommandBufferSubmitInfoKHRExterns
{
}

public struct VkCommandBufferSubmitInfoKHR
{
}
