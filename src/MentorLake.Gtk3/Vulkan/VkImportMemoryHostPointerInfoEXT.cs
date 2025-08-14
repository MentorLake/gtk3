namespace MentorLake.Vulkan;


public class VkImportMemoryHostPointerInfoEXTHandle : BaseSafeHandle
{
}


public static class VkImportMemoryHostPointerInfoEXTExtensions
{

	public static VkImportMemoryHostPointerInfoEXT Dereference(this VkImportMemoryHostPointerInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImportMemoryHostPointerInfoEXT>(x.DangerousGetHandle());
}
internal class VkImportMemoryHostPointerInfoEXTExterns
{
}


public struct VkImportMemoryHostPointerInfoEXT
{
}
