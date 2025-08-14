namespace MentorLake.Vulkan;


public class VkDirectDriverLoadingListLUNARGHandle : BaseSafeHandle
{
}


public static class VkDirectDriverLoadingListLUNARGExtensions
{

	public static VkDirectDriverLoadingListLUNARG Dereference(this VkDirectDriverLoadingListLUNARGHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDirectDriverLoadingListLUNARG>(x.DangerousGetHandle());
}
internal class VkDirectDriverLoadingListLUNARGExterns
{
}


public struct VkDirectDriverLoadingListLUNARG
{
}
