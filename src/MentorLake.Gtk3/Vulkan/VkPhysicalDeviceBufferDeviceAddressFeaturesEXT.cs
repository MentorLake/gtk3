namespace MentorLake.Vulkan;


public class VkPhysicalDeviceBufferDeviceAddressFeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceBufferDeviceAddressFeaturesEXTExtensions
{

	public static VkPhysicalDeviceBufferDeviceAddressFeaturesEXT Dereference(this VkPhysicalDeviceBufferDeviceAddressFeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceBufferDeviceAddressFeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceBufferDeviceAddressFeaturesEXTExterns
{
}


public struct VkPhysicalDeviceBufferDeviceAddressFeaturesEXT
{
}
