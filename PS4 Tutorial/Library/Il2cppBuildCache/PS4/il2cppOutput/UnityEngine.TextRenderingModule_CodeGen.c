#include "pch-c.h"
#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include "codegen/il2cpp-codegen-metadata.h"





// 0x00000001 System.Void UnityEngine.TextMesh::set_text(System.String)
extern void TextMesh_set_text_m5879B13F5C9E4A1D05155839B89CCDB85BE28A04 (void);
// 0x00000002 System.Void UnityEngine.Font::InvokeTextureRebuilt_Internal(UnityEngine.Font)
extern void Font_InvokeTextureRebuilt_Internal_m35C57E19A7E53A2F2A94DF909E6903DFFEE7679B (void);
// 0x00000003 System.Void UnityEngine.Font/FontTextureRebuildCallback::.ctor(System.Object,System.IntPtr)
extern void FontTextureRebuildCallback__ctor_m58D67535ED1CC9895AB016CBB713A730A73480E0 (void);
// 0x00000004 System.Void UnityEngine.Font/FontTextureRebuildCallback::Invoke()
extern void FontTextureRebuildCallback_Invoke_m7F5D9CAA51DC8C9779104ACF46F668654B35EA1F (void);
static Il2CppMethodPointer s_methodPointers[4] = 
{
	TextMesh_set_text_m5879B13F5C9E4A1D05155839B89CCDB85BE28A04,
	Font_InvokeTextureRebuilt_Internal_m35C57E19A7E53A2F2A94DF909E6903DFFEE7679B,
	FontTextureRebuildCallback__ctor_m58D67535ED1CC9895AB016CBB713A730A73480E0,
	FontTextureRebuildCallback_Invoke_m7F5D9CAA51DC8C9779104ACF46F668654B35EA1F,
};
static const int32_t s_InvokerIndices[4] = 
{
	812,
	1702,
	508,
	962,
};
extern const Il2CppDebuggerMetadataRegistration g_DebuggerMetadataRegistrationUnityEngine_TextRenderingModule;
extern const CustomAttributesCacheGenerator g_UnityEngine_TextRenderingModule_AttributeGenerators[];
IL2CPP_EXTERN_C const Il2CppCodeGenModule g_UnityEngine_TextRenderingModule_CodeGenModule;
const Il2CppCodeGenModule g_UnityEngine_TextRenderingModule_CodeGenModule = 
{
	"UnityEngine.TextRenderingModule.dll",
	4,
	s_methodPointers,
	0,
	NULL,
	s_InvokerIndices,
	0,
	NULL,
	0,
	NULL,
	0,
	NULL,
	&g_DebuggerMetadataRegistrationUnityEngine_TextRenderingModule,
	g_UnityEngine_TextRenderingModule_AttributeGenerators,
	NULL, // module initializer,
	NULL,
	NULL,
	NULL,
};
