namespace MentorLake.Vulkan;


public class VkImagePlaneMemoryRequirementsInfoHandle : BaseSafeHandle
{
}


public static class VkImagePlaneMemoryRequirementsInfoExtensions
{

	public static VkImagePlaneMemoryRequirementsInfo Dereference(this VkImagePlaneMemoryRequirementsInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImagePlaneMemoryRequirementsInfo>(x.DangerousGetHandle());
}
internal class VkImagePlaneMemoryRequirementsInfoExterns
{
}


public struct VkImagePlaneMemoryRequirementsInfo
{
}
