namespace MentorLake.Vulkan;

public class VkPhysicalDeviceDepthStencilResolvePropertiesHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceDepthStencilResolvePropertiesExtensions
{

	public static VkPhysicalDeviceDepthStencilResolveProperties Dereference(this VkPhysicalDeviceDepthStencilResolvePropertiesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceDepthStencilResolveProperties>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceDepthStencilResolvePropertiesExterns
{
}

public struct VkPhysicalDeviceDepthStencilResolveProperties
{
}
