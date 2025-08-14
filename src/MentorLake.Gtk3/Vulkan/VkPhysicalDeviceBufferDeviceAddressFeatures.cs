namespace MentorLake.Vulkan;


public class VkPhysicalDeviceBufferDeviceAddressFeaturesHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceBufferDeviceAddressFeaturesExtensions
{

	public static VkPhysicalDeviceBufferDeviceAddressFeatures Dereference(this VkPhysicalDeviceBufferDeviceAddressFeaturesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceBufferDeviceAddressFeatures>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceBufferDeviceAddressFeaturesExterns
{
}


public struct VkPhysicalDeviceBufferDeviceAddressFeatures
{
}
