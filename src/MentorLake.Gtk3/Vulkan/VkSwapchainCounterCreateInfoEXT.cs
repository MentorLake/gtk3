namespace MentorLake.Vulkan;


public class VkSwapchainCounterCreateInfoEXTHandle : BaseSafeHandle
{
}


public static class VkSwapchainCounterCreateInfoEXTExtensions
{

	public static VkSwapchainCounterCreateInfoEXT Dereference(this VkSwapchainCounterCreateInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSwapchainCounterCreateInfoEXT>(x.DangerousGetHandle());
}
internal class VkSwapchainCounterCreateInfoEXTExterns
{
}


public struct VkSwapchainCounterCreateInfoEXT
{
}
