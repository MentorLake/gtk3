namespace MentorLake.Vulkan;

public class VkPhysicalDevicePointClippingPropertiesHandle : BaseSafeHandle
{
}


public static class VkPhysicalDevicePointClippingPropertiesExtensions
{

	public static VkPhysicalDevicePointClippingProperties Dereference(this VkPhysicalDevicePointClippingPropertiesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDevicePointClippingProperties>(x.DangerousGetHandle());
}
internal class VkPhysicalDevicePointClippingPropertiesExterns
{
}

public struct VkPhysicalDevicePointClippingProperties
{
}
