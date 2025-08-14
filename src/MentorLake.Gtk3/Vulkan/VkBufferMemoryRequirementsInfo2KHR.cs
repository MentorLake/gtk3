namespace MentorLake.Vulkan;


public class VkBufferMemoryRequirementsInfo2KHRHandle : BaseSafeHandle
{
}


public static class VkBufferMemoryRequirementsInfo2KHRExtensions
{

	public static VkBufferMemoryRequirementsInfo2KHR Dereference(this VkBufferMemoryRequirementsInfo2KHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBufferMemoryRequirementsInfo2KHR>(x.DangerousGetHandle());
}
internal class VkBufferMemoryRequirementsInfo2KHRExterns
{
}


public struct VkBufferMemoryRequirementsInfo2KHR
{
}
