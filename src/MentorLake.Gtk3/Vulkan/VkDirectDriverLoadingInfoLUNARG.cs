namespace MentorLake.Vulkan;


public class VkDirectDriverLoadingInfoLUNARGHandle : BaseSafeHandle
{
}


public static class VkDirectDriverLoadingInfoLUNARGExtensions
{

	public static VkDirectDriverLoadingInfoLUNARG Dereference(this VkDirectDriverLoadingInfoLUNARGHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDirectDriverLoadingInfoLUNARG>(x.DangerousGetHandle());
}
internal class VkDirectDriverLoadingInfoLUNARGExterns
{
}


public struct VkDirectDriverLoadingInfoLUNARG
{
}
