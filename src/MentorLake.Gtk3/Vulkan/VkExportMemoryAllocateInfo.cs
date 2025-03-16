namespace MentorLake.Vulkan;

public class VkExportMemoryAllocateInfoHandle : BaseSafeHandle
{
}


public static class VkExportMemoryAllocateInfoExtensions
{

	public static VkExportMemoryAllocateInfo Dereference(this VkExportMemoryAllocateInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkExportMemoryAllocateInfo>(x.DangerousGetHandle());
}
internal class VkExportMemoryAllocateInfoExterns
{
}

public struct VkExportMemoryAllocateInfo
{
}
