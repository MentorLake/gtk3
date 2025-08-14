namespace MentorLake.Vulkan;


public class VkPhysicalDeviceBufferDeviceAddressFeaturesKHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceBufferDeviceAddressFeaturesKHRExtensions
{

	public static VkPhysicalDeviceBufferDeviceAddressFeaturesKHR Dereference(this VkPhysicalDeviceBufferDeviceAddressFeaturesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceBufferDeviceAddressFeaturesKHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceBufferDeviceAddressFeaturesKHRExterns
{
}


public struct VkPhysicalDeviceBufferDeviceAddressFeaturesKHR
{
}
