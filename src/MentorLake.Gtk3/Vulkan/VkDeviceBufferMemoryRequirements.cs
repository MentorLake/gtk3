namespace MentorLake.Vulkan;

public class VkDeviceBufferMemoryRequirementsHandle : BaseSafeHandle
{
}


public static class VkDeviceBufferMemoryRequirementsExtensions
{

	public static VkDeviceBufferMemoryRequirements Dereference(this VkDeviceBufferMemoryRequirementsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDeviceBufferMemoryRequirements>(x.DangerousGetHandle());
}
internal class VkDeviceBufferMemoryRequirementsExterns
{
}

public struct VkDeviceBufferMemoryRequirements
{
}
