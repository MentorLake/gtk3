namespace MentorLake.Vulkan;

public class VkFenceImportFlagsKHRHandle : BaseSafeHandle
{
}


public static class VkFenceImportFlagsKHRExtensions
{

	public static VkFenceImportFlagsKHR Dereference(this VkFenceImportFlagsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkFenceImportFlagsKHR>(x.DangerousGetHandle());
}
internal class VkFenceImportFlagsKHRExterns
{
}

public struct VkFenceImportFlagsKHR
{
}
