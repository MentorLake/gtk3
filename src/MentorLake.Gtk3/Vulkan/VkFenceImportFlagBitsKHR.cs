namespace MentorLake.Vulkan;


public class VkFenceImportFlagBitsKHRHandle : BaseSafeHandle
{
}


public static class VkFenceImportFlagBitsKHRExtensions
{

	public static VkFenceImportFlagBitsKHR Dereference(this VkFenceImportFlagBitsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkFenceImportFlagBitsKHR>(x.DangerousGetHandle());
}
internal class VkFenceImportFlagBitsKHRExterns
{
}


public struct VkFenceImportFlagBitsKHR
{
}
