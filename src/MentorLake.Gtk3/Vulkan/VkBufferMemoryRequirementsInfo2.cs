namespace MentorLake.Vulkan;


public class VkBufferMemoryRequirementsInfo2Handle : BaseSafeHandle
{
}


public static class VkBufferMemoryRequirementsInfo2Extensions
{

	public static VkBufferMemoryRequirementsInfo2 Dereference(this VkBufferMemoryRequirementsInfo2Handle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBufferMemoryRequirementsInfo2>(x.DangerousGetHandle());
}
internal class VkBufferMemoryRequirementsInfo2Externs
{
}


public struct VkBufferMemoryRequirementsInfo2
{
}
