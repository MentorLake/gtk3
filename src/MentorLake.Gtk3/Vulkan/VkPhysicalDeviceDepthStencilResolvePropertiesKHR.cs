namespace MentorLake.Vulkan;


public class VkPhysicalDeviceDepthStencilResolvePropertiesKHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceDepthStencilResolvePropertiesKHRExtensions
{

	public static VkPhysicalDeviceDepthStencilResolvePropertiesKHR Dereference(this VkPhysicalDeviceDepthStencilResolvePropertiesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceDepthStencilResolvePropertiesKHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceDepthStencilResolvePropertiesKHRExterns
{
}


public struct VkPhysicalDeviceDepthStencilResolvePropertiesKHR
{
}
