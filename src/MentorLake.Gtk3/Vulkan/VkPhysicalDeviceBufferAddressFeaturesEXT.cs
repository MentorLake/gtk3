namespace MentorLake.Vulkan;


public class VkPhysicalDeviceBufferAddressFeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceBufferAddressFeaturesEXTExtensions
{

	public static VkPhysicalDeviceBufferAddressFeaturesEXT Dereference(this VkPhysicalDeviceBufferAddressFeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceBufferAddressFeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceBufferAddressFeaturesEXTExterns
{
}


public struct VkPhysicalDeviceBufferAddressFeaturesEXT
{
}
