namespace MentorLake.Vulkan;

public class VkRenderPassMultiviewCreateInfoKHRHandle : BaseSafeHandle
{
}


public static class VkRenderPassMultiviewCreateInfoKHRExtensions
{

	public static VkRenderPassMultiviewCreateInfoKHR Dereference(this VkRenderPassMultiviewCreateInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkRenderPassMultiviewCreateInfoKHR>(x.DangerousGetHandle());
}
internal class VkRenderPassMultiviewCreateInfoKHRExterns
{
}

public struct VkRenderPassMultiviewCreateInfoKHR
{
}
