namespace MentorLake.Vulkan;


public class VkDeviceBufferMemoryRequirementsKHRHandle : BaseSafeHandle
{
}


public static class VkDeviceBufferMemoryRequirementsKHRExtensions
{

	public static VkDeviceBufferMemoryRequirementsKHR Dereference(this VkDeviceBufferMemoryRequirementsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDeviceBufferMemoryRequirementsKHR>(x.DangerousGetHandle());
}
internal class VkDeviceBufferMemoryRequirementsKHRExterns
{
}


public struct VkDeviceBufferMemoryRequirementsKHR
{
}
