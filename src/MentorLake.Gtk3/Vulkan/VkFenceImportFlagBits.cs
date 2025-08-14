namespace MentorLake.Vulkan;


public class VkFenceImportFlagBitsHandle : BaseSafeHandle
{
}


public static class VkFenceImportFlagBitsExtensions
{

	public static VkFenceImportFlagBits Dereference(this VkFenceImportFlagBitsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkFenceImportFlagBits>(x.DangerousGetHandle());
}
internal class VkFenceImportFlagBitsExterns
{
}


public struct VkFenceImportFlagBits
{
}
