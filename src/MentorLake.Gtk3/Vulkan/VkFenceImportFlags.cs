namespace MentorLake.Vulkan;


public class VkFenceImportFlagsHandle : BaseSafeHandle
{
}


public static class VkFenceImportFlagsExtensions
{

	public static VkFenceImportFlags Dereference(this VkFenceImportFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkFenceImportFlags>(x.DangerousGetHandle());
}
internal class VkFenceImportFlagsExterns
{
}


public struct VkFenceImportFlags
{
}
