#include "pch-c.h"
#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include "codegen/il2cpp-codegen-metadata.h"





#if IL2CPP_MONO_DEBUGGER
static const Il2CppMethodExecutionContextInfo g_methodExecutionContextInfos[2] = 
{
	{ 4205, 0,  7 } /*tableIndex: 0 */,
	{ 4203, 1,  9 } /*tableIndex: 1 */,
};
#else
static const Il2CppMethodExecutionContextInfo g_methodExecutionContextInfos[1] = { { 0, 0, 0 } };
#endif
#if IL2CPP_MONO_DEBUGGER
static const char* g_methodExecutionContextInfoStrings[2] = 
{
	"tileData",
	"tileAnimationData",
};
#else
static const char* g_methodExecutionContextInfoStrings[1] = { NULL };
#endif
#if IL2CPP_MONO_DEBUGGER
static const Il2CppMethodExecutionContextInfoIndex g_methodExecutionContextInfoIndexes[35] = 
{
	{ 0, 0 } /* 0x06000001 System.Void UnityEngine.Tilemaps.ITilemap::.ctor() */,
	{ 0, 0 } /* 0x06000002 System.Void UnityEngine.Tilemaps.ITilemap::RefreshTile(UnityEngine.Vector3Int) */,
	{ 0, 0 } /* 0x06000003 UnityEngine.Tilemaps.ITilemap UnityEngine.Tilemaps.ITilemap::CreateInstance() */,
	{ 0, 0 } /* 0x06000004 UnityEngine.Sprite UnityEngine.Tilemaps.Tile::get_sprite() */,
	{ 0, 0 } /* 0x06000005 System.Void UnityEngine.Tilemaps.Tile::set_sprite(UnityEngine.Sprite) */,
	{ 0, 0 } /* 0x06000006 UnityEngine.Color UnityEngine.Tilemaps.Tile::get_color() */,
	{ 0, 0 } /* 0x06000007 System.Void UnityEngine.Tilemaps.Tile::set_color(UnityEngine.Color) */,
	{ 0, 0 } /* 0x06000008 UnityEngine.Matrix4x4 UnityEngine.Tilemaps.Tile::get_transform() */,
	{ 0, 0 } /* 0x06000009 System.Void UnityEngine.Tilemaps.Tile::set_transform(UnityEngine.Matrix4x4) */,
	{ 0, 0 } /* 0x0600000A UnityEngine.GameObject UnityEngine.Tilemaps.Tile::get_gameObject() */,
	{ 0, 0 } /* 0x0600000B System.Void UnityEngine.Tilemaps.Tile::set_gameObject(UnityEngine.GameObject) */,
	{ 0, 0 } /* 0x0600000C UnityEngine.Tilemaps.TileFlags UnityEngine.Tilemaps.Tile::get_flags() */,
	{ 0, 0 } /* 0x0600000D System.Void UnityEngine.Tilemaps.Tile::set_flags(UnityEngine.Tilemaps.TileFlags) */,
	{ 0, 0 } /* 0x0600000E UnityEngine.Tilemaps.Tile/ColliderType UnityEngine.Tilemaps.Tile::get_colliderType() */,
	{ 0, 0 } /* 0x0600000F System.Void UnityEngine.Tilemaps.Tile::set_colliderType(UnityEngine.Tilemaps.Tile/ColliderType) */,
	{ 0, 0 } /* 0x06000010 System.Void UnityEngine.Tilemaps.Tile::GetTileData(UnityEngine.Vector3Int,UnityEngine.Tilemaps.ITilemap,UnityEngine.Tilemaps.TileData&) */,
	{ 0, 0 } /* 0x06000011 System.Void UnityEngine.Tilemaps.Tile::.ctor() */,
	{ 0, 0 } /* 0x06000012 System.Void UnityEngine.Tilemaps.TileBase::RefreshTile(UnityEngine.Vector3Int,UnityEngine.Tilemaps.ITilemap) */,
	{ 0, 0 } /* 0x06000013 System.Void UnityEngine.Tilemaps.TileBase::GetTileData(UnityEngine.Vector3Int,UnityEngine.Tilemaps.ITilemap,UnityEngine.Tilemaps.TileData&) */,
	{ 0, 1 } /* 0x06000014 UnityEngine.Tilemaps.TileData UnityEngine.Tilemaps.TileBase::GetTileDataNoRef(UnityEngine.Vector3Int,UnityEngine.Tilemaps.ITilemap) */,
	{ 0, 0 } /* 0x06000015 System.Boolean UnityEngine.Tilemaps.TileBase::GetTileAnimationData(UnityEngine.Vector3Int,UnityEngine.Tilemaps.ITilemap,UnityEngine.Tilemaps.TileAnimationData&) */,
	{ 1, 1 } /* 0x06000016 UnityEngine.Tilemaps.TileAnimationData UnityEngine.Tilemaps.TileBase::GetTileAnimationDataNoRef(UnityEngine.Vector3Int,UnityEngine.Tilemaps.ITilemap) */,
	{ 0, 0 } /* 0x06000017 System.Boolean UnityEngine.Tilemaps.TileBase::StartUp(UnityEngine.Vector3Int,UnityEngine.Tilemaps.ITilemap,UnityEngine.GameObject) */,
	{ 0, 0 } /* 0x06000018 System.Void UnityEngine.Tilemaps.TileBase::.ctor() */,
	{ 0, 0 } /* 0x06000019 System.Void UnityEngine.Tilemaps.Tilemap::RefreshTile(UnityEngine.Vector3Int) */,
	{ 0, 0 } /* 0x0600001A System.Void UnityEngine.Tilemaps.Tilemap::RefreshTile_Injected(UnityEngine.Vector3Int&) */,
	{ 0, 0 } /* 0x0600001B System.Void UnityEngine.Tilemaps.TilemapRenderer::RegisterSpriteAtlasRegistered() */,
	{ 0, 0 } /* 0x0600001C System.Void UnityEngine.Tilemaps.TilemapRenderer::UnregisterSpriteAtlasRegistered() */,
	{ 0, 0 } /* 0x0600001D System.Void UnityEngine.Tilemaps.TilemapRenderer::OnSpriteAtlasRegistered(UnityEngine.U2D.SpriteAtlas) */,
	{ 0, 0 } /* 0x0600001E System.Void UnityEngine.Tilemaps.TileData::set_sprite(UnityEngine.Sprite) */,
	{ 0, 0 } /* 0x0600001F System.Void UnityEngine.Tilemaps.TileData::set_color(UnityEngine.Color) */,
	{ 0, 0 } /* 0x06000020 System.Void UnityEngine.Tilemaps.TileData::set_transform(UnityEngine.Matrix4x4) */,
	{ 0, 0 } /* 0x06000021 System.Void UnityEngine.Tilemaps.TileData::set_gameObject(UnityEngine.GameObject) */,
	{ 0, 0 } /* 0x06000022 System.Void UnityEngine.Tilemaps.TileData::set_flags(UnityEngine.Tilemaps.TileFlags) */,
	{ 0, 0 } /* 0x06000023 System.Void UnityEngine.Tilemaps.TileData::set_colliderType(UnityEngine.Tilemaps.Tile/ColliderType) */,
};
#else
static const Il2CppMethodExecutionContextInfoIndex g_methodExecutionContextInfoIndexes[1] = { { 0, 0} };
#endif
#if IL2CPP_MONO_DEBUGGER
IL2CPP_EXTERN_C Il2CppSequencePoint g_sequencePointsUnityEngine_TilemapModule[];
Il2CppSequencePoint g_sequencePointsUnityEngine_TilemapModule[184] = 
{
	{ 11669, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 0 } /* seqPointIndex: 0 */,
	{ 11669, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 1 } /* seqPointIndex: 1 */,
	{ 11669, 1, 11, 11, 9, 28, 0, kSequencePointKind_Normal, 0, 2 } /* seqPointIndex: 2 */,
	{ 11669, 1, 12, 12, 9, 10, 7, kSequencePointKind_Normal, 0, 3 } /* seqPointIndex: 3 */,
	{ 11669, 1, 13, 13, 9, 10, 8, kSequencePointKind_Normal, 0, 4 } /* seqPointIndex: 4 */,
	{ 11669, 1, 11, 11, 9, 28, 1, kSequencePointKind_StepOut, 0, 5 } /* seqPointIndex: 5 */,
	{ 11670, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 6 } /* seqPointIndex: 6 */,
	{ 11670, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 7 } /* seqPointIndex: 7 */,
	{ 11670, 1, 59, 59, 9, 10, 0, kSequencePointKind_Normal, 0, 8 } /* seqPointIndex: 8 */,
	{ 11670, 1, 60, 60, 13, 45, 1, kSequencePointKind_Normal, 0, 9 } /* seqPointIndex: 9 */,
	{ 11670, 1, 61, 61, 9, 10, 14, kSequencePointKind_Normal, 0, 10 } /* seqPointIndex: 10 */,
	{ 11670, 1, 60, 60, 13, 45, 8, kSequencePointKind_StepOut, 0, 11 } /* seqPointIndex: 11 */,
	{ 11671, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 12 } /* seqPointIndex: 12 */,
	{ 11671, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 13 } /* seqPointIndex: 13 */,
	{ 11671, 1, 70, 70, 9, 10, 0, kSequencePointKind_Normal, 0, 14 } /* seqPointIndex: 14 */,
	{ 11671, 1, 71, 71, 13, 41, 1, kSequencePointKind_Normal, 0, 15 } /* seqPointIndex: 15 */,
	{ 11671, 1, 72, 72, 13, 31, 11, kSequencePointKind_Normal, 0, 16 } /* seqPointIndex: 16 */,
	{ 11671, 1, 73, 73, 9, 10, 19, kSequencePointKind_Normal, 0, 17 } /* seqPointIndex: 17 */,
	{ 11671, 1, 71, 71, 13, 41, 1, kSequencePointKind_StepOut, 0, 18 } /* seqPointIndex: 18 */,
	{ 11672, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 19 } /* seqPointIndex: 19 */,
	{ 11672, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 20 } /* seqPointIndex: 20 */,
	{ 11672, 2, 13, 13, 36, 37, 0, kSequencePointKind_Normal, 0, 21 } /* seqPointIndex: 21 */,
	{ 11672, 2, 13, 13, 38, 54, 1, kSequencePointKind_Normal, 0, 22 } /* seqPointIndex: 22 */,
	{ 11672, 2, 13, 13, 55, 56, 10, kSequencePointKind_Normal, 0, 23 } /* seqPointIndex: 23 */,
	{ 11673, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 24 } /* seqPointIndex: 24 */,
	{ 11673, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 25 } /* seqPointIndex: 25 */,
	{ 11673, 2, 13, 13, 61, 62, 0, kSequencePointKind_Normal, 0, 26 } /* seqPointIndex: 26 */,
	{ 11673, 2, 13, 13, 63, 80, 1, kSequencePointKind_Normal, 0, 27 } /* seqPointIndex: 27 */,
	{ 11673, 2, 13, 13, 81, 82, 8, kSequencePointKind_Normal, 0, 28 } /* seqPointIndex: 28 */,
	{ 11674, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 29 } /* seqPointIndex: 29 */,
	{ 11674, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 30 } /* seqPointIndex: 30 */,
	{ 11674, 2, 14, 14, 34, 35, 0, kSequencePointKind_Normal, 0, 31 } /* seqPointIndex: 31 */,
	{ 11674, 2, 14, 14, 36, 51, 1, kSequencePointKind_Normal, 0, 32 } /* seqPointIndex: 32 */,
	{ 11674, 2, 14, 14, 52, 53, 10, kSequencePointKind_Normal, 0, 33 } /* seqPointIndex: 33 */,
	{ 11675, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 34 } /* seqPointIndex: 34 */,
	{ 11675, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 35 } /* seqPointIndex: 35 */,
	{ 11675, 2, 14, 14, 58, 59, 0, kSequencePointKind_Normal, 0, 36 } /* seqPointIndex: 36 */,
	{ 11675, 2, 14, 14, 60, 76, 1, kSequencePointKind_Normal, 0, 37 } /* seqPointIndex: 37 */,
	{ 11675, 2, 14, 14, 77, 78, 8, kSequencePointKind_Normal, 0, 38 } /* seqPointIndex: 38 */,
	{ 11676, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 39 } /* seqPointIndex: 39 */,
	{ 11676, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 40 } /* seqPointIndex: 40 */,
	{ 11676, 2, 15, 15, 42, 43, 0, kSequencePointKind_Normal, 0, 41 } /* seqPointIndex: 41 */,
	{ 11676, 2, 15, 15, 44, 63, 1, kSequencePointKind_Normal, 0, 42 } /* seqPointIndex: 42 */,
	{ 11676, 2, 15, 15, 64, 65, 10, kSequencePointKind_Normal, 0, 43 } /* seqPointIndex: 43 */,
	{ 11677, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 44 } /* seqPointIndex: 44 */,
	{ 11677, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 45 } /* seqPointIndex: 45 */,
	{ 11677, 2, 15, 15, 70, 71, 0, kSequencePointKind_Normal, 0, 46 } /* seqPointIndex: 46 */,
	{ 11677, 2, 15, 15, 72, 92, 1, kSequencePointKind_Normal, 0, 47 } /* seqPointIndex: 47 */,
	{ 11677, 2, 15, 15, 93, 94, 8, kSequencePointKind_Normal, 0, 48 } /* seqPointIndex: 48 */,
	{ 11678, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 49 } /* seqPointIndex: 49 */,
	{ 11678, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 50 } /* seqPointIndex: 50 */,
	{ 11678, 2, 16, 16, 44, 45, 0, kSequencePointKind_Normal, 0, 51 } /* seqPointIndex: 51 */,
	{ 11678, 2, 16, 16, 46, 75, 1, kSequencePointKind_Normal, 0, 52 } /* seqPointIndex: 52 */,
	{ 11678, 2, 16, 16, 76, 77, 10, kSequencePointKind_Normal, 0, 53 } /* seqPointIndex: 53 */,
	{ 11679, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 54 } /* seqPointIndex: 54 */,
	{ 11679, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 55 } /* seqPointIndex: 55 */,
	{ 11679, 2, 16, 16, 82, 83, 0, kSequencePointKind_Normal, 0, 56 } /* seqPointIndex: 56 */,
	{ 11679, 2, 16, 16, 84, 114, 1, kSequencePointKind_Normal, 0, 57 } /* seqPointIndex: 57 */,
	{ 11679, 2, 16, 16, 115, 116, 8, kSequencePointKind_Normal, 0, 58 } /* seqPointIndex: 58 */,
	{ 11680, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 59 } /* seqPointIndex: 59 */,
	{ 11680, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 60 } /* seqPointIndex: 60 */,
	{ 11680, 2, 17, 17, 38, 39, 0, kSequencePointKind_Normal, 0, 61 } /* seqPointIndex: 61 */,
	{ 11680, 2, 17, 17, 40, 55, 1, kSequencePointKind_Normal, 0, 62 } /* seqPointIndex: 62 */,
	{ 11680, 2, 17, 17, 56, 57, 10, kSequencePointKind_Normal, 0, 63 } /* seqPointIndex: 63 */,
	{ 11681, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 64 } /* seqPointIndex: 64 */,
	{ 11681, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 65 } /* seqPointIndex: 65 */,
	{ 11681, 2, 17, 17, 62, 63, 0, kSequencePointKind_Normal, 0, 66 } /* seqPointIndex: 66 */,
	{ 11681, 2, 17, 17, 64, 80, 1, kSequencePointKind_Normal, 0, 67 } /* seqPointIndex: 67 */,
	{ 11681, 2, 17, 17, 81, 82, 8, kSequencePointKind_Normal, 0, 68 } /* seqPointIndex: 68 */,
	{ 11682, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 69 } /* seqPointIndex: 69 */,
	{ 11682, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 70 } /* seqPointIndex: 70 */,
	{ 11682, 2, 18, 18, 48, 49, 0, kSequencePointKind_Normal, 0, 71 } /* seqPointIndex: 71 */,
	{ 11682, 2, 18, 18, 50, 72, 1, kSequencePointKind_Normal, 0, 72 } /* seqPointIndex: 72 */,
	{ 11682, 2, 18, 18, 73, 74, 10, kSequencePointKind_Normal, 0, 73 } /* seqPointIndex: 73 */,
	{ 11683, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 74 } /* seqPointIndex: 74 */,
	{ 11683, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 75 } /* seqPointIndex: 75 */,
	{ 11683, 2, 18, 18, 79, 80, 0, kSequencePointKind_Normal, 0, 76 } /* seqPointIndex: 76 */,
	{ 11683, 2, 18, 18, 81, 104, 1, kSequencePointKind_Normal, 0, 77 } /* seqPointIndex: 77 */,
	{ 11683, 2, 18, 18, 105, 106, 8, kSequencePointKind_Normal, 0, 78 } /* seqPointIndex: 78 */,
	{ 11684, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 79 } /* seqPointIndex: 79 */,
	{ 11684, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 80 } /* seqPointIndex: 80 */,
	{ 11684, 2, 34, 34, 9, 10, 0, kSequencePointKind_Normal, 0, 81 } /* seqPointIndex: 81 */,
	{ 11684, 2, 35, 35, 13, 40, 1, kSequencePointKind_Normal, 0, 82 } /* seqPointIndex: 82 */,
	{ 11684, 2, 36, 36, 13, 38, 14, kSequencePointKind_Normal, 0, 83 } /* seqPointIndex: 83 */,
	{ 11684, 2, 37, 37, 13, 46, 27, kSequencePointKind_Normal, 0, 84 } /* seqPointIndex: 84 */,
	{ 11684, 2, 38, 38, 13, 57, 40, kSequencePointKind_Normal, 0, 85 } /* seqPointIndex: 85 */,
	{ 11684, 2, 39, 39, 13, 38, 53, kSequencePointKind_Normal, 0, 86 } /* seqPointIndex: 86 */,
	{ 11684, 2, 40, 40, 13, 52, 66, kSequencePointKind_Normal, 0, 87 } /* seqPointIndex: 87 */,
	{ 11684, 2, 41, 41, 9, 10, 79, kSequencePointKind_Normal, 0, 88 } /* seqPointIndex: 88 */,
	{ 11684, 2, 35, 35, 13, 40, 8, kSequencePointKind_StepOut, 0, 89 } /* seqPointIndex: 89 */,
	{ 11684, 2, 36, 36, 13, 38, 21, kSequencePointKind_StepOut, 0, 90 } /* seqPointIndex: 90 */,
	{ 11684, 2, 37, 37, 13, 46, 34, kSequencePointKind_StepOut, 0, 91 } /* seqPointIndex: 91 */,
	{ 11684, 2, 38, 38, 13, 57, 47, kSequencePointKind_StepOut, 0, 92 } /* seqPointIndex: 92 */,
	{ 11684, 2, 39, 39, 13, 38, 60, kSequencePointKind_StepOut, 0, 93 } /* seqPointIndex: 93 */,
	{ 11684, 2, 40, 40, 13, 52, 73, kSequencePointKind_StepOut, 0, 94 } /* seqPointIndex: 94 */,
	{ 11685, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 95 } /* seqPointIndex: 95 */,
	{ 11685, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 96 } /* seqPointIndex: 96 */,
	{ 11685, 2, 23, 23, 9, 45, 0, kSequencePointKind_Normal, 0, 97 } /* seqPointIndex: 97 */,
	{ 11685, 2, 25, 25, 9, 60, 11, kSequencePointKind_Normal, 0, 98 } /* seqPointIndex: 98 */,
	{ 11685, 2, 29, 29, 9, 57, 22, kSequencePointKind_Normal, 0, 99 } /* seqPointIndex: 99 */,
	{ 11685, 2, 31, 31, 9, 67, 29, kSequencePointKind_Normal, 0, 100 } /* seqPointIndex: 100 */,
	{ 11685, 2, 23, 23, 9, 45, 1, kSequencePointKind_StepOut, 0, 101 } /* seqPointIndex: 101 */,
	{ 11685, 2, 25, 25, 9, 60, 12, kSequencePointKind_StepOut, 0, 102 } /* seqPointIndex: 102 */,
	{ 11685, 2, 31, 31, 9, 67, 37, kSequencePointKind_StepOut, 0, 103 } /* seqPointIndex: 103 */,
	{ 11686, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 104 } /* seqPointIndex: 104 */,
	{ 11686, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 105 } /* seqPointIndex: 105 */,
	{ 11686, 3, 10, 10, 80, 81, 0, kSequencePointKind_Normal, 0, 106 } /* seqPointIndex: 106 */,
	{ 11686, 3, 10, 10, 82, 112, 1, kSequencePointKind_Normal, 0, 107 } /* seqPointIndex: 107 */,
	{ 11686, 3, 10, 10, 113, 114, 9, kSequencePointKind_Normal, 0, 108 } /* seqPointIndex: 108 */,
	{ 11686, 3, 10, 10, 82, 112, 3, kSequencePointKind_StepOut, 0, 109 } /* seqPointIndex: 109 */,
	{ 11687, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 110 } /* seqPointIndex: 110 */,
	{ 11687, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 111 } /* seqPointIndex: 111 */,
	{ 11687, 3, 13, 13, 103, 104, 0, kSequencePointKind_Normal, 0, 112 } /* seqPointIndex: 112 */,
	{ 11687, 3, 13, 13, 104, 105, 1, kSequencePointKind_Normal, 0, 113 } /* seqPointIndex: 113 */,
	{ 11688, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 114 } /* seqPointIndex: 114 */,
	{ 11688, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 115 } /* seqPointIndex: 115 */,
	{ 11688, 3, 15, 15, 9, 10, 0, kSequencePointKind_Normal, 0, 116 } /* seqPointIndex: 116 */,
	{ 11688, 3, 16, 16, 13, 48, 1, kSequencePointKind_Normal, 0, 117 } /* seqPointIndex: 117 */,
	{ 11688, 3, 17, 17, 13, 58, 9, kSequencePointKind_Normal, 0, 118 } /* seqPointIndex: 118 */,
	{ 11688, 3, 18, 18, 13, 29, 20, kSequencePointKind_Normal, 0, 119 } /* seqPointIndex: 119 */,
	{ 11688, 3, 19, 19, 9, 10, 24, kSequencePointKind_Normal, 0, 120 } /* seqPointIndex: 120 */,
	{ 11688, 3, 17, 17, 13, 58, 14, kSequencePointKind_StepOut, 0, 121 } /* seqPointIndex: 121 */,
	{ 11689, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 122 } /* seqPointIndex: 122 */,
	{ 11689, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 123 } /* seqPointIndex: 123 */,
	{ 11689, 3, 22, 22, 130, 131, 0, kSequencePointKind_Normal, 0, 124 } /* seqPointIndex: 124 */,
	{ 11689, 3, 22, 22, 132, 145, 1, kSequencePointKind_Normal, 0, 125 } /* seqPointIndex: 125 */,
	{ 11689, 3, 22, 22, 146, 147, 5, kSequencePointKind_Normal, 0, 126 } /* seqPointIndex: 126 */,
	{ 11690, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 127 } /* seqPointIndex: 127 */,
	{ 11690, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 128 } /* seqPointIndex: 128 */,
	{ 11690, 3, 24, 24, 9, 10, 0, kSequencePointKind_Normal, 0, 129 } /* seqPointIndex: 129 */,
	{ 11690, 3, 25, 25, 13, 75, 1, kSequencePointKind_Normal, 0, 130 } /* seqPointIndex: 130 */,
	{ 11690, 3, 26, 26, 13, 76, 9, kSequencePointKind_Normal, 0, 131 } /* seqPointIndex: 131 */,
	{ 11690, 3, 27, 27, 13, 38, 20, kSequencePointKind_Normal, 0, 132 } /* seqPointIndex: 132 */,
	{ 11690, 3, 28, 28, 9, 10, 24, kSequencePointKind_Normal, 0, 133 } /* seqPointIndex: 133 */,
	{ 11690, 3, 26, 26, 13, 76, 14, kSequencePointKind_StepOut, 0, 134 } /* seqPointIndex: 134 */,
	{ 11691, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 135 } /* seqPointIndex: 135 */,
	{ 11691, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 136 } /* seqPointIndex: 136 */,
	{ 11691, 3, 31, 31, 91, 92, 0, kSequencePointKind_Normal, 0, 137 } /* seqPointIndex: 137 */,
	{ 11691, 3, 31, 31, 93, 106, 1, kSequencePointKind_Normal, 0, 138 } /* seqPointIndex: 138 */,
	{ 11691, 3, 31, 31, 107, 108, 5, kSequencePointKind_Normal, 0, 139 } /* seqPointIndex: 139 */,
	{ 11695, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 140 } /* seqPointIndex: 140 */,
	{ 11695, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 141 } /* seqPointIndex: 141 */,
	{ 11695, 4, 415, 415, 9, 10, 0, kSequencePointKind_Normal, 0, 142 } /* seqPointIndex: 142 */,
	{ 11695, 4, 416, 416, 13, 75, 1, kSequencePointKind_Normal, 0, 143 } /* seqPointIndex: 143 */,
	{ 11695, 4, 417, 417, 9, 10, 19, kSequencePointKind_Normal, 0, 144 } /* seqPointIndex: 144 */,
	{ 11695, 4, 416, 416, 13, 75, 8, kSequencePointKind_StepOut, 0, 145 } /* seqPointIndex: 145 */,
	{ 11695, 4, 416, 416, 13, 75, 13, kSequencePointKind_StepOut, 0, 146 } /* seqPointIndex: 146 */,
	{ 11696, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 147 } /* seqPointIndex: 147 */,
	{ 11696, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 148 } /* seqPointIndex: 148 */,
	{ 11696, 4, 421, 421, 9, 10, 0, kSequencePointKind_Normal, 0, 149 } /* seqPointIndex: 149 */,
	{ 11696, 4, 422, 422, 13, 75, 1, kSequencePointKind_Normal, 0, 150 } /* seqPointIndex: 150 */,
	{ 11696, 4, 423, 423, 9, 10, 19, kSequencePointKind_Normal, 0, 151 } /* seqPointIndex: 151 */,
	{ 11696, 4, 422, 422, 13, 75, 8, kSequencePointKind_StepOut, 0, 152 } /* seqPointIndex: 152 */,
	{ 11696, 4, 422, 422, 13, 75, 13, kSequencePointKind_StepOut, 0, 153 } /* seqPointIndex: 153 */,
	{ 11698, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 154 } /* seqPointIndex: 154 */,
	{ 11698, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 155 } /* seqPointIndex: 155 */,
	{ 11698, 4, 433, 433, 61, 62, 0, kSequencePointKind_Normal, 0, 156 } /* seqPointIndex: 156 */,
	{ 11698, 4, 433, 433, 63, 80, 1, kSequencePointKind_Normal, 0, 157 } /* seqPointIndex: 157 */,
	{ 11698, 4, 433, 433, 81, 82, 8, kSequencePointKind_Normal, 0, 158 } /* seqPointIndex: 158 */,
	{ 11699, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 159 } /* seqPointIndex: 159 */,
	{ 11699, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 160 } /* seqPointIndex: 160 */,
	{ 11699, 4, 434, 434, 58, 59, 0, kSequencePointKind_Normal, 0, 161 } /* seqPointIndex: 161 */,
	{ 11699, 4, 434, 434, 60, 76, 1, kSequencePointKind_Normal, 0, 162 } /* seqPointIndex: 162 */,
	{ 11699, 4, 434, 434, 77, 78, 8, kSequencePointKind_Normal, 0, 163 } /* seqPointIndex: 163 */,
	{ 11700, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 164 } /* seqPointIndex: 164 */,
	{ 11700, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 165 } /* seqPointIndex: 165 */,
	{ 11700, 4, 435, 435, 70, 71, 0, kSequencePointKind_Normal, 0, 166 } /* seqPointIndex: 166 */,
	{ 11700, 4, 435, 435, 72, 92, 1, kSequencePointKind_Normal, 0, 167 } /* seqPointIndex: 167 */,
	{ 11700, 4, 435, 435, 93, 94, 8, kSequencePointKind_Normal, 0, 168 } /* seqPointIndex: 168 */,
	{ 11701, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 169 } /* seqPointIndex: 169 */,
	{ 11701, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 170 } /* seqPointIndex: 170 */,
	{ 11701, 4, 436, 436, 73, 74, 0, kSequencePointKind_Normal, 0, 171 } /* seqPointIndex: 171 */,
	{ 11701, 4, 436, 436, 75, 96, 1, kSequencePointKind_Normal, 0, 172 } /* seqPointIndex: 172 */,
	{ 11701, 4, 436, 436, 97, 98, 8, kSequencePointKind_Normal, 0, 173 } /* seqPointIndex: 173 */,
	{ 11702, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 174 } /* seqPointIndex: 174 */,
	{ 11702, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 175 } /* seqPointIndex: 175 */,
	{ 11702, 4, 437, 437, 62, 63, 0, kSequencePointKind_Normal, 0, 176 } /* seqPointIndex: 176 */,
	{ 11702, 4, 437, 437, 64, 80, 1, kSequencePointKind_Normal, 0, 177 } /* seqPointIndex: 177 */,
	{ 11702, 4, 437, 437, 81, 82, 8, kSequencePointKind_Normal, 0, 178 } /* seqPointIndex: 178 */,
	{ 11703, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 179 } /* seqPointIndex: 179 */,
	{ 11703, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 180 } /* seqPointIndex: 180 */,
	{ 11703, 4, 438, 438, 84, 85, 0, kSequencePointKind_Normal, 0, 181 } /* seqPointIndex: 181 */,
	{ 11703, 4, 438, 438, 86, 109, 1, kSequencePointKind_Normal, 0, 182 } /* seqPointIndex: 182 */,
	{ 11703, 4, 438, 438, 110, 111, 8, kSequencePointKind_Normal, 0, 183 } /* seqPointIndex: 183 */,
};
#else
extern Il2CppSequencePoint g_sequencePointsUnityEngine_TilemapModule[];
Il2CppSequencePoint g_sequencePointsUnityEngine_TilemapModule[1] = { { 0, 0, 0, 0, 0, 0, 0, kSequencePointKind_Normal, 0, 0, } };
#endif
#if IL2CPP_MONO_DEBUGGER
static const Il2CppCatchPoint g_catchPoints[1] = { { 0, 0, 0, 0, } };
#else
static const Il2CppCatchPoint g_catchPoints[1] = { { 0, 0, 0, 0, } };
#endif
#if IL2CPP_MONO_DEBUGGER
static const Il2CppSequencePointSourceFile g_sequencePointSourceFiles[] = {
{ "", { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0} }, //0 
{ "C:\\buildslave\\unity\\build\\Modules\\Tilemap\\Managed\\ITilemap.cs", { 107, 173, 168, 105, 31, 52, 198, 96, 56, 142, 66, 136, 164, 159, 72, 172} }, //1 
{ "C:\\buildslave\\unity\\build\\Modules\\Tilemap\\Managed\\Tile.cs", { 121, 80, 238, 205, 152, 125, 96, 4, 12, 18, 146, 139, 102, 200, 201, 39} }, //2 
{ "C:\\buildslave\\unity\\build\\Modules\\Tilemap\\Managed\\TileBase.cs", { 144, 95, 197, 97, 211, 190, 218, 96, 88, 179, 234, 178, 55, 33, 87, 161} }, //3 
{ "C:\\buildslave\\unity\\build\\Modules\\Tilemap\\ScriptBindings\\Tilemap.bindings.cs", { 111, 226, 70, 220, 255, 4, 221, 194, 169, 76, 167, 10, 146, 68, 215, 66} }, //4 
};
#else
static const Il2CppSequencePointSourceFile g_sequencePointSourceFiles[1] = { NULL, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
#endif
#if IL2CPP_MONO_DEBUGGER
static const Il2CppTypeSourceFilePair g_typeSourceFiles[5] = 
{
	{ 2176, 1 },
	{ 2178, 2 },
	{ 2179, 3 },
	{ 2182, 4 },
	{ 2183, 4 },
};
#else
static const Il2CppTypeSourceFilePair g_typeSourceFiles[1] = { { 0, 0 } };
#endif
#if IL2CPP_MONO_DEBUGGER
static const Il2CppMethodScope g_methodScopes[11] = 
{
	{ 0, 21 },
	{ 0, 12 },
	{ 0, 12 },
	{ 0, 12 },
	{ 0, 12 },
	{ 0, 12 },
	{ 0, 12 },
	{ 0, 26 },
	{ 0, 7 },
	{ 0, 26 },
	{ 0, 7 },
};
#else
static const Il2CppMethodScope g_methodScopes[1] = { { 0, 0 } };
#endif
#if IL2CPP_MONO_DEBUGGER
static const Il2CppMethodHeaderInfo g_methodHeaderInfos[35] = 
{
	{ 0, 0, 0 } /* System.Void UnityEngine.Tilemaps.ITilemap::.ctor() */,
	{ 0, 0, 0 } /* System.Void UnityEngine.Tilemaps.ITilemap::RefreshTile(UnityEngine.Vector3Int) */,
	{ 21, 0, 1 } /* UnityEngine.Tilemaps.ITilemap UnityEngine.Tilemaps.ITilemap::CreateInstance() */,
	{ 12, 1, 1 } /* UnityEngine.Sprite UnityEngine.Tilemaps.Tile::get_sprite() */,
	{ 0, 0, 0 } /* System.Void UnityEngine.Tilemaps.Tile::set_sprite(UnityEngine.Sprite) */,
	{ 12, 2, 1 } /* UnityEngine.Color UnityEngine.Tilemaps.Tile::get_color() */,
	{ 0, 0, 0 } /* System.Void UnityEngine.Tilemaps.Tile::set_color(UnityEngine.Color) */,
	{ 12, 3, 1 } /* UnityEngine.Matrix4x4 UnityEngine.Tilemaps.Tile::get_transform() */,
	{ 0, 0, 0 } /* System.Void UnityEngine.Tilemaps.Tile::set_transform(UnityEngine.Matrix4x4) */,
	{ 12, 4, 1 } /* UnityEngine.GameObject UnityEngine.Tilemaps.Tile::get_gameObject() */,
	{ 0, 0, 0 } /* System.Void UnityEngine.Tilemaps.Tile::set_gameObject(UnityEngine.GameObject) */,
	{ 12, 5, 1 } /* UnityEngine.Tilemaps.TileFlags UnityEngine.Tilemaps.Tile::get_flags() */,
	{ 0, 0, 0 } /* System.Void UnityEngine.Tilemaps.Tile::set_flags(UnityEngine.Tilemaps.TileFlags) */,
	{ 12, 6, 1 } /* UnityEngine.Tilemaps.Tile/ColliderType UnityEngine.Tilemaps.Tile::get_colliderType() */,
	{ 0, 0, 0 } /* System.Void UnityEngine.Tilemaps.Tile::set_colliderType(UnityEngine.Tilemaps.Tile/ColliderType) */,
	{ 0, 0, 0 } /* System.Void UnityEngine.Tilemaps.Tile::GetTileData(UnityEngine.Vector3Int,UnityEngine.Tilemaps.ITilemap,UnityEngine.Tilemaps.TileData&) */,
	{ 0, 0, 0 } /* System.Void UnityEngine.Tilemaps.Tile::.ctor() */,
	{ 0, 0, 0 } /* System.Void UnityEngine.Tilemaps.TileBase::RefreshTile(UnityEngine.Vector3Int,UnityEngine.Tilemaps.ITilemap) */,
	{ 0, 0, 0 } /* System.Void UnityEngine.Tilemaps.TileBase::GetTileData(UnityEngine.Vector3Int,UnityEngine.Tilemaps.ITilemap,UnityEngine.Tilemaps.TileData&) */,
	{ 26, 7, 1 } /* UnityEngine.Tilemaps.TileData UnityEngine.Tilemaps.TileBase::GetTileDataNoRef(UnityEngine.Vector3Int,UnityEngine.Tilemaps.ITilemap) */,
	{ 7, 8, 1 } /* System.Boolean UnityEngine.Tilemaps.TileBase::GetTileAnimationData(UnityEngine.Vector3Int,UnityEngine.Tilemaps.ITilemap,UnityEngine.Tilemaps.TileAnimationData&) */,
	{ 26, 9, 1 } /* UnityEngine.Tilemaps.TileAnimationData UnityEngine.Tilemaps.TileBase::GetTileAnimationDataNoRef(UnityEngine.Vector3Int,UnityEngine.Tilemaps.ITilemap) */,
	{ 7, 10, 1 } /* System.Boolean UnityEngine.Tilemaps.TileBase::StartUp(UnityEngine.Vector3Int,UnityEngine.Tilemaps.ITilemap,UnityEngine.GameObject) */,
	{ 0, 0, 0 } /* System.Void UnityEngine.Tilemaps.TileBase::.ctor() */,
	{ 0, 0, 0 } /* System.Void UnityEngine.Tilemaps.Tilemap::RefreshTile(UnityEngine.Vector3Int) */,
	{ 0, 0, 0 } /* System.Void UnityEngine.Tilemaps.Tilemap::RefreshTile_Injected(UnityEngine.Vector3Int&) */,
	{ 0, 0, 0 } /* System.Void UnityEngine.Tilemaps.TilemapRenderer::RegisterSpriteAtlasRegistered() */,
	{ 0, 0, 0 } /* System.Void UnityEngine.Tilemaps.TilemapRenderer::UnregisterSpriteAtlasRegistered() */,
	{ 0, 0, 0 } /* System.Void UnityEngine.Tilemaps.TilemapRenderer::OnSpriteAtlasRegistered(UnityEngine.U2D.SpriteAtlas) */,
	{ 0, 0, 0 } /* System.Void UnityEngine.Tilemaps.TileData::set_sprite(UnityEngine.Sprite) */,
	{ 0, 0, 0 } /* System.Void UnityEngine.Tilemaps.TileData::set_color(UnityEngine.Color) */,
	{ 0, 0, 0 } /* System.Void UnityEngine.Tilemaps.TileData::set_transform(UnityEngine.Matrix4x4) */,
	{ 0, 0, 0 } /* System.Void UnityEngine.Tilemaps.TileData::set_gameObject(UnityEngine.GameObject) */,
	{ 0, 0, 0 } /* System.Void UnityEngine.Tilemaps.TileData::set_flags(UnityEngine.Tilemaps.TileFlags) */,
	{ 0, 0, 0 } /* System.Void UnityEngine.Tilemaps.TileData::set_colliderType(UnityEngine.Tilemaps.Tile/ColliderType) */,
};
#else
static const Il2CppMethodHeaderInfo g_methodHeaderInfos[1] = { { 0, 0, 0 } };
#endif
IL2CPP_EXTERN_C const Il2CppDebuggerMetadataRegistration g_DebuggerMetadataRegistrationUnityEngine_TilemapModule;
const Il2CppDebuggerMetadataRegistration g_DebuggerMetadataRegistrationUnityEngine_TilemapModule = 
{
	(Il2CppMethodExecutionContextInfo*)g_methodExecutionContextInfos,
	(Il2CppMethodExecutionContextInfoIndex*)g_methodExecutionContextInfoIndexes,
	(Il2CppMethodScope*)g_methodScopes,
	(Il2CppMethodHeaderInfo*)g_methodHeaderInfos,
	(Il2CppSequencePointSourceFile*)g_sequencePointSourceFiles,
	184,
	(Il2CppSequencePoint*)g_sequencePointsUnityEngine_TilemapModule,
	0,
	(Il2CppCatchPoint*)g_catchPoints,
	5,
	(Il2CppTypeSourceFilePair*)g_typeSourceFiles,
	(const char**)g_methodExecutionContextInfoStrings,
};
